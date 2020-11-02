using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vansh_6th_MobileShop.BussinessLayer
{
    public class Model
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
