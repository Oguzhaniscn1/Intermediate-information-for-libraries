using AutoMapper;
using FluentValidationApp.Web.DTOs;
using FluentValidationApp.Web.Models;

namespace FluentValidationApp.Web.Mapping
{
    public class CustomerProfile:Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerDto>();//entity isimleri aynı olduğu için otomatik olarak kullandığımız entityi eşleyebiliyor.
            CreateMap<CustomerDto, Customer>();
        }

    }
}
