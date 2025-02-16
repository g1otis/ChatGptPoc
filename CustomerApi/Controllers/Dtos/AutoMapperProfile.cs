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
        CreateMap<TelephoneCreateDto, Telephone>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())  // Ignoring Id since it's likely set by the database
            .ForMember(dest => dest.CustomerId, opt => opt.Ignore())  // Ignoring CustomerId if it's not part of the DTO
            .ForMember(dest => dest.Customer, opt => opt.Ignore());  // Ignoring Customer object mapping;

        // Update DTO mappings
        CreateMap<CustomerUpdateDto, Customer>()
            .ForMember(c => c.Id, opt => opt.Ignore());  // Ignore Id to prevent updates
        CreateMap<OriginUpdateDto, Origin>();
        CreateMap<AddressUpdateDto, Address>();
        CreateMap<TelephoneUpdateDto, Telephone>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())  // Id should not be updated from DTO
            .ForMember(dest => dest.CustomerId, opt => opt.Ignore())
            .ForMember(dest => dest.Customer, opt => opt.Ignore());;
    }
}