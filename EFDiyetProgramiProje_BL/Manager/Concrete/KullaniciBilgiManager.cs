using EFDiyetProgramiProje_BL.Manager.Abstract;
using EFDiyetProgramiProje_BL.MappingProfiles;
using EFDiyetProgramiProje_BL.Models;
using EFDiyetProgramiProje_DAL.Context;
using EFDiyetProgramiProje_DAL.Entities;
using EFDiyetProgramiProje_DAL.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje_BL.Manager.Concrete
{
    public class KullaniciBilgiManager : Manager<KullaniciBilgiViewModel, KullaniciBilgi, KullaniciBilgiMappingProfile>
    {
        public KullaniciBilgiManager()
        {
            _repository = new KullaniciBilgiRepository(new DiyetProgramiDbContext());
        }
    }
}
