using EFDiyetProgramiProje_BL.Manager.Concrete;
using EFDiyetProgramiProje_DAL.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFDiyetProgramiProje_BL.Models;
using EFDiyetProgramiProje_DAL.Entities;
using EFDiyetProgramiProje_DAL.Enums;

namespace EFDiyetProgramiProje_PL
{
    public partial class KullaniciKontrolPaneli : Form
    {
        KullaniciManager kullaniciManager = new KullaniciManager();
        KullaniciBilgiManager kullaniciBilgiManager =new KullaniciBilgiManager();
        private int kullaniciId;
        public KullaniciKontrolPaneli(int mevcutKullaniciId)
        {
            InitializeComponent();
            kullaniciId = mevcutKullaniciId;
            var mevcutKullaniciBilgileri = kullaniciBilgiManager.Search(k => k.KullaniciId== kullaniciId).FirstOrDefault();

            if (mevcutKullaniciBilgileri == null)
            {
                //this.Close();
                MessageBox.Show("Yeni kayıt yaptığınız için öncelikle kullanıcı bilgilerinizi girmelisiniz!");
                KullaniciBilgileri kullaniciBilgileri = new KullaniciBilgileri(kullaniciId);
                kullaniciBilgileri.ShowDialog();
            }
            else
            {
                var kullaniciBilgileri = kullaniciBilgiManager.Search(k => k.KullaniciId == kullaniciId).FirstOrDefault(); 
                lblGunlukHedefKalori.Text = Convert.ToString(kullaniciBilgileri.GunlukHedefKalori);
                lblBMI.Text = Convert.ToString(kullaniciBilgileri.VucutKitleEndeksi);
                lblBMR.Text = Convert.ToString(kullaniciBilgileri.BazalMetabolizmaHizi);
                lblBoy.Text = Convert.ToString(kullaniciBilgileri.Boy);
                lblYas.Text = Convert.ToString(kullaniciBilgileri.Yas);
                lblHedefKilo.Text = Convert.ToString(kullaniciBilgileri.HedefKilo);
                lblKilo.Text = Convert.ToString(kullaniciBilgileri.Kilo);
                lblCinsiyet.Text = kullaniciBilgileri.Cinsiyet;
            }
        }

        private void btnKullaniciBilgiGuncelle_Click(object sender, EventArgs e)
        {
            //this.Close();
            KullaniciBilgileri kullaniciBilgileri = new KullaniciBilgileri(kullaniciId);
            kullaniciBilgileri.ShowDialog();
        }

    }
}
