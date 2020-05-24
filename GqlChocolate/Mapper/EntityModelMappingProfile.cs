using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GqlChocolate.Mapper
{
    public class EntityModelMappingProfile : Profile
    {
        public EntityModelMappingProfile()
        {
            CreateMap<Entities.Locations, GraphQL.Types.LocationType>()
                .ForCtorParam("code", opt => opt.MapFrom(src => src.Code))
                .ForCtorParam("name", opt => opt.MapFrom(src => src.Name))
                .ForCtorParam("isActive", opt => opt.MapFrom(src => src.Active))
                .ReverseMap();

            CreateMap<Entities.Tags, GraphQL.Types.TagType>()
                .ForCtorParam("title", opt => opt.MapFrom(src => src.Title))
                .ForCtorParam("description", opt => opt.MapFrom(src => src.Description))
                .ForCtorParam("isActive", opt => opt.MapFrom(src => src.Active))
                .ReverseMap();
        }
    }
}
