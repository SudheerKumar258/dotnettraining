using System;
using System.Collections.Generic;
namespace dotNetTraining.domainClass
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long MobileNumber { get; set; }
        public string EmailId { get; set; }
        public List<Address> CustomerAddress { get; set; }
        public bool Validate()
        {
            return true;
        }
    }
}
