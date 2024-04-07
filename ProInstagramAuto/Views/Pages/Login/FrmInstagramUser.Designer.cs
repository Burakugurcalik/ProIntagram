namespace ProInstagramAuto.Views.Pages
{
    partial class FrmInstagramUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInstagramUser));
            pcAvatar = new PictureBox();
            LblInfo1 = new Label();
            BwLogin = new System.ComponentModel.BackgroundWorker();
            txtUser = new TextBox();
            txtPass = new TextBox();
            LblInfo2 = new Label();
            BtnLogin = new Label();
            lblClose = new Label();
            LblInfo = new Label();
            chcMe = new CheckBox();
            chcAutoLogin = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pcAvatar).BeginInit();
            SuspendLayout();
            // 
            // pcAvatar
            // 
            pcAvatar.BackColor = Color.Transparent;
            pcAvatar.BackgroundImage = Properties.Resources.avatarbackgraoundx;
            pcAvatar.BackgroundImageLayout = ImageLayout.Stretch;
            pcAvatar.Image = Properties.Resources.sdsd;
            pcAvatar.Location = new Point(109, 40);
            pcAvatar.Margin = new Padding(4, 3, 4, 3);
            pcAvatar.Name = "pcAvatar";
            pcAvatar.Size = new Size(175, 173);
            pcAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pcAvatar.TabIndex = 1;
            pcAvatar.TabStop = false;
            // 
            // LblInfo1
            // 
            LblInfo1.AutoSize = true;
            LblInfo1.BackColor = Color.Transparent;
            LblInfo1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LblInfo1.ForeColor = Color.White;
            LblInfo1.Location = new Point(77, 262);
            LblInfo1.Name = "LblInfo1";
            LblInfo1.Size = new Size(99, 21);
            LblInfo1.TabIndex = 2;
            LblInfo1.Text = "Kullanıcı Adı";
            // 
            // BwLogin
            // 
            BwLogin.DoWork += BwLogin_DoWork;
            BwLogin.RunWorkerCompleted += BwLogin_RunWorkerCompleted;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtUser.ForeColor = Color.FromArgb(90, 66, 236);
            txtUser.Location = new Point(77, 296);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Kullanıcı Adını Giriniz";
            txtUser.Size = new Size(279, 29);
            txtUser.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtPass.ForeColor = Color.FromArgb(90, 66, 236);
            txtPass.Location = new Point(77, 373);
            txtPass.Name = "txtPass";
            txtPass.PlaceholderText = "Şifre Giriniz";
            txtPass.Size = new Size(279, 29);
            txtPass.TabIndex = 5;
            // 
            // LblInfo2
            // 
            LblInfo2.AutoSize = true;
            LblInfo2.BackColor = Color.Transparent;
            LblInfo2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LblInfo2.ForeColor = Color.White;
            LblInfo2.Location = new Point(77, 339);
            LblInfo2.Name = "LblInfo2";
            LblInfo2.Size = new Size(44, 21);
            LblInfo2.TabIndex = 4;
            LblInfo2.Text = "Şifre";
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.FromArgb(90, 66, 236);
            BtnLogin.Cursor = Cursors.Hand;
            BtnLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnLogin.ForeColor = Color.White;
            BtnLogin.Location = new Point(150, 486);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(99, 32);
            BtnLogin.TabIndex = 6;
            BtnLogin.Text = "Giriş Yap";
            BtnLogin.TextAlign = ContentAlignment.MiddleCenter;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // lblClose
            // 
            lblClose.AutoSize = true;
            lblClose.BackColor = Color.Transparent;
            lblClose.Cursor = Cursors.Hand;
            lblClose.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClose.ForeColor = Color.White;
            lblClose.Location = new Point(358, 9);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(30, 32);
            lblClose.TabIndex = 7;
            lblClose.Text = "X";
            lblClose.Click += lblClose_Click;
            // 
            // LblInfo
            // 
            LblInfo.BackColor = Color.Transparent;
            LblInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LblInfo.ForeColor = SystemColors.Control;
            LblInfo.Location = new Point(83, 536);
            LblInfo.Name = "LblInfo";
            LblInfo.Size = new Size(273, 42);
            LblInfo.TabIndex = 8;
            LblInfo.Text = "label1";
            LblInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chcMe
            // 
            chcMe.AutoSize = true;
            chcMe.BackColor = Color.Transparent;
            chcMe.Font = new Font("Segoe UI", 9.75F);
            chcMe.ForeColor = Color.White;
            chcMe.Location = new Point(74, 419);
            chcMe.Name = "chcMe";
            chcMe.Size = new Size(93, 21);
            chcMe.TabIndex = 9;
            chcMe.Text = "Beni Hatırla";
            chcMe.UseVisualStyleBackColor = false;
            // 
            // chcAutoLogin
            // 
            chcAutoLogin.AutoSize = true;
            chcAutoLogin.BackColor = Color.Transparent;
            chcAutoLogin.Font = new Font("Segoe UI", 9.75F);
            chcAutoLogin.ForeColor = Color.White;
            chcAutoLogin.Location = new Point(75, 444);
            chcAutoLogin.Name = "chcAutoLogin";
            chcAutoLogin.Size = new Size(110, 21);
            chcAutoLogin.TabIndex = 10;
            chcAutoLogin.Text = "Otomatik Giriş";
            chcAutoLogin.UseVisualStyleBackColor = false;
            chcAutoLogin.CheckedChanged += chcAutoLogin_CheckedChanged;
            // 
            // FrmInstagramUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = Properties.Resources.menubgx;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(400, 600);
            Controls.Add(chcAutoLogin);
            Controls.Add(chcMe);
            Controls.Add(LblInfo);
            Controls.Add(lblClose);
            Controls.Add(BtnLogin);
            Controls.Add(txtPass);
            Controls.Add(LblInfo2);
            Controls.Add(txtUser);
            Controls.Add(LblInfo1);
            Controls.Add(pcAvatar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmInstagramUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Yap";
            Load += FrmInstagramUser_Load;
            MouseDown += PnlHeader_MouseDown;
            MouseMove += PnlHeader_MouseMove;
            MouseUp += PnlHeader_MouseUp;
            ((System.ComponentModel.ISupportInitialize)pcAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcAvatar;
        private Label LblInfo1;
        private System.ComponentModel.BackgroundWorker BwLogin;
        private TextBox txtUser;
        private TextBox txtPass;
        private Label LblInfo2;
        private Label BtnLogin;
        private Label lblClose;
        private Label LblInfo;
        private CheckBox chcMe;
        private CheckBox chcAutoLogin;
    }
}