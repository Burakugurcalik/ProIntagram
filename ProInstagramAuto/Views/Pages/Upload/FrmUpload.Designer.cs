namespace ProIntagramAuto.Views.Pages
{
    partial class FrmUpload
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
            LblFormTitle = new Label();
            LblInfo1 = new Label();
            LblInfo2 = new Label();
            LblInfo3 = new Label();
            LblInfo4 = new Label();
            BtnSave = new Label();
            pbline = new PictureBox();
            pcView = new PictureBox();
            opencontent = new OpenFileDialog();
            txtline = new TextBox();
            btnSelectContent = new Label();
            cbDay = new ComboBox();
            cbMounth = new ComboBox();
            cbYear = new ComboBox();
            cbMinutes = new ComboBox();
            cbHour = new ComboBox();
            txttitle = new TextBox();
            LblInfo5 = new Label();
            LblInfo6 = new Label();
            LblInfo7 = new Label();
            LblInfo8 = new Label();
            LblInfo9 = new Label();
            bwsave = new System.ComponentModel.BackgroundWorker();
            Lblinfo = new Label();
            ((System.ComponentModel.ISupportInitialize)pbline).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcView).BeginInit();
            SuspendLayout();
            // 
            // LblFormTitle
            // 
            LblFormTitle.AutoSize = true;
            LblFormTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LblFormTitle.ForeColor = Color.FromArgb(90, 66, 236);
            LblFormTitle.Location = new Point(114, 20);
            LblFormTitle.Name = "LblFormTitle";
            LblFormTitle.Size = new Size(269, 32);
            LblFormTitle.TabIndex = 0;
            LblFormTitle.Text = "Gönderi Resim Ekleme";
            // 
            // LblInfo1
            // 
            LblInfo1.AutoSize = true;
            LblInfo1.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold);
            LblInfo1.ForeColor = Color.FromArgb(90, 66, 236);
            LblInfo1.Location = new Point(87, 187);
            LblInfo1.Name = "LblInfo1";
            LblInfo1.Size = new Size(101, 18);
            LblInfo1.TabIndex = 1;
            LblInfo1.Text = "Dosyayı seçiniz";
            // 
            // LblInfo2
            // 
            LblInfo2.AutoSize = true;
            LblInfo2.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold);
            LblInfo2.ForeColor = Color.FromArgb(90, 66, 236);
            LblInfo2.Location = new Point(87, 247);
            LblInfo2.Name = "LblInfo2";
            LblInfo2.Size = new Size(88, 18);
            LblInfo2.TabIndex = 2;
            LblInfo2.Text = "Tarih Seçiniz";
            // 
            // LblInfo3
            // 
            LblInfo3.AutoSize = true;
            LblInfo3.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold);
            LblInfo3.ForeColor = Color.FromArgb(90, 66, 236);
            LblInfo3.Location = new Point(87, 316);
            LblInfo3.Name = "LblInfo3";
            LblInfo3.Size = new Size(82, 18);
            LblInfo3.TabIndex = 3;
            LblInfo3.Text = "Saat Seçiniz";
            // 
            // LblInfo4
            // 
            LblInfo4.AutoSize = true;
            LblInfo4.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold);
            LblInfo4.ForeColor = Color.FromArgb(90, 66, 236);
            LblInfo4.Location = new Point(87, 370);
            LblInfo4.Name = "LblInfo4";
            LblInfo4.Size = new Size(63, 18);
            LblInfo4.TabIndex = 4;
            LblInfo4.Text = "Açıklama";
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.FromArgb(90, 66, 236);
            BtnSave.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnSave.ForeColor = Color.White;
            BtnSave.Location = new Point(1012, 660);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(134, 51);
            BtnSave.TabIndex = 5;
            BtnSave.Text = "Kaydet";
            BtnSave.TextAlign = ContentAlignment.MiddleCenter;
            BtnSave.Click += BtnSave_Click;
            // 
            // pbline
            // 
            pbline.BackColor = Color.FromArgb(90, 66, 236);
            pbline.Location = new Point(-9, 69);
            pbline.Name = "pbline";
            pbline.Size = new Size(1243, 10);
            pbline.TabIndex = 6;
            pbline.TabStop = false;
            // 
            // pcView
            // 
            pcView.Location = new Point(704, 138);
            pcView.Name = "pcView";
            pcView.Size = new Size(367, 490);
            pcView.SizeMode = PictureBoxSizeMode.StretchImage;
            pcView.TabIndex = 7;
            pcView.TabStop = false;
            // 
            // opencontent
            // 
            opencontent.FileName = "openFileDialog1";
         
            // 
            // txtline
            // 
            txtline.BackColor = Color.White;
            txtline.BorderStyle = BorderStyle.FixedSingle;
            txtline.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtline.ForeColor = Color.FromArgb(90, 66, 236);
            txtline.Location = new Point(236, 180);
            txtline.Multiline = true;
            txtline.Name = "txtline";
            txtline.ReadOnly = true;
            txtline.Size = new Size(401, 25);
            txtline.TabIndex = 9999;
            txtline.Text = "Dosya Seçimi Yapınız";
            // 
            // btnSelectContent
            // 
            btnSelectContent.BackColor = Color.FromArgb(90, 66, 236);
            btnSelectContent.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSelectContent.ForeColor = Color.White;
            btnSelectContent.Location = new Point(547, 177);
            btnSelectContent.Name = "btnSelectContent";
            btnSelectContent.Size = new Size(100, 31);
            btnSelectContent.TabIndex = 9;
            btnSelectContent.Text = "Dosya Seçiniz";
            btnSelectContent.TextAlign = ContentAlignment.MiddleCenter;
            btnSelectContent.Click += btnSelectContent_Click;
            // 
            // cbDay
            // 
            cbDay.Font = new Font("Segoe UI", 9.75F);
            cbDay.ForeColor = Color.FromArgb(90, 66, 236);
            cbDay.FormattingEnabled = true;
            cbDay.Location = new Point(235, 247);
            cbDay.Name = "cbDay";
            cbDay.Size = new Size(64, 25);
            cbDay.TabIndex = 10;
            cbDay.Text = "Gün";
            // 
            // cbMounth
            // 
            cbMounth.Font = new Font("Segoe UI", 9.75F);
            cbMounth.ForeColor = Color.FromArgb(90, 66, 236);
            cbMounth.FormattingEnabled = true;
            cbMounth.Location = new Point(319, 247);
            cbMounth.Name = "cbMounth";
            cbMounth.Size = new Size(64, 25);
            cbMounth.TabIndex = 11;
            cbMounth.Text = "Ay";
            // 
            // cbYear
            // 
            cbYear.Font = new Font("Segoe UI", 9.75F);
            cbYear.ForeColor = Color.FromArgb(90, 66, 236);
            cbYear.FormattingEnabled = true;
            cbYear.Location = new Point(401, 247);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(84, 25);
            cbYear.TabIndex = 12;
            cbYear.Text = "Yıl";
            // 
            // cbMinutes
            // 
            cbMinutes.Font = new Font("Segoe UI", 9.75F);
            cbMinutes.ForeColor = Color.FromArgb(90, 66, 236);
            cbMinutes.FormattingEnabled = true;
            cbMinutes.Location = new Point(319, 313);
            cbMinutes.Name = "cbMinutes";
            cbMinutes.Size = new Size(64, 25);
            cbMinutes.TabIndex = 14;
            cbMinutes.Text = "Dakika";
            // 
            // cbHour
            // 
            cbHour.Font = new Font("Segoe UI", 9.75F);
            cbHour.ForeColor = Color.FromArgb(90, 66, 236);
            cbHour.FormattingEnabled = true;
            cbHour.Location = new Point(235, 313);
            cbHour.Name = "cbHour";
            cbHour.Size = new Size(64, 25);
            cbHour.TabIndex = 13;
            cbHour.Text = "Saat";
            // 
            // txttitle
            // 
            txttitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txttitle.ForeColor = Color.FromArgb(90, 66, 236);
            txttitle.Location = new Point(239, 379);
            txttitle.MaxLength = 999999;
            txttitle.Multiline = true;
            txttitle.Name = "txttitle";
            txttitle.PlaceholderText = "Açıklama Giriniz";
            txttitle.Size = new Size(398, 232);
            txttitle.TabIndex = 1;
            // 
            // LblInfo5
            // 
            LblInfo5.AutoSize = true;
            LblInfo5.Location = new Point(234, 226);
            LblInfo5.Name = "LblInfo5";
            LblInfo5.Size = new Size(29, 15);
            LblInfo5.TabIndex = 10000;
            LblInfo5.Text = "Gün";
            // 
            // LblInfo6
            // 
            LblInfo6.AutoSize = true;
            LblInfo6.Location = new Point(329, 226);
            LblInfo6.Name = "LblInfo6";
            LblInfo6.Size = new Size(21, 15);
            LblInfo6.TabIndex = 10001;
            LblInfo6.Text = "Ay";
            // 
            // LblInfo7
            // 
            LblInfo7.AutoSize = true;
            LblInfo7.Location = new Point(417, 226);
            LblInfo7.Name = "LblInfo7";
            LblInfo7.Size = new Size(20, 15);
            LblInfo7.TabIndex = 10002;
            LblInfo7.Text = "Yıl";
            // 
            // LblInfo8
            // 
            LblInfo8.AutoSize = true;
            LblInfo8.Location = new Point(236, 293);
            LblInfo8.Name = "LblInfo8";
            LblInfo8.Size = new Size(29, 15);
            LblInfo8.TabIndex = 10003;
            LblInfo8.Text = "Saat";
            // 
            // LblInfo9
            // 
            LblInfo9.AutoSize = true;
            LblInfo9.Location = new Point(319, 293);
            LblInfo9.Name = "LblInfo9";
            LblInfo9.Size = new Size(42, 15);
            LblInfo9.TabIndex = 10004;
            LblInfo9.Text = "Dakika";
            // 
            // bwsave
            // 
            bwsave.DoWork += bwsave_DoWork;
            bwsave.RunWorkerCompleted += bwsave_RunWorkerCompleted;
            // 
            // Lblinfo
            // 
            Lblinfo.AutoSize = true;
            Lblinfo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Lblinfo.ForeColor = Color.FromArgb(90, 66, 236);
            Lblinfo.Location = new Point(236, 660);
            Lblinfo.Name = "Lblinfo";
            Lblinfo.Size = new Size(269, 32);
            Lblinfo.TabIndex = 10005;
            Lblinfo.Text = "Gönderi Resim Ekleme";
            // 
            // FrmUpload
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1161, 720);
            Controls.Add(Lblinfo);
            Controls.Add(LblInfo9);
            Controls.Add(LblInfo8);
            Controls.Add(LblInfo7);
            Controls.Add(LblInfo6);
            Controls.Add(LblInfo5);
            Controls.Add(txttitle);
            Controls.Add(cbMinutes);
            Controls.Add(cbHour);
            Controls.Add(cbYear);
            Controls.Add(cbMounth);
            Controls.Add(cbDay);
            Controls.Add(btnSelectContent);
            Controls.Add(txtline);
            Controls.Add(pcView);
            Controls.Add(pbline);
            Controls.Add(BtnSave);
            Controls.Add(LblInfo4);
            Controls.Add(LblInfo3);
            Controls.Add(LblInfo2);
            Controls.Add(LblInfo1);
            Controls.Add(LblFormTitle);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmUpload";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmUpload";
            Load += FrmUpload_Load;
            ((System.ComponentModel.ISupportInitialize)pbline).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblFormTitle;
        private Label LblInfo1;
        private Label LblInfo2;
        private Label LblInfo3;
        private Label LblInfo4;
        private Label BtnSave;
        private PictureBox pbline;
        private PictureBox pcView;
        private OpenFileDialog opencontent;
        private TextBox txtline;
        private Label btnSelectContent;
        private ComboBox cbDay;
        private ComboBox cbMounth;
        private ComboBox cbYear;
        private ComboBox cbMinutes;
        private ComboBox cbHour;
        private TextBox txttitle;
        private Label LblInfo5;
        private Label LblInfo6;
        private Label LblInfo7;
        private Label LblInfo8;
        private Label LblInfo9;
        private System.ComponentModel.BackgroundWorker bwsave;
        private Label Lblinfo;
    }
}