using EFDiyetProgramiProje_DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje_DAL.Entities
{
    public class YemekKategori : BaseEntity
    {
        public string KategoriAdi { get; set; }
        public List<Yemek> Yemekler { get; set; }
    }
}
