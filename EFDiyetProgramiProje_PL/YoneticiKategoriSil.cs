using EFDiyetProgramiProje_BL.Manager.Concrete;
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
    public partial class YoneticiKategoriSil : Form
    {

        YemekKategoriManager yemekKategori = new YemekKategoriManager();
        public YoneticiKategoriSil()
        {
            InitializeComponent();

            var kategoriler = yemekKategori.GetAll();

            foreach (var kategori in kategoriler)
            {
                cbKategoriSil.Items.Add(kategori.KategoriAdi);
            }
            cbKategoriSil.Text = "Silmek istediğiniz kategoriyi seçiniz...";
        }

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            var kategori = yemekKategori.Search(s => s.KategoriAdi == cbKategoriSil.Text).FirstOrDefault();

            if(kategori != null)
            {
                yemekKategori.Delete(kategori);
                MessageBox.Show("Kategori Silindi.");   
            }

        }
    }
}
