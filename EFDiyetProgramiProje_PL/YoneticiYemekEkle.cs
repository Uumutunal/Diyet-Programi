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

        public YoneticiYemekEkle()
        {
            InitializeComponent();

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
            //yeniYemek.Gorsel = pbYemekGörseli.Text;


            yemekManager.Insert(yeniYemek);

            MessageBox.Show("Yeni Yemek Eklendi");  
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
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
        }
    }
}
