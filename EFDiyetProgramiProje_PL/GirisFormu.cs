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
            {
                txtSifre.UseSystemPasswordChar = false;
                chkSifreyiGoster.Text = "�ifreyi Gizle";
            }
            else
            {
                txtSifre.UseSystemPasswordChar = true;
                chkSifreyiGoster.Text = "�ifreyi G�ster";
            }
                
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            var admin = kullaniciManager.Search(k => k.KullaniciAdi == "admin").FirstOrDefault();
            var kullanici = kullaniciManager.Search(k => k.KullaniciAdi == txtKullaniciAdi.Text).FirstOrDefault();
            if (txtKullaniciAdi.Text == null || txtSifre.Text == null)
            {
                MessageBox.Show("Kullan�c� ad� ve �ifre bo� b�rak�lamaz! L�tfen yukar�daki k�s�mlar� doldurun!");
            }
            else if (txtKullaniciAdi.Text == admin.KullaniciAdi && txtSifre.Text == admin.Sifre)
            {

                MessageBox.Show("Admin giri�i ba�ar�l�!");
                this.Hide();
                YoneticiKontrolPaneli yoneticiKontrolPaneli = new YoneticiKontrolPaneli();
                yoneticiKontrolPaneli.ShowDialog();
                this.Close();
            }
            else if (kullanici == null)
            {
                MessageBox.Show("B�yle bir kullan�c� bulunamad�! L�tfen kullan�c� ad�n�z� ve �ifrenizi tekrar giriniz!");
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
                MessageBox.Show("Kullan�c� bulunamad�, kullan�c� ad�n� do�ru girdi�inizden amin olun!");
            }
        }
    }
}
