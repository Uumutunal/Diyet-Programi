using EFDiyetProgramiProje_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje_BL.Models
{
    public class KullaniciViewModel
    {
        public string KullaniciAdi { get; set; }
        public string EPostaAdresi { get; set; }
        public string? Sifre { get; set; }
        public string Sifre2 { get; set; }
        public string Sifre3 { get; set; }
        public string Sifre4 { get; set; }

        public int? KullaniciBilgiId { get; set; }
        public KullaniciBilgiViewModel KullaniciBilgi { get; set; }
        public List<OgunYemekViewModel> OgunYemekler { get; set; }

    }
}
