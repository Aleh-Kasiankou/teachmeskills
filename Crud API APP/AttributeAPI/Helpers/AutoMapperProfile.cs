using System.Collections.Generic;
using API.Entities;
using API.Models.Attribute;
using API.Models.PossibleValues;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            var map = CreateMap<AttributeCreateRequest, Attribute>();
            
            CreateMap<PossibleValueCreateRequest, PossibleValue>();

            CreateMap<AttributeUpdateRequest, Attribute>()
                .ForAllMembers(x => x.Condition(
                    (src, dest, prop) =>
                    {
                        if (prop == null) return false;
                        if (prop is string && string.IsNullOrEmpty((string)prop)) return false;

                        return true;
                    }
                ));
        }
    }
}