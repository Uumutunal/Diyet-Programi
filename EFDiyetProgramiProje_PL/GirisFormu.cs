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
        KullaniciViewModel kullanici;


        public GirisFormu()
        {
            InitializeComponent();

        }


        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            KayitFormu yeniKayitFormu = new KayitFormu();
            yeniKayitFormu.ShowDialog();
        }

        private void txtSifre_Enter(object sender, EventArgs e)
        {
            var kullanici = kullaniciManager.Search(k => k.KullaniciAdi == txtKullaniciAdi.Text).FirstOrDefault();
            if (kullanici != null)
            {
                txtSifre.Text = kullanici.HatirlaSifre;
            }
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
            string adminsifre = "123";
            string sifrelenmis = Sha256Hasher.ComputeSha256Hash(txtSifre.Text);
            var kullanici = kullaniciManager.Search(k => k.KullaniciAdi == txtKullaniciAdi.Text && k.Sifre == sifrelenmis).FirstOrDefault();
            if (txtKullaniciAdi.Text == null || txtSifre.Text == null)
            {
                MessageBox.Show("Kullanýcý adý ve Þifre boþ býrakýlamaz! Lütfen yukarýdaki kýsýmlarý doldurun!");
            }
            else if (txtKullaniciAdi.Text == "admin" && txtSifre.Text == adminsifre)
            {

                MessageBox.Show("Admin giriþi baþarýlý!");
                this.Hide();
                YoneticiKontrolPaneli yoneticiKontrolPaneli = new YoneticiKontrolPaneli();
                yoneticiKontrolPaneli.ShowDialog();
                this.Close();
            }
            else if (kullanici == null)
            {
                MessageBox.Show("Böyle bir kullanýcý bulunamadý! Lütfen kullanýcý adýnýzý ve þifrenizi tekrar giriniz!");
            }
            else
            {

                MessageBox.Show("Kullanýcý giriþi baþarýlý!");

                int kullaniciId = kullanici.Id;
                KullaniciKontrolPaneli kullaniciKontrolPaneli = new KullaniciKontrolPaneli(kullaniciId);
                this.Hide();
                kullaniciKontrolPaneli.ShowDialog();
                this.Show();
            }
        }

        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            SifremiUnuttum sifremiUnuttum = new SifremiUnuttum();
            this.Hide();
            sifremiUnuttum.ShowDialog();
            this.Show();
        }

        private void chkBeniHatirla_CheckedChanged(object sender, EventArgs e)
        {
            var kullanici = kullaniciManager.Search(k => k.KullaniciAdi == txtKullaniciAdi.Text).FirstOrDefault();
            if (kullanici != null)
            {
                kullanici.HatirlaSifre = txtSifre.Text;
                kullaniciManager.Update(kullanici);
            }
            


        }

 
    }
}
