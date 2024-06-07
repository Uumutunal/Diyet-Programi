using EFDiyetProgramiProje_BL.Manager.Concrete;
using EFDiyetProgramiProje_BL.Models;
using EFDiyetProgramiProje_DAL.Context;
using EFDiyetProgramiProje_DAL.Entities;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFDiyetProgramiProje_DAL.Enums;
using static System.Net.Mime.MediaTypeNames;
using System.Globalization;


namespace EFDiyetProgramiProje_PL
{
    public partial class KullaniciBilgileri : Form
    {
        KullaniciManager kullaniciManager = new KullaniciManager();
        KullaniciBilgiManager kullaniciBilgiManager = new KullaniciBilgiManager();
        KullaniciBilgiViewModel? kullaniciBilgiViewModel;
        private int kullaniciId;


        public KullaniciBilgileri(int mevcutKullaniciId)
        {
            InitializeComponent();
            kullaniciId = mevcutKullaniciId;
            var kullanici = kullaniciManager.Search(k => k.Id == kullaniciId).FirstOrDefault();
            kullaniciBilgiViewModel = kullaniciBilgiManager.Search(k => k.KullaniciId == kullaniciId).FirstOrDefault();

            lblKullaniciAdi.Text = kullanici.KullaniciAdi;

            if (kullaniciBilgiViewModel != null)
            {
                txtBoy.Text = Convert.ToString(kullaniciBilgiViewModel.Boy);
                txtHedefKilo.Text = Convert.ToString(kullaniciBilgiViewModel.HedefKilo);
                txtKilo.Text = Convert.ToString(kullaniciBilgiViewModel.Kilo);

                //string gun = kullaniciBilgiViewModel.DogumTarihi.Value.Day < 10 ? "0" + kullaniciBilgiViewModel.DogumTarihi.Value.Day : kullaniciBilgiViewModel.DogumTarihi.Value.Day.ToString();
                //string ay = kullaniciBilgiViewModel.DogumTarihi.Value.Month < 10 ? "0" + kullaniciBilgiViewModel.DogumTarihi.Value.Month : kullaniciBilgiViewModel.DogumTarihi.Value.Month.ToString();
                //txtDogumTarihi.Text = Convert.ToString(gun + "." + ay + "." +kullaniciBilgiViewModel.DogumTarihi.Value.Year);

                txtDogumTarihi.Text = kullaniciBilgiViewModel.DogumTarihi.Value.ToShortDateString();
                cmbCinsiyet.Text = kullaniciBilgiViewModel.Cinsiyet;
            }


        }

        private void btnKullaniciBilgiGuncelle_Click(object sender, EventArgs e)
        {
            if (txtBoy.Text == null || txtKilo.Text == null || cmbCinsiyet.Text == null || txtDogumTarihi.Text == null || txtHedefKilo == null)
                MessageBox.Show("Kullanıcı bilgileri boş bırakılamaz. Lütfen yukarıdaki tbilgilerin hepsini doldurunuz!");
            else if (!txtBoy.Text.All(char.IsDigit))
                MessageBox.Show("Boy bilgisini hatalı girdiniz! Lütfen boy bilgisini cm cinsinden girerken sadece rakam kullanınız!");
            else if (!Double.TryParse(txtKilo.Text, out double kilo) || Convert.ToDouble(txtKilo.Text) < 0)
                MessageBox.Show("Kilo bilgisini hatalı girdiniz! Lütfen 0 ile 200 arası bir değer giriniz!");
            else if (!DateTime.TryParseExact(txtDogumTarihi.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dogumTarihi))
                MessageBox.Show("Doğum tarihinizi hatalı girdiniz! Lütfen gg.aa.yyyy formatında giriniz!");
            else if (!Double.TryParse(txtHedefKilo.Text, out double hedefKilo) || Convert.ToDouble(txtHedefKilo.Text) < 0)
            {
                MessageBox.Show("Hedef kilo bilgisini hatalı girdiniz! Lütfen 0 ile 200 arası bir değer giriniz!");
            }
            else
            {
                string dogumTarihitxt = txtDogumTarihi.Text;
                string format = "dd.MM.yyyy";
                DateTime dogumTarihidate = DateTime.ParseExact(dogumTarihitxt, format, CultureInfo.InvariantCulture);


                int yas = DateTime.Now.Year - dogumTarihidate.Year;
                double BMR = 0.0;
                if (cmbCinsiyet.Text == "Kadın")
                    BMR = (655.1 + (9.56 * Convert.ToDouble(txtKilo.Text)) + (1.85 * Convert.ToDouble(txtBoy.Text)) - (4.67 * yas)) * 1.35;
                else if (cmbCinsiyet.Text == "Erkek")
                    BMR = (66.5 + (13.75 * Convert.ToDouble(txtKilo.Text)) + (5.0 * Convert.ToDouble(txtBoy.Text)) - (6.77 * yas)) * 1.35;
                int gunlukHedefKalori = Convert.ToInt32(BMR) - 700;
                double vucutKitleEndeksi = Convert.ToDouble(txtKilo.Text) / (Convert.ToDouble(txtBoy.Text) * Convert.ToDouble(txtBoy.Text) / 10000);
                double yasFaktoru = 0.0;
                if (yas >= 20 && yas < 30)
                {
                    yasFaktoru = 0.05;
                }
                else if (yas >= 30 && yas < 40)
                {
                    yasFaktoru = 0.1;
                }
                else if (yas >= 40 && yas < 50)
                {
                    yasFaktoru = 0.15;
                }
                else if (yas >= 50 && yas < 60)
                {
                    yasFaktoru = 0.2;
                }
                else if (yas >= 60)
                {
                    yasFaktoru = 0.25;
                }
                double vucutKitleEndeksiHesabı = vucutKitleEndeksi + yasFaktoru;
                //var kullaniciBilgi = kullaniciBilgiManager.Search(k => k.KullaniciId == kullaniciId).FirstOrDefault();
                if (kullaniciBilgiViewModel == null)
                {

                    KullaniciBilgiViewModel yeniKullaniciBilgi = new KullaniciBilgiViewModel()
                    {
                        Kilo = Convert.ToInt32(txtKilo.Text),
                        Cinsiyet = cmbCinsiyet.Text,
                        Boy = Convert.ToInt32(txtBoy.Text),
                        HedefKilo = Convert.ToInt32(txtHedefKilo.Text),
                        DogumTarihi = Convert.ToDateTime(txtDogumTarihi.Text),
                        KullaniciId = kullaniciId,
                        GunlukHedefKalori = gunlukHedefKalori,
                        BazalMetabolizmaHizi = BMR,
                        Yas = yas,
                        VucutKitleEndeksi = vucutKitleEndeksiHesabı
                    };

                    kullaniciBilgiManager.Insert(yeniKullaniciBilgi);
                    this.Hide();
                    KullaniciKontrolPaneli kullaniciKontrolPanel = new KullaniciKontrolPaneli(kullaniciId);
                    kullaniciKontrolPanel.ShowDialog();
                }
                else
                {

                    kullaniciBilgiViewModel.Kilo = Convert.ToInt32(txtKilo.Text);

                    kullaniciBilgiViewModel.Cinsiyet = cmbCinsiyet.Text;

                    kullaniciBilgiViewModel.Boy = Convert.ToInt32(txtBoy.Text);

                    kullaniciBilgiViewModel.HedefKilo = Convert.ToInt32(txtHedefKilo.Text);

                    kullaniciBilgiViewModel.DogumTarihi = Convert.ToDateTime(txtDogumTarihi.Text);
                    kullaniciBilgiViewModel.Yas = yas;
                    kullaniciBilgiViewModel.VucutKitleEndeksi = vucutKitleEndeksiHesabı;
                    kullaniciBilgiViewModel.BazalMetabolizmaHizi = BMR;
                    kullaniciBilgiViewModel.GunlukHedefKalori = gunlukHedefKalori;

                    kullaniciBilgiManager.Update(kullaniciBilgiViewModel);
                    this.Hide();
                }
                MessageBox.Show("Kullanıcı bilgileri başarı ile güncellendi!");

                
            }
        }
    }
}
