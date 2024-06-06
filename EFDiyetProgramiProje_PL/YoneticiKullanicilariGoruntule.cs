using EFDiyetProgramiProje_BL.Manager.Concrete;
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
    public partial class YoneticiKullanicilariGoruntule : Form
    {
        KullaniciManager kullaniciManager=new KullaniciManager();
        public YoneticiKullanicilariGoruntule()
        {
            InitializeComponent();
            dgvKullanicilar.DataSource = kullaniciManager.GetAll();
        }
    }
}
