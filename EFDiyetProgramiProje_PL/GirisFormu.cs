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
                chkSifreyiGoster.Text = "Þifreyi Gizle";
            }
            else
            {
                txtSifre.UseSystemPasswordChar = true;
                chkSifreyiGoster.Text = "Þifreyi Göster";
            }
                
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            var admin = kullaniciManager.Search(k => k.KullaniciAdi == "admin").FirstOrDefault();
            var kullanici = kullaniciManager.Search(k => k.KullaniciAdi == txtKullaniciAdi.Text).FirstOrDefault();
            if (txtKullaniciAdi.Text == null || txtSifre.Text == null)
            {
                MessageBox.Show("Kullanýcý adý ve Þifre boþ býrakýlamaz! Lütfen yukarýdaki kýsýmlarý doldurun!");
            }
            else if (txtKullaniciAdi.Text == admin.KullaniciAdi && txtSifre.Text == admin.Sifre)
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
                MessageBox.Show("Kullanýcý bulunamadý, kullanýcý adýný doðru girdiðinizden amin olun!");
            }
        }
    }
}
