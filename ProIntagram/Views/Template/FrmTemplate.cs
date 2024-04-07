using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProIntagram.Views.Template
{
    public partial class FrmTemplate : Form
    {
        public FrmTemplate()
        {
            InitializeComponent();
        }
        #region Varibles

        #region Drag-Drop
        bool FormMove = false;
        public Point StartLine = new Point(0, 0);//SÜRÜKLE BIRAK İÇİN KULLANILIR.-USED ​​FOR DRAG AND DRAG.
        public static Point ChildStartLine;
        #endregion
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
        #region FUNCTIONS
        #region MENUS
        #region OPEN MENUS
        public void OpenMenu(int Pageid)
        {
            CloseMdiParent();
            ClearBackgound();
            switch (Pageid)
            {
                case 0: OpenDashborad(); BtnMenu1.Image = Properties.Resources.opacly; break;
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
        private void BtnMenu7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region Header Menu

        #endregion
        #region Fotter Menu
        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            PnlFotterMenu.Visible = !PnlFotterMenu.Visible;
        }

        #endregion
        #endregion

        #region CLEARBACKGOUND
        public void ClearBackgound()
        {
            BtnMenu1.Image = null; BtnMenu2.Image=null; BtnMenu3.Image = null; BtnMenu4.Image = null; BtnMenu5.Image = null; BtnMenu6.Image = null;
           
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

            //; Views.Pages.Dashboard.FrmDashboard frm = new Pages.Dashboard.FrmDashboard();
            //frm.MdiParent = this;
            //frm.Show();
        }
        #endregion

        #endregion

        #endregion




    }
}
