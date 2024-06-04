using EFDiyetProgramiProje_DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje_DAL.Entities
{
    public class Kullanici : BaseEntity
    {
        public string Ad { get; set; }
        public string Sifre { get; set; }

        public int? KullaniciBilgiId { get; set; }
        public KullaniciBilgi KullaniciBilgi { get; set; }

    }
}
