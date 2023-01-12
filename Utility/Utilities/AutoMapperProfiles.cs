using AutoMapper;
using DTO.DTOs;
using EL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.Utilities
{
    public static class AutoMapperProfiles
    {
        public class AutoMapperProfile : Profile
        {
            public AutoMapperProfile()
            {
                CreateMap<Siparis, SiparisDTO>().ReverseMap();
                CreateMap<Firma,SiparisDTO >().ReverseMap();
                CreateMap<Urun, UrunDTO>().ReverseMap();
                CreateMap<Firma, FirmaDTO>().ReverseMap();
                CreateMap<Firma, FirmaToAddDTO>().ReverseMap();
                CreateMap<Firma, FirmaToUpdateDTO>().ReverseMap();
            }
        }
    }
}
