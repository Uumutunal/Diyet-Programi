using EFDiyetProgramiProje_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje_BL.Models
{
    public class YemekViewModel
    {
        public int Id { get; set; }
        public string? YemekAdi { get; set; }
        public string? Birim { get; set; }
        public double? Kalori { get; set; }
        public string? Tarif { get; set; }
        public byte[]? Gorsel { get; set; }

        public int? YemekKategoriId { get; set; }
        public YemekKategoriViewModel YemekKategori { get; set; }
        public List<OgunYemekViewModel> OgunYemekler { get; set; }
    }
}
