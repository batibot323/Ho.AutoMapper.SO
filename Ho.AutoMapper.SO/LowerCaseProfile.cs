using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ho.AutoMapper.SO
{
    public class LowerCaseProfile : Profile
    {
        public LowerCaseProfile()
        {
            CreateMap<Person, Human>()
                    .ForMember(d => d.Name, opt => opt.MapFrom(src => src.Name.ToLower()));
        }
    }
}
