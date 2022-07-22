using AutoMapper;
using PersonalPortfolio.Entities.Concrete.Models;
using PersonalPortfolio.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolio.Entities.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
        CreateMap<Contact, ContactDto>();
        CreateMap<Home, HomeDto>();
        CreateMap<Repo, RepoDto>();
        CreateMap<About, AboutDto>();
        }

    }
}
