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
using Microsoft.Identity.Client.NativeInterop;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EFDiyetProgramiProje_PL
{

    public partial class KullaniciKontrolPaneli : Form
    {
        KullaniciManager kullaniciManager = new KullaniciManager();
        KullaniciBilgiManager kullaniciBilgiManager = new KullaniciBilgiManager();
        YemekManager yemekManager = new YemekManager();
        YemekKategoriManager YemekKategoriManager = new YemekKategoriManager();
        OgunYemekManager OgunYemekManager = new OgunYemekManager();
        OgunManager ogunManager = new OgunManager();
        YemekViewModel secilenYemek = new YemekViewModel();
        List<OgunViewModel> kullaniciOgunYemekler;

        DateTime tarih;

        double gunlukToplamKalori;


        private int kullaniciId;
        public KullaniciKontrolPaneli(int mevcutKullaniciId)
        {
            InitializeComponent();
            timer1.Enabled = true;
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
                //lblBMI.Text = Convert.ToString(kullaniciBilgileri.VucutKitleEndeksi);
                lblBMI.Text = Math.Round(kullaniciBilgileri.VucutKitleEndeksi.GetValueOrDefault(), 2).ToString();
                //lblBMR.Text = Convert.ToString(kullaniciBilgileri.BazalMetabolizmaHizi);
                lblBMR.Text = Math.Round(kullaniciBilgileri.BazalMetabolizmaHizi.GetValueOrDefault(), 2).ToString();
                lblBoy.Text = Convert.ToString(kullaniciBilgileri.Boy);
                lblYas.Text = Convert.ToString(kullaniciBilgileri.Yas);
                lblHedefKilo.Text = Convert.ToString(kullaniciBilgileri.HedefKilo);
                lblKilo.Text = Convert.ToString(kullaniciBilgileri.Kilo);
                lblCinsiyet.Text = kullaniciBilgileri.Cinsiyet;
            }


            monthCalendar1.MaxSelectionCount = 2;
            tarih = monthCalendar1.SelectionStart;

            //kullaniciOgunYemekler = OgunYemekManager.Search(s => s.KullaniciId == mevcutKullaniciId);
            kullaniciOgunYemekler = ogunManager.GetAll();

            //yemek listele
            YemekListeleButunOgunler();



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


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            tarih = monthCalendar1.SelectionStart;

            //yemek listele
            YemekListeleButunOgunler();
        }


        void YemekListeleButunOgunler()
        {
            int sayac = 0;
            pnlYemekler.Controls.Clear();
            gunlukToplamKalori = 0;
            foreach (var kullaniciOgunYemek in kullaniciOgunYemekler)
            {
                YemekListele(kullaniciOgunYemek.Id, sayac);
                sayac++;
            }
            lblGunlukToplamKalori.Text = gunlukToplamKalori.ToString();
        }

        void YemekListele(int ogunId, int sayac)
        {

            var ogun = ogunManager.GetById(ogunId);

            if (ogun == null)
            {
                ogun = ogunManager.GetDeletedById(ogunId);
            }


            //

            int inc = 250;

            Button buttonEkle = new Button();

            buttonEkle.Text = "Ekle";
            buttonEkle.Size = new Size(227, 70);
            buttonEkle.Top = 3;
            buttonEkle.Click += (sender, e) => btnEkle_Click(sender, e, ogunId);
            buttonEkle.Left = 3 + inc * sayac;


            Label ogunLabel = new Label();
            ogunLabel.Text = ogun.OgunAdi + ":";
            ogunLabel.Top = 90;
            ogunLabel.Left = 3 + inc * sayac;
            ogunLabel.AutoSize = true;

            Label kaloriLabel = new Label();
            kaloriLabel.Text = "Toplam Kalori(kcal): ";
            kaloriLabel.Top = 90;
            kaloriLabel.Left = 3 + inc * sayac + 70;
            kaloriLabel.AutoSize = true;


            Label kaloriGosterLabel = new Label();
            kaloriGosterLabel.Text = "";
            kaloriGosterLabel.Top = 90;
            kaloriGosterLabel.Left = 3 + inc * sayac + 190;
            kaloriGosterLabel.AutoSize = true;
            kaloriGosterLabel.Tag = ogunId;


            FlowLayoutPanel flpYemekler = new FlowLayoutPanel();
            flpYemekler.Size = new Size(225, 415);
            flpYemekler.Top = 120;
            flpYemekler.Tag = ogunId;
            flpYemekler.Left = 3 + inc * sayac;
            flpYemekler.AutoScroll = true;


            pnlYemekler.Controls.Add(buttonEkle);
            pnlYemekler.Controls.Add(ogunLabel);
            pnlYemekler.Controls.Add(kaloriLabel);
            pnlYemekler.Controls.Add(kaloriGosterLabel);
            pnlYemekler.Controls.Add(flpYemekler);

            //

            var ogunYemekler = OgunYemekManager.Search(s => s.Tarih == DateOnly.FromDateTime(tarih) && s.OgunId == ogunId);




            double? kaloriToplam = 0;
            foreach (var ogunYemek in ogunYemekler)
            {
                kaloriToplam += YemekEkle(ogunYemek, ogunId);
            }
            kaloriGosterLabel.Text = kaloriToplam.ToString();

            gunlukToplamKalori += kaloriToplam.GetValueOrDefault();

        }

        double? YemekEkle(OgunYemekViewModel ogunYemek, int ogunId)
        {

            Panel panel = new Panel();


            var eklenenYemek = yemekManager.Search(s => s.Id == ogunYemek.YemekId).FirstOrDefault();

            if (eklenenYemek == null)
            {
                eklenenYemek = yemekManager.GetDeletedById(ogunYemek.YemekId);
            }


            Label yemekAdi = new Label();
            yemekAdi.Text = "Yemek Adı: " + eklenenYemek.YemekAdi;
            yemekAdi.Top = 0;
            yemekAdi.AutoSize = true;


            Label kalori = new Label();
            kalori.Text = "Kalori: " + eklenenYemek.Kalori + " Kcal";
            kalori.Top = 30;
            kalori.AutoSize = true;



            Label adet = new Label();
            adet.Text = "Adet: " + ogunYemek.BirimAdedi + " " + eklenenYemek.Birim;
            adet.Top = 60;
            adet.AutoSize = true;

            PictureBox gorsel = new PictureBox();

            if (eklenenYemek.Gorsel != null)
            {
                using (MemoryStream ms = new MemoryStream(eklenenYemek.Gorsel))
                {
                    //null hatası
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



            //
            FlowLayoutPanel flpYemek = new FlowLayoutPanel();

            foreach (Control control in pnlYemekler.Controls)
            {
                if (control is FlowLayoutPanel)
                {
                    FlowLayoutPanel flp = (FlowLayoutPanel)control;
                    int tag = (int)flp.Tag;
                    if (tag == ogunId)
                    {
                        flpYemek = (FlowLayoutPanel)control;
                    }
                }
            }

            flpYemek.Controls.Add(panel);

            //



            return eklenenYemek.Kalori * ogunYemek.BirimAdedi;
        }


        private void btnEkle_Click(object sender, EventArgs e, int id)
        {
            if (!YemekEklemeKontrol())
            {
                return;
            }
            OgunYemekViewModel eklenenYemek = new OgunYemekViewModel();
            eklenenYemek.YemekId = secilenYemek.Id;
            eklenenYemek.OgunId = id;
            eklenenYemek.Tarih = DateOnly.FromDateTime(tarih);
            eklenenYemek.KullaniciId = kullaniciId;
            eklenenYemek.BirimAdedi = Convert.ToInt32(txtAdet.Text);

            OgunYemekManager.Insert(eklenenYemek);

            YemekListeleButunOgunler();
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

            //yemek listele
            YemekListeleButunOgunler();
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


            double toplamKalori = 0;

            Dictionary<string, double> ogunKalorileri = new Dictionary<string, double>
            {
            };
            foreach (Control control in pnlYemekler.Controls)
            {
                if (control is Label && control.Tag != null)
                {
                    ogunKalorileri.Add(ogunManager.GetById(Convert.ToInt32(control.Tag)).OgunAdi, Convert.ToDouble(control.Text));
                    toplamKalori += Convert.ToDouble(control.Text);
                }
            }
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

            if (yemek == null)
            {
                yemek = yemekManager.GetDeletedById(yemekId);
            }

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
            var yemekTuketimSayilari = yemekTuketimleri.GroupBy(y => y.YemekId).ToDictionary(g => g.Key, g => g.Count());

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] motivasyonSozleri =
            {
                "Sağlığınız, sahip olabileceğiniz en değerli varlıktır.",
                "Bir şeyi gerçekten istersen, buna engel olabilecek hiçbir şey yoktur.",
                "Diyet yapmak değil, yaşam tarzını değiştirmek önemlidir.",
                "Her büyük başarı, küçük adımlarla başlar.",
                "Kendine iyi bak. Seninle geçireceğin hayatın geri kalanı için tek bedenin var. ",
                "Diyet yapmak, kendinize olan sevginizi göstermenin en iyi yoludur. ",
                "İyi bir ruh halinden sadece bir egzersiz uzaklıktasın.",
                "İlerlemek için mücadele et, mükemmellik için değil.",
                "Sağlığın korunması, hastalığın tedavisinden daha kolaydır.",
                "Diyetinizde hedeflerinizi açık ve ölçülebilir yapın, böylece ilerlemeyi takip edebilirsiniz.",
                "Başarı, güçlü bir niyetle başlar ve sürekli bir çaba ile devam eder.",
                "Başarılı olmak için, her gün bir adım atmanız yeterlidir.",
                "Bu kez vazgeçmezsen neler olacağını görmek istemez misin?",
            };
            Random random = new Random();
            int uzunluk = motivasyonSozleri.Length;
            lblMotivasyonSozleri.Text = motivasyonSozleri[random.Next(0, uzunluk)];
            
        }
    }
}
