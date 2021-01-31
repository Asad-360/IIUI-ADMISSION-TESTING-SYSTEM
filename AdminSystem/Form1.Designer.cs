namespace AdminSystem
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelLogin = new Bunifu.Framework.UI.BunifuCards();
            this.label1 = new System.Windows.Forms.Label();
            this.adminLoginButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.adminSignUpButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.passBox = new MetroFramework.Controls.MetroTextBox();
            this.userBox = new MetroFramework.Controls.MetroTextBox();
            this.panelSignUp = new Bunifu.Framework.UI.BunifuCards();
            this.cnicBox = new MetroFramework.Controls.MetroTextBox();
            this.signUpButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.loginButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.confirmPassowordBox = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameBox = new MetroFramework.Controls.MetroTextBox();
            this.passwordBox = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adminPicture = new AdminSystem.OvalPictureBox();
            this.backgroundWorkerForSignUp = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerForLogin = new System.ComponentModel.BackgroundWorker();
            this.panelLogin.SuspendLayout();
            this.panelSignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.BorderRadius = 5;
            this.panelLogin.BottomSahddow = true;
            this.panelLogin.color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(187)))), ((int)(((byte)(31)))));
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.adminLoginButton);
            this.panelLogin.Controls.Add(this.adminSignUpButton);
            this.panelLogin.Controls.Add(this.passBox);
            this.panelLogin.Controls.Add(this.userBox);
            this.panelLogin.LeftSahddow = false;
            this.panelLogin.Location = new System.Drawing.Point(289, 138);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.RightSahddow = true;
            this.panelLogin.ShadowDepth = 20;
            this.panelLogin.Size = new System.Drawing.Size(344, 430);
            this.panelLogin.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADMIN LOGIN";
            // 
            // adminLoginButton
            // 
            this.adminLoginButton.Active = false;
            this.adminLoginButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.adminLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.adminLoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminLoginButton.BorderRadius = 0;
            this.adminLoginButton.ButtonText = "LOGIN";
            this.adminLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminLoginButton.DisabledColor = System.Drawing.Color.Gray;
            this.adminLoginButton.Iconcolor = System.Drawing.Color.Transparent;
            this.adminLoginButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("adminLoginButton.Iconimage")));
            this.adminLoginButton.Iconimage_right = null;
            this.adminLoginButton.Iconimage_right_Selected = null;
            this.adminLoginButton.Iconimage_Selected = null;
            this.adminLoginButton.IconMarginLeft = 0;
            this.adminLoginButton.IconMarginRight = 0;
            this.adminLoginButton.IconRightVisible = true;
            this.adminLoginButton.IconRightZoom = 0D;
            this.adminLoginButton.IconVisible = false;
            this.adminLoginButton.IconZoom = 90D;
            this.adminLoginButton.IsTab = false;
            this.adminLoginButton.Location = new System.Drawing.Point(41, 365);
            this.adminLoginButton.Name = "adminLoginButton";
            this.adminLoginButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.adminLoginButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.adminLoginButton.OnHoverTextColor = System.Drawing.Color.White;
            this.adminLoginButton.selected = false;
            this.adminLoginButton.Size = new System.Drawing.Size(255, 48);
            this.adminLoginButton.TabIndex = 12;
            this.adminLoginButton.Text = "LOGIN";
            this.adminLoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.adminLoginButton.Textcolor = System.Drawing.Color.White;
            this.adminLoginButton.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginButton.Click += new System.EventHandler(this.adminLoginButton_Click);
            // 
            // adminSignUpButton
            // 
            this.adminSignUpButton.Active = false;
            this.adminSignUpButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.adminSignUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.adminSignUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminSignUpButton.BorderRadius = 0;
            this.adminSignUpButton.ButtonText = "SIGN UP";
            this.adminSignUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminSignUpButton.DisabledColor = System.Drawing.Color.Gray;
            this.adminSignUpButton.Iconcolor = System.Drawing.Color.Transparent;
            this.adminSignUpButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("adminSignUpButton.Iconimage")));
            this.adminSignUpButton.Iconimage_right = null;
            this.adminSignUpButton.Iconimage_right_Selected = null;
            this.adminSignUpButton.Iconimage_Selected = null;
            this.adminSignUpButton.IconMarginLeft = 0;
            this.adminSignUpButton.IconMarginRight = 0;
            this.adminSignUpButton.IconRightVisible = true;
            this.adminSignUpButton.IconRightZoom = 0D;
            this.adminSignUpButton.IconVisible = false;
            this.adminSignUpButton.IconZoom = 90D;
            this.adminSignUpButton.IsTab = false;
            this.adminSignUpButton.Location = new System.Drawing.Point(41, 311);
            this.adminSignUpButton.Name = "adminSignUpButton";
            this.adminSignUpButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.adminSignUpButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.adminSignUpButton.OnHoverTextColor = System.Drawing.Color.White;
            this.adminSignUpButton.selected = false;
            this.adminSignUpButton.Size = new System.Drawing.Size(255, 48);
            this.adminSignUpButton.TabIndex = 18;
            this.adminSignUpButton.Text = "SIGN UP";
            this.adminSignUpButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.adminSignUpButton.Textcolor = System.Drawing.Color.White;
            this.adminSignUpButton.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminSignUpButton.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // passBox
            // 
            // 
            // 
            // 
            this.passBox.CustomButton.Image = null;
            this.passBox.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.passBox.CustomButton.Name = "";
            this.passBox.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.passBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passBox.CustomButton.TabIndex = 1;
            this.passBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passBox.CustomButton.UseSelectable = true;
            this.passBox.CustomButton.Visible = false;
            this.passBox.DisplayIcon = true;
            this.passBox.Icon = global::AdminSystem.Properties.Resources.icons8_Password_20px;
            this.passBox.Lines = new string[0];
            this.passBox.Location = new System.Drawing.Point(41, 212);
            this.passBox.MaxLength = 32767;
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '\0';
            this.passBox.PromptText = "Enter Password";
            this.passBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passBox.SelectedText = "";
            this.passBox.SelectionLength = 0;
            this.passBox.SelectionStart = 0;
            this.passBox.ShortcutsEnabled = true;
            this.passBox.Size = new System.Drawing.Size(255, 35);
            this.passBox.TabIndex = 11;
            this.passBox.UseSelectable = true;
            this.passBox.WaterMark = "Enter Password";
            this.passBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // userBox
            // 
            // 
            // 
            // 
            this.userBox.CustomButton.Image = null;
            this.userBox.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.userBox.CustomButton.Name = "";
            this.userBox.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.userBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userBox.CustomButton.TabIndex = 1;
            this.userBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userBox.CustomButton.UseSelectable = true;
            this.userBox.CustomButton.Visible = false;
            this.userBox.DisplayIcon = true;
            this.userBox.Icon = global::AdminSystem.Properties.Resources.icons8_User_Male_20px;
            this.userBox.Lines = new string[0];
            this.userBox.Location = new System.Drawing.Point(41, 152);
            this.userBox.MaxLength = 32767;
            this.userBox.Name = "userBox";
            this.userBox.PasswordChar = '\0';
            this.userBox.PromptText = "Enter Username";
            this.userBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userBox.SelectedText = "";
            this.userBox.SelectionLength = 0;
            this.userBox.SelectionStart = 0;
            this.userBox.ShortcutsEnabled = true;
            this.userBox.ShowClearButton = true;
            this.userBox.Size = new System.Drawing.Size(255, 35);
            this.userBox.TabIndex = 10;
            this.userBox.UseSelectable = true;
            this.userBox.WaterMark = "Enter Username";
            this.userBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.userBox.Click += new System.EventHandler(this.userBox_Click);
            // 
            // panelSignUp
            // 
            this.panelSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSignUp.BackColor = System.Drawing.Color.White;
            this.panelSignUp.BorderRadius = 5;
            this.panelSignUp.BottomSahddow = true;
            this.panelSignUp.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelSignUp.Controls.Add(this.cnicBox);
            this.panelSignUp.Controls.Add(this.signUpButton);
            this.panelSignUp.Controls.Add(this.loginButton);
            this.panelSignUp.Controls.Add(this.confirmPassowordBox);
            this.panelSignUp.Controls.Add(this.label2);
            this.panelSignUp.Controls.Add(this.usernameBox);
            this.panelSignUp.Controls.Add(this.passwordBox);
            this.panelSignUp.LeftSahddow = false;
            this.panelSignUp.Location = new System.Drawing.Point(289, 138);
            this.panelSignUp.Name = "panelSignUp";
            this.panelSignUp.RightSahddow = true;
            this.panelSignUp.ShadowDepth = 20;
            this.panelSignUp.Size = new System.Drawing.Size(344, 430);
            this.panelSignUp.TabIndex = 22;
            // 
            // cnicBox
            // 
            // 
            // 
            // 
            this.cnicBox.CustomButton.Image = null;
            this.cnicBox.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.cnicBox.CustomButton.Name = "";
            this.cnicBox.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.cnicBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cnicBox.CustomButton.TabIndex = 1;
            this.cnicBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cnicBox.CustomButton.UseSelectable = true;
            this.cnicBox.CustomButton.Visible = false;
            this.cnicBox.DisplayIcon = true;
            this.cnicBox.Icon = global::AdminSystem.Properties.Resources.icons8_ID_Card_20px_1;
            this.cnicBox.Lines = new string[0];
            this.cnicBox.Location = new System.Drawing.Point(41, 242);
            this.cnicBox.MaxLength = 32767;
            this.cnicBox.Name = "cnicBox";
            this.cnicBox.PasswordChar = '\0';
            this.cnicBox.PromptText = "Enter Cnic Number";
            this.cnicBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cnicBox.SelectedText = "";
            this.cnicBox.SelectionLength = 0;
            this.cnicBox.SelectionStart = 0;
            this.cnicBox.ShortcutsEnabled = true;
            this.cnicBox.ShowClearButton = true;
            this.cnicBox.Size = new System.Drawing.Size(265, 35);
            this.cnicBox.TabIndex = 20;
            this.cnicBox.UseSelectable = true;
            this.cnicBox.WaterMark = "Enter Cnic Number";
            this.cnicBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cnicBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // signUpButton
            // 
            this.signUpButton.Active = false;
            this.signUpButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.signUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signUpButton.BorderRadius = 0;
            this.signUpButton.ButtonText = "SIGN UP";
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.DisabledColor = System.Drawing.Color.Gray;
            this.signUpButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.Iconcolor = System.Drawing.Color.Transparent;
            this.signUpButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("signUpButton.Iconimage")));
            this.signUpButton.Iconimage_right = null;
            this.signUpButton.Iconimage_right_Selected = null;
            this.signUpButton.Iconimage_Selected = null;
            this.signUpButton.IconMarginLeft = 0;
            this.signUpButton.IconMarginRight = 0;
            this.signUpButton.IconRightVisible = true;
            this.signUpButton.IconRightZoom = 0D;
            this.signUpButton.IconVisible = false;
            this.signUpButton.IconZoom = 90D;
            this.signUpButton.IsTab = false;
            this.signUpButton.Location = new System.Drawing.Point(41, 311);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signUpButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.signUpButton.OnHoverTextColor = System.Drawing.Color.White;
            this.signUpButton.selected = false;
            this.signUpButton.Size = new System.Drawing.Size(265, 48);
            this.signUpButton.TabIndex = 12;
            this.signUpButton.Text = "SIGN UP";
            this.signUpButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signUpButton.Textcolor = System.Drawing.Color.White;
            this.signUpButton.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // loginButton
            // 
            this.loginButton.Active = false;
            this.loginButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginButton.BorderRadius = 0;
            this.loginButton.ButtonText = "LOGIN";
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.DisabledColor = System.Drawing.Color.Gray;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Iconcolor = System.Drawing.Color.Transparent;
            this.loginButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("loginButton.Iconimage")));
            this.loginButton.Iconimage_right = null;
            this.loginButton.Iconimage_right_Selected = null;
            this.loginButton.Iconimage_Selected = null;
            this.loginButton.IconMarginLeft = 0;
            this.loginButton.IconMarginRight = 0;
            this.loginButton.IconRightVisible = true;
            this.loginButton.IconRightZoom = 0D;
            this.loginButton.IconVisible = false;
            this.loginButton.IconZoom = 90D;
            this.loginButton.IsTab = false;
            this.loginButton.Location = new System.Drawing.Point(41, 365);
            this.loginButton.Name = "loginButton";
            this.loginButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.loginButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.loginButton.OnHoverTextColor = System.Drawing.Color.White;
            this.loginButton.selected = false;
            this.loginButton.Size = new System.Drawing.Size(265, 48);
            this.loginButton.TabIndex = 17;
            this.loginButton.Text = "LOGIN";
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginButton.Textcolor = System.Drawing.Color.White;
            this.loginButton.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // confirmPassowordBox
            // 
            // 
            // 
            // 
            this.confirmPassowordBox.CustomButton.Image = null;
            this.confirmPassowordBox.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.confirmPassowordBox.CustomButton.Name = "";
            this.confirmPassowordBox.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.confirmPassowordBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.confirmPassowordBox.CustomButton.TabIndex = 1;
            this.confirmPassowordBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.confirmPassowordBox.CustomButton.UseSelectable = true;
            this.confirmPassowordBox.CustomButton.Visible = false;
            this.confirmPassowordBox.DisplayIcon = true;
            this.confirmPassowordBox.Icon = global::AdminSystem.Properties.Resources.icons8_Password_20px;
            this.confirmPassowordBox.Lines = new string[0];
            this.confirmPassowordBox.Location = new System.Drawing.Point(41, 201);
            this.confirmPassowordBox.MaxLength = 32767;
            this.confirmPassowordBox.Name = "confirmPassowordBox";
            this.confirmPassowordBox.PasswordChar = '\0';
            this.confirmPassowordBox.PromptText = "Confirm Password";
            this.confirmPassowordBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.confirmPassowordBox.SelectedText = "";
            this.confirmPassowordBox.SelectionLength = 0;
            this.confirmPassowordBox.SelectionStart = 0;
            this.confirmPassowordBox.ShortcutsEnabled = true;
            this.confirmPassowordBox.ShowClearButton = true;
            this.confirmPassowordBox.Size = new System.Drawing.Size(265, 35);
            this.confirmPassowordBox.TabIndex = 16;
            this.confirmPassowordBox.UseSelectable = true;
            this.confirmPassowordBox.WaterMark = "Confirm Password";
            this.confirmPassowordBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.confirmPassowordBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADMIN SIGN-UP";
            // 
            // usernameBox
            // 
            // 
            // 
            // 
            this.usernameBox.CustomButton.Image = null;
            this.usernameBox.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.usernameBox.CustomButton.Name = "";
            this.usernameBox.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.usernameBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.usernameBox.CustomButton.TabIndex = 1;
            this.usernameBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usernameBox.CustomButton.UseSelectable = true;
            this.usernameBox.CustomButton.Visible = false;
            this.usernameBox.DisplayIcon = true;
            this.usernameBox.Icon = global::AdminSystem.Properties.Resources.icons8_User_Male_20px;
            this.usernameBox.Lines = new string[0];
            this.usernameBox.Location = new System.Drawing.Point(41, 118);
            this.usernameBox.MaxLength = 32767;
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.PasswordChar = '\0';
            this.usernameBox.PromptText = "Enter Username";
            this.usernameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernameBox.SelectedText = "";
            this.usernameBox.SelectionLength = 0;
            this.usernameBox.SelectionStart = 0;
            this.usernameBox.ShortcutsEnabled = true;
            this.usernameBox.ShowClearButton = true;
            this.usernameBox.Size = new System.Drawing.Size(265, 35);
            this.usernameBox.TabIndex = 10;
            this.usernameBox.UseSelectable = true;
            this.usernameBox.WaterMark = "Enter Username";
            this.usernameBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usernameBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // passwordBox
            // 
            // 
            // 
            // 
            this.passwordBox.CustomButton.Image = null;
            this.passwordBox.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.passwordBox.CustomButton.Name = "";
            this.passwordBox.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.passwordBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordBox.CustomButton.TabIndex = 1;
            this.passwordBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordBox.CustomButton.UseSelectable = true;
            this.passwordBox.CustomButton.Visible = false;
            this.passwordBox.DisplayIcon = true;
            this.passwordBox.Icon = global::AdminSystem.Properties.Resources.icons8_Password_20px;
            this.passwordBox.Lines = new string[0];
            this.passwordBox.Location = new System.Drawing.Point(41, 159);
            this.passwordBox.MaxLength = 32767;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '\0';
            this.passwordBox.PromptText = "Enter Password";
            this.passwordBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordBox.SelectedText = "";
            this.passwordBox.SelectionLength = 0;
            this.passwordBox.SelectionStart = 0;
            this.passwordBox.ShortcutsEnabled = true;
            this.passwordBox.ShowClearButton = true;
            this.passwordBox.Size = new System.Drawing.Size(265, 35);
            this.passwordBox.TabIndex = 11;
            this.passwordBox.UseSelectable = true;
            this.passwordBox.WaterMark = "Enter Password";
            this.passwordBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(180, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(588, 54);
            this.label3.TabIndex = 23;
            this.label3.Text = "IIUI ADMISSION TESTING SYSTEM";
            // 
            // adminPicture
            // 
            this.adminPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.adminPicture.BackColor = System.Drawing.Color.DarkGray;
            this.adminPicture.Image = global::AdminSystem.Properties.Resources.Student_3_icon__1_;
            this.adminPicture.Location = new System.Drawing.Point(406, 99);
            this.adminPicture.Name = "adminPicture";
            this.adminPicture.Size = new System.Drawing.Size(100, 100);
            this.adminPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adminPicture.TabIndex = 21;
            this.adminPicture.TabStop = false;
            this.adminPicture.Click += new System.EventHandler(this.ovalPictureBox2_Click);
            // 
            // backgroundWorkerForSignUp
            // 
            this.backgroundWorkerForSignUp.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerForSignUp_DoWork);
            this.backgroundWorkerForSignUp.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerForSignUp_RunWorkerCompleted);
            // 
            // backgroundWorkerForLogin
            // 
            this.backgroundWorkerForLogin.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerForLogin_DoWork);
            this.backgroundWorkerForLogin.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerForLogin_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(947, 603);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adminPicture);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelSignUp);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IIUI ADMISSION TESTING SYSTEM";
            this.TransparencyKey = System.Drawing.Color.DarkOrchid;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelSignUp.ResumeLayout(false);
            this.panelSignUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroTextBox userBox;
        private MetroFramework.Controls.MetroTextBox passBox;
        private Bunifu.Framework.UI.BunifuFlatButton loginButton;
        private Bunifu.Framework.UI.BunifuFlatButton adminSignUpButton;
        private Bunifu.Framework.UI.BunifuFlatButton signUpButton;
        private MetroFramework.Controls.MetroTextBox usernameBox;
        private MetroFramework.Controls.MetroTextBox passwordBox;
        private MetroFramework.Controls.MetroTextBox confirmPassowordBox;
        private MetroFramework.Controls.MetroTextBox cnicBox;
        private Bunifu.Framework.UI.BunifuCards panelLogin;
        private OvalPictureBox adminPicture;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCards panelSignUp;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton adminLoginButton;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorkerForSignUp;
        private System.ComponentModel.BackgroundWorker backgroundWorkerForLogin;
    }
}

