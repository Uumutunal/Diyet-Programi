using EFDiyetProgramiProje_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje_BL.Models
{
    public class YemekKategoriViewModel
    {
        public string KategoriAdi { get; set; }
        public List<YemekViewModel> Yemekler { get; set; }
    }
}
