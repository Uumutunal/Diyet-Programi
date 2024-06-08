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
    public partial class YoneticiYemekEkle : Form
    {

        YemekManager yemekManager = new YemekManager();
        YemekKategoriManager yemekKategori = new YemekKategoriManager();
        string imageDirectory;
        public YoneticiYemekEkle()
        {
            InitializeComponent();

            imageDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");

            if (!Directory.Exists(imageDirectory))
            {
                Directory.CreateDirectory(imageDirectory);
            }

            var kategoriler = yemekKategori.GetAll();

            foreach (var kategori in kategoriler)
            {
                cbKategoriSec.Items.Add(kategori.KategoriAdi);
            }

        }

        private void btnYemekOgunleEkle_Click(object sender, EventArgs e)
        {
            YemekViewModel yeniYemek = new YemekViewModel();

            yeniYemek.YemekAdi = txtYemekAdi.Text;
            yeniYemek.Tarif = rtxtTarifi.Text;
            string kategoriAdi = (string)(cbKategoriSec.SelectedItem);

            var kategori = yemekKategori.Search(s => s.KategoriAdi == kategoriAdi).FirstOrDefault();
            yeniYemek.YemekKategoriId = kategori.Id;

            bool kaloriDene = Double.TryParse(txtKalori.Text, out double kalori);

            if (kaloriDene)
                yeniYemek.Kalori = kalori;

            yeniYemek.Birim = txtBirim.Text;
            //görseli düzelt

            yeniYemek.Gorsel = pbYemekGörseli.ImageLocation;

            string ImagePath = pbYemekGörseli.ImageLocation;
            string savedImagePath = null;
            if (!string.IsNullOrEmpty(ImagePath))
            {
                string extension = Path.GetExtension(ImagePath);
                string fileName = Guid.NewGuid().ToString() + extension;
                savedImagePath = Path.Combine(imageDirectory, fileName);
                File.Copy(ImagePath, savedImagePath);
            }


            yemekManager.Insert(yeniYemek);

            MessageBox.Show("Yeni Yemek Eklendi");
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            /*
            YemekKategoriViewModel yeniKategori = new YemekKategoriViewModel();
            yeniKategori.KategoriAdi = cbKategoriSec.Text;

            yemekKategori.Insert(yeniKategori);
            MessageBox.Show("Yeni Kategori Eklendi");

            cbKategoriSec.Items.Clear();
            var kategoriler = yemekKategori.GetAll();

            foreach (var kategori in kategoriler)
            {
                cbKategoriSec.Items.Add(kategori.KategoriAdi);
            }
            */
            KullaniciYeniKategoriEkle kullaniciYeniKategoriEkle = new KullaniciYeniKategoriEkle();
            kullaniciYeniKategoriEkle.Show();

            cbKategoriSec.Items.Clear();

            var kategoriler = yemekKategori.GetAll();

            foreach (var kategori in kategoriler)
            {
                cbKategoriSec.Items.Add(kategori.KategoriAdi);
            }
            cbKategoriSec.Text = "Kategori seçiniz...";

        }

        private void pbYemekGörseli_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Image Files |*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Resim Seç"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbYemekGörseli.ImageLocation = openFileDialog.FileName;
            }
        }
    }
}
