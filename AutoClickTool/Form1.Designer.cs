namespace AutoClickTool
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
            this.BtnScreenShot = new System.Windows.Forms.Button();
            this.txtPoint1 = new System.Windows.Forms.TextBox();
            this.txtPoint2 = new System.Windows.Forms.TextBox();
            this.txtClickPoint1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSetClick = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtActionTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblActions = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAction = new System.Windows.Forms.TabPage();
            this.lblSaveError = new System.Windows.Forms.Label();
            this.tabActionList = new System.Windows.Forms.TabPage();
            this.btnOpenAction = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.listBoxActions = new System.Windows.Forms.ListBox();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.lblThrottleWait = new System.Windows.Forms.Label();
            this.txtThrottleWait = new System.Windows.Forms.TextBox();
            this.lblThrottle = new System.Windows.Forms.Label();
            this.txtThrottle = new System.Windows.Forms.TextBox();
            this.chkboxRandom = new System.Windows.Forms.CheckBox();
            this.lblConfigError = new System.Windows.Forms.Label();
            this.txtConfigFile = new System.Windows.Forms.TextBox();
            this.lblSaveLoc = new System.Windows.Forms.Label();
            this.txtSSLoc = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.lblConfigName = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.lblInterval = new System.Windows.Forms.Label();
            this.backgroundLoopWorker = new System.ComponentModel.BackgroundWorker();
            this.lblTechaholica = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabAction.SuspendLayout();
            this.tabActionList.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnScreenShot
            // 
            this.BtnScreenShot.Location = new System.Drawing.Point(11, 79);
            this.BtnScreenShot.Name = "BtnScreenShot";
            this.BtnScreenShot.Size = new System.Drawing.Size(75, 23);
            this.BtnScreenShot.TabIndex = 1;
            this.BtnScreenShot.Text = "Screen Shot";
            this.BtnScreenShot.UseVisualStyleBackColor = true;
            this.BtnScreenShot.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPoint1
            // 
            this.txtPoint1.Location = new System.Drawing.Point(107, 79);
            this.txtPoint1.Name = "txtPoint1";
            this.txtPoint1.ReadOnly = true;
            this.txtPoint1.Size = new System.Drawing.Size(100, 20);
            this.txtPoint1.TabIndex = 2;
            // 
            // txtPoint2
            // 
            this.txtPoint2.Location = new System.Drawing.Point(219, 79);
            this.txtPoint2.Name = "txtPoint2";
            this.txtPoint2.ReadOnly = true;
            this.txtPoint2.Size = new System.Drawing.Size(100, 20);
            this.txtPoint2.TabIndex = 4;
            // 
            // txtClickPoint1
            // 
            this.txtClickPoint1.Location = new System.Drawing.Point(107, 308);
            this.txtClickPoint1.Name = "txtClickPoint1";
            this.txtClickPoint1.ReadOnly = true;
            this.txtClickPoint1.Size = new System.Drawing.Size(100, 20);
            this.txtClickPoint1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 157);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnSetClick
            // 
            this.btnSetClick.Location = new System.Drawing.Point(11, 306);
            this.btnSetClick.Name = "btnSetClick";
            this.btnSetClick.Size = new System.Drawing.Size(75, 23);
            this.btnSetClick.TabIndex = 10;
            this.btnSetClick.Text = "Set Click";
            this.btnSetClick.UseVisualStyleBackColor = true;
            this.btnSetClick.Click += new System.EventHandler(this.btnSetClick_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(8, 118);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 11;
            this.lblMessage.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtActionTitle
            // 
            this.txtActionTitle.Location = new System.Drawing.Point(44, 34);
            this.txtActionTitle.Name = "txtActionTitle";
            this.txtActionTitle.Size = new System.Drawing.Size(275, 20);
            this.txtActionTitle.TabIndex = 13;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(8, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Title:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(11, 355);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblActions
            // 
            this.lblActions.AutoSize = true;
            this.lblActions.Location = new System.Drawing.Point(11, 19);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(42, 13);
            this.lblActions.TabIndex = 16;
            this.lblActions.Text = "Actions";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAction);
            this.tabControl1.Controls.Add(this.tabActionList);
            this.tabControl1.Controls.Add(this.tabConfig);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(344, 426);
            this.tabControl1.TabIndex = 17;
            // 
            // tabAction
            // 
            this.tabAction.Controls.Add(this.lblMessage);
            this.tabAction.Controls.Add(this.lblSaveError);
            this.tabAction.Controls.Add(this.lblTitle);
            this.tabAction.Controls.Add(this.txtActionTitle);
            this.tabAction.Controls.Add(this.btnSave);
            this.tabAction.Controls.Add(this.BtnScreenShot);
            this.tabAction.Controls.Add(this.txtPoint1);
            this.tabAction.Controls.Add(this.txtPoint2);
            this.tabAction.Controls.Add(this.txtClickPoint1);
            this.tabAction.Controls.Add(this.btnSetClick);
            this.tabAction.Controls.Add(this.pictureBox1);
            this.tabAction.Location = new System.Drawing.Point(4, 22);
            this.tabAction.Name = "tabAction";
            this.tabAction.Padding = new System.Windows.Forms.Padding(3);
            this.tabAction.Size = new System.Drawing.Size(336, 400);
            this.tabAction.TabIndex = 0;
            this.tabAction.Text = "Action";
            this.tabAction.UseVisualStyleBackColor = true;
            // 
            // lblSaveError
            // 
            this.lblSaveError.AutoSize = true;
            this.lblSaveError.Location = new System.Drawing.Point(104, 362);
            this.lblSaveError.Name = "lblSaveError";
            this.lblSaveError.Size = new System.Drawing.Size(0, 13);
            this.lblSaveError.TabIndex = 16;
            // 
            // tabActionList
            // 
            this.tabActionList.Controls.Add(this.btnOpenAction);
            this.tabActionList.Controls.Add(this.btnDown);
            this.tabActionList.Controls.Add(this.btnUp);
            this.tabActionList.Controls.Add(this.btnRemove);
            this.tabActionList.Controls.Add(this.listBoxActions);
            this.tabActionList.Controls.Add(this.lblActions);
            this.tabActionList.Location = new System.Drawing.Point(4, 22);
            this.tabActionList.Name = "tabActionList";
            this.tabActionList.Padding = new System.Windows.Forms.Padding(3);
            this.tabActionList.Size = new System.Drawing.Size(336, 400);
            this.tabActionList.TabIndex = 1;
            this.tabActionList.Text = "Action List";
            this.tabActionList.UseVisualStyleBackColor = true;
            // 
            // btnOpenAction
            // 
            this.btnOpenAction.Location = new System.Drawing.Point(256, 140);
            this.btnOpenAction.Name = "btnOpenAction";
            this.btnOpenAction.Size = new System.Drawing.Size(75, 23);
            this.btnOpenAction.TabIndex = 21;
            this.btnOpenAction.Text = "Edit";
            this.btnOpenAction.UseVisualStyleBackColor = true;
            this.btnOpenAction.Click += new System.EventHandler(this.btnOpenAction_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(256, 64);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 20;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(256, 35);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 19;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(256, 169);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // listBoxActions
            // 
            this.listBoxActions.FormattingEnabled = true;
            this.listBoxActions.Location = new System.Drawing.Point(11, 35);
            this.listBoxActions.Name = "listBoxActions";
            this.listBoxActions.Size = new System.Drawing.Size(229, 355);
            this.listBoxActions.TabIndex = 17;
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.lblThrottleWait);
            this.tabConfig.Controls.Add(this.txtThrottleWait);
            this.tabConfig.Controls.Add(this.lblThrottle);
            this.tabConfig.Controls.Add(this.txtThrottle);
            this.tabConfig.Controls.Add(this.chkboxRandom);
            this.tabConfig.Controls.Add(this.lblConfigError);
            this.tabConfig.Controls.Add(this.txtConfigFile);
            this.tabConfig.Controls.Add(this.lblSaveLoc);
            this.tabConfig.Controls.Add(this.txtSSLoc);
            this.tabConfig.Controls.Add(this.lblStatus);
            this.tabConfig.Controls.Add(this.btnStop);
            this.tabConfig.Controls.Add(this.btnStart);
            this.tabConfig.Controls.Add(this.btnSaveConfig);
            this.tabConfig.Controls.Add(this.lblConfigName);
            this.tabConfig.Controls.Add(this.btnLoad);
            this.tabConfig.Controls.Add(this.txtInterval);
            this.tabConfig.Controls.Add(this.lblInterval);
            this.tabConfig.Location = new System.Drawing.Point(4, 22);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(336, 400);
            this.tabConfig.TabIndex = 2;
            this.tabConfig.Text = "Config";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // lblThrottleWait
            // 
            this.lblThrottleWait.AutoSize = true;
            this.lblThrottleWait.Location = new System.Drawing.Point(126, 133);
            this.lblThrottleWait.Name = "lblThrottleWait";
            this.lblThrottleWait.Size = new System.Drawing.Size(124, 13);
            this.lblThrottleWait.TabIndex = 18;
            this.lblThrottleWait.Text = "Throttle wait time? (secs)";
            // 
            // txtThrottleWait
            // 
            this.txtThrottleWait.Location = new System.Drawing.Point(129, 149);
            this.txtThrottleWait.Name = "txtThrottleWait";
            this.txtThrottleWait.Size = new System.Drawing.Size(100, 20);
            this.txtThrottleWait.TabIndex = 17;
            this.txtThrottleWait.Text = "1800";
            // 
            // lblThrottle
            // 
            this.lblThrottle.AutoSize = true;
            this.lblThrottle.Location = new System.Drawing.Point(5, 134);
            this.lblThrottle.Name = "lblThrottle";
            this.lblThrottle.Size = new System.Drawing.Size(102, 13);
            this.lblThrottle.TabIndex = 16;
            this.lblThrottle.Text = "Throttle time? (secs)";
            // 
            // txtThrottle
            // 
            this.txtThrottle.Location = new System.Drawing.Point(8, 150);
            this.txtThrottle.Name = "txtThrottle";
            this.txtThrottle.Size = new System.Drawing.Size(103, 20);
            this.txtThrottle.TabIndex = 15;
            this.txtThrottle.Text = "0";
            // 
            // chkboxRandom
            // 
            this.chkboxRandom.AutoSize = true;
            this.chkboxRandom.Location = new System.Drawing.Point(129, 107);
            this.chkboxRandom.Name = "chkboxRandom";
            this.chkboxRandom.Size = new System.Drawing.Size(72, 17);
            this.chkboxRandom.TabIndex = 14;
            this.chkboxRandom.Text = "Random?";
            this.chkboxRandom.UseVisualStyleBackColor = true;
            // 
            // lblConfigError
            // 
            this.lblConfigError.AutoSize = true;
            this.lblConfigError.Location = new System.Drawing.Point(14, 229);
            this.lblConfigError.Name = "lblConfigError";
            this.lblConfigError.Size = new System.Drawing.Size(0, 13);
            this.lblConfigError.TabIndex = 13;
            // 
            // txtConfigFile
            // 
            this.txtConfigFile.Location = new System.Drawing.Point(105, 235);
            this.txtConfigFile.Name = "txtConfigFile";
            this.txtConfigFile.Size = new System.Drawing.Size(207, 20);
            this.txtConfigFile.TabIndex = 12;
            this.txtConfigFile.Text = "New Configuration";
            this.txtConfigFile.TextChanged += new System.EventHandler(this.txtConfigFile_TextChanged);
            // 
            // lblSaveLoc
            // 
            this.lblSaveLoc.AutoSize = true;
            this.lblSaveLoc.Location = new System.Drawing.Point(8, 190);
            this.lblSaveLoc.Name = "lblSaveLoc";
            this.lblSaveLoc.Size = new System.Drawing.Size(76, 13);
            this.lblSaveLoc.TabIndex = 9;
            this.lblSaveLoc.Text = "Save Location";
            // 
            // txtSSLoc
            // 
            this.txtSSLoc.Location = new System.Drawing.Point(11, 206);
            this.txtSSLoc.Name = "txtSSLoc";
            this.txtSSLoc.Size = new System.Drawing.Size(301, 20);
            this.txtSSLoc.TabIndex = 8;
            this.txtSSLoc.Text = "C:\\Temp\\";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(11, 303);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Not Started";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(105, 277);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(8, 277);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(8, 235);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(75, 23);
            this.btnSaveConfig.TabIndex = 4;
            this.btnSaveConfig.Text = "Save";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // lblConfigName
            // 
            this.lblConfigName.AutoSize = true;
            this.lblConfigName.Location = new System.Drawing.Point(114, 15);
            this.lblConfigName.Name = "lblConfigName";
            this.lblConfigName.Size = new System.Drawing.Size(94, 13);
            this.lblConfigName.TabIndex = 3;
            this.lblConfigName.Text = "New Configuration";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(8, 48);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(8, 104);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(100, 20);
            this.txtInterval.TabIndex = 1;
            this.txtInterval.Text = "5";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(5, 88);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(99, 13);
            this.lblInterval.TabIndex = 0;
            this.lblInterval.Text = "Interval Time (secs)";
            // 
            // backgroundLoopWorker
            // 
            this.backgroundLoopWorker.WorkerSupportsCancellation = true;
            this.backgroundLoopWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundLoopWorker_DoWork);
            this.backgroundLoopWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundLoopWorker_RunWorkerCompleted);
            // 
            // lblTechaholica
            // 
            this.lblTechaholica.AutoSize = true;
            this.lblTechaholica.Location = new System.Drawing.Point(276, 9);
            this.lblTechaholica.Name = "lblTechaholica";
            this.lblTechaholica.Size = new System.Drawing.Size(80, 13);
            this.lblTechaholica.TabIndex = 18;
            this.lblTechaholica.Text = "by Techaholica";
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(12, 455);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(340, 49);
            this.webBrowser.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 516);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.lblTechaholica);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Auto Click Tool";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabAction.ResumeLayout(false);
            this.tabAction.PerformLayout();
            this.tabActionList.ResumeLayout(false);
            this.tabActionList.PerformLayout();
            this.tabConfig.ResumeLayout(false);
            this.tabConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnScreenShot;
        private System.Windows.Forms.TextBox txtPoint1;
        private System.Windows.Forms.TextBox txtPoint2;
        private System.Windows.Forms.TextBox txtClickPoint1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSetClick;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtActionTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblActions;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAction;
        private System.Windows.Forms.TabPage tabActionList;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox listBoxActions;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Label lblConfigName;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Label lblSaveError;
        private System.Windows.Forms.Button btnOpenAction;
        private System.Windows.Forms.Label lblSaveLoc;
        private System.Windows.Forms.TextBox txtSSLoc;
        private System.Windows.Forms.TextBox txtConfigFile;
        private System.Windows.Forms.Label lblConfigError;
        private System.ComponentModel.BackgroundWorker backgroundLoopWorker;
        private System.Windows.Forms.Label lblTechaholica;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.CheckBox chkboxRandom;
        private System.Windows.Forms.Label lblThrottleWait;
        private System.Windows.Forms.TextBox txtThrottleWait;
        private System.Windows.Forms.Label lblThrottle;
        private System.Windows.Forms.TextBox txtThrottle;
    }
}

