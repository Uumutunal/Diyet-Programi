using EFDiyetProgramiProje_BL.Manager.Concrete;
using EFDiyetProgramiProje_BL.Models;
using EFDiyetProgramiProje_DAL.Entities;
using EFDiyetProgramiProje_PL.Properties;
using EFDiyetProgramiProje_PL.StaticMethods;
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
    public partial class KullaniciGuncelle : Form
    {
        KullaniciManager kullaniciManager = new KullaniciManager();
        KullaniciViewModel kullaniciViewModel;
        KullaniciKontrolPaneli kullaniciKontrolPanel;
        private int kullaniciId;
        public KullaniciGuncelle(int mevcutkullaniciId)
        {
            InitializeComponent();
            kullaniciId = mevcutkullaniciId;
        }

        private void btnKullaniciGuncelle_Click(object sender, EventArgs e)
        {

            var kullaniciViewModel = kullaniciManager.Search(k => k.Id == kullaniciId).FirstOrDefault();
            string sifre = txtSifre.Text;
            string sifrelenmis = Sha256Hasher.ComputeSha256Hash(sifre);
            string mevcutSifre = kullaniciViewModel.Sifre;
            if (sifrelenmis != mevcutSifre)
            {
                MessageBox.Show("Mevcut şifrenizi doğru girmediniz! Lütfen şifrenizi tekrar giriniz!");
            }
            else
            {
                bool SembolIceriyorMu(string metin)
                {
                    foreach (char karakter in metin)
                    {
                        if (!char.IsLetterOrDigit(karakter) && !char.IsWhiteSpace(karakter))
                        {
                            return true;
                        }
                    }
                    return false;
                }

                bool KucukHarfIceriyormu(string metin)
                {
                    foreach (char karakter in metin)
                    {
                        if (char.IsLower(karakter))
                        {
                            return true;
                        }
                    }
                    return false; ;
                }

                bool BuyukHarfIceriyorMu(string metin)
                {
                    foreach (char karakter in metin)
                    {
                        if (char.IsUpper(karakter))
                        {
                            return true;
                        }
                    }
                    return false;
                }
                bool MetinRakamIceriyorMu(string metin)
                {
                    foreach (char karakter in metin)
                    {
                        if (char.IsDigit(karakter))
                        {
                            return true;
                        }
                    }
                    return false;
                }
                string kullaniciAdi = txtYeniKullaniciAdi.Text;
                string yeniSifre = txtYeniSifre.Text;
                string yeniSifreTekrar = txtYeniSifreTekrar.Text;
                string guvenlikSorusu = cmbYeniGuvenlikSorusu.Text;
                string guvenlikYaniti = txtYeniGuvenlikSorusuYaniti.Text;
                string yeniSifreSifrelenmis = Sha256Hasher.ComputeSha256Hash(yeniSifre);
                if (kullaniciAdi == null || yeniSifre == null || yeniSifreTekrar == null || guvenlikSorusu == null || guvenlikYaniti == null)
                {
                    MessageBox.Show("Yukarıdaki kısımlar boş bırakılamaz. Lütfen tüm kısımları doldurunuz!");
                }
                else if (yeniSifre.Length < 8)
                {
                    MessageBox.Show("Şifre 8 karakterden uzun olmak zorundadır. Lütfen daha uzun şifre giriniz!");
                }
                else if (!BuyukHarfIceriyorMu(yeniSifre) || !KucukHarfIceriyormu(yeniSifre) || !MetinRakamIceriyorMu(yeniSifre) || !SembolIceriyorMu(yeniSifre))
                {
                    MessageBox.Show("Şifre içerisinde büyük harf, küçük harf, rakam  ve sembol bulunmak zorundadır. Lütfen başka bir şifre deneyiniz!");
                }
                else if (yeniSifre != yeniSifreTekrar)
                {
                    MessageBox.Show("Şifre tekrarında girdiğiniz şifrenin aynısını girmelisiniz! Lütfen şifrenizi kontrol edin!");
                }
                else if (!kullaniciAdi.Contains("@") || !kullaniciAdi.Contains("."))
                {
                    MessageBox.Show("Kullanıcı adınız Eposta adresiniz olmalıdır. Eposta adresinizi hatalı girdiniz! Lütfen kullanıcı adı kısmına eposta adresinizi tekrar giriniz.");
                }
                else if ((yeniSifreSifrelenmis == kullaniciViewModel.Sifre) || (yeniSifreSifrelenmis == kullaniciViewModel.Sifre2) || (yeniSifreSifrelenmis == kullaniciViewModel.Sifre3))
                {
                    MessageBox.Show("Yeni şifreniz son üç şifreniz ile aynı olamaz! Lütfen farklı bir şifre deneyiniz!");
                }
                else
                {
                    MessageBox.Show("Kayıt Başarılı! Giriş Yapabilirsiniz.");
                    kullaniciViewModel.Sifre4 = kullaniciViewModel.Sifre3;
                    kullaniciViewModel.Sifre3 = kullaniciViewModel.Sifre2;
                    kullaniciViewModel.Sifre2 = kullaniciViewModel.Sifre;
                    kullaniciViewModel.KullaniciAdi = kullaniciAdi;
                    kullaniciViewModel.Sifre = yeniSifreSifrelenmis;
                    kullaniciViewModel.GuvenlikSorusu = guvenlikSorusu;
                    kullaniciViewModel.GuvenlikYaniti = guvenlikYaniti;
                    kullaniciManager.Update(kullaniciViewModel);
                    this.Close();
                    KullaniciKontrolPaneli kulllaniciKontrolPaneli = new KullaniciKontrolPaneli(kullaniciId);
                    kulllaniciKontrolPaneli.ShowDialog();
                }
            }
        }

        private void btnKullaniciPanelineDon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtYeniSifre_TextChanged(object sender, EventArgs e)
        {
            txtYeniSifre.UseSystemPasswordChar = true;
            pbYeniSifre.Image = Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
        }
        int sayac = 0;
        private void pbYeniSifre_Click(object sender, EventArgs e)
        {
            sayac++;
            if (sayac % 2 != 0)
            {
                txtYeniSifre.UseSystemPasswordChar = false;
                pbYeniSifre.Image = Resources.png_transparent_eye_eyes_password_security_show_password_essential_icon_thumbnail;
            }
            else
            {
                txtYeniSifre.UseSystemPasswordChar = true;
                pbYeniSifre.Image = Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
            }
        }

        private void txtYeniSifreTekrar_TextChanged(object sender, EventArgs e)
        {
            txtYeniSifreTekrar.UseSystemPasswordChar = true;
            pbYeniSifreTekrar.Image = Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
        }
        int sayac2 = 0;
        private void pbYeniSifreTekrar_Click(object sender, EventArgs e)
        {
            sayac2++;
            if (sayac2 % 2 != 0)
            {
                txtYeniSifreTekrar.UseSystemPasswordChar = false;
                pbYeniSifreTekrar.Image = Resources.png_transparent_eye_eyes_password_security_show_password_essential_icon_thumbnail;
            }
            else
            {
                txtYeniSifreTekrar.UseSystemPasswordChar = true;
                pbYeniSifreTekrar.Image = Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
            pbSifre.Image = Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
        }
        int sayac3 = 0;
        private void pbSifre_Click(object sender, EventArgs e)
        {
            sayac2++;
            if (sayac2 % 2 != 0)
            {
                txtSifre.UseSystemPasswordChar = false;
                pbSifre.Image = Resources.png_transparent_eye_eyes_password_security_show_password_essential_icon_thumbnail;
            }
            else
            {
                txtSifre.UseSystemPasswordChar = true;
                pbSifre.Image = Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
            }
        }
    }
}
