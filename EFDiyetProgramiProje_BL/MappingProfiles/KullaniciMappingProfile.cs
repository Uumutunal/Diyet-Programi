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
    public class KullaniciMappingProfile : Profile
    {
        public KullaniciMappingProfile()
        {
            CreateMap<KullaniciBilgiViewModel, KullaniciBilgi>().ForMember(a => a.Kullanici, b => b.MapFrom(b => b.Kullanici)).ReverseMap();
            CreateMap<KullaniciOgunYemekViewModel, KullaniciOgunYemek>().ForMember(a => a.Kullanici, b => b.MapFrom(b => b.Kullanici)).ReverseMap();
        }
    }
}
