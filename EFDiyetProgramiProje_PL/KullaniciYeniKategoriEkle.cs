using EFDiyetProgramiProje_BL.Manager.Concrete;
using EFDiyetProgramiProje_BL.Models;
using EFDiyetProgramiProje_DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDiyetProgramiProje_PL
{
    public partial class KullaniciYeniKategoriEkle : Form
    {
        YemekKategoriManager yemekKategoriManager = new YemekKategoriManager();
        public KullaniciYeniKategoriEkle()
        {
            InitializeComponent();
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            YemekKategoriViewModel yeniKategori = new YemekKategoriViewModel();
            yeniKategori.KategoriAdi = txtYeniKategoriEkle.Text;

            yemekKategoriManager.Insert(yeniKategori);
            MessageBox.Show("Yeni Kategori Eklendi");

            this.Hide();
        }
    }
}
