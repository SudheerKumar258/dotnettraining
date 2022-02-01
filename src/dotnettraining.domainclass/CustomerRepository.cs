using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetTraining.domainClass
{
    public class CustomerRepository
    {
        public Customer Retrieve(int custoner)
        {
            return new()
            {
                Id = 1,
                Name = "Amit",
                CustomerAddress = new List<Address>()
                {
                    new Address()
                    {
                        city="Bhopal"
                    },
                    new Address()
                    {
                        city="Indore"
                    }
                },

                EmailId = "sp@gmail.com",
                MobileNumber = 12345678
            };
        }
        public bool Save(Customer customer)
        {
            if (customer == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
