using DevExpress.Utils.Animation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NGP814
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private NGPTCP _ngp = new NGPTCP();
        private Timer _timer;
        public Form1()
        {
            InitializeComponent();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("VS2019 Blue");
            _timer = new Timer();
            _timer.Interval = 500;
            //_timer.Tick+= Timer_Tick;

        }


        private int GetSelectedChannel()
        {
            if (rgChannel.EditValue == null) return 1;
            return Convert.ToInt32(rgChannel.EditValue);
        }


        private void grpConnection_Paint(object sender, PaintEventArgs e)
        {

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
                MessageBox.Show("연결 실패:"+ ex.Message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                _ngp.Disconnect();

                lblStatus.Text = "Disconnected";
                lblStatus.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show("연결 해제 실패: " + ex.Message);
            }
        }
    }
}
