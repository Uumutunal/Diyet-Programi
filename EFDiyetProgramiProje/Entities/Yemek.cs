using EFDiyetProgramiProje_DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje_DAL.Entities
{
    public class Yemek : BaseEntity
    {
        public string? YemekAdi { get; set; }
        public string? Birim { get; set; }
        public double? Kalori { get; set; }
        public string? Tarif { get; set; }
        public byte[]? Gorsel { get; set; }

        public int? YemekKategoriId { get; set; }
        public YemekKategori YemekKategori { get; set; }
        public List<OgunYemek> OgunYemekler { get; set; }
    }
}
