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

        public CreditCard CreditCard { get; set; }

        public string GetFullName()//get kullanırsak otomatik olarak eşleşme gerçekleşecek kullanmaz isek mapping sınıfında ile belirtmemiz gerekli
        {
            return $"{Name}-{Email}-{Age}";
        }




    }
}
