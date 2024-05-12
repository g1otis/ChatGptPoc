namespace CustomerApi;

using AutoMapper;
using CustomerApi.Controllers.Dtos.Create;
using CustomerApi.Controllers.Dtos.Read;
using CustomerApi.Controllers.Dtos.Update;
using CustomerApi.Models;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        // Read DTO mappings
        CreateMap<Customer, CustomerReadDto>();
        CreateMap<Origin, OriginReadDto>();
        CreateMap<Address, AddressReadDto>();
        CreateMap<Telephone, TelephoneReadDto>();

        // Create DTO mappings
        CreateMap<CustomerCreateDto, Customer>()
            .ForMember(c => c.Id, opt => opt.Ignore());  // Ignore Id as it is not needed during creation
        CreateMap<OriginCreateDto, Origin>();
        CreateMap<AddressCreateDto, Address>();
        CreateMap<TelephoneCreateDto, Telephone>();

        // Update DTO mappings
        CreateMap<CustomerUpdateDto, Customer>()
            .ForMember(c => c.Id, opt => opt.Ignore());  // Ignore Id to prevent updates
        CreateMap<OriginUpdateDto, Origin>();
        CreateMap<AddressUpdateDto, Address>();
        CreateMap<TelephoneUpdateDto, Telephone>();
    }
}