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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-HLJBBVE\\MSSQLSERVER01;database=DiyetProgramiDb;uid=sa;pwd=123;trustservercertificate=true");
        }
    }
}
//asd