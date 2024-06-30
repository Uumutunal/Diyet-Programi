using EFDiyetProgramiProje_BL.Manager.Concrete;
using EFDiyetProgramiProje_BL.Models;
using EFDiyetProgramiProje_PL.Properties;
using EFDiyetProgramiProje_PL.StaticMethods;
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
        string kullaniciAdi;
        KullaniciViewModel kullanici;

        public SifremiUnuttum(string _kullanici)
        {
            InitializeComponent();
            kullaniciAdi = _kullanici;

            kullanici = kullaniciManager.Search(k => k.KullaniciAdi == kullaniciAdi).FirstOrDefault();

            txtKullaniciAdi.Enabled = false;
            if(kullanici.KullaniciAdi == "admin")
            {
                txtGuvenlikYaniti.Enabled = false;
                cmbGuvenlikSorusu.Enabled = false;
            }
            txtKullaniciAdi.Text = kullanici.KullaniciAdi;
            cmbGuvenlikSorusu.Text = kullanici.GuvenlikSorusu;
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
            string guvenlikYaniti = txtGuvenlikYaniti.Text;
            string sifrelenmisYeniSifre = Sha256Hasher.ComputeSha256Hash(txtYeniSifre.Text);
            string yeniSifre = txtYeniSifre.Text;
            string yeniSifreTekrar = txtYeniSifreTekrar.Text;

            if (kullanici.KullaniciAdi == "admin")
            {
                if (yeniSifre.Length < 3)
                {
                    MessageBox.Show("Şifreniz 3 karakterden kısa olamaz.");
                }
                else if (yeniSifre != yeniSifreTekrar)
                {
                    MessageBox.Show("Girmiş olduğunuz şifreler eşleşmiyor. Tekrar deneyiniz.");
                }
                else
                {
                    MessageBox.Show("Şifre güncelleme işlemi başarılı!");
                }
            }
            else
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


                //var kullanici = kullaniciManager.Search(k => k.KullaniciAdi == kullaniciAdi).FirstOrDefault();




                //var kullanici = kullaniciManager.Search(k => k.KullaniciAdi == kullaniciAdi && k.GuvenlikSorusu == guvenlikSorusu && k.GuvenlikYaniti == guvenlikYaniti).FirstOrDefault();



                if (txtKullaniciAdi.Text == null || cmbGuvenlikSorusu.Text == null || txtGuvenlikYaniti.Text == null || txtYeniSifre.Text == null || txtYeniSifreTekrar.Text == null)
                    MessageBox.Show("Yukarıdaki kısımlar boş bırakılamaz! Lütfen tüm bilgileri giriniz.");
                else if (kullanici == null)
                    MessageBox.Show("Kullanıcı adı, güvenlik sorusu veya guvenlik yanıtı kısmını hatalı girdiniz! Kullanıcı bilgileriniz bulunamadı lütfen düzelterek tekrar deneyin!");
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
                else if ((sifrelenmisYeniSifre == kullanici.Sifre) || (sifrelenmisYeniSifre == kullanici.Sifre2) || (sifrelenmisYeniSifre == kullanici.Sifre3))
                {
                    MessageBox.Show("Yeni şifreniz son üç şifreniz ile aynı olamaz! Lütfen farklı bir şifre deneyiniz!");
                }
                else if (txtGuvenlikYaniti.Text != kullanici.GuvenlikYaniti)
                {
                    MessageBox.Show("Kullanıcı adı, güvenlik sorusu veya guvenlik yanıtı kısmını hatalı girdiniz! Kullanıcı bilgileriniz bulunamadı lütfen düzelterek tekrar deneyin!");

                }
                else
                {
                    MessageBox.Show("Kullanıcı bilgileriniz ve güvenlik sorusu cevabınız doğru eşleşti! Şifre başarıyla güncellendi!");
                    kullanici.Sifre4 = kullanici.Sifre3;
                    kullanici.Sifre3 = kullanici.Sifre2;
                    kullanici.Sifre2 = kullanici.Sifre;
                    kullanici.Sifre = sifrelenmisYeniSifre;
                    kullaniciManager.Update(kullanici);
                    this.Close();
                }
            }

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
