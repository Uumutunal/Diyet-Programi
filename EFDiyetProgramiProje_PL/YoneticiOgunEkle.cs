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
    public partial class YoneticiOgunEkle : Form
    {
        OgunManager ogunManager = new OgunManager();
        public YoneticiOgunEkle()
        {
            InitializeComponent();
            dgvOgunListesi.DataSource = ogunManager.GetAll();
            lblEkleHata.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            var ogun = ogunManager.Search(o=>o.OgunAdi==txtOgunEkle.Text).FirstOrDefault();
            if(txtOgunEkle.Text==null)
            {
                lblEkleHata.Text = "Öğün ismini boş bıraktınız!";
            }
            else if (ogun!=null)
            {
                lblEkleHata.Text = "Bu öğün listede bulunmaktadır! Başka ögün deneyiniz!";
            }
            else
            {
                lblEkleHata.Text = "";
                MessageBox.Show("Yeni öğün Başarıyla eklendi!");
                OgunViewModel yeniOgun = new OgunViewModel()
                {
                    OgunAdi = txtOgunEkle.Text
                };
                ogunManager.Insert(yeniOgun);
                dgvOgunListesi.DataSource = ogunManager.GetAll();
            }
        }
    }
}
