using EFDiyetProgramiProje_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje_DAL.Context
{
    public class DiyetProgramiDbContext : DbContext
    {

        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<KullaniciBilgi> KullaniciBilgiler { get; set; }
        public DbSet<Ogun> Ogunler { get; set; }
        public DbSet<OgunYemek> OgunYemekler { get; set; }
        public DbSet<Yemek> Yemekler { get; set; }
        public DbSet<YemekKategori> YemekKategoriler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-HLJBBVE\\MSSQLSERVER01;database=DiyetProgramiDb;uid=sa;pwd=123;trustservercertificate=true");
        }
    }
}
