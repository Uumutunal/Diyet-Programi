using EFDiyetProgramiProje_DAL.Context;
using EFDiyetProgramiProje_DAL.Entities;
using EFDiyetProgramiProje_DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje_DAL.Repository.Concrete
{
    public class YemekRepository : Repository<Yemek>
    {
        public YemekRepository(DiyetProgramiDbContext db) : base(db)
        {
            
        }
    }
}
