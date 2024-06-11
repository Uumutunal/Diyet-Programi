using EFDiyetProgramiProje_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje_BL.Models
{
    public class KullaniciViewModel
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string? GuvenlikSorusu { get; set; }
        public string? GuvenlikYaniti { get; set; }
        public string Sifre { get; set; }
        public string? Sifre2 { get; set; }
        public string? Sifre3 { get; set; }
        public string? Sifre4 { get; set; }
        public KullaniciBilgiViewModel KullaniciBilgi { get; set; }
        public List<OgunYemekViewModel> OgunYemekler { get; set; }

    }
}
