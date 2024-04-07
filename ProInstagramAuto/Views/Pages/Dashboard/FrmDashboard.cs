using BussinnesLayer.Concrate;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProIntagramAuto.Views.Pages.Dashboard
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }
        ProductManager productManager = new ProductManager();
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            getFill();
        }
        public void getFill()
        {
            List<ProductModel> product = productManager.List();
            lblinfodata1.Text=product.Where(m=>m.Type==1).Count().ToString();
            lblinfodata2.Text = product.Where(m => m.Type == 2).Count().ToString();
            lblinfodata3.Text = product.Where(m => m.Type == 1 || m.Type==2).Count().ToString();
            lblinfodata4.Text = product.Where(m => m.Type == 3).Count().ToString();
            lblinfodata5.Text = product.Where(m => m.Type == 4).Count().ToString();
            lblinfodata6.Text = product.Where(m => (m.Type == 3 || m.Type == 4)).Count().ToString();

            lblinfodata7.Text = product.Where(m => m.Type == 1 && m.Status==1).Count().ToString();
            lblinfodata8.Text = product.Where(m => m.Type == 2 && m.Status == 1).Count().ToString();
            lblinfodata9.Text = product.Where(m => (m.Type == 1 || m.Type == 2) && m.Status == 1).Count().ToString();
            lblinfodata10.Text = product.Where(m => m.Type == 3 && m.Status == 1).Count().ToString();
            lblinfodata11.Text = product.Where(m => m.Type == 4 && m.Status == 1).Count().ToString();
            lblinfodata12.Text = product.Where(m => (m.Type == 3 || m.Type == 4) && m.Status == 1).Count().ToString();

            lblinfodata13.Text = product.Where(m => m.Type == 1 && m.Status == 4).Count().ToString();
            lblinfodata14.Text = product.Where(m => m.Type == 2 && m.Status == 4).Count().ToString();
            lblinfodata15.Text = product.Where(m => (m.Type == 1 || m.Type == 2) && m.Status == 4).Count().ToString();
            lblinfodata16.Text = product.Where(m => m.Type == 3 && m.Status == 4).Count().ToString();
            lblinfodata17.Text = product.Where(m => m.Type == 4 && m.Status == 4).Count().ToString();
            lblinfodata18.Text = product.Where(m => (m.Type == 3 || m.Type == 4) && m.Status == 4).Count().ToString();
        }

        private void tmrfill_Tick(object sender, EventArgs e)
        {
            getFill();
        }
    }
}
