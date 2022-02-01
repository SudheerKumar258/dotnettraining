using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetTraining.domainClass
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? SallingePrice { get; set; }
        public decimal? Unit { get; set; }
        public bool Validate()
        {
            return true;
        }
    }
}
