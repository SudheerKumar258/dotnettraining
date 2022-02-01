using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetTraining.domainClass
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            return new Order
            {
                Id = orderId,
                CustomerId = 1,
                OrderDate = DateTime.Now,
                OrderItems = new List<OrderItem>()
                {
                    new OrderItem() { Id = 1, ProductId = 1, PurchasePrice = 123, SallingePrice = 321, Unit = 5 }
                },
                ShippingAddressId = 1
            };

        }
        public bool Save(Order order)
        {
            return order == null ? false : true;
        }
    }
}
