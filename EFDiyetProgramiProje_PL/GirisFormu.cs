using EFDiyetProgramiProje_BL.Manager.Concrete;
using EFDiyetProgramiProje_BL.Models;
using EFDiyetProgramiProje_DAL.Entities;
using EFDiyetProgramiProje_DAL.Enums;
using EFDiyetProgramiProje_DAL.Repository.Abstract;
using EFDiyetProgramiProje_PL.StaticMethods;
using System.Reflection;

namespace EFDiyetProgramiProje_PL
{
    public partial class GirisFormu : Form
    {
        KullaniciManager kullaniciManager = new KullaniciManager();


        public GirisFormu()
        {
            InitializeComponent();

        }


        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            KayitFormu yeniKayitFormu = new KayitFormu();
            yeniKayitFormu.ShowDialog();
        }


        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
            chkSifreyiGoster.Checked = false;
        }
        private void chkSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSifreyiGoster.Checked)
                txtSifre.UseSystemPasswordChar = false;
            else
                txtSifre.UseSystemPasswordChar = true;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            string sifrelenmisSifre = Sha256Hasher.ComputeSha256Hash(txtSifre.Text);

            var kullanici = kullaniciManager.Search(k => k.KullaniciAdi == txtKullaniciAdi.Text).FirstOrDefault();
            var sifre = kullaniciManager.Search(k => k.Sifre == sifrelenmisSifre && k.KullaniciAdi == txtKullaniciAdi.Text).FirstOrDefault();

            if (txtKullaniciAdi.Text == null || txtSifre.Text == null)
            {
                MessageBox.Show("Kullan�c� ad� ve �ifre bo� b�rak�lamaz! L�tfen yukar�daki k�s�mlar� doldurun!");
            }
            else if (kullanici == null)
            {
                MessageBox.Show("B�yle bir kullan�c� bulunamad�! L�tfen kullan�c� ad�n�z� ve �ifrenizi tekrar giriniz!");
            }
            else if (kullanici.KullaniciAdi == "admin" && kullanici.Sifre == txtSifre.Text)
            {

                MessageBox.Show("Admin giri�i ba�ar�l�!");
                txtKullaniciAdi.Text = "";
                txtSifre.Text = "";
                this.Hide();
                YoneticiKontrolPaneli yoneticiKontrolPaneli = new YoneticiKontrolPaneli();
                yoneticiKontrolPaneli.ShowDialog();
                this.Show();
            }
            else if (kullanici != null && sifre == null)
            {
                MessageBox.Show("Hatal� �ifre girdiniz, tekrar deneyiniz!");
            }
            else
            {

                MessageBox.Show("Kullan�c� giri�i ba�ar�l�!");

                txtKullaniciAdi.Text = "";
                txtSifre.Text = "";

                int kullaniciId = kullanici.Id;
                KullaniciKontrolPaneli kullaniciKontrolPaneli = new KullaniciKontrolPaneli(kullaniciId);
                this.Hide();
                kullaniciKontrolPaneli.ShowDialog();
                this.Show();
            }   
        }

        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            var kullanici = kullaniciManager.Search(s => s.KullaniciAdi == txtKullaniciAdi.Text).FirstOrDefault();
            if (kullanici != null)
            {
                SifremiUnuttum sifremiUnuttum = new SifremiUnuttum(txtKullaniciAdi.Text);

                sifremiUnuttum.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Kullan�c� bulunamad�, kullan�c� ad�n� do�ru girdi�inizden emin olun!");
            }
        }
    }
}
