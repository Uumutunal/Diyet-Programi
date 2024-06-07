using AutoMapper;
using EFDiyetProgramiProje_BL.Models;
using EFDiyetProgramiProje_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje_BL.MappingProfiles
{
    public class KullaniciBilgiMappingProfile : Profile
    {
        public KullaniciBilgiMappingProfile()
        {
            CreateMap<KullaniciViewModel, Kullanici>().ForMember(a => a.KullaniciBilgi, b => b.MapFrom(b => b.KullaniciBilgi)).ReverseMap();

        }

    }

}
