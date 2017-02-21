namespace WindowsService
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstInfo = new System.Windows.Forms.ListView();
            this.btnClean = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStartMailing = new System.Windows.Forms.Button();
            this.gbMainServ = new System.Windows.Forms.GroupBox();
            this.lblMain3 = new System.Windows.Forms.Label();
            this.lblServStatusMain = new System.Windows.Forms.Label();
            this.lblMain2 = new System.Windows.Forms.Label();
            this.lblMain1 = new System.Windows.Forms.Label();
            this.dispNameMain = new System.Windows.Forms.Label();
            this.lblServNameMain = new System.Windows.Forms.Label();
            this.gbMailingServ = new System.Windows.Forms.GroupBox();
            this.lblMail3 = new System.Windows.Forms.Label();
            this.lblServStatusMail = new System.Windows.Forms.Label();
            this.lblMail2 = new System.Windows.Forms.Label();
            this.dispNameMail = new System.Windows.Forms.Label();
            this.lblMail1 = new System.Windows.Forms.Label();
            this.lblServNameMail = new System.Windows.Forms.Label();
            this.btnStopMailing = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbMainServ.SuspendLayout();
            this.gbMailingServ.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(21, 47);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(121, 35);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START MAIN SERVICE";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Enabled = false;
            this.btnRestart.Location = new System.Drawing.Point(148, 47);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(121, 35);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "RE-START MAIN SERVICE";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(275, 47);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(121, 35);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "STOP MAIN SERVICE";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "WINDOWS SERVICE ACTIONS";
            // 
            // lstInfo
            // 
            this.lstInfo.Location = new System.Drawing.Point(21, 88);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(788, 253);
            this.lstInfo.TabIndex = 4;
            this.lstInfo.UseCompatibleStateImageBehavior = false;
            this.lstInfo.View = System.Windows.Forms.View.List;
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(721, 347);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(88, 42);
            this.btnClean.TabIndex = 5;
            this.btnClean.Text = "CLEAN INFO";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(721, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "FILE DELETE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStartMailing
            // 
            this.btnStartMailing.Enabled = false;
            this.btnStartMailing.Location = new System.Drawing.Point(599, 47);
            this.btnStartMailing.Name = "btnStartMailing";
            this.btnStartMailing.Size = new System.Drawing.Size(102, 35);
            this.btnStartMailing.TabIndex = 8;
            this.btnStartMailing.Text = "START MAILING";
            this.btnStartMailing.UseVisualStyleBackColor = true;
            this.btnStartMailing.Click += new System.EventHandler(this.btnStartMailing_Click);
            // 
            // gbMainServ
            // 
            this.gbMainServ.Controls.Add(this.lblMain3);
            this.gbMainServ.Controls.Add(this.lblServStatusMain);
            this.gbMainServ.Controls.Add(this.lblMain2);
            this.gbMainServ.Controls.Add(this.lblMain1);
            this.gbMainServ.Controls.Add(this.dispNameMain);
            this.gbMainServ.Controls.Add(this.lblServNameMain);
            this.gbMainServ.Location = new System.Drawing.Point(21, 347);
            this.gbMainServ.Name = "gbMainServ";
            this.gbMainServ.Size = new System.Drawing.Size(338, 92);
            this.gbMainServ.TabIndex = 9;
            this.gbMainServ.TabStop = false;
            this.gbMainServ.Text = "Main Service";
            // 
            // lblMain3
            // 
            this.lblMain3.AutoSize = true;
            this.lblMain3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain3.Location = new System.Drawing.Point(71, 70);
            this.lblMain3.Name = "lblMain3";
            this.lblMain3.Size = new System.Drawing.Size(55, 15);
            this.lblMain3.TabIndex = 9;
            this.lblMain3.Text = "[Status]";
            this.lblMain3.Visible = false;
            // 
            // lblServStatusMain
            // 
            this.lblServStatusMain.AutoSize = true;
            this.lblServStatusMain.Location = new System.Drawing.Point(6, 70);
            this.lblServStatusMain.Name = "lblServStatusMain";
            this.lblServStatusMain.Size = new System.Drawing.Size(68, 13);
            this.lblServStatusMain.TabIndex = 8;
            this.lblServStatusMain.Text = "Serv. Status:";
            // 
            // lblMain2
            // 
            this.lblMain2.AutoSize = true;
            this.lblMain2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain2.Location = new System.Drawing.Point(71, 47);
            this.lblMain2.Name = "lblMain2";
            this.lblMain2.Size = new System.Drawing.Size(104, 15);
            this.lblMain2.TabIndex = 3;
            this.lblMain2.Text = "[Service Name]";
            this.lblMain2.Visible = false;
            // 
            // lblMain1
            // 
            this.lblMain1.AutoSize = true;
            this.lblMain1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain1.Location = new System.Drawing.Point(71, 23);
            this.lblMain1.Name = "lblMain1";
            this.lblMain1.Size = new System.Drawing.Size(104, 15);
            this.lblMain1.TabIndex = 2;
            this.lblMain1.Text = "[Service Name]";
            this.lblMain1.Visible = false;
            // 
            // dispNameMain
            // 
            this.dispNameMain.AutoSize = true;
            this.dispNameMain.Location = new System.Drawing.Point(6, 47);
            this.dispNameMain.Name = "dispNameMain";
            this.dispNameMain.Size = new System.Drawing.Size(67, 13);
            this.dispNameMain.TabIndex = 1;
            this.dispNameMain.Text = "Displ. Name:";
            // 
            // lblServNameMain
            // 
            this.lblServNameMain.AutoSize = true;
            this.lblServNameMain.Location = new System.Drawing.Point(7, 23);
            this.lblServNameMain.Name = "lblServNameMain";
            this.lblServNameMain.Size = new System.Drawing.Size(66, 13);
            this.lblServNameMain.TabIndex = 0;
            this.lblServNameMain.Text = "Serv. Name:";
            // 
            // gbMailingServ
            // 
            this.gbMailingServ.Controls.Add(this.lblMail3);
            this.gbMailingServ.Controls.Add(this.lblServStatusMail);
            this.gbMailingServ.Controls.Add(this.lblMail2);
            this.gbMailingServ.Controls.Add(this.dispNameMail);
            this.gbMailingServ.Controls.Add(this.lblMail1);
            this.gbMailingServ.Controls.Add(this.lblServNameMail);
            this.gbMailingServ.Location = new System.Drawing.Point(377, 347);
            this.gbMailingServ.Name = "gbMailingServ";
            this.gbMailingServ.Size = new System.Drawing.Size(338, 92);
            this.gbMailingServ.TabIndex = 10;
            this.gbMailingServ.TabStop = false;
            this.gbMailingServ.Text = "Mailing Service";
            // 
            // lblMail3
            // 
            this.lblMail3.AutoSize = true;
            this.lblMail3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail3.Location = new System.Drawing.Point(71, 68);
            this.lblMail3.Name = "lblMail3";
            this.lblMail3.Size = new System.Drawing.Size(55, 15);
            this.lblMail3.TabIndex = 7;
            this.lblMail3.Text = "[Status]";
            this.lblMail3.Visible = false;
            // 
            // lblServStatusMail
            // 
            this.lblServStatusMail.AutoSize = true;
            this.lblServStatusMail.Location = new System.Drawing.Point(6, 70);
            this.lblServStatusMail.Name = "lblServStatusMail";
            this.lblServStatusMail.Size = new System.Drawing.Size(68, 13);
            this.lblServStatusMail.TabIndex = 6;
            this.lblServStatusMail.Text = "Serv. Status:";
            // 
            // lblMail2
            // 
            this.lblMail2.AutoSize = true;
            this.lblMail2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail2.Location = new System.Drawing.Point(71, 45);
            this.lblMail2.Name = "lblMail2";
            this.lblMail2.Size = new System.Drawing.Size(104, 15);
            this.lblMail2.TabIndex = 5;
            this.lblMail2.Text = "[Service Name]";
            this.lblMail2.Visible = false;
            // 
            // dispNameMail
            // 
            this.dispNameMail.AutoSize = true;
            this.dispNameMail.Location = new System.Drawing.Point(6, 47);
            this.dispNameMail.Name = "dispNameMail";
            this.dispNameMail.Size = new System.Drawing.Size(67, 13);
            this.dispNameMail.TabIndex = 3;
            this.dispNameMail.Text = "Displ. Name:";
            // 
            // lblMail1
            // 
            this.lblMail1.AutoSize = true;
            this.lblMail1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail1.Location = new System.Drawing.Point(70, 21);
            this.lblMail1.Name = "lblMail1";
            this.lblMail1.Size = new System.Drawing.Size(104, 15);
            this.lblMail1.TabIndex = 4;
            this.lblMail1.Text = "[Service Name]";
            this.lblMail1.Visible = false;
            // 
            // lblServNameMail
            // 
            this.lblServNameMail.AutoSize = true;
            this.lblServNameMail.Location = new System.Drawing.Point(6, 23);
            this.lblServNameMail.Name = "lblServNameMail";
            this.lblServNameMail.Size = new System.Drawing.Size(66, 13);
            this.lblServNameMail.TabIndex = 2;
            this.lblServNameMail.Text = "Serv. Name:";
            // 
            // btnStopMailing
            // 
            this.btnStopMailing.Enabled = false;
            this.btnStopMailing.Location = new System.Drawing.Point(707, 47);
            this.btnStopMailing.Name = "btnStopMailing";
            this.btnStopMailing.Size = new System.Drawing.Size(102, 35);
            this.btnStopMailing.TabIndex = 11;
            this.btnStopMailing.Text = "STOP MAILING";
            this.btnStopMailing.UseVisualStyleBackColor = true;
            this.btnStopMailing.Click += new System.EventHandler(this.btnStopMailing_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(445, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "START SKYPE CHAT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 451);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnStopMailing);
            this.Controls.Add(this.gbMailingServ);
            this.Controls.Add(this.gbMainServ);
            this.Controls.Add(this.btnStartMailing);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.lstInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbMainServ.ResumeLayout(false);
            this.gbMainServ.PerformLayout();
            this.gbMailingServ.ResumeLayout(false);
            this.gbMailingServ.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstInfo;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStartMailing;
        private System.Windows.Forms.GroupBox gbMainServ;
        private System.Windows.Forms.Label dispNameMain;
        private System.Windows.Forms.Label lblServNameMain;
        private System.Windows.Forms.GroupBox gbMailingServ;
        private System.Windows.Forms.Label dispNameMail;
        private System.Windows.Forms.Label lblServNameMail;
        private System.Windows.Forms.Label lblMain2;
        private System.Windows.Forms.Label lblMain1;
        private System.Windows.Forms.Label lblMail2;
        private System.Windows.Forms.Label lblMail1;
        private System.Windows.Forms.Label lblMail3;
        private System.Windows.Forms.Label lblServStatusMail;
        private System.Windows.Forms.Label lblMain3;
        private System.Windows.Forms.Label lblServStatusMain;
        private System.Windows.Forms.Button btnStopMailing;
        private System.Windows.Forms.Button button2;
    }
}

