using EFDiyetProgramiProje_DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje_DAL.Entities
{
    public class OgunYemek : BaseEntity
    {
        public int OgunId { get; set; }
        public int YemekId { get; set; }
        public int KullaniciId { get; set; }
        public int BirimAdedi { get; set; }
        public DateOnly Tarih { get; set; }

        public Yemek Yemek { get; set; }
        public Ogun Ogun { get; set; }
        public Kullanici Kullanici { get; set; }
    }
}
