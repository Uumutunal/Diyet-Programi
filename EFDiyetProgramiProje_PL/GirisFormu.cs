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
            yeniKayitFormu.Show();
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
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
            string adminsifre = "Aa1234.5";
            string sifrelenmis = Sha256Hasher.ComputeSha256Hash(txtSifre.Text);
            var kullanici = kullaniciManager.Search(k => k.KullaniciAdi == txtKullaniciAdi.Text && k.Sifre == sifrelenmis).FirstOrDefault();
            if (txtKullaniciAdi.Text==null||txtSifre.Text==null)
            {
                MessageBox.Show("Kullan�c� ad� ve �ifre bo� b�rak�lamaz! L�tfen yukar�daki k�s�mlar� doldurun!");
            }
            else if (txtKullaniciAdi.Text == "admin" && txtSifre.Text==adminsifre)
            {
                
                MessageBox.Show("Admin giri�i ba�ar�l�!");
                this.Hide();
                YoneticiKontrolPaneli yoneticiKontrolPaneli = new YoneticiKontrolPaneli();
                yoneticiKontrolPaneli.ShowDialog();
            }
            else if (kullanici == null)
            {
                MessageBox.Show("B�yle bir kullan�c� bulunamad�! L�tfen kullan�c� ad�n�z� ve �ifrenizi tekrar giriniz!");
            }
            else
            {
                
                MessageBox.Show("Kullan�c� giri�i ba�ar�l�!");

                int kullaniciId = kullanici.Id;
                KullaniciKontrolPaneli kullaniciKontrolPaneli = new KullaniciKontrolPaneli(kullaniciId);
                kullaniciKontrolPaneli.ShowDialog();
                this.Close();
            }
        }
    }
}
