using EFDiyetProgramiProje_BL.Manager.Concrete;
using EFDiyetProgramiProje_BL.Models;
using EFDiyetProgramiProje_DAL.Context;
using EFDiyetProgramiProje_DAL.Entities;
using EFDiyetProgramiProje_DAL.Enums;
using EFDiyetProgramiProje_PL.Properties;
using EFDiyetProgramiProje_PL.StaticMethods;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDiyetProgramiProje_PL
{
    public partial class KayitFormu : Form
    {
        KullaniciManager kullaniciManager = new KullaniciManager();
        public KayitFormu()
        {
            InitializeComponent();
        }


        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
            pictureBox1.Image = Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {


            if (txtSifre.UseSystemPasswordChar)
            {
                txtSifre.UseSystemPasswordChar = false;
                pictureBox1.Image = Resources.png_transparent_eye_eyes_password_security_show_password_essential_icon_thumbnail;
            }
            else
            {
                txtSifre.UseSystemPasswordChar = true;
                pictureBox1.Image = Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
            }
        }

        private void txtSifreTekrar_TextChanged(object sender, EventArgs e)
        {
            txtSifreTekrar.UseSystemPasswordChar = true;
            pictureBox2.Image = Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (txtSifre.UseSystemPasswordChar)
            {
                txtSifreTekrar.UseSystemPasswordChar = false;
                pictureBox2.Image = Resources.png_transparent_eye_eyes_password_security_show_password_essential_icon_thumbnail;
            }
            else
            {
                txtSifreTekrar.UseSystemPasswordChar = true;
                pictureBox2.Image = Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
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
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            string sifreTekrar = txtSifreTekrar.Text;
            string guvenlikSorusu = cmbGuvenlikSorusu.Text;
            string guvenlikYaniti = txtGuvenlikYaniti.Text;
            if (kullaniciAdi == null || sifre == null || sifreTekrar == null || guvenlikSorusu == null || guvenlikYaniti == null)
            {
                MessageBox.Show("Yukarıdaki kısımlar boş bırakılamaz. Lütfen tüm kısımları doldurunuz!");
            }
            else if (sifre.Length < 8)
            {
                MessageBox.Show("Şifre 8 karakterden uzun olmak zorundadır. Lütfen daha uzun şifre giriniz!");
            }
            else if (!BuyukHarfIceriyorMu(sifre) || !KucukHarfIceriyormu(sifre) || !MetinRakamIceriyorMu(sifre) || !SembolIceriyorMu(sifre))
            {
                MessageBox.Show("Şifre içerisinde büyük harf, küçük harf, rakam  ve sembol bulunmak zorundadır. Lütfen başka bir şifre deneyiniz!");
            }
            else if (sifre != sifreTekrar)
            {
                MessageBox.Show("Şifre tekrarında girdiğiniz şifrenin aynısını girmelisiniz! Lütfen şifrenizi kontrol edin!");
            }
            else if (!kullaniciAdi.Contains("@") || !kullaniciAdi.Contains("."))
            {
                MessageBox.Show("Kullanıcı adınız Eposta adresiniz olmalıdır. Eposta adresinizi hatalı girdiniz! Lütfen kullanıcı adı kısmına eposta adresinizi tekrar giriniz.");
            }
            else if (kullaniciManager.Search(k => k.KullaniciAdi == txtKullaniciAdi.Text).FirstOrDefault() != null)
            {
                MessageBox.Show("Bu kullanıcı adı sistemde kayıtlı. Lütfen başka bir kullanıcı adı(eposta) kullanarak tekrar deneyiniz!");
            }
            else
            {
                string sifrelenmis = Sha256Hasher.ComputeSha256Hash(sifre);
                KullaniciViewModel yeniKullanici = new KullaniciViewModel()
                {
                    KullaniciAdi = kullaniciAdi,
                    Sifre = sifrelenmis,
                    GuvenlikSorusu = guvenlikSorusu,
                    GuvenlikYaniti = guvenlikYaniti
                };
                kullaniciManager.Insert(yeniKullanici);
                MessageBox.Show("Kayıt Başarılı! Giriş Yapabilirsiniz.");
                this.Close();

            }
        }
    }
}

