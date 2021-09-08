using AutoMapper;
using CableManager.Modelos;
using CableManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CableManager.Mapper_Profiles
{
    public class CarreraProfile : Profile
    {
        public CarreraProfile()
        {
            CreateMap<Carrera, CarreraDto>()
                .ForMember(dest => dest.CableNumero, opt => opt.MapFrom(src => src.Cable.Numero));
            CreateMap<CarreraDto, Carrera>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
