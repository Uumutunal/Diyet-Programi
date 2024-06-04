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
        public string Ad { get; set; }
        public string Sifre { get; set; }

        public int? KullaniciBilgiId { get; set; }
        public KullaniciBilgiViewModel KullaniciBilgi { get; set; }
    }
}
