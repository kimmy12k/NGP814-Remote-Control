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
            GrpVoltageControl = new DevExpress.XtraEditors.GroupControl();
            btnReadCurr = new DevExpress.XtraEditors.SimpleButton();
            btnSetCurr = new DevExpress.XtraEditors.SimpleButton();
            btnReadVolt = new DevExpress.XtraEditors.SimpleButton();
            btnSetVolt = new DevExpress.XtraEditors.SimpleButton();
            lvlCurrUnit = new DevExpress.XtraEditors.LabelControl();
            lblVoltUnit = new DevExpress.XtraEditors.LabelControl();
            txtSetCurr = new DevExpress.XtraEditors.TextEdit();
            txtSetVolt = new DevExpress.XtraEditors.TextEdit();
            lblSetCurr = new DevExpress.XtraEditors.LabelControl();
            lblSetVolt = new DevExpress.XtraEditors.LabelControl();
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
            ((System.ComponentModel.ISupportInitialize)GrpVoltageControl).BeginInit();
            GrpVoltageControl.SuspendLayout();
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
            grpConnection.Location = new System.Drawing.Point(12, 12);
            grpConnection.Name = "grpConnection";
            grpConnection.Size = new System.Drawing.Size(710, 60);
            grpConnection.TabIndex = 0;
            grpConnection.Text = "Connection";
            grpConnection.Paint += grpConnection_Paint;
            // 
            // lblStatus
            // 
            lblStatus.Appearance.ForeColor = System.Drawing.Color.Red;
            lblStatus.Appearance.Options.UseForeColor = true;
            lblStatus.Location = new System.Drawing.Point(611, 35);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(74, 14);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Disconnected";
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new System.Drawing.Point(515, 28);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new System.Drawing.Size(90, 28);
            btnDisconnect.TabIndex = 5;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // btnConnect
            // 
            btnConnect.Location = new System.Drawing.Point(408, 28);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new System.Drawing.Size(90, 28);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "Connect";
            btnConnect.Click += btnConnect_Click;
            // 
            // txtPort
            // 
            txtPort.EditValue = "5025";
            txtPort.Location = new System.Drawing.Point(259, 29);
            txtPort.Name = "txtPort";
            txtPort.Size = new System.Drawing.Size(120, 20);
            txtPort.TabIndex = 3;
            // 
            // lblPort
            // 
            lblPort.Location = new System.Drawing.Point(230, 35);
            lblPort.Name = "lblPort";
            lblPort.Size = new System.Drawing.Size(23, 14);
            lblPort.TabIndex = 2;
            lblPort.Text = "Port";
            // 
            // txtIp
            // 
            txtIp.EditValue = "192.168.29.2";
            txtIp.Location = new System.Drawing.Point(83, 29);
            txtIp.Name = "txtIp";
            txtIp.Size = new System.Drawing.Size(120, 20);
            txtIp.TabIndex = 1;
            // 
            // lblIP
            // 
            lblIP.Location = new System.Drawing.Point(19, 35);
            lblIP.Name = "lblIP";
            lblIP.Size = new System.Drawing.Size(58, 14);
            lblIP.TabIndex = 0;
            lblIP.Text = "IP Address";
            // 
            // grpChannel
            // 
            grpChannel.Controls.Add(rgChannel);
            grpChannel.Location = new System.Drawing.Point(12, 78);
            grpChannel.Name = "grpChannel";
            grpChannel.Size = new System.Drawing.Size(710, 57);
            grpChannel.TabIndex = 7;
            grpChannel.Text = "channel Select";
            // 
            // rgChannel
            // 
            rgChannel.Location = new System.Drawing.Point(5, 25);
            rgChannel.Name = "rgChannel";
            rgChannel.Properties.Columns = 4;
            rgChannel.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] { new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "CH1", true, null, ""), new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "CH2"), new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "CH3"), new DevExpress.XtraEditors.Controls.RadioGroupItem(4, "CH4") });
            rgChannel.Size = new System.Drawing.Size(400, 25);
            rgChannel.TabIndex = 0;
            // 
            // GrpVoltageControl
            // 
            GrpVoltageControl.Controls.Add(btnReadCurr);
            GrpVoltageControl.Controls.Add(btnSetCurr);
            GrpVoltageControl.Controls.Add(btnReadVolt);
            GrpVoltageControl.Controls.Add(btnSetVolt);
            GrpVoltageControl.Controls.Add(lvlCurrUnit);
            GrpVoltageControl.Controls.Add(lblVoltUnit);
            GrpVoltageControl.Controls.Add(txtSetCurr);
            GrpVoltageControl.Controls.Add(txtSetVolt);
            GrpVoltageControl.Controls.Add(lblSetCurr);
            GrpVoltageControl.Controls.Add(lblSetVolt);
            GrpVoltageControl.Location = new System.Drawing.Point(12, 141);
            GrpVoltageControl.Name = "GrpVoltageControl";
            GrpVoltageControl.Size = new System.Drawing.Size(710, 86);
            GrpVoltageControl.TabIndex = 1;
            GrpVoltageControl.Text = "Voltage/Current Control";
            // 
            // btnReadCurr
            // 
            btnReadCurr.Location = new System.Drawing.Point(296, 60);
            btnReadCurr.Name = "btnReadCurr";
            btnReadCurr.Size = new System.Drawing.Size(75, 23);
            btnReadCurr.TabIndex = 9;
            btnReadCurr.Text = "Read";
            // 
            // btnSetCurr
            // 
            btnSetCurr.Location = new System.Drawing.Point(215, 60);
            btnSetCurr.Name = "btnSetCurr";
            btnSetCurr.Size = new System.Drawing.Size(75, 23);
            btnSetCurr.TabIndex = 8;
            btnSetCurr.Text = "Set";
            // 
            // btnReadVolt
            // 
            btnReadVolt.Location = new System.Drawing.Point(296, 30);
            btnReadVolt.Name = "btnReadVolt";
            btnReadVolt.Size = new System.Drawing.Size(75, 23);
            btnReadVolt.TabIndex = 7;
            btnReadVolt.Text = "Read";
            // 
            // btnSetVolt
            // 
            btnSetVolt.Location = new System.Drawing.Point(215, 30);
            btnSetVolt.Name = "btnSetVolt";
            btnSetVolt.Size = new System.Drawing.Size(75, 23);
            btnSetVolt.TabIndex = 6;
            btnSetVolt.Text = "Set";
            // 
            // lvlCurrUnit
            // 
            lvlCurrUnit.Location = new System.Drawing.Point(189, 64);
            lvlCurrUnit.Name = "lvlCurrUnit";
            lvlCurrUnit.Size = new System.Drawing.Size(8, 14);
            lvlCurrUnit.TabIndex = 5;
            lvlCurrUnit.Text = "A";
            // 
            // lblVoltUnit
            // 
            lblVoltUnit.Location = new System.Drawing.Point(189, 34);
            lblVoltUnit.Name = "lblVoltUnit";
            lblVoltUnit.Size = new System.Drawing.Size(8, 14);
            lblVoltUnit.TabIndex = 4;
            lblVoltUnit.Text = "V";
            // 
            // txtSetCurr
            // 
            txtSetCurr.EditValue = "0.000";
            txtSetCurr.Location = new System.Drawing.Point(83, 61);
            txtSetCurr.Name = "txtSetCurr";
            txtSetCurr.Size = new System.Drawing.Size(100, 20);
            txtSetCurr.TabIndex = 3;
            // 
            // txtSetVolt
            // 
            txtSetVolt.EditValue = "0.000";
            txtSetVolt.Location = new System.Drawing.Point(83, 31);
            txtSetVolt.Name = "txtSetVolt";
            txtSetVolt.Size = new System.Drawing.Size(100, 20);
            txtSetVolt.TabIndex = 2;
            // 
            // lblSetCurr
            // 
            lblSetCurr.Location = new System.Drawing.Point(19, 67);
            lblSetCurr.Name = "lblSetCurr";
            lblSetCurr.Size = new System.Drawing.Size(41, 14);
            lblSetCurr.TabIndex = 1;
            lblSetCurr.Text = "Current";
            // 
            // lblSetVolt
            // 
            lblSetVolt.Location = new System.Drawing.Point(19, 37);
            lblSetVolt.Name = "lblSetVolt";
            lblSetVolt.Size = new System.Drawing.Size(42, 14);
            lblSetVolt.TabIndex = 0;
            lblSetVolt.Text = "Voltage";
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
            grpSafetyLimit.Location = new System.Drawing.Point(12, 233);
            grpSafetyLimit.Name = "grpSafetyLimit";
            grpSafetyLimit.Size = new System.Drawing.Size(710, 135);
            grpSafetyLimit.TabIndex = 10;
            grpSafetyLimit.Text = "safety Limit(Alim)";
            // 
            // lblCurrHigh
            // 
            lblCurrHigh.Location = new System.Drawing.Point(230, 92);
            lblCurrHigh.Name = "lblCurrHigh";
            lblCurrHigh.Size = new System.Drawing.Size(32, 14);
            lblCurrHigh.TabIndex = 14;
            lblCurrHigh.Text = "I High";
            // 
            // lblVoltHigh
            // 
            lblVoltHigh.Location = new System.Drawing.Point(229, 65);
            lblVoltHigh.Name = "lblVoltHigh";
            lblVoltHigh.Size = new System.Drawing.Size(36, 14);
            lblVoltHigh.TabIndex = 13;
            lblVoltHigh.Text = "V High";
            // 
            // btnReadLimit
            // 
            btnReadLimit.Location = new System.Drawing.Point(611, 74);
            btnReadLimit.Name = "btnReadLimit";
            btnReadLimit.Size = new System.Drawing.Size(75, 23);
            btnReadLimit.TabIndex = 12;
            btnReadLimit.Text = "Read";
            // 
            // btnApplyLimit
            // 
            btnApplyLimit.Location = new System.Drawing.Point(530, 74);
            btnApplyLimit.Name = "btnApplyLimit";
            btnApplyLimit.Size = new System.Drawing.Size(75, 23);
            btnApplyLimit.TabIndex = 11;
            btnApplyLimit.Text = "Apply";
            // 
            // txtCurrHigh
            // 
            txtCurrHigh.EditValue = "20.010";
            txtCurrHigh.Location = new System.Drawing.Point(305, 89);
            txtCurrHigh.Name = "txtCurrHigh";
            txtCurrHigh.Size = new System.Drawing.Size(100, 20);
            txtCurrHigh.TabIndex = 10;
            // 
            // txtCurrLow
            // 
            txtCurrLow.Location = new System.Drawing.Point(95, 91);
            txtCurrLow.Name = "txtCurrLow";
            txtCurrLow.Size = new System.Drawing.Size(100, 20);
            txtCurrLow.TabIndex = 9;
            // 
            // txtVoltHigh
            // 
            txtVoltHigh.EditValue = "32.050";
            txtVoltHigh.Location = new System.Drawing.Point(305, 59);
            txtVoltHigh.Name = "txtVoltHigh";
            txtVoltHigh.Size = new System.Drawing.Size(100, 20);
            txtVoltHigh.TabIndex = 8;
            // 
            // txtVoltLow
            // 
            txtVoltLow.EditValue = "0.000";
            txtVoltLow.Location = new System.Drawing.Point(97, 59);
            txtVoltLow.Name = "txtVoltLow";
            txtVoltLow.Size = new System.Drawing.Size(100, 20);
            txtVoltLow.TabIndex = 7;
            // 
            // lblVurrHighUnit
            // 
            lblVurrHighUnit.Location = new System.Drawing.Point(428, 92);
            lblVurrHighUnit.Name = "lblVurrHighUnit";
            lblVurrHighUnit.Size = new System.Drawing.Size(8, 14);
            lblVurrHighUnit.TabIndex = 6;
            lblVurrHighUnit.Text = "A";
            // 
            // lblVoltHighUnit
            // 
            lblVoltHighUnit.Location = new System.Drawing.Point(428, 62);
            lblVoltHighUnit.Name = "lblVoltHighUnit";
            lblVoltHighUnit.Size = new System.Drawing.Size(8, 14);
            lblVoltHighUnit.TabIndex = 5;
            lblVoltHighUnit.Text = "V";
            // 
            // lblCurrLowUnit
            // 
            lblCurrLowUnit.Location = new System.Drawing.Point(203, 94);
            lblCurrLowUnit.Name = "lblCurrLowUnit";
            lblCurrLowUnit.Size = new System.Drawing.Size(8, 14);
            lblCurrLowUnit.TabIndex = 4;
            lblCurrLowUnit.Text = "A";
            // 
            // lblVoltLowUnit
            // 
            lblVoltLowUnit.Location = new System.Drawing.Point(203, 62);
            lblVoltLowUnit.Name = "lblVoltLowUnit";
            lblVoltLowUnit.Size = new System.Drawing.Size(8, 14);
            lblVoltLowUnit.TabIndex = 3;
            lblVoltLowUnit.Text = "V";
            // 
            // lblCurrLow
            // 
            lblCurrLow.Location = new System.Drawing.Point(23, 92);
            lblCurrLow.Name = "lblCurrLow";
            lblCurrLow.Size = new System.Drawing.Size(31, 14);
            lblCurrLow.TabIndex = 2;
            lblCurrLow.Text = "I Low";
            // 
            // lblVoltLow
            // 
            lblVoltLow.Location = new System.Drawing.Point(19, 62);
            lblVoltLow.Name = "lblVoltLow";
            lblVoltLow.Size = new System.Drawing.Size(35, 14);
            lblVoltLow.TabIndex = 1;
            lblVoltLow.Text = "V Low";
            // 
            // chkAlimEnable
            // 
            chkAlimEnable.Location = new System.Drawing.Point(5, 36);
            chkAlimEnable.Name = "chkAlimEnable";
            chkAlimEnable.Properties.Caption = "Safety Limit Enable";
            chkAlimEnable.Size = new System.Drawing.Size(131, 20);
            chkAlimEnable.TabIndex = 0;
            // 
            // grpMeasure
            // 
            grpMeasure.Controls.Add(chkAutoRefresh);
            grpMeasure.Controls.Add(btnMeasure);
            grpMeasure.Controls.Add(lblMeasCurr);
            grpMeasure.Controls.Add(lblMeasVolt);
            grpMeasure.Controls.Add(lblMeasCurrTitle);
            grpMeasure.Controls.Add(lblMeasVoltTitle);
            grpMeasure.Location = new System.Drawing.Point(12, 384);
            grpMeasure.Name = "grpMeasure";
            grpMeasure.Size = new System.Drawing.Size(710, 100);
            grpMeasure.TabIndex = 11;
            grpMeasure.Text = "Measure(전압/전류 측정)";
            // 
            // chkAutoRefresh
            // 
            chkAutoRefresh.Location = new System.Drawing.Point(408, 67);
            chkAutoRefresh.Name = "chkAutoRefresh";
            chkAutoRefresh.Properties.Caption = "Auto Refresh";
            chkAutoRefresh.Size = new System.Drawing.Size(118, 20);
            chkAutoRefresh.TabIndex = 5;
            // 
            // btnMeasure
            // 
            btnMeasure.Location = new System.Drawing.Point(408, 33);
            btnMeasure.Name = "btnMeasure";
            btnMeasure.Size = new System.Drawing.Size(90, 28);
            btnMeasure.TabIndex = 4;
            btnMeasure.Text = "Measure";
            // 
            // lblMeasCurr
            // 
            lblMeasCurr.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            lblMeasCurr.Appearance.ForeColor = System.Drawing.Color.FromArgb(255, 128, 0);
            lblMeasCurr.Appearance.Options.UseFont = true;
            lblMeasCurr.Appearance.Options.UseForeColor = true;
            lblMeasCurr.Location = new System.Drawing.Point(141, 66);
            lblMeasCurr.Name = "lblMeasCurr";
            lblMeasCurr.Size = new System.Drawing.Size(107, 29);
            lblMeasCurr.TabIndex = 3;
            lblMeasCurr.Text = "0.0000 A";
            // 
            // lblMeasVolt
            // 
            lblMeasVolt.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            lblMeasVolt.Appearance.ForeColor = System.Drawing.Color.Blue;
            lblMeasVolt.Appearance.Options.UseFont = true;
            lblMeasVolt.Appearance.Options.UseForeColor = true;
            lblMeasVolt.Location = new System.Drawing.Point(141, 27);
            lblMeasVolt.Name = "lblMeasVolt";
            lblMeasVolt.Size = new System.Drawing.Size(98, 29);
            lblMeasVolt.TabIndex = 2;
            lblMeasVolt.Text = "0.000 V";
            // 
            // lblMeasCurrTitle
            // 
            lblMeasCurrTitle.Location = new System.Drawing.Point(19, 78);
            lblMeasCurrTitle.Name = "lblMeasCurrTitle";
            lblMeasCurrTitle.Size = new System.Drawing.Size(40, 14);
            lblMeasCurrTitle.TabIndex = 1;
            lblMeasCurrTitle.Text = "current";
            // 
            // lblMeasVoltTitle
            // 
            lblMeasVoltTitle.Location = new System.Drawing.Point(19, 39);
            lblMeasVoltTitle.Name = "lblMeasVoltTitle";
            lblMeasVoltTitle.Size = new System.Drawing.Size(42, 14);
            lblMeasVoltTitle.TabIndex = 0;
            lblMeasVoltTitle.Text = "Voltage";
            // 
            // grpOutput
            // 
            grpOutput.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            grpOutput.AppearanceCaption.Options.UseFont = true;
            grpOutput.Controls.Add(simpleButton2);
            grpOutput.Controls.Add(btnOutputOn);
            grpOutput.Location = new System.Drawing.Point(12, 490);
            grpOutput.Name = "grpOutput";
            grpOutput.Size = new System.Drawing.Size(710, 90);
            grpOutput.TabIndex = 6;
            grpOutput.Text = "Output Control";
            // 
            // simpleButton2
            // 
            simpleButton2.Appearance.BackColor = System.Drawing.Color.Red;
            simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            simpleButton2.Appearance.Options.UseBackColor = true;
            simpleButton2.Appearance.Options.UseFont = true;
            simpleButton2.Location = new System.Drawing.Point(345, 39);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new System.Drawing.Size(120, 30);
            simpleButton2.TabIndex = 1;
            simpleButton2.Text = "OUTPUT OFF";
            // 
            // btnOutputOn
            // 
            btnOutputOn.Appearance.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            btnOutputOn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnOutputOn.Appearance.Options.UseBackColor = true;
            btnOutputOn.Appearance.Options.UseFont = true;
            btnOutputOn.Location = new System.Drawing.Point(189, 39);
            btnOutputOn.Name = "btnOutputOn";
            btnOutputOn.Size = new System.Drawing.Size(120, 30);
            btnOutputOn.TabIndex = 0;
            btnOutputOn.Text = "OUTPUT ON";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(748, 602);
            Controls.Add(grpOutput);
            Controls.Add(grpMeasure);
            Controls.Add(grpSafetyLimit);
            Controls.Add(GrpVoltageControl);
            Controls.Add(grpChannel);
            Controls.Add(grpConnection);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "NGP814 Remote Control";
            ((System.ComponentModel.ISupportInitialize)grpConnection).EndInit();
            grpConnection.ResumeLayout(false);
            grpConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPort.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtIp.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)grpChannel).EndInit();
            grpChannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rgChannel.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)GrpVoltageControl).EndInit();
            GrpVoltageControl.ResumeLayout(false);
            GrpVoltageControl.PerformLayout();
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
        private DevExpress.XtraEditors.GroupControl GrpVoltageControl;
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
    }
}

