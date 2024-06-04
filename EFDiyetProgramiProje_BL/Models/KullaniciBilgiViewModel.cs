using EFDiyetProgramiProje_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje_BL.Models
{
    public class KullaniciBilgiViewModel
    {
        public int Yas { get; set; }
        public double Kilo { get; set; }
        public double Boy { get; set; }
        public string Cinsiyet { get; set; }
        public KullaniciViewModel Kullanici { get; set; }
    }
}
