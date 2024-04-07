using BussinnesLayer.Concrate;
using DataLayer.Temps;
using EntityLayer;
using ProInstagramAuto.Views.Pages;
using ProInstagramAuto.Views.Pages.List;
using ProIntagramAuto.Views.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProIntagramAuto.Views.Template
{
    public partial class FrmTemplate : Form
    {

        #region Varibles

        #region Drag-Drop
        bool FormMove = false;
        public Point StartLine = new Point(0, 0);//SÜRÜKLE BIRAK İÇİN KULLANILIR.-USED ​​FOR DRAG AND DRAG.
        public static Point ChildStartLine;
        #endregion
        #region Instagram
        InstagramManager instagramManager = new InstagramManager();
        #endregion
        #region Product
        public ProductManager productManager = new ProductManager();
        #endregion
        #endregion



        #region FORM

        #region CREATE
        public FrmTemplate()
        {
            InitializeComponent();
        }
        #endregion

        #region LOAD
        private void FrmTemplate_Load(object sender, EventArgs e)
        {
            OpenLogin(false);
            Staticlist.Dbpac = Application.StartupPath + "Data.db";
              LblUser.Text = Staticlist.Username;
            OpenMenu(0);
            getWorkerlist();
        }
        #endregion

        #region #FORM DRAG DROP ||  #FORM SÜRÜKLE BIRAK
        //SÜRÜKLE BIRAK İŞLEMİ BİR KAÇ METODTAN OLUŞUR.BU METODLAR FARENİN OLAYLARINI İÇERİR.- THE DROP BY PRODUCT CONSISTS OF A FEW METHODS. THESE METHODS INCLUDE THE EVENTS OF THE MOUSE.
        private void PnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            FormMove = true;
            this.Cursor = Cursors.SizeAll;
            StartLine = new Point(e.X, e.Y);
            ChildStartLine = new Point(e.X, e.Y);
        }

        private void PnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
            ChildStartLine = this.Location;
            FormMove = false;
        }

        private void PnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (FormMove)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.StartLine.X, p.Y - this.StartLine.Y);

            }
        }
        #endregion

        #region #FORM RESIZE || #FORM YENİDEN BOYUTLANDIRMA
        private void FrmTemplate_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {

                Hide();
                NIconProInstagram.Visible = true;




            }
        }

        #endregion

        #endregion

        #region FUNCTIONS

        #region MENUS

        #region OPEN MENUS
        public void OpenMenu(int Pageid)
        {
            CloseMdiParent();
            ClearBackgound();
            switch (Pageid)
            {
                case 0: OpenDashborad(); BtnMenu1.Image = ProInstagramAuto.Properties.Resources.opacly; break;
                case 1: OpenUpload(1); BtnMenu2.Image = ProInstagramAuto.Properties.Resources.opacly; break;
                case 2: OpenUpload(2); BtnMenu3.Image = ProInstagramAuto.Properties.Resources.opacly; break;
                case 3: OpenUpload(3); BtnMenu4.Image = ProInstagramAuto.Properties.Resources.opacly; break;
                case 4: OpenUpload(4); BtnMenu5.Image = ProInstagramAuto.Properties.Resources.opacly; break;
                case 5: OpenList(); BtnMenu6.Image = ProInstagramAuto.Properties.Resources.opacly; break;
                case 6: OpenErrorList(); BtnMenu6.Image = ProInstagramAuto.Properties.Resources.opacly; break;
                default:
                    break;
            }


        }

        #endregion
        #region MENU BUTTONS
        #region Nav Menu
        private void BtnMenu1_Click(object sender, EventArgs e)
        {
            OpenMenu(0);
        }
        private void BtnMenu2_Click(object sender, EventArgs e)
        {
            OpenMenu(1);
        }

        private void BtnMenu3_Click(object sender, EventArgs e)
        {
            OpenMenu(2);
        }

        private void BtnMenu4_Click(object sender, EventArgs e)
        {
            OpenMenu(3);
        }

        private void BtnMenu5_Click(object sender, EventArgs e)
        {
            OpenMenu(4);
        }
        private void BtnMenu7_Click(object sender, EventArgs e)
        {
            instagramManager.IsLogout(Staticlist.Username, Staticlist.Pass);
            Application.Exit();
        }
        private void BtnMenu6_Click(object sender, EventArgs e)
        {
            OpenMenu(5);
        }

        #endregion
        #region Header Menu
        private void BtnHeaderMenu4_Click(object sender, EventArgs e)
        {
            this.Hide();

            OpenLogin(true);
            this.Show();
        }

        private void BtnHeaderMenu1_Click(object sender, EventArgs e)
        {
            OpenMenu(5);
        }

        private void BtnHeaderMenu6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        private void BtnHeaderMenu2_Click(object sender, EventArgs e)
        {
            OpenMenu(6);
        }

        #endregion
        #region Fotter Menu
        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            PnlFotterMenu.Visible = !PnlFotterMenu.Visible;
        }
        private void FotterSubMenu1_Click(object sender, EventArgs e)
        {
            OpenMenu(1);
            PnlFotterMenu.Visible = !PnlFotterMenu.Visible;
        }

        private void FotterSubMenu2_Click(object sender, EventArgs e)
        {
            OpenMenu(2);
            PnlFotterMenu.Visible = !PnlFotterMenu.Visible;
        }

        private void FotterSubMenu3_Click(object sender, EventArgs e)
        {
            OpenMenu(3);
            PnlFotterMenu.Visible = !PnlFotterMenu.Visible;
        }

        private void FotterSubMenu4_Click(object sender, EventArgs e)
        {
            OpenMenu(4);
            PnlFotterMenu.Visible = !PnlFotterMenu.Visible;
        }
        private void NIconProInstagram_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
        #endregion
        #endregion

        #region CLEARBACKGOUND
        public void ClearBackgound()
        {
            BtnMenu1.Image = null; BtnMenu2.Image = null; BtnMenu3.Image = null; BtnMenu4.Image = null; BtnMenu5.Image = null; BtnMenu6.Image = null;

        }
        #endregion

        #region FOTTER SUB MENU COLOR CHANGE 
        private void FotterSubMenu_MouseHover(object sender, EventArgs e)
        {
            Label btn = (Label)sender;
            btn.BackColor = Color.FromArgb(77, 58, 193);
            //  "90; 66; 236"
        }

        private void FotterSubMenu_MouseLeave(object sender, EventArgs e)
        {
            Label btn = (Label)sender;
            btn.BackColor = Color.FromArgb(90, 66, 236);

        }
        #endregion

        #endregion

        #region MIDI PARENT
        #region Close
        public void CloseMdiParent()
        {


            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
        }
        #endregion

        #endregion

        #region PAGES
        #region DASHBOARD

        public void OpenDashborad()
        {

            Views.Pages.Dashboard.FrmDashboard frm = new Pages.Dashboard.FrmDashboard();
            frm.MdiParent = this;
            frm.Show();
        }
        #endregion
        #region OpenPages

        public void OpenList()
        {

            FrmProductList frm = new FrmProductList();
            frm.MdiParent = this;
            frm.Show();
        }
        public void OpenErrorList()
        {

            FrmProductList frm = new FrmProductList();
            frm.MdiParent = this;
            frm.senderror = true;
            frm.Show();
        }
        public void OpenUpload(int Type)
        {

            FrmUpload frm = new FrmUpload();
            frm.model.Type = Type;
            frm.MdiParent = this;
            frm.Show();
        }
        public void OpenLogin(Boolean send)
        {

            FrmInstagramUser frm = new FrmInstagramUser();
            frm.Location = ChildStartLine;
            frm.send = send;
            frm.ShowDialog();
        }
        #endregion
        #endregion

        #region Other

        #region Worker List
        public void getWorkerlist()
        {
            if (Staticlist.IsLogin && !bwinstagram.IsBusy)
            {
                Staticlist.WorkerProducs.Clear();
                Staticlist.WorkerProducs = productManager.List().Where(m =>(m.Status==1 || m.Status==2) &&  m.Day <= DateTime.Now.Day && m.Month <= DateTime.Now.Month && m.Year <= DateTime.Now.Year && m.Hour <= DateTime.Now.Hour && m.Minutes <= DateTime.Now.Minute).ToList();
                bwinstagram.RunWorkerAsync();
            }
        }

        #endregion
        #endregion
        #region BW
        private void bwinstagram_DoWork(object sender, DoWorkEventArgs e)
        {

            foreach (var item in Staticlist.WorkerProducs)
            {
                item.Status = 2;
                productManager.Update(item);
                if (item.Type == 1) { instagramManager.UploadPhoto(item); }
                else if (item.Type == 2){instagramManager.UploadVieo(item);  }
                else if (item.Type == 3) { instagramManager.UploadStoryPhoto(item);  }
                else if (item.Type == 4) { instagramManager.UploadStoryVieo(item);  }
            }
        }

        #endregion
        #region TİMER
        private void tmSendinstagram_Tick(object sender, EventArgs e)
        {
            getWorkerlist();
        }

        #endregion
        #endregion









  

 

 

       
    }
}
