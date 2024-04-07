namespace ProInstagramAuto.Views.Pages.List
{
    partial class FrmProductList
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
            components = new System.ComponentModel.Container();
            grdControlproducts = new DevExpress.XtraGrid.GridControl();
            grdvwproducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            grdStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            grdViewImage = new DevExpress.XtraGrid.Columns.GridColumn();
            grdContent = new DevExpress.XtraGrid.Columns.GridColumn();
            grdTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            grdType = new DevExpress.XtraGrid.Columns.GridColumn();
            grdDay = new DevExpress.XtraGrid.Columns.GridColumn();
            grdMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            grdMinutes = new DevExpress.XtraGrid.Columns.GridColumn();
            grdYear = new DevExpress.XtraGrid.Columns.GridColumn();
            grdHour = new DevExpress.XtraGrid.Columns.GridColumn();
            cbtype = new ComboBox();
            LblInfo1 = new Label();
            label1 = new Label();
            cbstate = new ComboBox();
            BtnList = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            güncelleToolStripMenuItem = new ToolStripMenuItem();
            silToolStripMenuItem = new ToolStripMenuItem();
            grdbutton = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)grdControlproducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdvwproducts).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).BeginInit();
            SuspendLayout();
            // 
            // grdControlproducts
            // 
            grdControlproducts.Location = new Point(12, 67);
            grdControlproducts.MainView = grdvwproducts;
            grdControlproducts.Name = "grdControlproducts";
            grdControlproducts.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemButtonEdit1 });
            grdControlproducts.Size = new Size(1152, 628);
            grdControlproducts.TabIndex = 0;
            grdControlproducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { grdvwproducts });
            // 
            // grdvwproducts
            // 
            grdvwproducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { grdStatus, grdViewImage, grdContent, grdTitle, grdType, grdDay, grdMonth, grdMinutes, grdYear, grdHour, grdbutton });
            grdvwproducts.CustomizationFormBounds = new Rectangle(-1168, 286, 264, 272);
            grdvwproducts.GridControl = grdControlproducts;
            grdvwproducts.Name = "grdvwproducts";
            grdvwproducts.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.True;
            grdvwproducts.OptionsFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.TextAndVisual;
            grdvwproducts.OptionsFilter.InHeaderSearchMode = DevExpress.XtraGrid.Views.Grid.GridInHeaderSearchMode.TextSearch;
            grdvwproducts.OptionsFilter.ShowInHeaderSearchTextMode = DevExpress.XtraGrid.Views.Grid.ShowInHeaderSearchTextMode.Text;
            grdvwproducts.OptionsView.ShowGroupPanel = false;
            // 
            // grdStatus
            // 
            grdStatus.Caption = "Durum";
            grdStatus.FieldName = "Statusx";
            grdStatus.Name = "grdStatus";
            grdStatus.Visible = true;
            grdStatus.VisibleIndex = 0;
            // 
            // grdViewImage
            // 
            grdViewImage.Caption = "Ön Görünüm";
            grdViewImage.FieldName = "Viewimage";
            grdViewImage.Name = "grdViewImage";
            grdViewImage.Visible = true;
            grdViewImage.VisibleIndex = 1;
            // 
            // grdContent
            // 
            grdContent.Caption = "İçerik";
            grdContent.FieldName = "Content";
            grdContent.Name = "grdContent";
            grdContent.Visible = true;
            grdContent.VisibleIndex = 2;
            // 
            // grdTitle
            // 
            grdTitle.Caption = "Başlık";
            grdTitle.FieldName = "Title";
            grdTitle.Name = "grdTitle";
            grdTitle.Visible = true;
            grdTitle.VisibleIndex = 3;
            // 
            // grdType
            // 
            grdType.Caption = "Türü";
            grdType.FieldName = "Typex";
            grdType.Name = "grdType";
            grdType.OptionsFilter.AllowFilter = false;
            grdType.Visible = true;
            grdType.VisibleIndex = 4;
            // 
            // grdDay
            // 
            grdDay.Caption = "Gün";
            grdDay.FieldName = "Day";
            grdDay.Name = "grdDay";
            grdDay.OptionsFilter.AllowFilter = false;
            grdDay.Visible = true;
            grdDay.VisibleIndex = 5;
            // 
            // grdMonth
            // 
            grdMonth.Caption = "Ay";
            grdMonth.FieldName = "Month";
            grdMonth.Name = "grdMonth";
            grdMonth.Visible = true;
            grdMonth.VisibleIndex = 6;
            // 
            // grdMinutes
            // 
            grdMinutes.Caption = "Dakika";
            grdMinutes.FieldName = "Minutes";
            grdMinutes.Name = "grdMinutes";
            grdMinutes.Visible = true;
            grdMinutes.VisibleIndex = 9;
            // 
            // grdYear
            // 
            grdYear.Caption = "Yıl";
            grdYear.FieldName = "Year";
            grdYear.Name = "grdYear";
            grdYear.Visible = true;
            grdYear.VisibleIndex = 7;
            // 
            // grdHour
            // 
            grdHour.Caption = "Saat";
            grdHour.FieldName = "Hour";
            grdHour.Name = "grdHour";
            grdHour.Visible = true;
            grdHour.VisibleIndex = 8;
            // 
            // cbtype
            // 
            cbtype.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            cbtype.ForeColor = Color.FromArgb(90, 66, 236);
            cbtype.FormattingEnabled = true;
            cbtype.Items.AddRange(new object[] { "Hepsi", "Gönderi Resim", "Gönderi Video", "Story Resim", "Story Video" });
            cbtype.Location = new Point(401, 12);
            cbtype.Name = "cbtype";
            cbtype.Size = new Size(138, 28);
            cbtype.TabIndex = 1;
            // 
            // LblInfo1
            // 
            LblInfo1.AutoSize = true;
            LblInfo1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            LblInfo1.ForeColor = Color.FromArgb(90, 66, 236);
            LblInfo1.Location = new Point(306, 15);
            LblInfo1.Name = "LblInfo1";
            LblInfo1.Size = new Size(88, 20);
            LblInfo1.TabIndex = 2;
            LblInfo1.Text = "Ürün Çeşidi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(90, 66, 236);
            label1.Location = new Point(37, 15);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 4;
            label1.Text = "Durum";
            // 
            // cbstate
            // 
            cbstate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            cbstate.ForeColor = Color.FromArgb(90, 66, 236);
            cbstate.FormattingEnabled = true;
            cbstate.Items.AddRange(new object[] { "Hepsi", "Bekliyor", "İşlemde", "Tamamlandı", "Hata Oluştu" });
            cbstate.Location = new Point(106, 12);
            cbstate.Name = "cbstate";
            cbstate.Size = new Size(138, 28);
            cbstate.TabIndex = 3;
            // 
            // BtnList
            // 
            BtnList.BackColor = Color.FromArgb(90, 66, 236);
            BtnList.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            BtnList.ForeColor = Color.White;
            BtnList.Location = new Point(563, 9);
            BtnList.Name = "BtnList";
            BtnList.Size = new Size(94, 31);
            BtnList.TabIndex = 5;
            BtnList.Text = "Listele";
            BtnList.TextAlign = ContentAlignment.MiddleCenter;
            BtnList.Click += BtnList_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { güncelleToolStripMenuItem, silToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(121, 48);
            // 
            // güncelleToolStripMenuItem
            // 
            güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            güncelleToolStripMenuItem.Size = new Size(120, 22);
            güncelleToolStripMenuItem.Text = "Güncelle";
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(120, 22);
            silToolStripMenuItem.Text = "Sil";
            // 
            // grdbutton
            // 
            grdbutton.Caption = "Sil";
            grdbutton.ColumnEdit = repositoryItemButtonEdit1;
            grdbutton.FieldName = "Id";
            grdbutton.Name = "grdbutton";
            grdbutton.Visible = true;
            grdbutton.VisibleIndex = 10;
            // 
            // repositoryItemButtonEdit1
            // 
            repositoryItemButtonEdit1.AutoHeight = false;
            repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete) });
            repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryItemButtonEdit1.ButtonClick += repositoryItemButtonEdit1_ButtonClick;
            // 
            // FrmProductList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1161, 720);
            Controls.Add(BtnList);
            Controls.Add(label1);
            Controls.Add(cbstate);
            Controls.Add(LblInfo1);
            Controls.Add(cbtype);
            Controls.Add(grdControlproducts);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmProductList";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmProductList";
            Load += FrmProductList_Load;
            ((System.ComponentModel.ISupportInitialize)grdControlproducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdvwproducts).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdControlproducts;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvwproducts;
        private DevExpress.XtraGrid.Columns.GridColumn grdViewImage;
        private DevExpress.XtraGrid.Columns.GridColumn grdContent;
        private DevExpress.XtraGrid.Columns.GridColumn grdTitle;
        private DevExpress.XtraGrid.Columns.GridColumn grdType;
        private DevExpress.XtraGrid.Columns.GridColumn grdDay;
        private DevExpress.XtraGrid.Columns.GridColumn grdStatus;
        private DevExpress.XtraGrid.Columns.GridColumn grdMonth;
        private DevExpress.XtraGrid.Columns.GridColumn grdYear;
        private DevExpress.XtraGrid.Columns.GridColumn grdHour;
        private DevExpress.XtraGrid.Columns.GridColumn grdMinutes;
        private ComboBox cbtype;
        private Label LblInfo1;
        private Label label1;
        private Label BtnList;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem güncelleToolStripMenuItem;
        private ToolStripMenuItem silToolStripMenuItem;
        public ComboBox cbstate;
        private DevExpress.XtraGrid.Columns.GridColumn grdbutton;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}