using DevExpress.CodeParser;
using DevExpress.DataProcessing;
using DevExpress.DirectX.Common.Direct2D;
using DevExpress.Drawing.Internal.Fonts.Interop;
using DevExpress.Pdf.Native;
using DevExpress.Utils.Animation;
using DevExpress.XtraCharts.Designer.Native;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit.Commands;
using DevExpress.XtraRichEdit.Import.OpenXml;
using DevExpress.XtraSpreadsheet.DocumentFormats.Xlsb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;

namespace NGP814
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private NGPTCP _ngp;
        private Thread _thread;              // Task → Thread
        private bool _isRunning = false;
        private ChannelConfig[] _channels;
        private const double CH12_MAX_VOLT = 32.050;
        private const double CH34_MAX_VOLT = 64.050;
        private const double CH12_MAX_CURR = 20.010;
        private const double CH34_MAX_CURR = 10.010;
        private const double MIN_VOLT = 0.000;
        private const double MIN_CURR = 0.001;
        private const int MAX_POWER = 200;
        private const string CH12_VOLT_RANGE = "0.000 ~ 32.050 V";
        private const string CH34_VOLT_RANGE = "0.000 ~ 64.050 V";
        private const string CH12_CURR_RANGE = "0.001 ~ 20.010 A";
        private const string CH34_CURR_RANGE = "0.001 ~ 10.010 A";
        public Form1()
        {
            InitializeComponent();
            _ngp = new NGPTCP();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _channels = new ChannelConfig[5];
            _channels[1] = new ChannelConfig() { Channel = 1 };
            _channels[2] = new ChannelConfig() { Channel = 2 };
            _channels[3] = new ChannelConfig() { Channel = 3 };
            _channels[4] = new ChannelConfig() { Channel = 4 };
            ApplyGrayText(1);
            ApplyGrayLimit(1);
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string ip = txtIp.Text.Trim();
                int port = int.Parse(txtPort.Text.Trim());
                _ngp.Connect(ip, port);
                lblStatus.Text = "Connected";
                lblStatus.Appearance.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show("연결 실패:" + ex.Message);
            }
        }
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                _isRunning = false;     // Thread에 "멈춰!" 신호
                _ngp.Disconnect();
                lblStatus.Text = "Disconnected";
                lblStatus.Appearance.ForeColor = Color.Red;
                lblAutoRangeWarning.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("연결 해제 실패: " + ex.Message);
            }
        }
        private void btnSetVolt_Click(object sender, EventArgs e)
        {

            lblAutoRangeWarning.Visible = false;
            try
            {
                int ch = GetSelectedChannel();
                double volt = double.Parse(txtSetVolt.Text);
                volt = CheckVoltRanges(ch, volt);
                _ngp.Write($"VOLT {volt:F3}");
                _channels[ch].VoltFlag = true;
                CheckMode(ch);
                if (_channels[ch].VoltFlag && _channels[ch].CurrFlag)
                {
                    UpdatePowerBar(ch);
                }

            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(txtSetVolt.Text))
                {
                    MessageBox.Show("전압 값을 설정해주세요");
                }
                else
                {
                    MessageBox.Show("전압 설정 실패: " + ex.Message);
                }
            }
        }

        private void btnReadVolt_Click(object sender, EventArgs e)
        {
            lblAutoRangeWarning.Visible = false;
            try
            {

                int ch = GetSelectedChannel();
                string result = _ngp.Query("VOLT?");
                txtSetVolt.Text = double.Parse(result).ToString("F3");
                _channels[ch].VoltFlag = true;
                if (_channels[ch].VoltFlag && _channels[ch].CurrFlag)
                {
                    UpdatePowerBar(ch);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("전압 읽기 실패: " + ex.Message);
            }
        }
        private void btnSetCurr_Click(object sender, EventArgs e)
        {
            try
            {
                int ch = GetSelectedChannel();
                double curr = double.Parse(txtSetCurr.Text);
                lblAutoRangeWarning.Visible = false;
                curr = CheckCurrentRanges(ch, curr);
                _channels[ch].CurrFlag = true;
                CheckMode(ch);
                _ngp.Write($"CURR {curr:F4}");
                if (_channels[ch].VoltFlag && _channels[ch].CurrFlag)
                {
                    UpdatePowerBar(ch);
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(txtSetCurr.Text))
                {
                    MessageBox.Show("전류 값을 설정해주세요");
                }
                else if (double.Parse(txtSetVolt.Text) < 0 || double.Parse(txtSetVolt.Text) > CH12_MAX_VOLT)
                {
                    MessageBox.Show("0.001 ~ 20.050 범위의 값을 입력하세요.");
                }
                else
                {
                    MessageBox.Show("전류 설정 실패" + ex.Message);
                }
            }
        }
        private void btnReadCurr_Click(object sender, EventArgs e)
        {
            try
            {
                lblAutoRangeWarning.Visible = false;
                int ch = GetSelectedChannel();
                string result = _ngp.Query("CURR?");
                txtSetCurr.Text = double.Parse(result).ToString("F4");
                _channels[ch].CurrFlag = true;
                if (_channels[ch].VoltFlag && _channels[ch].CurrFlag)
                {
                    UpdatePowerBar(ch);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("전류 읽기 실패: " + ex.Message);
            }
        }
        private void btnApplyLimit_Click(object sender, EventArgs e)
        {
            try
            {
                int ch = GetSelectedChannel();


                double voltLow = double.Parse(txtVoltLow.Text);
                double voltHigh = double.Parse(txtVoltHigh.Text);

                CheckVoltRanges(ch, voltLow);
                CheckVoltRanges(ch, voltHigh);

                _channels[ch].VltLwFlag = true;
                _channels[ch].VltHFlag = true;

                _ngp.Write($"VOLT:ALIM:LOW {voltLow:F3}");
                _ngp.Write($"VOLT:ALIM {voltHigh:F3}");

                double currLow = double.Parse(txtCurrLow.Text);
                double currHigh = double.Parse(txtCurrHigh.Text);

                CheckCurrentRanges(ch, currLow);
                CheckCurrentRanges(ch, currHigh);

                _channels[ch].CrLwFlag = true;
                _channels[ch].CrHFlag = true;
                _ngp.Write($"CURR:ALIM:LOW {currLow:F4}");
                _ngp.Write($"CURR:ALIM {currHigh:F4}");


                int enable = chkAlimEnable.Checked ? 1 : 0;
                _ngp.Write($"ALIM {enable}");
                if (enable == 1)
                    MessageBox.Show("Safety Limit 적용 완료");
            }
            catch (Exception ex)
            {
                bool isEmpty =
                    string.IsNullOrWhiteSpace(txtVoltLow.Text) ||
                    string.IsNullOrWhiteSpace(txtVoltHigh.Text) ||
                    string.IsNullOrWhiteSpace(txtCurrLow.Text) ||
                    string.IsNullOrWhiteSpace(txtCurrHigh.Text);
                if (isEmpty)
                {
                    MessageBox.Show("입력되지 않은 칸이 있습니다.");
                }
                else
                {
                    MessageBox.Show("Limit 적용 실패: " + ex.Message);
                }

            }
        }
        private void btnReadLimit_Click(object sender, EventArgs e)
        {
            try
            {
                int ch = GetSelectedChannel();
                string alimState = _ngp.Query("ALIM?");
                chkAlimEnable.Checked = alimState.Trim() == "1";

                string voltLow = _ngp.Query("VOLT:ALIM:LOW?");
                string voltHigh = _ngp.Query("VOLT:ALIM?");
                txtVoltLow.Text = double.Parse(voltLow).ToString("F3");
                txtVoltHigh.Text = double.Parse(voltHigh).ToString("F3");
                _channels[ch].VltLwFlag = true;
                _channels[ch].VltHFlag = true;

                string currLow = _ngp.Query("CURR:ALIM:LOW?");
                string currHigh = _ngp.Query("CURR:ALIM?");
                _channels[ch].CrLwFlag = true;
                _channels[ch].CrHFlag = true;
                txtCurrLow.Text = double.Parse(currLow).ToString("F4");
                txtCurrHigh.Text = double.Parse(currHigh).ToString("F4");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Limit 읽기 실패: " + ex.Message);
            }
        }

        private void btnMeasure_Click(object sender, EventArgs e)
        {
            DoMeasure();
        }
        private void DoMeasure()
        {
            try
            {
                int ch = GetSelectedChannel();
                _ngp.SelectChannel(ch);

                string voltResult = _ngp.Query("MEAS:VOLT?");
                double volt = double.Parse(voltResult);
                lblMeasVolt.Text = volt.ToString("F3") + " V";

                string currResult = _ngp.Query("MEAS:CURR?");
                double curr = double.Parse(currResult);
                lblMeasCurr.Text = curr.ToString("F4") + " A";
            }
            catch (Exception ex)
            {
                _isRunning = false;              // Thread 멈춤
                chkAutoRefresh.Checked = false;
                MessageBox.Show("측정 실패: " + ex.Message);
            }
        }
        private void chkAutoRefresh_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoRefresh.Checked)
            {
                _isRunning = true;                        // 실행 플래그 ON
                _thread = new Thread(MeasureLoop);        // 스레드 생성
                _thread.IsBackground = true;              // 프로그램 종료 시 같이 종료
                _thread.Start();                          // 스레드 시작
            }
            else
            {
                _isRunning = false;                       // 실행 플래그 OFF → while 루프 종료
            }
        }

        private void MeasureLoop()                        // async Task → void
        {
            while (_isRunning)                            // CancellationToken → bool 플래그
            {
                try
                {
                    this.Invoke(new Action(() =>           // UI 스레드에서 실행 요청
                    {
                        DoMeasure();
                    }));
                }
                catch
                {
                    _isRunning = false;                   // 에러 시 멈춤
                    this.Invoke(new Action(() =>           // UI 스레드에서 체크 해제
                    {
                        chkAutoRefresh.Checked = false;
                    }));
                    break;
                }
                Thread.Sleep(500);                        // Task.Delay → Thread.Sleep
            }
        }
        private void btnOutputOn_Click(object sender, EventArgs e)
        {
            try
            {
                int ch = GetSelectedChannel();
                _ngp.SelectChannel(ch);
                _ngp.Write("OUTP 1");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Output ON 실패: " + ex.Message);
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                int ch = GetSelectedChannel();
                _ngp.SelectChannel(ch);
                _ngp.Write("OUTP 0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Output OFF 실패: " + ex.Message);
            }
        }
        private int GetSelectedChannel()
        {
            if (rgChannel.EditValue == null) return 1;
            return Convert.ToInt32(rgChannel.EditValue);
        }


        private double CheckVoltRanges(int ch, double volt)
        {
            switch (ch)
            {
                case 1:
                case 2:
                    if (volt > CH12_MAX_VOLT)
                    {
                        volt = CH12_MAX_VOLT;
                        ValidateRange(ch, volt, MIN_VOLT, true, true);
                        return volt;
                    }
                    else if (volt < MIN_VOLT)
                    {
                        volt = MIN_VOLT;
                        ValidateRange(ch, CH12_MAX_VOLT, volt, true, false);
                        return volt;
                    }
                    return volt;
                    break;
                default:
                    if (volt > CH34_MAX_VOLT)
                    {
                        volt = CH34_MAX_VOLT;
                        ValidateRange(ch, volt, MIN_VOLT, true, true);
                        return volt;
                    }
                    else if (volt < MIN_CURR)
                    {
                        volt = MIN_CURR;
                        ValidateRange(ch, CH34_MAX_VOLT, volt, true, false);
                        return volt;
                    }
                    return volt;
            }

        }

        private double CheckCurrentRanges(int ch, double curr)
        {
            switch (ch)
            {
                case 1:
                case 2:
                    if (curr > CH12_MAX_CURR)
                    {
                        curr = CH12_MAX_CURR;
                        ValidateRange(ch, curr, MIN_CURR, false, true);
                        return curr;
                    }
                    else if (curr < MIN_CURR)
                    {
                        curr = MIN_CURR;
                        ValidateRange(ch, CH12_MAX_CURR, curr, false, false);
                    }
                    return curr;
                    break;
                default:
                    if (curr > CH34_MAX_CURR)
                    {
                        curr = CH34_MAX_CURR;
                        ValidateRange(ch, curr, MIN_CURR, false, true);
                        return curr;
                    }
                    else if (curr < MIN_CURR)
                    {
                        curr = MIN_CURR;
                        ValidateRange(ch, CH34_MAX_CURR, curr, false, false);
                    }
                    return curr;
            }
        }
        private void UpdatePowerBar(int ch)
        {
            try
            {
                double vlt = double.Parse(_ngp.ReadQ(3));
                double curr = double.Parse(_ngp.ReadQ(5));
                double power = vlt * curr;
                _channels[ch].PowerBarN = power;
                pgbPower.Value = (int)Math.Min(_channels[ch].PowerBarN, MAX_POWER);
                if (power >= MAX_POWER)
                {
                    lblPowerInfo.Text = $"200 W(최대 파워) - {power - MAX_POWER}W 만큼 초과!!!";
                    lblPowerInfo.Appearance.ForeColor = Color.Red;
                }
                else if (power > 160 && power < MAX_POWER)
                {
                    lblPowerInfo.Text = $"{power} W /{MAX_POWER} W";
                    lblPowerInfo.Appearance.ForeColor = Color.OrangeRed;
                }
                else
                {
                    lblPowerInfo.Text = $"{power} W /{MAX_POWER} W";
                    lblPowerInfo.Appearance.ForeColor = Color.Green;
                }
                double inputVolt = 0;
                double.TryParse(txtSetVolt.Text, out inputVolt);
                if (inputVolt != vlt)
                {
                    txtSetVolt.Text = vlt.ToString("F3");
                    lblAutoRangeWarning.Visible = true;
                    lblAutoRangeWarning.Appearance.ForeColor = Color.Red;
                    lblAutoRangeWarning.Text = $"Auto Ranging- Voltage 값을 {vlt}로 변경";
                }

                double inputCurr = 0;
                double.TryParse(txtSetCurr.Text, out inputCurr);
                if (inputCurr != curr)
                {
                    txtSetCurr.Text = curr.ToString("F4");
                    lblAutoRangeWarning.Visible = true;
                    lblAutoRangeWarning.Appearance.ForeColor = Color.Red;
                    lblAutoRangeWarning.Text = $"Auto Ranging- Current 값을 {curr}로 변경";
                }

            }
            catch
            { }
        }

        private void rgChannel_Click(object sender, EventArgs e)
        {
            int ch = GetSelectedChannel();
            _ngp.SelectChannel(ch);
            resetValue(ch);
        }

        private void rgChannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ch = GetSelectedChannel();
            _ngp.SelectChannel(ch);
            resetValue(ch);
        }
        private void ApplyGrayText(int ch)
        {
            switch (ch)
            {
                case 1:
                case 2:
                    if (!_channels[ch].VoltFlag)
                        ApplyGreyPrompt(txtSetVolt, CH12_VOLT_RANGE);
                    if (!_channels[ch].CurrFlag)
                        ApplyGreyPrompt(txtSetCurr, CH12_CURR_RANGE);
                    break;
                case 3:
                case 4:
                    if (!_channels[ch].VoltFlag)
                        ApplyGreyPrompt(txtSetVolt, CH34_VOLT_RANGE);
                    if (!_channels[ch].CurrFlag)
                        ApplyGreyPrompt(txtSetCurr, CH34_CURR_RANGE);
                    break;
            }
        }

        private void ApplyGrayLimit(int ch)
        {
            switch (ch)
            {
                case 1:
                case 2:
                    if (!_channels[ch].VltLwFlag)
                        ApplyGreyPrompt(txtVoltLow, MIN_VOLT.ToString());
                    if (!_channels[ch].VltHFlag)
                        ApplyGreyPrompt(txtVoltHigh, CH12_MAX_VOLT.ToString("F3"));
                    if (!_channels[ch].CrLwFlag)
                        ApplyGreyPrompt(txtCurrLow, MIN_CURR.ToString());
                    if (!_channels[ch].CrHFlag)
                        ApplyGreyPrompt(txtCurrHigh, CH12_MAX_CURR.ToString("F4"));
                    break;
                case 3:
                case 4:
                    if (!_channels[ch].VltLwFlag)
                        ApplyGreyPrompt(txtVoltLow, MIN_VOLT.ToString());
                    if (!_channels[ch].VltHFlag)
                        ApplyGreyPrompt(txtVoltHigh, CH34_MAX_VOLT.ToString("F3"));
                    if (!_channels[ch].CrLwFlag)
                        ApplyGreyPrompt(txtCurrLow, MIN_CURR.ToString());
                    if (!_channels[ch].CrHFlag)
                        ApplyGreyPrompt(txtCurrHigh, CH34_MAX_CURR.ToString("F4"));
                    break;
            }
        }
        private void ApplyGreyPrompt(DevExpress.XtraEditors.TextEdit txt, string str)
        {
            txt.EditValue = null;
            txt.Properties.NullValuePrompt = str;
            txt.Properties.ShowNullValuePrompt = DevExpress.XtraEditors.ShowNullValuePromptOptions.EmptyValue;
        }

        private void ValidateRange(int ch, double maxiNum, double minNum, bool configUnits, bool configRange)
        {
            string units = configUnits ? "V" : "A";
            string strUnits = configUnits ? "전압" : "전류";
            double limitValue = configRange ? maxiNum : minNum;
            string rangeType = configRange ? "최댓값" : "최솟값";
            if (configUnits)
            {
                txtSetVolt.Text = limitValue.ToString();
            }
            else
            {
                txtSetCurr.Text = limitValue.ToString();
            }
            MessageBox.Show($"{ch}채널은 {minNum} ~ {maxiNum} {units} 범위의 값을 입력하세요", "범위 오류", MessageBoxButtons.OK);
            lblAutoRangeWarning.Visible = true;
            lblAutoRangeWarning.Text = $"Auto Ranging - CH{ch}: {strUnits} {rangeType} 초과 -> {limitValue} {units}으로 변경";
            lblAutoRangeWarning.Appearance.ForeColor = Color.Red;
        }

        private void CheckMode(int ch)
        {
            string modeResult = _ngp.Query($"STAT:QUES:INST:ISUM{ch}:COND?").Trim();
            lblMeasMode.Text = modeResult == "1" ? "CC" : modeResult == "2" ? "CV" : "OFF";
        }


        private void resetValue(int ch)
        {
            ApplyGrayText(ch);

            lblAutoRangeWarning.Visible = false;
            int keyN = 0;
            if (_channels[ch].VoltFlag && !_channels[ch].CurrFlag)
                keyN = 1;
            else if (!_channels[ch].VoltFlag && _channels[ch].CurrFlag)
                keyN = 2;
            else if (_channels[ch].VoltFlag && _channels[ch].CurrFlag)
                keyN = 3;
            LoadVoltCurr(ch, keyN);

            ShowSafetyValues(ch);

            string modeResult = _ngp.Query($"STAT:QUES:INST:ISUM{ch}:COND?").Trim();
            lblMeasMode.Text = modeResult == "1" ? "CC" : modeResult == "2" ? "CV" : "OFF";
        }
        private void LoadVoltCurr(int ch, int key)
        {
            switch (key)
            {
                case 0:
                    ApplyGrayText(ch);
                    break;
                case 1:
                    txtSetVolt.Text = double.Parse(_ngp.Query("VOLT?")).ToString("F3");
                    break;
                case 2:
                    txtSetCurr.Text = double.Parse(_ngp.Query("CURR?")).ToString("F4");
                    break;
                case 3:
                    txtSetVolt.Text = double.Parse(_ngp.Query("VOLT?")).ToString("F3");
                    txtSetCurr.Text = double.Parse(_ngp.Query("CURR?")).ToString("F4");
                    UpdatePowerBar(ch);
                    break;
            }
        }
        private void ShowSafetyValues(int ch)
        {
            if (_channels[ch].VltLwFlag) txtVoltLow.Text = double.Parse(_ngp.Query("VOLT:ALIM:LOW?")).ToString("F3");
            if (_channels[ch].VltHFlag) txtVoltHigh.Text = double.Parse(_ngp.Query("VOLT:ALIM?")).ToString("F3");
            if (_channels[ch].CrLwFlag) txtCurrLow.Text = double.Parse(_ngp.Query("CURR:ALIM:LOW?")).ToString("F4");
            if (_channels[ch].CrHFlag) txtCurrHigh.Text = double.Parse(_ngp.Query("CURR:ALIM?")).ToString("F4");
            ApplyGrayLimit(ch);
        }
        private void ChangetxtColor(int ch)
        {
            string modeResult = _ngp.Query($"STAT:QUES:INST:ISUM{ch}:COND?").Trim();
            if (modeResult == "1")
            {
                txtSetVolt.BackColor = Color.Yellow;
                txtSetVolt.Text = double.Parse(_ngp.Query("VOLT?")).ToString("F3");
                return;
            }

            txtSetCurr.BackColor = Color.Yellow;
            txtSetCurr.Text = double.Parse(_ngp.Query("CURR?")).ToString("F4");
        }
    }
}