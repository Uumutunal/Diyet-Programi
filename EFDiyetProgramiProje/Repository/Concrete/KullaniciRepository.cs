﻿using EFDiyetProgramiProje_DAL.Context;
using EFDiyetProgramiProje_DAL.Entities;
using EFDiyetProgramiProje_DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje_DAL.Repository.Concrete
{
    public class KullaniciRepository : Repository<Kullanici>
    {
        public KullaniciRepository(DiyetProgramiDbContext db) : base(db)
        {
            
        }
    }
}