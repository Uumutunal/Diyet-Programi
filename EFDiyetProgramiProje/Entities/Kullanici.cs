using EFDiyetProgramiProje_DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje_DAL.Entities
{
    public class Kullanici : BaseEntity
    {
        public string Ad { get; set; }
        public string Sifre { get; set; }
        public int KullaniciBilgisiId { get; set; }

    }
}
//8956