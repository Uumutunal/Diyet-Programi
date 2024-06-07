using EFDiyetProgramiProje_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje_BL.Models
{
    public class OgunYemekViewModel
    {
        public int Id { get; set; }
        public int OgunId { get; set; }
        public int YemekId { get; set; }
        public int KullaniciId { get; set; }
        public int BirimAdedi { get; set; }
        public DateOnly Tarih { get; set; }

        public YemekViewModel Yemek { get; set; }
        public OgunViewModel Ogun { get; set; }
    }
}
