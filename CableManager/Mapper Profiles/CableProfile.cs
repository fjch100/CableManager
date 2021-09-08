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
    public class CableProfile : Profile
    {
        public CableProfile()
        {
            CreateMap<Cable, CableDto>();
            CreateMap<CableDto, Cable>().ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
