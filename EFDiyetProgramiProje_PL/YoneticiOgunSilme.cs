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
using Microsoft.Extensions.Options;

namespace EFDiyetProgramiProje_PL
{
    public partial class YoneticiOgunSilme : Form
    {
        OgunManager ogunManager = new OgunManager();
        OgunViewModel ogun = new OgunViewModel();
        public YoneticiOgunSilme()
        {
            InitializeComponent();
            dgvOgunListesi.DataSource = ogunManager.GetAll();
            txtOgunAdi.Enabled = false;
            lblSilmeHata.Text = "";

        }
        //
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvOgunListesi.SelectedRows.Count < 1)
            {
                lblSilmeHata.Text = "Öğün seçmediniz!";
            }
            else
            {
                ogun = (OgunViewModel)dgvOgunListesi.SelectedRows[0].DataBoundItem;
                MessageBox.Show("Öğün başarıyla silindi!");
                ogunManager.Delete(ogun);
                dgvOgunListesi.DataSource = ogunManager.GetAll();
                lblSilmeHata.Text = "";
            }
        }

        private void dgvOgunListesi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOgunListesi.SelectedRows.Count > 0)
            {
                ogun = (OgunViewModel)dgvOgunListesi.SelectedRows[0].DataBoundItem;
                txtOgunAdi.Text = ogun.OgunAdi;
            }
        }
    }
}
