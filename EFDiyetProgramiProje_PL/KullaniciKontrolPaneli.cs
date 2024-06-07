using EFDiyetProgramiProje_BL.Manager.Concrete;
using EFDiyetProgramiProje_DAL.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFDiyetProgramiProje_BL.Models;
using EFDiyetProgramiProje_DAL.Entities;
using EFDiyetProgramiProje_DAL.Enums;
using System.Globalization;
using System.Xml.Serialization;

namespace EFDiyetProgramiProje_PL
{

    public partial class KullaniciKontrolPaneli : Form
    {
        KullaniciManager kullaniciManager = new KullaniciManager();
        KullaniciBilgiManager kullaniciBilgiManager = new KullaniciBilgiManager();
        YemekManager yemekManager = new YemekManager();
        YemekKategoriManager YemekKategoriManager = new YemekKategoriManager();
        OgunYemekManager OgunYemekManager = new OgunYemekManager();

        YemekViewModel secilenYemek = new YemekViewModel();

        DateTime tarih;

        private int kullaniciId;
        public KullaniciKontrolPaneli(int mevcutKullaniciId)
        {
            InitializeComponent();
            kullaniciId = mevcutKullaniciId;
            var mevcutKullaniciBilgileri = kullaniciBilgiManager.Search(k => k.KullaniciId == kullaniciId).FirstOrDefault();

            var kategoriler = YemekKategoriManager.GetAll();
            foreach (var kategori in kategoriler)
            {
                cbKategoriler.Items.Add(kategori.KategoriAdi);
            }
            cbKategoriler.Text = "Yemek kategorisi seçiniz...";


            if (mevcutKullaniciBilgileri == null)
            {
                //this.Close();
                MessageBox.Show("Yeni kayıt yaptığınız için öncelikle kullanıcı bilgilerinizi girmelisiniz!");
                KullaniciBilgileri kullaniciBilgileri = new KullaniciBilgileri(kullaniciId);
                kullaniciBilgileri.ShowDialog();
            }
            else
            {
                var kullaniciBilgileri = kullaniciBilgiManager.Search(k => k.KullaniciId == kullaniciId).FirstOrDefault();
                lblGunlukHedefKalori.Text = Convert.ToString(kullaniciBilgileri.GunlukHedefKalori);
                lblBMI.Text = Convert.ToString(kullaniciBilgileri.VucutKitleEndeksi);
                lblBMR.Text = Convert.ToString(kullaniciBilgileri.BazalMetabolizmaHizi);
                lblBoy.Text = Convert.ToString(kullaniciBilgileri.Boy);
                lblYas.Text = Convert.ToString(kullaniciBilgileri.Yas);
                lblHedefKilo.Text = Convert.ToString(kullaniciBilgileri.HedefKilo);
                lblKilo.Text = Convert.ToString(kullaniciBilgileri.Kilo);
                lblCinsiyet.Text = kullaniciBilgileri.Cinsiyet;
            }


            monthCalendar1.MaxSelectionCount = 1;
            tarih = monthCalendar1.SelectionStart;
            YemekListele(1);
            YemekListele(2);
            YemekListele(3);

            //lblGunlukToplamKalori.Text = lblKaloriToplamAksam.Text;
        }

        private void btnKisiselBilgileriGuncelle_Click(object sender, EventArgs e)
        {
            KullaniciBilgileri kullaniciBilgileri = new KullaniciBilgileri(kullaniciId);
            kullaniciBilgileri.ShowDialog();
        }

        private void btnKullaniciBilgileriGuncelle_Click(object sender, EventArgs e)
        {
            KullaniciGuncelle kullaniciGuncelle = new KullaniciGuncelle(kullaniciId);
            kullaniciGuncelle.ShowDialog();
        }

        private void btnOturumuKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbKategoriler.Items.AddRange(yemekManager.GetAll().ToArray());
            var kategori = YemekKategoriManager.Search(s => s.KategoriAdi == cbKategoriler.Text).FirstOrDefault();
            var yemekler = yemekManager.Search(s => s.YemekKategoriId == kategori.Id);
            lbYemekler.Items.Clear();
            foreach (var yemek in yemekler)
            {
                lbYemekler.Items.Add(yemek.YemekAdi);
            }

        }

        private void lbYemekler_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenYemek = yemekManager.Search(s => s.YemekAdi == lbYemekler.Text).FirstOrDefault();

            rtxtTarif.Text = secilenYemek.Tarif;

        }

        private void btnEkleSabah_Click(object sender, EventArgs e)
        {
            if (!YemekEklemeKontrol())
            {
                return;
            }

            OgunYemekViewModel eklenenYemek = new OgunYemekViewModel();
            eklenenYemek.YemekId = secilenYemek.Id;
            eklenenYemek.OgunId = 1;
            eklenenYemek.Tarih = DateOnly.FromDateTime(tarih);
            eklenenYemek.KullaniciId = kullaniciId;
            eklenenYemek.BirimAdedi = Convert.ToInt32(txtAdet.Text);

            OgunYemekManager.Insert(eklenenYemek);

            YemekListele(1);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            tarih = monthCalendar1.SelectionStart;
            YemekListele(1);
            YemekListele(2);
            YemekListele(3);
        }


        void YemekListele(int ogunId)
        {
            var ogunYemekler = OgunYemekManager.Search(s => s.Tarih == DateOnly.FromDateTime(tarih) && s.OgunId == ogunId);

            if (ogunId == 1)
            {
                flpSabahYemekler.Controls.Clear();
            }
            else if (ogunId == 2)
            {
                flpOgleYemekler.Controls.Clear();
            }
            else if (ogunId == 3)
            {
                flpAksamYemekler.Controls.Clear();
            }



            double? kaloriToplam = 0;

            foreach (var ogunYemek in ogunYemekler)
            {
                kaloriToplam += YemekEkle(ogunYemek, ogunId);
            }

            if (ogunId == 1)
            {
                lblKaloriToplamSabah.Text = "Toplam Kalori: " + kaloriToplam.ToString() + " Kcal";
            }
            else if (ogunId == 2)
            {
                lblKaloriToplamOgle.Text = "Toplam Kalori: " + kaloriToplam.ToString() + " Kcal";
            }
            else if (ogunId == 3)
            {
                lblKaloriToplamAksam.Text = "Toplam Kalori: " + kaloriToplam.ToString() + " Kcal";
            }
        }

        double? YemekEkle(OgunYemekViewModel ogunYemek, int ogunId)
        {

            Panel panel = new Panel();

            //var yy = yemekManager.GetDeletedById

            var eklenenYemek = yemekManager.Search(s => s.Id == ogunYemek.YemekId).FirstOrDefault();

            if (eklenenYemek == null)
            {
                eklenenYemek = yemekManager.GetDeletedById(ogunYemek.YemekId);
            }


            Label yemekAdi = new Label();
            yemekAdi.Text = "Yemek Adı: " + eklenenYemek.YemekAdi;
            yemekAdi.Top = 0;
            yemekAdi.Width = 110;


            Label kalori = new Label();
            kalori.Text = "Kalori: " + eklenenYemek.Kalori + " Kcal";
            kalori.Top = 30;
            kalori.Width = 80;



            Label adet = new Label();
            adet.Text = "Adet: " + ogunYemek.BirimAdedi + " " + eklenenYemek.Birim;
            adet.Top = 60;
            adet.Width = 80;

            PictureBox gorsel = new PictureBox();
            gorsel.SizeMode = PictureBoxSizeMode.StretchImage;
            gorsel.Left = 120;
            gorsel.Top = 10;
            gorsel.Size = new Size(75, 75);
            gorsel.ImageLocation = eklenenYemek.Gorsel;


            Button silButon = new Button();
            silButon.Text = "Sil";
            silButon.Top = 70;
            silButon.Size = new Size(80, 20);
            silButon.Location = new Point(60, 95);
            silButon.Click += new System.EventHandler(Sil_Click);
            silButon.Tag = ogunYemek.Id;


            panel.Controls.Add(yemekAdi);
            panel.Controls.Add(kalori);
            panel.Controls.Add(adet);
            panel.Controls.Add(gorsel);
            panel.Controls.Add(silButon);


            panel.Width = 200;
            panel.Height = 120;
            panel.BorderStyle = BorderStyle.FixedSingle;

            if (ogunId == 1)
            {
                flpSabahYemekler.Controls.Add(panel);
            }
            else if (ogunId == 2)
            {
                flpOgleYemekler.Controls.Add(panel);
            }
            else if (ogunId == 3)
            {
                flpAksamYemekler.Controls.Add(panel);
            }


            return eklenenYemek.Kalori * ogunYemek.BirimAdedi;
        }

        private void btnEkleOgle_Click(object sender, EventArgs e)
        {
            if (!YemekEklemeKontrol())
            {
                return;
            }
            OgunYemekViewModel eklenenYemek = new OgunYemekViewModel();
            eklenenYemek.YemekId = secilenYemek.Id;
            eklenenYemek.OgunId = 2;
            eklenenYemek.Tarih = DateOnly.FromDateTime(tarih);
            eklenenYemek.KullaniciId = kullaniciId;
            eklenenYemek.BirimAdedi = Convert.ToInt32(txtAdet.Text);

            OgunYemekManager.Insert(eklenenYemek);

            YemekListele(2);
        }

        private void btnEkleAksam_Click(object sender, EventArgs e)
        {
            if (!YemekEklemeKontrol())
            {
                return;
            }

            OgunYemekViewModel eklenenYemek = new OgunYemekViewModel();
            eklenenYemek.YemekId = secilenYemek.Id;
            eklenenYemek.OgunId = 3;
            eklenenYemek.Tarih = DateOnly.FromDateTime(tarih);
            eklenenYemek.KullaniciId = kullaniciId;
            eklenenYemek.BirimAdedi = Convert.ToInt32(txtAdet.Text);

            OgunYemekManager.Insert(eklenenYemek);

            YemekListele(3);
        }


        bool YemekEklemeKontrol()
        {
            if (txtAdet.Text == "")
            {
                MessageBox.Show("Lütfen adet giriniz!");
                return false;
            }
            if (secilenYemek == null)
            {
                MessageBox.Show("Lütfen bir yemek seçiniz!");
                return false;
            }
            return true;
        }

        void Sil_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            var ogunyemek = OgunYemekManager.Search(s => s.Id == Convert.ToInt32(button.Tag)).FirstOrDefault();

            if (ogunyemek == null)
            {
                ogunyemek = OgunYemekManager.GetDeletedById(Convert.ToInt32(button.Tag));
            }

            OgunYemekManager.Delete(ogunyemek);

            YemekListele(1);
            YemekListele(2);
            YemekListele(3);

        }
    }
}
