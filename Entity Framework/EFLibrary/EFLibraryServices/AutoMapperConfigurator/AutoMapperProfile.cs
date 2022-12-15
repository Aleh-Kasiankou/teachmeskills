using AutoMapper;

namespace EFLibraryServices.AutoMapperConfigurator
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            /*CreateMap<InitiativePostRequest, Initiative>();*/
            
         
            
          

            /*CreateMap<PossibleValueCreateRequest, PossibleValue>();

            CreateMap<AttributeUpdateRequest, Attribute>()
                .ForAllMembers(x => x.Condition(
                    (src, dest, prop) =>
                    {
                        if (prop == null) return false;
                        if (prop is string && string.IsNullOrEmpty((string)prop)) return false;

                        return true;
                    }
                ));*/
        }
    }
}