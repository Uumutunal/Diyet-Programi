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
    public class OgunMappingProfile : Profile
    {
        public OgunMappingProfile()
        {
            CreateMap<OgunYemekViewModel, OgunYemek>().ForMember(a => a.Ogun, b => b.MapFrom(b => b.Ogun)).ReverseMap();

        }
    }
}
