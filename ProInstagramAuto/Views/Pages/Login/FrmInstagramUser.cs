using BussinnesLayer.Concrate;
using DataLayer.Temps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProInstagramAuto.Views.Pages
{
    public partial class FrmInstagramUser : Form
    {
        #region Varibles
        #region Drag-Drop
        public bool send = false;
        bool FormMove = false;
        public Point StartLine = new Point(0, 0);//SÜRÜKLE BIRAK İÇİN KULLANILIR.-USED ​​FOR DRAG AND DRAG.
        public static Point ChildStartLine;
        #endregion
        #region Instagram
        InstagramManager manager = new InstagramManager();
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
        #region From Events
        public FrmInstagramUser()
        {
            InitializeComponent();
        }



        private void FrmInstagramUser_Load(object sender, EventArgs e)
        {
            LblInfo.Text = "";
            chcAutoLogin.Checked = UserSettings.Default.AutoLogin;
            chcMe.Checked = UserSettings.Default.Rememberme;
            if (UserSettings.Default.AutoLogin && send == false)
            {
                txtUser.Text = UserSettings.Default.UserName;
                txtPass.Text = UserSettings.Default.Pass;
                LblInfo.Text = "Giriş Yapılıyor....";
                BtnLogin.Visible = false;
                BwLogin.RunWorkerAsync();
            }
            if (UserSettings.Default.Rememberme)
            {
                txtUser.Text = UserSettings.Default.UserName;
                txtPass.Text = UserSettings.Default.Pass;
            }
        }


        #endregion
        #region Function

        #region Buttons
        private void lblClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LblInfo.Text = "Giriş Yapılıyor....";
            BtnLogin.Visible = false;
            BwLogin.RunWorkerAsync();
        }

        #endregion
        #region ChechkBoxs
        private void chcAutoLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (chcAutoLogin.Checked) { chcMe.Checked = true; }
        }

        #endregion
        #region Background Worker
        private void BwLogin_DoWork(object sender, DoWorkEventArgs e)
        {
            manager.IsLogout(txtUser.Text.ToString(), txtPass.Text.ToString());
            manager.IsLogin(txtUser.Text.ToString(), txtPass.Text.ToString());
            Thread.Sleep(10000);
        }

        private void BwLogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BtnLogin.Visible = true;
            if (Staticlist.IsLogin)
            {
                UserSettings.Default.AutoLogin = chcAutoLogin.Checked;
                UserSettings.Default.Rememberme = chcMe.Checked;
                UserSettings.Default.UserName = txtUser.Text.ToString();
                UserSettings.Default.Pass = txtPass.Text.ToString();
                UserSettings.Default.Save();
                Staticlist.Username = txtUser.Text.ToString();
                Staticlist.Pass= txtPass.Text.ToString();
                this.Close();

            }
            else
            {
                LblInfo.Text = "Kullanıcı Adı ve Şifre Yanlış!";
            }

        }

        #endregion
        #endregion

    }
}
