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
    public partial class YoneticiYemekSilme : Form
    {
        YemekManager yemekManager = new YemekManager();
        YemekKategoriManager yemekKategori = new YemekKategoriManager();

        YemekViewModel yeniYemek = new YemekViewModel();
        public YoneticiYemekSilme()
        {
            InitializeComponent();


            var kategoriler = yemekKategori.GetAll().ToList();

            foreach (var kategori in kategoriler)
            {
                cbKategoriSecSil.Items.Add(kategori.KategoriAdi);
            }

            var yemekler = yemekManager.GetAll().ToList();

            foreach (var yemek in yemekler)
            {

                cbYemekSecSil.Items.Add(yemek.YemekAdi);
            }

        }

        private void btnYemekOgunleEkle_Click(object sender, EventArgs e)
        {

            yeniYemek = yemekManager.Search(s => s.YemekAdi == cbYemekSecSil.Text.ToString()).FirstOrDefault();

            int a = 2;

            yemekManager.Delete(yeniYemek);

            MessageBox.Show("Yemek Silindi");
            cbYemekSecSil.Items.Clear();
            cbYemekSecSil.Text = "";

            var yemekler = yemekManager.GetAll().ToList();

            foreach (var yemek in yemekler)
            {

                cbYemekSecSil.Items.Add(yemek.YemekAdi);
            }

        }

        private void cbKategoriSecSil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbYemekSecSil.Items.Clear();
            var kategori = yemekKategori.Search(y => y.KategoriAdi == cbKategoriSecSil.Text).FirstOrDefault();
            var yemekler = yemekManager.Search(y => y.YemekKategoriId == kategori.Id);
            foreach (var yemek in yemekler)
            {
                cbYemekSecSil.Items.Add(yemek.YemekAdi);
            }
        }

        private void cbYemekSecSil_SelectedIndexChanged(object sender, EventArgs e)
        {

            yeniYemek = yemekManager.Search(s => s.YemekAdi == cbYemekSecSil.Text.ToString()).FirstOrDefault();

            rtxtTarifiGuncelleme.Text = yeniYemek.Tarif;
            //pbYemekGörseliGuncelleme = yemek.Gorsel;
            if (yeniYemek.Gorsel != null)
            {
                using (MemoryStream ms = new MemoryStream(yeniYemek.Gorsel))
                {

                    pbYemekGörseliGuncelleme.SizeMode = PictureBoxSizeMode.Zoom;

                    pbYemekGörseliGuncelleme.Image = Image.FromStream(ms);
                }
            }
        }
    }
}
