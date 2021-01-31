namespace StudentTestingSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ovalPictureBox1 = new AdminSystem.OvalPictureBox();
            this.panelLogin = new Bunifu.Framework.UI.BunifuCards();
            this.passwordField = new MetroFramework.Controls.MetroTextBox();
            this.usernameField = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.studentLoginButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.studentLoginBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.ovalPictureBox1);
            this.panel1.Controls.Add(this.panelLogin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 637);
            this.panel1.TabIndex = 0;
            // 
            // ovalPictureBox1
            // 
            this.ovalPictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.ovalPictureBox1.Image = global::StudentTestingSystem.Properties.Resources.Student_3_icon__1_;
            this.ovalPictureBox1.Location = new System.Drawing.Point(352, 110);
            this.ovalPictureBox1.Name = "ovalPictureBox1";
            this.ovalPictureBox1.Size = new System.Drawing.Size(108, 106);
            this.ovalPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ovalPictureBox1.TabIndex = 26;
            this.ovalPictureBox1.TabStop = false;
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.BorderRadius = 5;
            this.panelLogin.BottomSahddow = true;
            this.panelLogin.color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(187)))), ((int)(((byte)(31)))));
            this.panelLogin.Controls.Add(this.passwordField);
            this.panelLogin.Controls.Add(this.usernameField);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.studentLoginButton);
            this.panelLogin.LeftSahddow = false;
            this.panelLogin.Location = new System.Drawing.Point(239, 154);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.RightSahddow = true;
            this.panelLogin.ShadowDepth = 20;
            this.panelLogin.Size = new System.Drawing.Size(344, 430);
            this.panelLogin.TabIndex = 25;
            // 
            // passwordField
            // 
            // 
            // 
            // 
            this.passwordField.CustomButton.Image = null;
            this.passwordField.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.passwordField.CustomButton.Name = "";
            this.passwordField.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.passwordField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordField.CustomButton.TabIndex = 1;
            this.passwordField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordField.CustomButton.UseSelectable = true;
            this.passwordField.CustomButton.Visible = false;
            this.passwordField.DisplayIcon = true;
            this.passwordField.Icon = global::StudentTestingSystem.Properties.Resources.icons8_ID_Card_20px_1;
            this.passwordField.Lines = new string[0];
            this.passwordField.Location = new System.Drawing.Point(45, 220);
            this.passwordField.MaxLength = 32767;
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '\0';
            this.passwordField.PromptText = "Cnic Number";
            this.passwordField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordField.SelectedText = "";
            this.passwordField.SelectionLength = 0;
            this.passwordField.SelectionStart = 0;
            this.passwordField.ShortcutsEnabled = true;
            this.passwordField.Size = new System.Drawing.Size(255, 35);
            this.passwordField.TabIndex = 20;
            this.passwordField.UseSelectable = true;
            this.passwordField.WaterMark = "Cnic Number";
            this.passwordField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // usernameField
            // 
            // 
            // 
            // 
            this.usernameField.CustomButton.Image = null;
            this.usernameField.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.usernameField.CustomButton.Name = "";
            this.usernameField.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.usernameField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.usernameField.CustomButton.TabIndex = 1;
            this.usernameField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usernameField.CustomButton.UseSelectable = true;
            this.usernameField.CustomButton.Visible = false;
            this.usernameField.DisplayIcon = true;
            this.usernameField.Icon = global::StudentTestingSystem.Properties.Resources.icons8_User_Male_20px;
            this.usernameField.Lines = new string[0];
            this.usernameField.Location = new System.Drawing.Point(45, 156);
            this.usernameField.MaxLength = 32767;
            this.usernameField.Name = "usernameField";
            this.usernameField.PasswordChar = '\0';
            this.usernameField.PromptText = "Student Name";
            this.usernameField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernameField.SelectedText = "";
            this.usernameField.SelectionLength = 0;
            this.usernameField.SelectionStart = 0;
            this.usernameField.ShortcutsEnabled = true;
            this.usernameField.ShowClearButton = true;
            this.usernameField.Size = new System.Drawing.Size(255, 35);
            this.usernameField.TabIndex = 19;
            this.usernameField.UseSelectable = true;
            this.usernameField.WaterMark = "Student Name";
            this.usernameField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usernameField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "STUDENT LOGIN";
            // 
            // studentLoginButton
            // 
            this.studentLoginButton.Active = false;
            this.studentLoginButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.studentLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.studentLoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.studentLoginButton.BorderRadius = 0;
            this.studentLoginButton.ButtonText = "LOGIN";
            this.studentLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentLoginButton.DisabledColor = System.Drawing.Color.Gray;
            this.studentLoginButton.Iconcolor = System.Drawing.Color.Transparent;
            this.studentLoginButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("studentLoginButton.Iconimage")));
            this.studentLoginButton.Iconimage_right = null;
            this.studentLoginButton.Iconimage_right_Selected = null;
            this.studentLoginButton.Iconimage_Selected = null;
            this.studentLoginButton.IconMarginLeft = 0;
            this.studentLoginButton.IconMarginRight = 0;
            this.studentLoginButton.IconRightVisible = true;
            this.studentLoginButton.IconRightZoom = 0D;
            this.studentLoginButton.IconVisible = false;
            this.studentLoginButton.IconZoom = 90D;
            this.studentLoginButton.IsTab = false;
            this.studentLoginButton.Location = new System.Drawing.Point(45, 294);
            this.studentLoginButton.Name = "studentLoginButton";
            this.studentLoginButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.studentLoginButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.studentLoginButton.OnHoverTextColor = System.Drawing.Color.White;
            this.studentLoginButton.selected = false;
            this.studentLoginButton.Size = new System.Drawing.Size(255, 66);
            this.studentLoginButton.TabIndex = 12;
            this.studentLoginButton.Text = "LOGIN";
            this.studentLoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.studentLoginButton.Textcolor = System.Drawing.Color.White;
            this.studentLoginButton.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentLoginButton.Click += new System.EventHandler(this.studentLoginButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(101, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(588, 54);
            this.label3.TabIndex = 24;
            this.label3.Text = "IIUI ADMISSION TESTING SYSTEM";
            // 
            // studentLoginBackgroundWorker
            // 
            this.studentLoginBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.studentLoginBackgroundWorker_DoWork);
            this.studentLoginBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.studentLoginBackgroundWorker_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 637);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCards panelLogin;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton studentLoginButton;
        private AdminSystem.OvalPictureBox ovalPictureBox1;
        private MetroFramework.Controls.MetroTextBox usernameField;
        private MetroFramework.Controls.MetroTextBox passwordField;
        private System.ComponentModel.BackgroundWorker studentLoginBackgroundWorker;
    }
}

