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
    public class OgunYemekMappingProfile : Profile
    {
        public OgunYemekMappingProfile()
        {
            CreateMap<YemekViewModel, Yemek>().ForMember(a => a.OgunYemekler, b => b.MapFrom(b => b.OgunYemekler)).ReverseMap();
            CreateMap<OgunViewModel, Ogun>().ForMember(a => a.OgunYemekler, b => b.MapFrom(b => b.OgunYemekler)).ReverseMap();
            CreateMap<KullaniciViewModel, Kullanici>().ForMember(a => a.OgunYemekler, b => b.MapFrom(b => b.OgunYemekler)).ReverseMap();
        }
    }
}
