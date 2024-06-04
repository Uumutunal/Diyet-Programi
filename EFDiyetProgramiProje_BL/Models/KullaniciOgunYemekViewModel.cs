using EFDiyetProgramiProje_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje_BL.Models
{
    public class KullaniciOgunYemekViewModel
    {
        public int KullaniciId { get; set; }
        public int OgunYemekId { get; set; }

        public List<OgunYemekViewModel> OgunYemekler { get; set; }
        public KullaniciViewModel Kullanici { get; set; }
    }
}
