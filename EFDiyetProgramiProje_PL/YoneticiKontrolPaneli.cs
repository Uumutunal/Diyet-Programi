using EFDiyetProgramiProje_BL.Manager.Concrete;
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
    public partial class YoneticiKontrolPaneli : Form
    {

        public YoneticiKontrolPaneli()
        {
            InitializeComponent();
        }

        private void btnOgunEkleme_Click(object sender, EventArgs e)
        {
            YoneticiOgunEkle yoneticiOgunEkle = new YoneticiOgunEkle();
            yoneticiOgunEkle.ShowDialog();
        }

        private void btnOgunGuncelleme_Click(object sender, EventArgs e)
        {
            YoneticiOgunGuncelle yoneticiOgunGuncelle = new YoneticiOgunGuncelle();
            yoneticiOgunGuncelle.ShowDialog();
        }

        private void btnOgunSilme_Click(object sender, EventArgs e)
        {
            YoneticiOgunSilme yoneticiOgunSilme = new YoneticiOgunSilme();
            yoneticiOgunSilme.ShowDialog();
        }

        private void btnYemekEkleme_Click(object sender, EventArgs e)
        {
            YoneticiYemekEkle yoneticiYemekEkle = new YoneticiYemekEkle();
            yoneticiYemekEkle.ShowDialog();
        }

        private void btnYemekGuncelleme_Click(object sender, EventArgs e)
        {
            YoneticiYemekGuncelleme yoneticiYemekGuncelleme = new YoneticiYemekGuncelleme();
            yoneticiYemekGuncelleme.ShowDialog();
        }

        private void btnYemekSilme_Click(object sender, EventArgs e)
        {
            YoneticiYemekSilme yoneticiYemekSilme = new YoneticiYemekSilme();
            yoneticiYemekSilme.ShowDialog();
        }

        private void btnKullanicilariGoruntule_Click(object sender, EventArgs e)
        {
            YoneticiKullanicilariGoruntule yoneticiKullanicilariGoruntule = new YoneticiKullanicilariGoruntule();
            yoneticiKullanicilariGoruntule.ShowDialog();
        }

        private void btnRaporGoster_Click(object sender, EventArgs e)
        {
            YoneticiRaporEkrani yoneticiRaporEkrani = new YoneticiRaporEkrani();
            yoneticiRaporEkrani.ShowDialog();
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            YoneticiSifreDegistir yoneticiSifreDegistir =new YoneticiSifreDegistir();
            yoneticiSifreDegistir.ShowDialog();
        }
    }
}
