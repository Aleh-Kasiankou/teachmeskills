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
            var map = CreateMap<AttributeCreateRequest, AttributeEntity>().ForMember(d => d.PossibleValues,
                opt => opt.MapFrom((attributeCreateRequest, attributeEntity, i, context) =>
                    context.Mapper.Map<IEnumerable<PossibleValueCreateRequest>, IEnumerable<PossibleValueEntity>>(
                        attributeCreateRequest.PossibleValues)));

            CreateMap<PossibleValueCreateRequest, PossibleValueEntity>();

            CreateMap<AttributeUpdateRequest, AttributeEntity>()
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