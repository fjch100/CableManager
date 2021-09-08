using AutoMapper;
using CableManager.WinForm.DTOs;
using CableManager.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CableManager.WinForm.Mapper_Profiles
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
