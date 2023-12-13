using System.Security;

namespace FluentValidationApp.Web.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public DateTime? BirthDay { get; set; }

        //customer.address[0,1,2].ıd,postcode
        public IList<Address> Address { get; set; }

        public Gender Gender { get; set; }
    }
}
