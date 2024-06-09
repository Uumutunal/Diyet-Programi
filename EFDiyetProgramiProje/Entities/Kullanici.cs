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
        public string KullaniciAdi { get; set; }
        public string? GuvenlikSorusu { get; set; }
        public string? GuvenlikYaniti { get; set; }
        public string? HatirlaSifre {  get; set; }
        public string Sifre { get; set; }
        public string? Sifre2 { get; set; }
        public string? Sifre3 { get; set; }
        public string? Sifre4 { get; set; }
        public KullaniciBilgi KullaniciBilgi { get; set; }
        public List<OgunYemek> OgunYemekler { get; set; }

    }
}
