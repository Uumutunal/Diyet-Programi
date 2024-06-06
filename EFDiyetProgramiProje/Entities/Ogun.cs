using EFDiyetProgramiProje_DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje_DAL.Entities
{
    public class Ogun : BaseEntity
    {
        public string OgunAdi { get; set; }
        public List<OgunYemek> OgunYemekler { get; set; }

    }
}
