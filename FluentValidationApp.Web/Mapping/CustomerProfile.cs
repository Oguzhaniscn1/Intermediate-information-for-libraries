using AutoMapper;
using FluentValidationApp.Web.DTOs;
using FluentValidationApp.Web.Models;

namespace FluentValidationApp.Web.Mapping
{
    public class CustomerProfile:Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerDto>()
                .ForMember(dest => dest.Isim, opt => opt.MapFrom(x => x.Name))//name olanı isim ile eşleştir//entity isimleri aynı olduğu için otomatik olarak kullandığımız entityi eşleyebiliyor.
                .ForMember(dest => dest.Eposta, opt => opt.MapFrom(x => x.Email))
                .ForMember(dest => dest.Yas, opt => opt.MapFrom(x => x.Age));
            CreateMap<CustomerDto, Customer>();
        }

    }
}
