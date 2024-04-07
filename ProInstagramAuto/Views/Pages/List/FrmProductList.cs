using BussinnesLayer.Concrate;
using DevExpress.XtraEditors;
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

namespace ProInstagramAuto.Views.Pages.List
{
    public partial class FrmProductList : Form
    {
        public ProductManager productManager = new ProductManager();
        public int state = 0;
        public Boolean senderror = false;
        public FrmProductList()
        {
            InitializeComponent();
        }

        private void FrmProductList_Load(object sender, EventArgs e)
        {

            resetcb();
            fillgrd();
            //  gridControl1.DataSource = productManager.List().OrderByDescending(m => m.Id);
        }

        public void resetcb()
        {
            cbstate.SelectedIndex = 0;
            cbtype.SelectedIndex = 0;
        }
        public void fillgrd()
        {
            IOrderedEnumerable<ProductModel> products;
            state = cbstate.SelectedIndex;
            int type = cbtype.SelectedIndex;
            if (senderror == false)
            {
                if (state == 0 && type == 0) { products = productManager.List().OrderByDescending(m => m.Id); }
                else if (state == 0) { products = productManager.List().Where(m => m.Type == type).OrderByDescending(m => m.Id); }
                else if (type == 0) { products = productManager.List().Where(m => m.Status == state).OrderByDescending(m => m.Id); }
                else { products = productManager.List().Where(m => m.Status == state && m.Type == type).OrderByDescending(m => m.Id); }
            }
            else
            {
                cbstate.SelectedIndex = 4;
                products = productManager.List().Where(m => m.Status == 4).OrderByDescending(m => m.Id);
                senderror = false;
            }
            grdControlproducts.DataSource = products;
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            fillgrd();
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("Gerçekten silmek istiyor musun?","Dikkat",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                int id = (grdvwproducts.GetFocusedRow() as ProductModel).Id;
                productManager.Delete(id);
                fillgrd();

            }
        }
    }
}
