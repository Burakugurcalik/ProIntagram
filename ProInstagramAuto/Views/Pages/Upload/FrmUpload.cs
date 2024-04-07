using BussinnesLayer.Concrate;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xabe.FFmpeg;

namespace ProIntagramAuto.Views.Pages
{
    public partial class FrmUpload : Form
    {
        public ProductModel model = new ProductModel();
        public ProductManager productManager = new ProductManager();
        Boolean modelsave = false;
        public FrmUpload()
        {
            InitializeComponent();
        }

        private void FrmUpload_Load(object sender, EventArgs e)
        {
            GetTitle(model);
            GetCbItems();
            GetItem();
        }

        public void GetTitle(ProductModel model)
        {
            String Title = "";
            switch (model.Type)
            {
                case 1: Title = "Gönderi Resimi "; opencontent.Filter = "Resim Uzantıları|*.jpg;*.jpeg;*.png;)"; break;
                case 2: Title = "Gönderi Video "; opencontent.Filter = "Video Uzantıları|*.mp4;*.avi;*.flv;)"; break;
                case 3: Title = "Stroy Resimi "; opencontent.Filter = "Resim Uzantıları|*.jpg;*.jpeg;*.png;)"; break;
                case 4: Title = "Stroy Video "; opencontent.Filter = "Video Uzantıları|*.mp4;*.avi;*.flv;)"; break;
                default:
                    break;
            }
            if (model.Id == 0)
            {
                Title += "Ekleme";
            }
            else
            {
                Title += "Güncelleme";
            }
            LblFormTitle.Text = Title;
        }

        private void btnSelectContent_Click(object sender, EventArgs e)
        {
            if (opencontent.ShowDialog() == DialogResult.OK)
            {
                txtline.Text = opencontent.FileName;
            }
        }
        public void GetCbItems()
        {
            cbDay.Items.Clear();
            cbHour.Items.Clear();
            cbMinutes.Items.Clear();
            cbMounth.Items.Clear();
            cbYear.Items.Clear();
            for (int year = DateTime.Now.Year; year < 2050; year++)
            {
                cbYear.Items.Add(year);
            }
            for (int mount = 1; mount < 13; mount++)
            {
                cbMounth.Items.Add(mount);
            }
            for (int day = 1; day < 32; day++)
            {
                cbDay.Items.Add(day);
            }
            for (int hour = 0; hour < 12; hour++)
            {
                cbHour.Items.Add(hour);
            }
            for (int minitues = 0; minitues < 60; minitues++)
            {
                cbMinutes.Items.Add(minitues);
            }

        }
        public void GetItem()
        {
            Lblinfo.Text = "";
            cbDay.Text = model.Day.ToString();
            cbHour.Text = model.Hour.ToString();
            cbMinutes.Text = model.Minutes.ToString();
            cbMounth.Text = model.Month.ToString();
            cbYear.Text = model.Year.ToString();
            txtline.Text = model.Content.ToString();
            txttitle.Text = model.Title.ToString();
            if (model.Viewimage.Length > 0)
            {
                pcView.Image = Image.FromFile(model.Viewimage);
            }
        }
        public void SetModel()
        {
            model.Day = Convert.ToInt16(cbDay.Text.ToString());
            model.Month= Convert.ToInt16(cbMounth.Text.ToString());
            model.Year= Convert.ToInt32(cbYear.Text.ToString());
            model.Hour= Convert.ToInt16(cbHour.Text.ToString());
            model.Minutes= Convert.ToInt16(cbMinutes.Text.ToString());
            model.Status = 1;
            model.Title=txttitle.Text.ToString();
            model.Content=txtline.Text.ToString();

        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            BtnSave.Visible = false;
            SetModel();
            Lblinfo.Text = "Kaydeliyor....";
            if (opencontent.FileName.ToString().Length > 0)
            {
                String FakePac = Application.StartupPath + "\\Upload\\" + opencontent.SafeFileName;
                model.Content = FakePac;
                try
                {
                   File.Copy(opencontent.FileName, FakePac, true);
                }
                catch (Exception iox)
                {

                }
            }
            bwsave.RunWorkerAsync();

        }

        private async void bwsave_DoWork(object sender, DoWorkEventArgs e)
        {
            if (model.Id == 0)
            {
                if (model.Type == 1 || model.Type == 3)
                {
                    model.Viewimage=model.Content.ToString();

                }
                modelsave = productManager.Insert(model);

            }
            else
            {
                modelsave = productManager.Update(model);
            }
            if (model.Type == 2 || model.Type == 4)
            {
                if (opencontent.FileName.ToString().Length > 0)
                {

                    Snapshot(model);
                    Thread.Sleep(5000);
                }

            }
        }

        private void bwsave_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (modelsave)
            {
                Lblinfo.Text = "Kaydedildi";
                pcView.Image = Image.FromFile(model.Viewimage);
            }
            else
            {
                Lblinfo.Text = "Kaydedilmedi!";
            }
            BtnSave.Visible = true;
        }
        public async void Snapshot(ProductModel model)
        {

            try
            {
                model.Viewimage = Application.StartupPath + "\\Upload\\" + opencontent.SafeFileName.Substring(0, opencontent.SafeFileName.IndexOf('.')) + ".jpg";// model.Content.Substring(0, model.Content.IndexOf('.')) + ".jpg";

                string ax = model.Content;
               
                var conversion = await FFmpeg.Conversions.FromSnippet.Snapshot(model.Content, model.Viewimage, TimeSpan.FromSeconds(1));

                await conversion.Start();
                productManager.Update(model);
            }
            catch (Exception ex)
            {

            
            }

        }

      
    }
}
