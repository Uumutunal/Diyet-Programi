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


            monthCalendar1.MaxSelectionCount = 2;
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
                lblSabahKaloriToplam.Text = kaloriToplam.ToString();
            }
            else if (ogunId == 2)
            {
                lblOgleKaloriToplam.Text = kaloriToplam.ToString();
            }
            else if (ogunId == 3)
            {
                lblAksamKaloriToplam.Text = kaloriToplam.ToString();
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

            if (eklenenYemek.Gorsel != null)
            {
                using (MemoryStream ms = new MemoryStream(eklenenYemek.Gorsel))
                {

                    gorsel.SizeMode |= PictureBoxSizeMode.Zoom;
                    gorsel.Left = 120;
                    gorsel.Top = 10;
                    gorsel.Size = new Size(75, 75);
                    gorsel.Image = Image.FromStream(ms);
                }
            }


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

        private void btnGunSonuRaporu_Click(object sender, EventArgs e)
        {

            DateTime selectedDateTime = DateTime.Today;
            DateOnly selectedDate = ConvertToDateTimeOnly(selectedDateTime);

            var yemekTuketimleri = OgunYemekManager.Search(y => y.Tarih == selectedDate);


            if (yemekTuketimleri == null || !yemekTuketimleri.Any())
            {
                MessageBox.Show("Bugüne ait yemek tüketim bilgisi bulunamadı.");
                return;
            }

            double sabahKaloriToplami = Convert.ToDouble(lblSabahKaloriToplam.Text);
            double ogleKaloriToplami = Convert.ToDouble(lblOgleKaloriToplam.Text);
            double aksamKaloriToplami = Convert.ToDouble(lblAksamKaloriToplam.Text);
            double toplamKalori = sabahKaloriToplami + ogleKaloriToplami + aksamKaloriToplami;
            Dictionary<string, double> ogunKalorileri = new Dictionary<string, double>
            {
                { "Sabah", sabahKaloriToplami },
                { "Öğle", ogleKaloriToplami },
                { "Akşam", aksamKaloriToplami }
            };

            pnlRapor.Controls.Clear();

            var enCokKaloriTuketilenOgun = ogunKalorileri.OrderByDescending(k => k.Value).FirstOrDefault();
            string raporMesaji = $"Gün Sonu Raporu ({selectedDate.ToShortDateString()})\n" +
                                 $"Toplam Kalori: {toplamKalori}\n" +
                                 $"En Çok Kalori Tüketilen Öğün:\n {enCokKaloriTuketilenOgun.Key}\n ({enCokKaloriTuketilenOgun.Value} kalori)";

            DisplayReport(raporMesaji);

        }

        private DateOnly ConvertToDateTimeOnly(DateTime dateTime)
        {
            return new DateOnly(dateTime.Year, dateTime.Month, dateTime.Day);
        }

        private void btnKiyasRaporu_Click(object sender, EventArgs e)
        {

            DateTime startDate = dtpStartDate.Value.Date;
            DateOnly dateOnlyStart = ConvertToDateOnly(startDate);
            DateTime endDate = dtpEndDate.Value.Date;
            DateOnly dateOnlyEnd = ConvertToDateOnly(endDate);

            if (startDate > endDate)
            {
                MessageBox.Show("Başlangıç tarihi, bitiş tarihinden önce olmalıdır.");
                return;
            }

            // Her iki tarihteki ogunYemekler verilerini al
            var yemekTuketimleri1 = OgunYemekManager.Search(y => y.Tarih == dateOnlyStart).ToList();
            var yemekTuketimleri2 = OgunYemekManager.Search(y => y.Tarih == dateOnlyEnd).ToList();

            if (!yemekTuketimleri1.Any() || !yemekTuketimleri2.Any())
            {
                MessageBox.Show("Seçilen tarihler aralığında yemek tüketim bilgisi bulunamadı.");
                return;
            }

            // Her iki tarih için sabah, öğle ve akşam için toplam kalorileri hesapla
            double sabahKaloriToplami1 = CalculateTotalKalori(yemekTuketimleri1, "Sabah");
            double ogleKaloriToplami1 = CalculateTotalKalori(yemekTuketimleri1, "Öğle");
            double aksamKaloriToplami1 = CalculateTotalKalori(yemekTuketimleri1, "Akşam");

            double sabahKaloriToplami2 = CalculateTotalKalori(yemekTuketimleri2, "Sabah");
            double ogleKaloriToplami2 = CalculateTotalKalori(yemekTuketimleri2, "Öğle");
            double aksamKaloriToplami2 = CalculateTotalKalori(yemekTuketimleri2, "Akşam");

            // Raporu oluştur
            string raporMesaji = $"Kıyaslama Raporu\n\n" +
                                 $"Tarih 1 ({startDate.ToShortDateString()}):\n" +
                                 $"- Sabah: {sabahKaloriToplami1} Kcal\n" +
                                 $"- Öğle: {ogleKaloriToplami1} Kcal\n" +
                                 $"- Akşam: {aksamKaloriToplami1} Kcal\n\n" +
                                 $"Tarih 2 ({endDate.ToShortDateString()}):\n" +
                                 $"- Sabah: {sabahKaloriToplami2} Kcal\n" +
                                 $"- Öğle: {ogleKaloriToplami2} Kcal\n" +
                                 $"- Akşam: {aksamKaloriToplami2} Kcal";

            // Raporu pnlRapor kontrolünde göster
            DisplayReport(raporMesaji);
        }

        private DateOnly ConvertToDateOnly(DateTime dateTime)
        {
            return new DateOnly(dateTime.Year, dateTime.Month, dateTime.Day);
        }

        private double CalculateTotalKalori(IEnumerable<OgunYemekViewModel> yemekTuketimleri, string ogun)
        {
            double toplamKalori = 0;

            // Verilen öğün için yemeklerin toplam kalorisini hesapla
            foreach (var tuketim in yemekTuketimleri.Where(y => y.OgunId == GetOgunIdFromName(ogun)))
            {
                double yemekKalori = GetYemekKalori(tuketim.YemekId);
                toplamKalori += yemekKalori * tuketim.BirimAdedi;
            }

            return toplamKalori;
        }
        // Öğün adına göre ogunId döndürür
        private int GetOgunIdFromName(string ogunAdi)
        {
            switch (ogunAdi)
            {
                case "Sabah":
                    return 1;
                case "Öğle":
                    return 2;
                case "Akşam":
                    return 3;
                default:
                    return -1; // Hata durumu
            }
        }

        // Yemeğin kalorisini döndürür
        private double GetYemekKalori(int yemekId)
        {
            var yemek = yemekManager.GetById(yemekId);

            if (yemek != null)
            {
                return yemek.Kalori.Value; 
            }
            else
            {
                // Yemek bulunamadı, 0 dönüyoruz
                MessageBox.Show("Yemek bulunamadı."); 
                return 0;
            }
        }
        private void DisplayReport(string raporMesaji)
        {
            
            pnlRapor.Controls.Clear();

            // Raporu göstermek için bir Label oluştur
            Label lblRaporMesaji = new Label
            {
                Text = raporMesaji,
                AutoSize = true,
                Location = new Point(10, 10)
            };

            // Label'ı pnlRapor'a ekle
            pnlRapor.Controls.Add(lblRaporMesaji);
        }
        private void btnYemekCesidiRaporu_Click(object sender, EventArgs e)
        {
            DateTime endDate = DateTime.Today;
            DateOnly dateOnlyEnd = ConvertToDateOnly(endDate);
            DateTime startDate = endDate.AddDays(-7);
            DateOnly dateOnlyStart = ConvertToDateOnly(startDate);

            var yemekTuketimleri = OgunYemekManager.Search(y => y.KullaniciId == kullaniciId && y.Tarih >= dateOnlyStart && y.Tarih <= dateOnlyEnd).ToList();

            if (yemekTuketimleri == null || !yemekTuketimleri.Any())
            {
                MessageBox.Show("Son 7 gün içinde yemek tüketimi bulunamadı.");
                return;
            }

            // Tarih aralığında en çok tüketilen yemeğin Id'sini bul
            var enCokTuketilenYemekId = yemekTuketimleri
                .GroupBy(y => y.YemekId)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .FirstOrDefault();
            // Tarih aralığında her yemeğin kaç kez tüketildiğini hesapla
            var yemekTuketimSayilari = yemekTuketimleri .GroupBy(y => y.YemekId) .ToDictionary(g => g.Key, g => g.Count());

            if (enCokTuketilenYemekId == null)
            {
                MessageBox.Show("1 haftada en çok tüketilen yemek bulunamadı.");
                return;
            }

            // En çok tüketilen yemeğin adını al
            var enCokTuketilenYemek = yemekManager.GetById(enCokTuketilenYemekId);
            if (enCokTuketilenYemek != null)
            {
                string enCokTuketilenYemekAdi = enCokTuketilenYemek.YemekAdi;
                int enCokTuketilenYemekSayisi = yemekTuketimSayilari[enCokTuketilenYemekId]; 

                string raporMesaji = $"Yemek Çeşidi Raporu ({startDate.ToShortDateString()} - {endDate.ToShortDateString()})\n" +
                      $"En Çok Yenilen Yemek: {enCokTuketilenYemekAdi} ({enCokTuketilenYemekSayisi} kez)";

                DisplayReport(raporMesaji);
            }
            else
            {
                MessageBox.Show("En çok tüketilen yemek bulunamadı.");
            }



            if (enCokTuketilenYemek.Gorsel != null)
            {
                using (MemoryStream ms = new MemoryStream(enCokTuketilenYemek.Gorsel))
                {
                    PictureBox gorsel = new PictureBox();
                    gorsel.SizeMode |= PictureBoxSizeMode.Zoom;
                    gorsel.Left = 120;
                    gorsel.Top = 10;
                    gorsel.Size = new Size(75, 75);
                    gorsel.Image = Image.FromStream(ms);
                }
            }

        }
    }
}
