using EFDiyetProgramiProje_DAL.Entities;
using EFDiyetProgramiProje_DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje_BL.Models
{
    public class OgunViewModel
    {
        public int Id { get; set; }
        public string OgunAdi { get; set; }
        public List<OgunYemekViewModel> OgunYemekler { get; set; }
    }
}
