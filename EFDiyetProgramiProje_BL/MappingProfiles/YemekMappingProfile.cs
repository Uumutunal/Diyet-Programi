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
    public class YemekMappingProfile : Profile
    {
        public YemekMappingProfile()
        {
            CreateMap<OgunYemekViewModel, OgunYemek>().ForMember(a => a.Yemek, b => b.MapFrom(b => b.Yemek)).ReverseMap();
            CreateMap<YemekKategoriViewModel, YemekKategori>().ForMember(a => a.Yemekler, b => b.MapFrom(b => b.Yemekler)).ReverseMap();
        }
    }
}
