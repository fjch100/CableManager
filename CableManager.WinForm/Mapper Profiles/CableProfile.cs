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
    public class CableProfile : Profile
    {
        public CableProfile()
        {
            CreateMap<Cable, CableDto>();
            CreateMap<CableDto, Cable>().ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
