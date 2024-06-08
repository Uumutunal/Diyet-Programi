using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFDiyetProgramiProje_BL.Manager.Concrete;
using EFDiyetProgramiProje_BL.Models;
using EFDiyetProgramiProje_DAL.Context;
using EFDiyetProgramiProje_DAL.Entities;
using EFDiyetProgramiProje_PL.Properties;

namespace EFDiyetProgramiProje_PL
{
    public partial class YoneticiYemekGuncelleme : Form
    {
        YemekManager yemekManager = new YemekManager();
        YemekKategoriManager yemekKategori = new YemekKategoriManager();
        YemekViewModel yemek;
        public YoneticiYemekGuncelleme()
        {
            InitializeComponent();

            var kategoriler = yemekKategori.GetAll();

            foreach (var kategori in kategoriler)
            {
                cbKategoriSecGuncelleme.Items.Add(kategori.KategoriAdi);
                cbYeniKategori.Items.Add(kategori.KategoriAdi);
            }

            var yemekler = yemekManager.GetAll();

            foreach (var yemek in yemekler)
            {

                cbYemekSecGuncelleme.Items.Add(yemek.YemekAdi);
            }
        }

        private void cbKategoriSecGuncelleme_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbYemekSecGuncelleme.Items.Clear();
            var yemekler = yemekManager.GetAllWithIncludes();


            cbYeniKategori.Text = cbKategoriSecGuncelleme.Text;



            txtBirim.Text = "";
            txtKalori.Text = "";
            txtYemekAdiGuncelleme.Text = "";
            rtxtTarifiGuncelleme.Text = "";

            cbYemekSecGuncelleme.Text = "";

            foreach (var yemek in yemekler)
            {
                if (yemek.YemekKategori.KategoriAdi == cbKategoriSecGuncelleme.Text)
                    cbYemekSecGuncelleme.Items.Add(yemek.YemekAdi);
            }
        }

        private void cbYemekSecGuncelleme_SelectedIndexChanged(object sender, EventArgs e)
        {
            yemek = yemekManager.Search(s => s.YemekAdi == cbYemekSecGuncelleme.Text).FirstOrDefault();


            txtBirim.Text = yemek.Birim;
            txtKalori.Text = yemek.Kalori.ToString();
            txtYemekAdiGuncelleme.Text = yemek.YemekAdi;
            rtxtTarifiGuncelleme.Text = yemek.Tarif;
            //txtKategoriAdiGuncelleme.Text = yemek.YemekKategori.KategoriAdi;
            pbYemekGörseliGuncelleme.ImageLocation = yemek.Gorsel;

        }

        private void btnYemekOgunleEkle_Click(object sender, EventArgs e)
        {
            yemek.Birim = txtBirim.Text;

            if (cbYeniKategori.Text != cbKategoriSecGuncelleme.Text)
            {
                var yeniKategori = yemekKategori.Search(s => s.KategoriAdi == cbYeniKategori.Text).FirstOrDefault();
                yemek.YemekKategoriId = yeniKategori.Id;
            }

            bool kaloriDene = Double.TryParse(txtKalori.Text, out double kalori);

            if (kaloriDene)
                yemek.Kalori = kalori;

            yemek.YemekAdi = txtYemekAdiGuncelleme.Text;
            yemek.Tarif = rtxtTarifiGuncelleme.Text;
            yemek.Gorsel = pbYemekGörseliGuncelleme.ImageLocation;

            yemekManager.Update(yemek);
            MessageBox.Show("Yemek Güncellendi");
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            /*
            YemekKategoriViewModel yeniKategori = new YemekKategoriViewModel();
            yeniKategori.KategoriAdi = cbYeniKategori.Text;
            cbKategoriSecGuncelleme.Text = cbYeniKategori.Text;

            yemekKategori.Insert(yeniKategori);
            MessageBox.Show("Yeni Kategori Eklendi");

            cbYeniKategori.Items.Clear();
            cbKategoriSecGuncelleme.Items.Clear();
            var kategoriler = yemekKategori.GetAll();

            foreach (var kategori in kategoriler)
            {
                cbYeniKategori.Items.Add(kategori.KategoriAdi);
                cbKategoriSecGuncelleme.Items.Add(kategori.KategoriAdi);
            }
            */
            KullaniciYeniKategoriEkle kullaniciYeniKategoriEkle = new KullaniciYeniKategoriEkle();
            kullaniciYeniKategoriEkle.Show();

            cbKategoriSecGuncelleme.Items.Clear();

            var kategoriler = yemekKategori.GetAll();

            foreach (var kategori in kategoriler)
            {
                cbKategoriSecGuncelleme.Items.Add(kategori.KategoriAdi);
            }
            cbKategoriSecGuncelleme.Text = "Kategori seçiniz...";
        }

        private void pbYemekGörseliGuncelleme_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Image Files |*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Resim Seç"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbYemekGörseliGuncelleme.ImageLocation = openFileDialog.FileName;
            }
        }
    }
}
