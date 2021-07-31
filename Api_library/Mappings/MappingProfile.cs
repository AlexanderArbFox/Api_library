using Api_library.Models;
using AutoMapper;
using Library.Db.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_library.Mappings
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<DbUser, DtoUser>()
                .ReverseMap();
            CreateMap<DbBooks, DtoBooks>()
                .ReverseMap();
            CreateMap<DbAuthors, DtoAthors>()
              .ReverseMap();
        }
    }
}
