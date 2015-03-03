namespace Menora
{
    partial class TmpChangerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TmpChangerForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.radioUse = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTestDay = new System.Windows.Forms.TrackBar();
            this.radioTestDay = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTestTemp = new System.Windows.Forms.TrackBar();
            this.radioTestTemp = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.cboPreset = new System.Windows.Forms.ComboBox();
            this.btnSaveCode = new System.Windows.Forms.Button();
            this.tmrMinute = new System.Windows.Forms.Timer(this.components);
            this.strpStatus = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctxTrayIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.temperatureChangerV01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTestDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTestTemp)).BeginInit();
            this.strpStatus.SuspendLayout();
            this.ctxTrayIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblTemperature);
            this.groupBox1.Controls.Add(this.lblCurrentTime);
            this.groupBox1.Controls.Add(this.radioUse);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbTestDay);
            this.groupBox1.Controls.Add(this.radioTestDay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbTestTemp);
            this.groupBox1.Controls.Add(this.radioTestTemp);
            this.groupBox1.Location = new System.Drawing.Point(327, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(316, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test && use";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(122, 23);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(38, 13);
            this.lblTemperature.TabIndex = 1;
            this.lblTemperature.Text = "6500K";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Location = new System.Drawing.Point(101, 89);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(34, 13);
            this.lblCurrentTime.TabIndex = 7;
            this.lblCurrentTime.Text = "10:00";
            // 
            // radioUse
            // 
            this.radioUse.AutoSize = true;
            this.radioUse.Location = new System.Drawing.Point(7, 153);
            this.radioUse.Margin = new System.Windows.Forms.Padding(2);
            this.radioUse.Name = "radioUse";
            this.radioUse.Size = new System.Drawing.Size(88, 17);
            this.radioUse.TabIndex = 12;
            this.radioUse.TabStop = true;
            this.radioUse.Text = "Use for today";
            this.radioUse.UseVisualStyleBackColor = true;
            this.radioUse.CheckedChanged += new System.EventHandler(this.radioUse_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "4:00 PM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "4:00 AM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "4:00 AM";
            // 
            // tbTestDay
            // 
            this.tbTestDay.LargeChange = 60;
            this.tbTestDay.Location = new System.Drawing.Point(7, 106);
            this.tbTestDay.Margin = new System.Windows.Forms.Padding(2);
            this.tbTestDay.Maximum = 1440;
            this.tbTestDay.Name = "tbTestDay";
            this.tbTestDay.Size = new System.Drawing.Size(306, 45);
            this.tbTestDay.SmallChange = 5;
            this.tbTestDay.TabIndex = 8;
            this.tbTestDay.TickFrequency = 60;
            this.tbTestDay.Value = 360;
            this.tbTestDay.Scroll += new System.EventHandler(this.dayTrackbar_Scroll);
            // 
            // radioTestDay
            // 
            this.radioTestDay.AutoSize = true;
            this.radioTestDay.Location = new System.Drawing.Point(7, 87);
            this.radioTestDay.Margin = new System.Windows.Forms.Padding(2);
            this.radioTestDay.Name = "radioTestDay";
            this.radioTestDay.Size = new System.Drawing.Size(89, 17);
            this.radioTestDay.TabIndex = 6;
            this.radioTestDay.TabStop = true;
            this.radioTestDay.Text = "Test your day";
            this.radioTestDay.UseVisualStyleBackColor = true;
            this.radioTestDay.CheckedChanged += new System.EventHandler(this.radioTestDay_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "6500K";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "10000K";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "3000K";
            // 
            // tbTestTemp
            // 
            this.tbTestTemp.LargeChange = 500;
            this.tbTestTemp.Location = new System.Drawing.Point(3, 40);
            this.tbTestTemp.Margin = new System.Windows.Forms.Padding(2);
            this.tbTestTemp.Maximum = 10000;
            this.tbTestTemp.Minimum = 3000;
            this.tbTestTemp.Name = "tbTestTemp";
            this.tbTestTemp.Size = new System.Drawing.Size(309, 45);
            this.tbTestTemp.SmallChange = 10;
            this.tbTestTemp.TabIndex = 2;
            this.tbTestTemp.TickFrequency = 500;
            this.tbTestTemp.Value = 6500;
            this.tbTestTemp.Scroll += new System.EventHandler(this.tempTestTrackbar_Scroll);
            // 
            // radioTestTemp
            // 
            this.radioTestTemp.AutoSize = true;
            this.radioTestTemp.Location = new System.Drawing.Point(3, 21);
            this.radioTestTemp.Margin = new System.Windows.Forms.Padding(2);
            this.radioTestTemp.Name = "radioTestTemp";
            this.radioTestTemp.Size = new System.Drawing.Size(114, 17);
            this.radioTestTemp.TabIndex = 0;
            this.radioTestTemp.Text = "Test a temperature";
            this.radioTestTemp.UseVisualStyleBackColor = true;
            this.radioTestTemp.CheckedChanged += new System.EventHandler(this.radioTestTemp_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Apply preset config";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(330, 252);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(314, 30);
            this.label8.TabIndex = 5;
            this.label8.Text = "The tempConfig.json file is loaded automatically on startup.\r\nStart with option /" +
    "Minimize to use this app as a tool.";
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(7, 7);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(308, 278);
            this.txtCode.TabIndex = 4;
            this.txtCode.Leave += new System.EventHandler(this.txtCode_Leave);
            // 
            // cboPreset
            // 
            this.cboPreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPreset.FormattingEnabled = true;
            this.cboPreset.Location = new System.Drawing.Point(430, 196);
            this.cboPreset.Name = "cboPreset";
            this.cboPreset.Size = new System.Drawing.Size(213, 21);
            this.cboPreset.TabIndex = 2;
            this.cboPreset.SelectedIndexChanged += new System.EventHandler(this.cboPreset_SelectedIndexChanged);
            // 
            // btnSaveCode
            // 
            this.btnSaveCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveCode.Location = new System.Drawing.Point(330, 224);
            this.btnSaveCode.Name = "btnSaveCode";
            this.btnSaveCode.Size = new System.Drawing.Size(164, 23);
            this.btnSaveCode.TabIndex = 3;
            this.btnSaveCode.Text = "Save code (tempConfig.json)";
            this.btnSaveCode.UseVisualStyleBackColor = true;
            this.btnSaveCode.Click += new System.EventHandler(this.btnSaveCode_Click);
            // 
            // tmrMinute
            // 
            this.tmrMinute.Interval = 60000;
            this.tmrMinute.Tick += new System.EventHandler(this.tmrMinute_Tick);
            // 
            // strpStatus
            // 
            this.strpStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.strpStatus.Location = new System.Drawing.Point(0, 291);
            this.strpStatus.Name = "strpStatus";
            this.strpStatus.Padding = new System.Windows.Forms.Padding(1, 0, 8, 0);
            this.strpStatus.Size = new System.Drawing.Size(650, 22);
            this.strpStatus.TabIndex = 6;
            this.strpStatus.Text = "Ready";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 17);
            this.lblStatus.Text = "Ready";
            // 
            // ctxTrayIcon
            // 
            this.ctxTrayIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temperatureChangerV01ToolStripMenuItem,
            this.toolStripSeparator1,
            this.settingsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.ctxTrayIcon.Name = "ctxTrayIcon";
            this.ctxTrayIcon.Size = new System.Drawing.Size(212, 76);
            // 
            // temperatureChangerV01ToolStripMenuItem
            // 
            this.temperatureChangerV01ToolStripMenuItem.Enabled = false;
            this.temperatureChangerV01ToolStripMenuItem.Name = "temperatureChangerV01ToolStripMenuItem";
            this.temperatureChangerV01ToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.temperatureChangerV01ToolStripMenuItem.Text = "TemperatureChanger v0.1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(208, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.settingsToolStripMenuItem.Text = "Settings...";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.closeToolStripMenuItem.Text = "Exit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.ctxTrayIcon;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Menora";
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // TmpChangerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 313);
            this.Controls.Add(this.strpStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSaveCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboPreset);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TmpChangerForm";
            this.Text = "Menora - Warm light from your computer screen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TmpChangerForm_FormClosed);
            this.Load += new System.EventHandler(this.TmpChangerForm_Load);
            this.Resize += new System.EventHandler(this.TmpChangerForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTestDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTestTemp)).EndInit();
            this.strpStatus.ResumeLayout(false);
            this.strpStatus.PerformLayout();
            this.ctxTrayIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbTestTemp;
        private System.Windows.Forms.RadioButton radioTestTemp;
        private System.Windows.Forms.RadioButton radioUse;
        private System.Windows.Forms.TrackBar tbTestDay;
        private System.Windows.Forms.RadioButton radioTestDay;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.ComboBox cboPreset;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Button btnSaveCode;
        private System.Windows.Forms.Timer tmrMinute;
        private System.Windows.Forms.StatusStrip strpStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ContextMenuStrip ctxTrayIcon;
        private System.Windows.Forms.ToolStripMenuItem temperatureChangerV01ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;


    }
}

