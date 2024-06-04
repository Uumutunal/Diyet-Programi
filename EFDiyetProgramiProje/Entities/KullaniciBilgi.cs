using EFDiyetProgramiProje_DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje_DAL.Entities
{
    public class KullaniciBilgi : BaseEntity
    {
        public int? Yas { get; set; }
        public double? Kilo { get; set; }
        public double? Boy { get; set; }
        public string? Cinsiyet { get; set; }
        public Kullanici Kullanici { get; set; }
    }
}
