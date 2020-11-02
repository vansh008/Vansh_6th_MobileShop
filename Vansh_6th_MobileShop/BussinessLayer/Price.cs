using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vansh_6th_MobileShop.BussinessLayer
{
    public class Price
    {
        public int ID { get; set; }
        public decimal Rate { get; set; }
        public List<Customer> Customers { get; set; }

    }
}
