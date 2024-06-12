using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFDiyetProgramiProje_BL.Manager.Concrete;
using EFDiyetProgramiProje_BL.Models;
using EFDiyetProgramiProje_DAL.Context;
using EFDiyetProgramiProje_DAL.Entities;
using EFDiyetProgramiProje_PL.Properties;

namespace EFDiyetProgramiProje_PL
{
    public partial class YoneticiOgunGuncelle : Form
    {
        OgunManager ogunManager = new OgunManager();
        public YoneticiOgunGuncelle()
        {
            InitializeComponent();
            var ogunler = ogunManager.GetAll();
            ogunler.AddRange(ogunManager.GetAllDeleted());

            dgvOgunListesi.DataSource = ogunManager.GetAll();
            //dgvOgunListesi.DataSource = ogunler;
            lblGuncelleHata.Text = "Lütfen değiştireceğiniz öğün adını listeden seçiniz!";
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var ogun = (OgunViewModel)dgvOgunListesi.SelectedRows[0].DataBoundItem;
            if ( ogun == null)
            {
                lblGuncelleHata.Text = "Öğün seçmediniz! Lütfen öğün seçiniz!";
            }
            else if (txtYeniOgunAdi.Text == null)
                lblGuncelleHata.Text = "Yeni öğün adı girmediniz! Lütfen öğün adı giriniz!";
            else
            {
                lblGuncelleHata.Text = "";
                var ogunAdiVarMi = ogunManager.Search(o => o.OgunAdi == txtYeniOgunAdi.Text).FirstOrDefault();
                if (ogunAdiVarMi != null)
                {
                    MessageBox.Show("Bu öğün adı listede bulunmaktadır! Başka ögün adı deneyiniz!");
                }
                else if (ogunAdiVarMi == null)
                {
                    ogun.OgunAdi = txtYeniOgunAdi.Text;
                    ogunManager.Update(ogun);
                    MessageBox.Show("Öğün adı başarıyla güncellendi!");
                    dgvOgunListesi.DataSource = ogunManager.GetAll();
                }

            }

        }
    }
}
