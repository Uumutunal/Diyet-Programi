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
    public class YemekKategoriMappingProfile : Profile
    {
        public YemekKategoriMappingProfile()
        {
            CreateMap<YemekViewModel, Yemek>().ForMember(a => a.YemekKategori, b => b.MapFrom(b => b.YemekKategori)).ReverseMap();

        }
    }
}
