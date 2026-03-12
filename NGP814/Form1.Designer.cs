namespace NGP814
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpConnection = new DevExpress.XtraEditors.GroupControl();
            lblStatus = new DevExpress.XtraEditors.LabelControl();
            btnDisconnect = new DevExpress.XtraEditors.SimpleButton();
            btnConnect = new DevExpress.XtraEditors.SimpleButton();
            txtPort = new DevExpress.XtraEditors.TextEdit();
            lblPort = new DevExpress.XtraEditors.LabelControl();
            txtIp = new DevExpress.XtraEditors.TextEdit();
            lblIP = new DevExpress.XtraEditors.LabelControl();
            grpChannel = new DevExpress.XtraEditors.GroupControl();
            rgChannel = new DevExpress.XtraEditors.RadioGroup();
            pbgPower = new DevExpress.XtraEditors.GroupControl();
            lblAutoRangeWarning = new DevExpress.XtraEditors.LabelControl();
            btnReadCurr = new DevExpress.XtraEditors.SimpleButton();
            btnSetCurr = new DevExpress.XtraEditors.SimpleButton();
            btnReadVolt = new DevExpress.XtraEditors.SimpleButton();
            btnSetVolt = new DevExpress.XtraEditors.SimpleButton();
            lblPowerInfo = new DevExpress.XtraEditors.LabelControl();
            pgbPower = new System.Windows.Forms.ProgressBar();
            lvlCurrUnit = new DevExpress.XtraEditors.LabelControl();
            lblVoltUnit = new DevExpress.XtraEditors.LabelControl();
            txtSetCurr = new DevExpress.XtraEditors.TextEdit();
            txtSetVolt = new DevExpress.XtraEditors.TextEdit();
            lblSetCurr = new DevExpress.XtraEditors.LabelControl();
            lblSetVolt = new DevExpress.XtraEditors.LabelControl();
            lblMeasModeTitle = new DevExpress.XtraEditors.LabelControl();
            lblMeasMode = new DevExpress.XtraEditors.LabelControl();
            grpSafetyLimit = new DevExpress.XtraEditors.GroupControl();
            lblCurrHigh = new DevExpress.XtraEditors.LabelControl();
            lblVoltHigh = new DevExpress.XtraEditors.LabelControl();
            btnReadLimit = new DevExpress.XtraEditors.SimpleButton();
            btnApplyLimit = new DevExpress.XtraEditors.SimpleButton();
            txtCurrHigh = new DevExpress.XtraEditors.TextEdit();
            txtCurrLow = new DevExpress.XtraEditors.TextEdit();
            txtVoltHigh = new DevExpress.XtraEditors.TextEdit();
            txtVoltLow = new DevExpress.XtraEditors.TextEdit();
            lblVurrHighUnit = new DevExpress.XtraEditors.LabelControl();
            lblVoltHighUnit = new DevExpress.XtraEditors.LabelControl();
            lblCurrLowUnit = new DevExpress.XtraEditors.LabelControl();
            lblVoltLowUnit = new DevExpress.XtraEditors.LabelControl();
            lblCurrLow = new DevExpress.XtraEditors.LabelControl();
            lblVoltLow = new DevExpress.XtraEditors.LabelControl();
            chkAlimEnable = new DevExpress.XtraEditors.CheckEdit();
            grpMeasure = new DevExpress.XtraEditors.GroupControl();
            chkAutoRefresh = new DevExpress.XtraEditors.CheckEdit();
            btnMeasure = new DevExpress.XtraEditors.SimpleButton();
            lblMeasCurr = new DevExpress.XtraEditors.LabelControl();
            lblMeasVolt = new DevExpress.XtraEditors.LabelControl();
            lblMeasCurrTitle = new DevExpress.XtraEditors.LabelControl();
            lblMeasVoltTitle = new DevExpress.XtraEditors.LabelControl();
            grpOutput = new DevExpress.XtraEditors.GroupControl();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            btnOutputOn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)grpConnection).BeginInit();
            grpConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPort.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtIp.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grpChannel).BeginInit();
            grpChannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rgChannel.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbgPower).BeginInit();
            pbgPower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSetCurr.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSetVolt.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grpSafetyLimit).BeginInit();
            grpSafetyLimit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCurrHigh.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCurrLow.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtVoltHigh.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtVoltLow.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkAlimEnable.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grpMeasure).BeginInit();
            grpMeasure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chkAutoRefresh.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grpOutput).BeginInit();
            grpOutput.SuspendLayout();
            SuspendLayout();
            // 
            // grpConnection
            // 
            grpConnection.Controls.Add(lblStatus);
            grpConnection.Controls.Add(btnDisconnect);
            grpConnection.Controls.Add(btnConnect);
            grpConnection.Controls.Add(txtPort);
            grpConnection.Controls.Add(lblPort);
            grpConnection.Controls.Add(txtIp);
            grpConnection.Controls.Add(lblIP);
            grpConnection.Location = new System.Drawing.Point(14, 15);
            grpConnection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grpConnection.Name = "grpConnection";
            grpConnection.Size = new System.Drawing.Size(811, 77);
            grpConnection.TabIndex = 0;
            grpConnection.Text = "Connection";
            // 
            // lblStatus
            // 
            lblStatus.Appearance.ForeColor = System.Drawing.Color.Red;
            lblStatus.Appearance.Options.UseForeColor = true;
            lblStatus.Location = new System.Drawing.Point(698, 45);
            lblStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(86, 18);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Disconnected";
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new System.Drawing.Point(589, 36);
            btnDisconnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new System.Drawing.Size(103, 36);
            btnDisconnect.TabIndex = 5;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // btnConnect
            // 
            btnConnect.Location = new System.Drawing.Point(466, 36);
            btnConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new System.Drawing.Size(103, 36);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "Connect";
            btnConnect.Click += btnConnect_Click;
            // 
            // txtPort
            // 
            txtPort.EditValue = "5025";
            txtPort.Location = new System.Drawing.Point(296, 37);
            txtPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPort.Name = "txtPort";
            txtPort.Size = new System.Drawing.Size(137, 24);
            txtPort.TabIndex = 3;
            // 
            // lblPort
            // 
            lblPort.Location = new System.Drawing.Point(263, 45);
            lblPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lblPort.Name = "lblPort";
            lblPort.Size = new System.Drawing.Size(26, 18);
            lblPort.TabIndex = 2;
            lblPort.Text = "Port";
            // 
            // txtIp
            // 
            txtIp.EditValue = "192.168.29.2";
            txtIp.Location = new System.Drawing.Point(95, 37);
            txtIp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtIp.Name = "txtIp";
            txtIp.Size = new System.Drawing.Size(137, 24);
            txtIp.TabIndex = 1;
            // 
            // lblIP
            // 
            lblIP.Location = new System.Drawing.Point(22, 45);
            lblIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lblIP.Name = "lblIP";
            lblIP.Size = new System.Drawing.Size(71, 18);
            lblIP.TabIndex = 0;
            lblIP.Text = "IP Address";
            // 
            // grpChannel
            // 
            grpChannel.Controls.Add(rgChannel);
            grpChannel.Location = new System.Drawing.Point(14, 100);
            grpChannel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grpChannel.Name = "grpChannel";
            grpChannel.Size = new System.Drawing.Size(811, 73);
            grpChannel.TabIndex = 7;
            grpChannel.Text = "channel Select";
            // 
            // rgChannel
            // 
            rgChannel.Location = new System.Drawing.Point(6, 32);
            rgChannel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            rgChannel.Name = "rgChannel";
            rgChannel.Properties.Columns = 4;
            rgChannel.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] { new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "CH1", true, null, "rbChannel1"), new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "CH2", true, null, "rbChannel2"), new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "CH3", true, null, "rbChannel3"), new DevExpress.XtraEditors.Controls.RadioGroupItem(4, "CH4", true, null, "rbChannel4") });
            rgChannel.Size = new System.Drawing.Size(457, 32);
            rgChannel.TabIndex = 0;
            rgChannel.SelectedIndexChanged += rgChannel_SelectedIndexChanged;
            rgChannel.Click += rgChannel_Click;
            // 
            // pbgPower
            // 
            pbgPower.Controls.Add(lblAutoRangeWarning);
            pbgPower.Controls.Add(btnReadCurr);
            pbgPower.Controls.Add(btnSetCurr);
            pbgPower.Controls.Add(btnReadVolt);
            pbgPower.Controls.Add(btnSetVolt);
            pbgPower.Controls.Add(lblPowerInfo);
            pbgPower.Controls.Add(pgbPower);
            pbgPower.Controls.Add(lvlCurrUnit);
            pbgPower.Controls.Add(lblVoltUnit);
            pbgPower.Controls.Add(txtSetCurr);
            pbgPower.Controls.Add(txtSetVolt);
            pbgPower.Controls.Add(lblSetCurr);
            pbgPower.Controls.Add(lblSetVolt);
            pbgPower.Location = new System.Drawing.Point(14, 181);
            pbgPower.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pbgPower.Name = "pbgPower";
            pbgPower.Size = new System.Drawing.Size(811, 194);
            pbgPower.TabIndex = 1;
            pbgPower.Text = "Voltage/Current Control";
            // 
            // lblAutoRangeWarning
            // 
            lblAutoRangeWarning.Location = new System.Drawing.Point(123, 156);
            lblAutoRangeWarning.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lblAutoRangeWarning.Name = "lblAutoRangeWarning";
            lblAutoRangeWarning.Size = new System.Drawing.Size(53, 18);
            lblAutoRangeWarning.TabIndex = 12;
            lblAutoRangeWarning.Text = "Warning";
            lblAutoRangeWarning.Visible = false;
            // 
            // btnReadCurr
            // 
            btnReadCurr.Location = new System.Drawing.Point(392, 113);
            btnReadCurr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnReadCurr.Name = "btnReadCurr";
            btnReadCurr.Size = new System.Drawing.Size(86, 30);
            btnReadCurr.TabIndex = 9;
            btnReadCurr.Text = "Read";
            btnReadCurr.Click += btnReadCurr_Click;
            // 
            // btnSetCurr
            // 
            btnSetCurr.Location = new System.Drawing.Point(299, 112);
            btnSetCurr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSetCurr.Name = "btnSetCurr";
            btnSetCurr.Size = new System.Drawing.Size(86, 30);
            btnSetCurr.TabIndex = 8;
            btnSetCurr.Text = "Set";
            btnSetCurr.Click += btnSetCurr_Click;
            // 
            // btnReadVolt
            // 
            btnReadVolt.Location = new System.Drawing.Point(392, 54);
            btnReadVolt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnReadVolt.Name = "btnReadVolt";
            btnReadVolt.Size = new System.Drawing.Size(86, 30);
            btnReadVolt.TabIndex = 7;
            btnReadVolt.Text = "Read";
            btnReadVolt.Click += btnReadVolt_Click;
            // 
            // btnSetVolt
            // 
            btnSetVolt.Location = new System.Drawing.Point(299, 54);
            btnSetVolt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSetVolt.Name = "btnSetVolt";
            btnSetVolt.Size = new System.Drawing.Size(86, 30);
            btnSetVolt.TabIndex = 6;
            btnSetVolt.Text = "Set";
            btnSetVolt.Click += btnSetVolt_Click;
            // 
            // lblPowerInfo
            // 
            lblPowerInfo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            lblPowerInfo.Location = new System.Drawing.Point(559, 125);
            lblPowerInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lblPowerInfo.Name = "lblPowerInfo";
            lblPowerInfo.Size = new System.Drawing.Size(158, 18);
            lblPowerInfo.TabIndex = 11;
            lblPowerInfo.Text = "0.0 W/ 200W(최대 파워)";
            // 
            // pgbPower
            // 
            pgbPower.Location = new System.Drawing.Point(512, 72);
            pgbPower.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pgbPower.Maximum = 200;
            pgbPower.Name = "pgbPower";
            pgbPower.Size = new System.Drawing.Size(271, 30);
            pgbPower.TabIndex = 10;
            // 
            // lvlCurrUnit
            // 
            lvlCurrUnit.Location = new System.Drawing.Point(263, 113);
            lvlCurrUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lvlCurrUnit.Name = "lvlCurrUnit";
            lvlCurrUnit.Size = new System.Drawing.Size(10, 18);
            lvlCurrUnit.TabIndex = 5;
            lvlCurrUnit.Text = "A";
            // 
            // lblVoltUnit
            // 
            lblVoltUnit.Location = new System.Drawing.Point(262, 59);
            lblVoltUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lblVoltUnit.Name = "lblVoltUnit";
            lblVoltUnit.Size = new System.Drawing.Size(9, 18);
            lblVoltUnit.TabIndex = 4;
            lblVoltUnit.Text = "V";
            // 
            // txtSetCurr
            // 
            txtSetCurr.EditValue = "";
            txtSetCurr.Location = new System.Drawing.Point(95, 109);
            txtSetCurr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSetCurr.Name = "txtSetCurr";
            txtSetCurr.Size = new System.Drawing.Size(160, 24);
            txtSetCurr.TabIndex = 3;
            // 
            // txtSetVolt
            // 
            txtSetVolt.EditValue = "";
            txtSetVolt.Location = new System.Drawing.Point(95, 55);
            txtSetVolt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSetVolt.Name = "txtSetVolt";
            txtSetVolt.Properties.Name = "txtSetVolt";
            txtSetVolt.Size = new System.Drawing.Size(160, 24);
            txtSetVolt.TabIndex = 2;
            // 
            // lblSetCurr
            // 
            lblSetCurr.Location = new System.Drawing.Point(15, 113);
            lblSetCurr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lblSetCurr.Name = "lblSetCurr";
            lblSetCurr.Size = new System.Drawing.Size(48, 18);
            lblSetCurr.TabIndex = 1;
            lblSetCurr.Text = "Current";
            // 
            // lblSetVolt
            // 
            lblSetVolt.Location = new System.Drawing.Point(22, 59);
            lblSetVolt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lblSetVolt.Name = "lblSetVolt";
            lblSetVolt.Size = new System.Drawing.Size(48, 18);
            lblSetVolt.TabIndex = 0;
            lblSetVolt.Text = "Voltage";
            // 
            // lblMeasModeTitle
            // 
            lblMeasModeTitle.Location = new System.Drawing.Point(616, 96);
            lblMeasModeTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lblMeasModeTitle.Name = "lblMeasModeTitle";
            lblMeasModeTitle.Size = new System.Drawing.Size(36, 18);
            lblMeasModeTitle.TabIndex = 6;
            lblMeasModeTitle.Text = "Mode";
            // 
            // lblMeasMode
            // 
            lblMeasMode.Appearance.Font = new System.Drawing.Font("Tahoma", 33F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            lblMeasMode.Appearance.Options.UseFont = true;
            lblMeasMode.Location = new System.Drawing.Point(571, 33);
            lblMeasMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lblMeasMode.Name = "lblMeasMode";
            lblMeasMode.Size = new System.Drawing.Size(119, 66);
            lblMeasMode.TabIndex = 7;
            lblMeasMode.Text = "OFF";
            // 
            // grpSafetyLimit
            // 
            grpSafetyLimit.Controls.Add(lblCurrHigh);
            grpSafetyLimit.Controls.Add(lblVoltHigh);
            grpSafetyLimit.Controls.Add(btnReadLimit);
            grpSafetyLimit.Controls.Add(btnApplyLimit);
            grpSafetyLimit.Controls.Add(txtCurrHigh);
            grpSafetyLimit.Controls.Add(txtCurrLow);
            grpSafetyLimit.Controls.Add(txtVoltHigh);
            grpSafetyLimit.Controls.Add(txtVoltLow);
            grpSafetyLimit.Controls.Add(lblVurrHighUnit);
            grpSafetyLimit.Controls.Add(lblVoltHighUnit);
            grpSafetyLimit.Controls.Add(lblCurrLowUnit);
            grpSafetyLimit.Controls.Add(lblVoltLowUnit);
            grpSafetyLimit.Controls.Add(lblCurrLow);
            grpSafetyLimit.Controls.Add(lblVoltLow);
            grpSafetyLimit.Controls.Add(chkAlimEnable);
            grpSafetyLimit.Location = new System.Drawing.Point(14, 383);
            grpSafetyLimit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grpSafetyLimit.Name = "grpSafetyLimit";
            grpSafetyLimit.Size = new System.Drawing.Size(811, 174);
            grpSafetyLimit.TabIndex = 10;
            grpSafetyLimit.Text = "safety Limit(Alim)";
            // 
            // lblCurrHigh
            // 
            lblCurrHigh.Location = new System.Drawing.Point(290, 118);
            lblCurrHigh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lblCurrHigh.Name = "lblCurrHigh";
            lblCurrHigh.Size = new System.Drawing.Size(39, 18);
            lblCurrHigh.TabIndex = 14;
            lblCurrHigh.Text = "I High";
            // 
            // lblVoltHigh
            // 
            lblVoltHigh.Location = new System.Drawing.Point(286, 80);
            lblVoltHigh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lblVoltHigh.Name = "lblVoltHigh";
            lblVoltHigh.Size = new System.Drawing.Size(42, 18);
            lblVoltHigh.TabIndex = 13;
            lblVoltHigh.Text = "V High";
            // 
            // btnReadLimit
            // 
            btnReadLimit.Location = new System.Drawing.Point(634, 95);
            btnReadLimit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnReadLimit.Name = "btnReadLimit";
            btnReadLimit.Size = new System.Drawing.Size(86, 30);
            btnReadLimit.TabIndex = 12;
            btnReadLimit.Text = "Read";
            btnReadLimit.Click += btnReadLimit_Click;
            // 
            // btnApplyLimit
            // 
            btnApplyLimit.Location = new System.Drawing.Point(542, 95);
            btnApplyLimit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnApplyLimit.Name = "btnApplyLimit";
            btnApplyLimit.Size = new System.Drawing.Size(86, 30);
            btnApplyLimit.TabIndex = 11;
            btnApplyLimit.Text = "Apply";
            btnApplyLimit.Click += btnApplyLimit_Click;
            // 
            // txtCurrHigh
            // 
            txtCurrHigh.EditValue = "";
            txtCurrHigh.Location = new System.Drawing.Point(349, 114);
            txtCurrHigh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCurrHigh.Name = "txtCurrHigh";
            txtCurrHigh.Size = new System.Drawing.Size(114, 24);
            txtCurrHigh.TabIndex = 10;
            // 
            // txtCurrLow
            // 
            txtCurrLow.Location = new System.Drawing.Point(85, 114);
            txtCurrLow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCurrLow.Name = "txtCurrLow";
            txtCurrLow.Size = new System.Drawing.Size(114, 24);
            txtCurrLow.TabIndex = 9;
            // 
            // txtVoltHigh
            // 
            txtVoltHigh.EditValue = "";
            txtVoltHigh.Location = new System.Drawing.Point(349, 76);
            txtVoltHigh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtVoltHigh.Name = "txtVoltHigh";
            txtVoltHigh.Size = new System.Drawing.Size(114, 24);
            txtVoltHigh.TabIndex = 8;
            // 
            // txtVoltLow
            // 
            txtVoltLow.EditValue = "";
            txtVoltLow.Location = new System.Drawing.Point(85, 76);
            txtVoltLow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtVoltLow.Name = "txtVoltLow";
            txtVoltLow.Properties.NullValuePrompt = "0.001~32.050";
            txtVoltLow.Size = new System.Drawing.Size(114, 24);
            txtVoltLow.TabIndex = 7;
            // 
            // lblVurrHighUnit
            // 
            lblVurrHighUnit.Location = new System.Drawing.Point(470, 118);
            lblVurrHighUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lblVurrHighUnit.Name = "lblVurrHighUnit";
            lblVurrHighUnit.Size = new System.Drawing.Size(10, 18);
            lblVurrHighUnit.TabIndex = 6;
            lblVurrHighUnit.Text = "A";
            // 
            // lblVoltHighUnit
            // 
            lblVoltHighUnit.Location = new System.Drawing.Point(470, 80);
            lblVoltHighUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lblVoltHighUnit.Name = "lblVoltHighUnit";
            lblVoltHighUnit.Size = new System.Drawing.Size(9, 18);
            lblVoltHighUnit.TabIndex = 5;
            lblVoltHighUnit.Text = "V";
            // 
            // lblCurrLowUnit
            // 
            lblCurrLowUnit.Location = new System.Drawing.Point(206, 118);
            lblCurrLowUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lblCurrLowUnit.Name = "lblCurrLowUnit";
            lblCurrLowUnit.Size = new System.Drawing.Size(10, 18);
            lblCurrLowUnit.TabIndex = 4;
            lblCurrLowUnit.Text = "A";
            // 
            // lblVoltLowUnit
            // 
            lblVoltLowUnit.Location = new System.Drawing.Point(206, 80);
            lblVoltLowUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lblVoltLowUnit.Name = "lblVoltLowUnit";
            lblVoltLowUnit.Size = new System.Drawing.Size(9, 18);
            lblVoltLowUnit.TabIndex = 3;
            lblVoltLowUnit.Text = "V";
            // 
            // lblCurrLow
            // 
            lblCurrLow.Location = new System.Drawing.Point(26, 118);
            lblCurrLow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lblCurrLow.Name = "lblCurrLow";
            lblCurrLow.Size = new System.Drawing.Size(37, 18);
            lblCurrLow.TabIndex = 2;
            lblCurrLow.Text = "I Low";
            // 
            // lblVoltLow
            // 
            lblVoltLow.Location = new System.Drawing.Point(22, 80);
            lblVoltLow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lblVoltLow.Name = "lblVoltLow";
            lblVoltLow.Size = new System.Drawing.Size(40, 18);
            lblVoltLow.TabIndex = 1;
            lblVoltLow.Text = "V Low";
            // 
            // chkAlimEnable
            // 
            chkAlimEnable.Location = new System.Drawing.Point(6, 46);
            chkAlimEnable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            chkAlimEnable.Name = "chkAlimEnable";
            chkAlimEnable.Properties.Caption = "Safety Limit Enable";
            chkAlimEnable.Size = new System.Drawing.Size(150, 24);
            chkAlimEnable.TabIndex = 0;
            // 
            // grpMeasure
            // 
            grpMeasure.Controls.Add(lblMeasModeTitle);
            grpMeasure.Controls.Add(chkAutoRefresh);
            grpMeasure.Controls.Add(lblMeasMode);
            grpMeasure.Controls.Add(btnMeasure);
            grpMeasure.Controls.Add(lblMeasCurr);
            grpMeasure.Controls.Add(lblMeasVolt);
            grpMeasure.Controls.Add(lblMeasCurrTitle);
            grpMeasure.Controls.Add(lblMeasVoltTitle);
            grpMeasure.Location = new System.Drawing.Point(14, 564);
            grpMeasure.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grpMeasure.Name = "grpMeasure";
            grpMeasure.Size = new System.Drawing.Size(811, 129);
            grpMeasure.TabIndex = 11;
            grpMeasure.Text = "Measure(전압/전류 측정)";
            // 
            // chkAutoRefresh
            // 
            chkAutoRefresh.Location = new System.Drawing.Point(317, 90);
            chkAutoRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            chkAutoRefresh.Name = "chkAutoRefresh";
            chkAutoRefresh.Properties.Caption = "Auto Refresh";
            chkAutoRefresh.Size = new System.Drawing.Size(123, 24);
            chkAutoRefresh.TabIndex = 5;
            chkAutoRefresh.CheckedChanged += chkAutoRefresh_CheckedChanged;
            // 
            // btnMeasure
            // 
            btnMeasure.Location = new System.Drawing.Point(317, 41);
            btnMeasure.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnMeasure.Name = "btnMeasure";
            btnMeasure.Size = new System.Drawing.Size(103, 36);
            btnMeasure.TabIndex = 4;
            btnMeasure.Text = "Measure";
            btnMeasure.Click += btnMeasure_Click;
            // 
            // lblMeasCurr
            // 
            lblMeasCurr.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            lblMeasCurr.Appearance.ForeColor = System.Drawing.Color.FromArgb(255, 128, 0);
            lblMeasCurr.Appearance.Options.UseFont = true;
            lblMeasCurr.Appearance.Options.UseForeColor = true;
            lblMeasCurr.Location = new System.Drawing.Point(161, 85);
            lblMeasCurr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lblMeasCurr.Name = "lblMeasCurr";
            lblMeasCurr.Size = new System.Drawing.Size(135, 36);
            lblMeasCurr.TabIndex = 3;
            lblMeasCurr.Text = "0.0000 A";
            // 
            // lblMeasVolt
            // 
            lblMeasVolt.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            lblMeasVolt.Appearance.ForeColor = System.Drawing.Color.Blue;
            lblMeasVolt.Appearance.Options.UseFont = true;
            lblMeasVolt.Appearance.Options.UseForeColor = true;
            lblMeasVolt.Location = new System.Drawing.Point(168, 35);
            lblMeasVolt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lblMeasVolt.Name = "lblMeasVolt";
            lblMeasVolt.Size = new System.Drawing.Size(122, 36);
            lblMeasVolt.TabIndex = 2;
            lblMeasVolt.Text = "0.000 V";
            // 
            // lblMeasCurrTitle
            // 
            lblMeasCurrTitle.Location = new System.Drawing.Point(22, 100);
            lblMeasCurrTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lblMeasCurrTitle.Name = "lblMeasCurrTitle";
            lblMeasCurrTitle.Size = new System.Drawing.Size(46, 18);
            lblMeasCurrTitle.TabIndex = 1;
            lblMeasCurrTitle.Text = "current";
            // 
            // lblMeasVoltTitle
            // 
            lblMeasVoltTitle.Location = new System.Drawing.Point(22, 50);
            lblMeasVoltTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lblMeasVoltTitle.Name = "lblMeasVoltTitle";
            lblMeasVoltTitle.Size = new System.Drawing.Size(48, 18);
            lblMeasVoltTitle.TabIndex = 0;
            lblMeasVoltTitle.Text = "Voltage";
            // 
            // grpOutput
            // 
            grpOutput.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            grpOutput.AppearanceCaption.Options.UseFont = true;
            grpOutput.Controls.Add(simpleButton2);
            grpOutput.Controls.Add(btnOutputOn);
            grpOutput.Location = new System.Drawing.Point(14, 701);
            grpOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grpOutput.Name = "grpOutput";
            grpOutput.Size = new System.Drawing.Size(811, 99);
            grpOutput.TabIndex = 6;
            grpOutput.Text = "Output Control";
            // 
            // simpleButton2
            // 
            simpleButton2.Appearance.BackColor = System.Drawing.Color.Red;
            simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            simpleButton2.Appearance.Options.UseBackColor = true;
            simpleButton2.Appearance.Options.UseFont = true;
            simpleButton2.Location = new System.Drawing.Point(422, 50);
            simpleButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new System.Drawing.Size(137, 39);
            simpleButton2.TabIndex = 1;
            simpleButton2.Text = "OUTPUT OFF";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // btnOutputOn
            // 
            btnOutputOn.Appearance.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            btnOutputOn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnOutputOn.Appearance.Options.UseBackColor = true;
            btnOutputOn.Appearance.Options.UseFont = true;
            btnOutputOn.Location = new System.Drawing.Point(194, 50);
            btnOutputOn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnOutputOn.Name = "btnOutputOn";
            btnOutputOn.Size = new System.Drawing.Size(137, 39);
            btnOutputOn.TabIndex = 0;
            btnOutputOn.Text = "OUTPUT ON";
            btnOutputOn.Click += btnOutputOn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(855, 914);
            Controls.Add(grpOutput);
            Controls.Add(grpMeasure);
            Controls.Add(grpSafetyLimit);
            Controls.Add(pbgPower);
            Controls.Add(grpChannel);
            Controls.Add(grpConnection);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "NGP814 Remote Control";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grpConnection).EndInit();
            grpConnection.ResumeLayout(false);
            grpConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPort.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtIp.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)grpChannel).EndInit();
            grpChannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rgChannel.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbgPower).EndInit();
            pbgPower.ResumeLayout(false);
            pbgPower.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtSetCurr.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSetVolt.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)grpSafetyLimit).EndInit();
            grpSafetyLimit.ResumeLayout(false);
            grpSafetyLimit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCurrHigh.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCurrLow.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtVoltHigh.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtVoltLow.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkAlimEnable.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)grpMeasure).EndInit();
            grpMeasure.ResumeLayout(false);
            grpMeasure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chkAutoRefresh.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)grpOutput).EndInit();
            grpOutput.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpConnection;
        private DevExpress.XtraEditors.TextEdit txtIp;
        private DevExpress.XtraEditors.LabelControl lblIP;
        private DevExpress.XtraEditors.SimpleButton btnDisconnect;
        private DevExpress.XtraEditors.SimpleButton btnConnect;
        private DevExpress.XtraEditors.TextEdit txtPort;
        private DevExpress.XtraEditors.LabelControl lblPort;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraEditors.GroupControl grpChannel;
        private DevExpress.XtraEditors.RadioGroup rgChannel;
        private DevExpress.XtraEditors.GroupControl pbgPower;
        private DevExpress.XtraEditors.LabelControl lblSetCurr;
        private DevExpress.XtraEditors.LabelControl lblSetVolt;
        private DevExpress.XtraEditors.LabelControl lvlCurrUnit;
        private DevExpress.XtraEditors.LabelControl lblVoltUnit;
        private DevExpress.XtraEditors.TextEdit txtSetCurr;
        private DevExpress.XtraEditors.TextEdit txtSetVolt;
        private DevExpress.XtraEditors.SimpleButton btnReadCurr;
        private DevExpress.XtraEditors.SimpleButton btnSetCurr;
        private DevExpress.XtraEditors.SimpleButton btnReadVolt;
        private DevExpress.XtraEditors.SimpleButton btnSetVolt;
        private DevExpress.XtraEditors.GroupControl grpSafetyLimit;
        private DevExpress.XtraEditors.LabelControl lblVoltHighUnit;
        private DevExpress.XtraEditors.LabelControl lblVoltLowUnit;
        private DevExpress.XtraEditors.LabelControl lblCurrLow;
        private DevExpress.XtraEditors.LabelControl lblVoltLow;
        private DevExpress.XtraEditors.CheckEdit chkAlimEnable;
        private DevExpress.XtraEditors.LabelControl lblCurrLowUnit;
        private DevExpress.XtraEditors.LabelControl lblVurrHighUnit;
        private DevExpress.XtraEditors.SimpleButton btnReadLimit;
        private DevExpress.XtraEditors.SimpleButton btnApplyLimit;
        private DevExpress.XtraEditors.TextEdit txtCurrHigh;
        private DevExpress.XtraEditors.TextEdit txtCurrLow;
        private DevExpress.XtraEditors.TextEdit txtVoltHigh;
        private DevExpress.XtraEditors.TextEdit txtVoltLow;
        private DevExpress.XtraEditors.LabelControl lblCurrHigh;
        private DevExpress.XtraEditors.LabelControl lblVoltHigh;
        private DevExpress.XtraEditors.GroupControl grpMeasure;
        private DevExpress.XtraEditors.LabelControl lblMeasCurrTitle;
        private DevExpress.XtraEditors.LabelControl lblMeasVoltTitle;
        private DevExpress.XtraEditors.LabelControl lblMeasCurr;
        private DevExpress.XtraEditors.LabelControl lblMeasVolt;
        private DevExpress.XtraEditors.CheckEdit chkAutoRefresh;
        private DevExpress.XtraEditors.SimpleButton btnMeasure;
        private DevExpress.XtraEditors.GroupControl grpOutput;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnOutputOn;
        private System.Windows.Forms.ProgressBar pgbPower;
        private DevExpress.XtraEditors.LabelControl lblPowerInfo;
        private DevExpress.XtraEditors.LabelControl lblAutoRangeWarning;
        private DevExpress.XtraEditors.LabelControl lblMeasModeTitle;
        private DevExpress.XtraEditors.LabelControl lblMeasMode;
    }
}

