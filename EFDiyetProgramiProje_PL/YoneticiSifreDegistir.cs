using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFDiyetProgramiProje_BL.Manager.Abstract;
using EFDiyetProgramiProje_BL.Manager.Concrete;
using EFDiyetProgramiProje_BL.Models;
using EFDiyetProgramiProje_DAL.Context;
using EFDiyetProgramiProje_DAL.Entities;
using EFDiyetProgramiProje_PL.Properties;

namespace EFDiyetProgramiProje_PL
{
    public partial class YoneticiSifreDegistir : Form
    {
        KullaniciManager manager = new KullaniciManager();

        public YoneticiSifreDegistir()
        {
            InitializeComponent();
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            var adminSifre = manager.Search(a => a.KullaniciAdi == "admin").FirstOrDefault();
            string eskiSifre = txtEskiSifre.Text;
            string sifre = txtYeniSifre.Text;
            string sifreTekrar = txtYeniSifreTekrar.Text;

            if (adminSifre != null && eskiSifre == adminSifre.Sifre && sifre == sifreTekrar)
            {
                adminSifre.Sifre = sifre;
                manager.Update(adminSifre);
            }
            else if (sifre != sifreTekrar)
            {
                MessageBox.Show("Girdiğiniz şifreler eşleşmiyor.");
            }
        }

        private void txtEskiSifre_TextChanged(object sender, EventArgs e)
        {
            txtEskiSifre.UseSystemPasswordChar = true;
            pbEskiSifre.Image = Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
        }

        private void txtYeniSifre_TextChanged(object sender, EventArgs e)
        {

            txtYeniSifre.UseSystemPasswordChar = true;
            pbYeniSifre.Image = Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
        }

        private void txtYeniSifreTekrar_TextChanged(object sender, EventArgs e)
        {
            txtYeniSifreTekrar.UseSystemPasswordChar = true;
            pbYeniSifreTekrar.Image = Resources.png_transparent_hide_hide_eye_hide_password_essential_icon_thumbnail;
        }

        private void pbEskiSifre_Click(object sender, EventArgs e)
        {
            txtEskiSifre.UseSystemPasswordChar = false;
            pbEskiSifre.Image = Resources.png_transparent_eye_eyes_password_security_show_password_essential_icon_thumbnail;
        }

        private void pbYeniSifre_Click(object sender, EventArgs e)
        {
            txtYeniSifre.UseSystemPasswordChar = false;
            pbYeniSifre.Image = Resources.png_transparent_eye_eyes_password_security_show_password_essential_icon_thumbnail;
        }

        private void pbYeniSifreTekrar_Click(object sender, EventArgs e)
        {
            txtYeniSifreTekrar.UseSystemPasswordChar = false;
            pbYeniSifreTekrar.Image = Resources.png_transparent_eye_eyes_password_security_show_password_essential_icon_thumbnail;
        }
    }
}
