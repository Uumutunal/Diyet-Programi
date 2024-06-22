using EFDiyetProgramiProje_BL.Manager.Concrete;
using EFDiyetProgramiProje_BL.Models;
using EFDiyetProgramiProje_DAL.Entities;
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
    public partial class YoneticiRaporEkrani : Form
    {
        YemekManager yemekManager = new YemekManager();
        KullaniciManager kullaniciManager = new KullaniciManager();
        OgunYemekManager ogunYemekManager = new OgunYemekManager();
        OgunManager ogunManager = new OgunManager();
        public YoneticiRaporEkrani()
        {
            InitializeComponent();
            var kullanicilar = kullaniciManager.GetAll();
        }

        private void YoneticiRaporEkrani_Load(object sender, EventArgs e)
        {
            KullanicilariGoster();
            YemekleriGoster();
            dgvKullanicilar.ClearSelection();
            dgvKullanicilar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKullanicilar.MultiSelect = false;

            dgvYemekler.ClearSelection();
            dgvYemekler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvYemekler.MultiSelect = false;
        }

        private void YemekleriGoster()
        {
            var yemekler = yemekManager.GetAll().ToList();
            dgvYemekler.DataSource = yemekler;
        }

        private void KullanicilariGoster()
        {
            var kullanicilar = kullaniciManager.GetAll().Where(k => k.KullaniciAdi != "admin").ToList();
            dgvKullanicilar.DataSource = kullanicilar;
        }

        private void btnGunSonu_Click(object sender, EventArgs e)
        {
            lblHataMesaji.Text = "";

            if (dgvKullanicilar.SelectedRows.Count == 0)
            {
                lblHataMesaji.Text = "Lütfen bir kullanıcı seçin.";
                return;
            }

            int selectedUserId = (int)dgvKullanicilar.SelectedRows[0].Cells["Id"].Value;
            DateTime selectedDate = DateTime.Now; 

            var kullaniciOgunYemekler = ogunYemekManager.Search(y => y.KullaniciId == selectedUserId && y.Tarih == DateOnly.FromDateTime(selectedDate)).ToList();

            if (!kullaniciOgunYemekler.Any())
            {
                lblHataMesaji.Text = "Seçilen kullanıcı için yemek verisi bulunamadı.";
                return;
            }

            var ogunler = ogunManager.GetAll();

            pnlRapor.Controls.Clear();
            int top = 10;

            double gunlukToplamKalori = 0;

            foreach (var ogun in ogunler)
            {
                var ogunYemekler = kullaniciOgunYemekler.Where(y => y.OgunId == ogun.Id).ToList();
                double ogunKaloriToplam = ogunYemekler.Sum(y => (y.Yemek?.Kalori ?? 0) * y.BirimAdedi);

                Label lblOgunRapor = new Label
                {
                    Text = $"{ogun.OgunAdi}: {ogunKaloriToplam} Kcal",
                    AutoSize = true,
                    Location = new Point(10, top)
                };
                pnlRapor.Controls.Add(lblOgunRapor);
                top += 20;

                gunlukToplamKalori += ogunKaloriToplam;
            }

            Label lblGunlukToplam = new Label
            {
                Text = $"Günlük Toplam Kalori: {gunlukToplamKalori} Kcal",
                AutoSize = true,
                Location = new Point(10, top)
            };
            pnlRapor.Controls.Add(lblGunlukToplam);
        }

        private void btnKiyas_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpBaslangic.Value;
            DateTime endDate = dtpBitis.Value;

            lblHataMesaji.Text = "";

            if (dgvKullanicilar.SelectedRows.Count == 0)
            {
                lblHataMesaji.Text = "Lütfen bir kullanıcı seçin.";
                return;
            }

            int selectedUserId = (int)dgvKullanicilar.SelectedRows[0].Cells["Id"].Value;

            var kullaniciOgunYemekler = ogunYemekManager.Search(y => y.KullaniciId == selectedUserId && y.Tarih >= DateOnly.FromDateTime(startDate) && y.Tarih <= DateOnly.FromDateTime(endDate)).ToList();

            if (!kullaniciOgunYemekler.Any())
            {
                lblHataMesaji.Text = "Seçilen kullanıcı için belirtilen tarih aralığında yemek verisi bulunamadı.";
                return;
            }

            var ogunler = ogunManager.GetAll();

            pnlRapor.Controls.Clear();
            int top = 10;

            double toplamKalori = 0;

            foreach (var ogun in ogunler)
            {
                var ogunYemekler = kullaniciOgunYemekler.Where(y => y.OgunId == ogun.Id).ToList();
                double ogunKaloriToplam = ogunYemekler.Sum(y => (y.Yemek?.Kalori ?? 0) * y.BirimAdedi);

                Label lblOgunRapor = new Label
                {
                    Text = $"{ogun.OgunAdi}: {ogunKaloriToplam} Kcal",
                    AutoSize = true,
                    Location = new Point(10, top)
                };
                pnlRapor.Controls.Add(lblOgunRapor);
                top += 20;

                toplamKalori += ogunKaloriToplam;
            }

            Label lblToplamKalori = new Label
            {
                Text = $"Toplam Kalori: {toplamKalori} Kcal",
                AutoSize = true,
                Location = new Point(10, top)
            };
            pnlRapor.Controls.Add(lblToplamKalori);
        }

        private void btnYemekCesidi_Click(object sender, EventArgs e)
        {

            lblHataMesaji.Text = "";

            if (dgvYemekler.SelectedRows.Count == 0)
            {
                lblHataMesaji.Text = "Lütfen bir yemek seçin.";
                return;
            }

            int selectedMealId = (int)dgvYemekler.SelectedRows[0].Cells["Id"].Value;
            DateTime endDate = DateTime.Now;
            DateTime startDate = endDate.AddDays(-7);

            var yemekTuketimleri = ogunYemekManager.Search(y => y.YemekId == selectedMealId && y.Tarih >= DateOnly.FromDateTime(startDate) && y.Tarih <= DateOnly.FromDateTime(endDate)).ToList();

            if (!yemekTuketimleri.Any())
            {
                lblHataMesaji.Text ="Belirtilen tarih aralığında yemek tüketim bilgisi bulunamadı.";
                return;
            }

            var yemekKullaniciGruplari = yemekTuketimleri.GroupBy(y => y.KullaniciId).Select(g => new
            {
                KullaniciId = g.Key,
                Adet = g.Sum(y => y.BirimAdedi)
            }).ToList();

            pnlRapor.Controls.Clear();
            Label lblReportHeader = new Label
            {
                Text = $"Yemek Çeşidi Raporu - {startDate.ToShortDateString()} - {endDate.ToShortDateString()}",
                AutoSize = true,
                Location = new Point(10, 10)
            };
            pnlRapor.Controls.Add(lblReportHeader);

            int top = 30;
            foreach (var group in yemekKullaniciGruplari)
            {
                var kullanici = kullaniciManager.GetById(group.KullaniciId);
                Label lblUserReport = new Label
                {
                    Text = $"Kullanıcı: {kullanici.Id} - {kullanici.KullaniciAdi} - Adet: {group.Adet}",
                    AutoSize = true,
                    Location = new Point(10, top)
                };
                pnlRapor.Controls.Add(lblUserReport);
                top += 20;
            }
        }
    }
}
