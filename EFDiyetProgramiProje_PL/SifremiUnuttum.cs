using EFDiyetProgramiProje_BL.Manager.Concrete;
using EFDiyetProgramiProje_PL.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDiyetProgramiProje_PL
{
    public partial class SifremiUnuttum : Form
    {
        KullaniciManager kullaniciManager = new KullaniciManager();
        public SifremiUnuttum()
        {
            InitializeComponent();
        }
        #region SifreGizleme
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
        #endregion


        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            #region Yeni Sifre Kısıtlama 
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
            #endregion

            string kullaniciAdi = txtKullaniciAdi.Text;
            string guvenlikSorusu = cmbGuvenlikSorusu.Text;
            string guvenlikYaniti = txtGuvenlikYaniti.Text;
            string yeniSifre = txtYeniSifre.Text;
            string yeniSifreTekrar = txtYeniSifreTekrar.Text; 
            var kullanici = kullaniciManager.Search(k => k.KullaniciAdi == kullaniciAdi && k.GuvenlikSorusu == guvenlikSorusu && k.GuvenlikYaniti == guvenlikYaniti).FirstOrDefault();
            if (txtKullaniciAdi.Text == null || cmbGuvenlikSorusu.Text == null || txtGuvenlikYaniti.Text == null || txtYeniSifre.Text == null || txtYeniSifreTekrar.Text == null)
                MessageBox.Show("Yukarıdaki kısımlar booş bırakılamaz! Lütfen tüm bilgileri giriniz.");
            else if (kullanici == null)
                MessageBox.Show("Kullanıcı adı, güvenlik sorusu veya guvenlik yanıtı kısmını hatalı girdiniz! Kullanıcı bilgileriniz bulunamadı lütfen düzelterek tekrar deneyin!");
            else if (yeniSifre.Length < 8)
            {
                MessageBox.Show("Kullanıcı bilgileriniz ve güvenlik sorusu cevabınız doğru eşleşti! Yeni şifre oluşturabilirsiniz!");
                MessageBox.Show("Şifre 8 karakterden uzun olmak zorundadır. Lütfen daha uzun şifre giriniz!");
            }
            else if (!BuyukHarfIceriyorMu(yeniSifre) || !KucukHarfIceriyormu(yeniSifre) || !MetinRakamIceriyorMu(yeniSifre) || !SembolIceriyorMu(yeniSifre))
            {
                MessageBox.Show("Kullanıcı bilgileriniz ve güvenlik sorusu cevabınız doğru eşleşti! Yeni şifre oluşturabilirsiniz!");
                MessageBox.Show("Şifre içerisinde büyük harf, küçük harf, rakam  ve sembol bulunmak zorundadır. Lütfen başka bir şifre deneyiniz!");
            }
            else if (yeniSifre != yeniSifreTekrar)
            {
                MessageBox.Show("Kullanıcı bilgileriniz ve güvenlik sorusu cevabınız doğru eşleşti! Yeni şifre oluşturabilirsiniz!");
                MessageBox.Show("Şifre tekrarında girdiğiniz şifrenin aynısını girmelisiniz! Lütfen şifrenizi kontrol edin!");
            }
            else if ((yeniSifre == kullanici.Sifre) || (yeniSifre==kullanici.Sifre2) || (yeniSifre==kullanici.Sifre3))
            {
                MessageBox.Show("Kullanıcı bilgileriniz ve güvenlik sorusu cevabınız doğru eşleşti! Yeni şifre oluşturabilirsiniz!");
                MessageBox.Show("Yeni şifreniz son üç şifreniz ile aynı olamaz! Lütfen farklı bir şifre deneyiniz!");
            }
            else
            {
                MessageBox.Show("Kullanıcı bilgileriniz ve güvenlik sorusu cevabınız doğru eşleşti! Şifre başarıyla güncellendi!");
                kullanici.Sifre4 = kullanici.Sifre3;
                kullanici.Sifre3 = kullanici.Sifre2;
                kullanici.Sifre2 = kullanici.Sifre;
                kullanici.Sifre = yeniSifre;
                kullaniciManager.Update(kullanici);
                this.Close();
            }
        }
    }
}
