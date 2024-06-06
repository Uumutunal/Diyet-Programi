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
        public YoneticiYemekSilme()
        {
            InitializeComponent();

            var kategoriler = yemekKategori.GetAll();

            foreach (var kategori in kategoriler)
            {
                cbKategoriSecSil.Items.Add(kategori.KategoriAdi);
            }

            var yemekler = yemekManager.GetAll();

            foreach (var yemek in yemekler)
            {

                cbYemekSecSil.Items.Add(yemek.YemekAdi);
            }

        }

        private void btnYemekOgunleEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var yemek = yemekManager.Search(s => s.YemekAdi == cbYemekSecSil.Text.ToString()).FirstOrDefault();
                int a = 2;

                yemekManager.Delete(yemek);

                MessageBox.Show("Yemek Silindi");
            }
            catch (Exception)
            {

                MessageBox.Show("silinemedi");

            }

        }

        private void cbKategoriSecSil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbYemekSecSil.Items.Clear();
            var yemekler = yemekManager.GetAllWithIncludes();

            foreach (var yemek in yemekler)
            {
                if (yemek.YemekKategori.KategoriAdi == cbKategoriSecSil.Text)
                    cbYemekSecSil.Items.Add(yemek.YemekAdi);
            }
        }
    }
}
