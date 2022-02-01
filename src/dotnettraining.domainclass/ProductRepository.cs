using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetTraining.domainClass
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            return new Product()
            {
                Id = productId,
                ProductName = "abc",
                ProductDescription = "xyz",
                CurrentPrice = 123
            };
        }
        public bool Save(Product product)
        {
            return product == null ? false : true;
        }
    }
}
