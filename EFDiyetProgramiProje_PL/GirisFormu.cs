using EFDiyetProgramiProje_BL.Manager.Concrete;
using EFDiyetProgramiProje_BL.Models;
using EFDiyetProgramiProje_DAL.Entities;
using EFDiyetProgramiProje_DAL.Enums;

namespace EFDiyetProgramiProje_PL
{
    public partial class GirisFormu : Form
    {
        public GirisFormu()
        {
            InitializeComponent();

            KullaniciManager kullaniciManager = new KullaniciManager();
            YemekManager yemekManager = new YemekManager();
            YemekKategoriManager yemekKategoriManager = new YemekKategoriManager();


            YemekKategoriViewModel yemekKategoriViewModel = new YemekKategoriViewModel()
            {
                KategoriAdi = "tatlý"
            };

            yemekKategoriManager.Insert(yemekKategoriViewModel);

            KullaniciViewModel kullanici = new KullaniciViewModel()
            {
                Ad = "k1",
                Sifre = "321",
                //DataStatus = DataStatus.Added
            };

            //kullaniciManager.Insert(kullanici);

            var admin = kullaniciManager.GetAll();

            foreach ( var adminItem in admin )
            {
                MessageBox.Show(adminItem.Ad);
            }
        }
    }
}
