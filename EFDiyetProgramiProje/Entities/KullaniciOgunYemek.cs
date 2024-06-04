using EFDiyetProgramiProje_DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje_DAL.Entities
{
    public class KullaniciOgunYemek : BaseEntity
    {
        public int KullaniciId { get; set; }
        public int OgunYemekId { get; set; }

        public List<OgunYemek> OgunYemekler { get; set; }
        public Kullanici Kullanici { get; set; }
    }
}
