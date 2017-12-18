namespace JsonServicesTester
{
    partial class FormJsonServiceTester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJsonServiceTester));
            this.buttonGetJsonRequest = new System.Windows.Forms.Button();
            this.textBoxJsonFileName = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageReguest = new System.Windows.Forms.TabPage();
            this.textBoxReguest = new System.Windows.Forms.TextBox();
            this.tabPageResponce = new System.Windows.Forms.TabPage();
            this.textBoxResponce = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxCurrent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxBaseAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxWait = new System.Windows.Forms.PictureBox();
            this.textBoxAddressLink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSendRequest = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.checkBoxAuthorization = new System.Windows.Forms.CheckBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPageReguest.SuspendLayout();
            this.tabPageResponce.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWait)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGetJsonRequest
            // 
            this.buttonGetJsonRequest.Location = new System.Drawing.Point(144, 11);
            this.buttonGetJsonRequest.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.buttonGetJsonRequest.Name = "buttonGetJsonRequest";
            this.buttonGetJsonRequest.Size = new System.Drawing.Size(121, 23);
            this.buttonGetJsonRequest.TabIndex = 0;
            this.buttonGetJsonRequest.Text = "Get Request From File";
            this.buttonGetJsonRequest.UseVisualStyleBackColor = true;
            this.buttonGetJsonRequest.Click += new System.EventHandler(this.buttonGetJsonRequest_Click);
            // 
            // textBoxJsonFileName
            // 
            this.textBoxJsonFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxJsonFileName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJsonFileName.Location = new System.Drawing.Point(285, 10);
            this.textBoxJsonFileName.Name = "textBoxJsonFileName";
            this.textBoxJsonFileName.Size = new System.Drawing.Size(477, 24);
            this.textBoxJsonFileName.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageReguest);
            this.tabControl.Controls.Add(this.tabPageResponce);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(786, 300);
            this.tabControl.TabIndex = 3;
            // 
            // tabPageReguest
            // 
            this.tabPageReguest.Controls.Add(this.textBoxReguest);
            this.tabPageReguest.Location = new System.Drawing.Point(4, 22);
            this.tabPageReguest.Name = "tabPageReguest";
            this.tabPageReguest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReguest.Size = new System.Drawing.Size(778, 274);
            this.tabPageReguest.TabIndex = 0;
            this.tabPageReguest.Text = "Reguest";
            this.tabPageReguest.UseVisualStyleBackColor = true;
            // 
            // textBoxReguest
            // 
            this.textBoxReguest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxReguest.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReguest.Location = new System.Drawing.Point(3, 3);
            this.textBoxReguest.Multiline = true;
            this.textBoxReguest.Name = "textBoxReguest";
            this.textBoxReguest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxReguest.Size = new System.Drawing.Size(772, 268);
            this.textBoxReguest.TabIndex = 1;
            // 
            // tabPageResponce
            // 
            this.tabPageResponce.Controls.Add(this.textBoxResponce);
            this.tabPageResponce.Location = new System.Drawing.Point(4, 22);
            this.tabPageResponce.Name = "tabPageResponce";
            this.tabPageResponce.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResponce.Size = new System.Drawing.Size(669, 269);
            this.tabPageResponce.TabIndex = 1;
            this.tabPageResponce.Text = "Response";
            this.tabPageResponce.UseVisualStyleBackColor = true;
            // 
            // textBoxResponce
            // 
            this.textBoxResponce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResponce.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResponce.Location = new System.Drawing.Point(3, 3);
            this.textBoxResponce.Multiline = true;
            this.textBoxResponce.Name = "textBoxResponce";
            this.textBoxResponce.ReadOnly = true;
            this.textBoxResponce.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResponce.Size = new System.Drawing.Size(663, 263);
            this.textBoxResponce.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonGetJsonRequest);
            this.panel1.Controls.Add(this.textBoxJsonFileName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 44);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save Request To File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 406);
            this.panel2.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tabControl);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(786, 300);
            this.panel4.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxPassword);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.textBoxUserName);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.checkBoxAuthorization);
            this.panel3.Controls.Add(this.textBoxCurrent);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBoxCount);
            this.panel3.Controls.Add(this.textBoxBaseAddress);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBoxWait);
            this.panel3.Controls.Add(this.textBoxAddressLink);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.buttonSendRequest);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(786, 106);
            this.panel3.TabIndex = 4;
            // 
            // textBoxCurrent
            // 
            this.textBoxCurrent.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrent.Location = new System.Drawing.Point(156, 75);
            this.textBoxCurrent.Name = "textBoxCurrent";
            this.textBoxCurrent.ReadOnly = true;
            this.textBoxCurrent.Size = new System.Drawing.Size(43, 23);
            this.textBoxCurrent.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stress Test Count";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCount.Location = new System.Drawing.Point(107, 75);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(43, 23);
            this.textBoxCount.TabIndex = 6;
            this.textBoxCount.Text = "1";
            // 
            // textBoxBaseAddress
            // 
            this.textBoxBaseAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBaseAddress.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBaseAddress.Location = new System.Drawing.Point(336, 41);
            this.textBoxBaseAddress.Name = "textBoxBaseAddress";
            this.textBoxBaseAddress.Size = new System.Drawing.Size(438, 23);
            this.textBoxBaseAddress.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Base Address";
            // 
            // pictureBoxWait
            // 
            this.pictureBoxWait.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWait.ErrorImage = null;
            this.pictureBoxWait.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWait.Image")));
            this.pictureBoxWait.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxWait.InitialImage")));
            this.pictureBoxWait.Location = new System.Drawing.Point(205, 50);
            this.pictureBoxWait.Name = "pictureBoxWait";
            this.pictureBoxWait.Size = new System.Drawing.Size(47, 44);
            this.pictureBoxWait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWait.TabIndex = 3;
            this.pictureBoxWait.TabStop = false;
            this.pictureBoxWait.Visible = false;
            // 
            // textBoxAddressLink
            // 
            this.textBoxAddressLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddressLink.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddressLink.Location = new System.Drawing.Point(336, 71);
            this.textBoxAddressLink.Name = "textBoxAddressLink";
            this.textBoxAddressLink.Size = new System.Drawing.Size(438, 23);
            this.textBoxAddressLink.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Service ........";
            // 
            // buttonSendRequest
            // 
            this.buttonSendRequest.Location = new System.Drawing.Point(12, 46);
            this.buttonSendRequest.Name = "buttonSendRequest";
            this.buttonSendRequest.Size = new System.Drawing.Size(187, 23);
            this.buttonSendRequest.TabIndex = 0;
            this.buttonSendRequest.Text = "Send Request";
            this.buttonSendRequest.UseVisualStyleBackColor = true;
            this.buttonSendRequest.Click += new System.EventHandler(this.buttonSendRequest_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // checkBoxAuthorization
            // 
            this.checkBoxAuthorization.AutoSize = true;
            this.checkBoxAuthorization.Location = new System.Drawing.Point(15, 11);
            this.checkBoxAuthorization.Name = "checkBoxAuthorization";
            this.checkBoxAuthorization.Size = new System.Drawing.Size(123, 17);
            this.checkBoxAuthorization.TabIndex = 10;
            this.checkBoxAuthorization.Text = "Basic Authentication";
            this.checkBoxAuthorization.UseVisualStyleBackColor = true;
            this.checkBoxAuthorization.CheckedChanged += new System.EventHandler(this.checkBoxAuthorization_CheckedChanged);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Enabled = false;
            this.textBoxUserName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(205, 10);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(99, 23);
            this.textBoxUserName.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "UserName";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Enabled = false;
            this.textBoxPassword.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(378, 10);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(99, 23);
            this.textBoxPassword.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Password";
            // 
            // FormJsonServiceTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormJsonServiceTester";
            this.Text = "Tester for Json Services";
            this.Load += new System.EventHandler(this.FormBeproTest_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageReguest.ResumeLayout(false);
            this.tabPageReguest.PerformLayout();
            this.tabPageResponce.ResumeLayout(false);
            this.tabPageResponce.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetJsonRequest;
        private System.Windows.Forms.TextBox textBoxJsonFileName;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageReguest;
        private System.Windows.Forms.TabPage tabPageResponce;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBoxWait;
        private System.Windows.Forms.TextBox textBoxAddressLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSendRequest;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxResponce;
        private System.Windows.Forms.TextBox textBoxReguest;
        private System.Windows.Forms.TextBox textBoxBaseAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxCurrent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxAuthorization;
    }
}

