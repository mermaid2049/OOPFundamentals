using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; set; }

        public Order Retrieve(int orderId)
        {
            //Retrieves one order that retrieves the defined order
            return new Order(); 
        }

        public bool Save()
        {
            return true ; 

        }

        public bool OrderValidate()
        {
            var isValid = true;

            if (OrderDate == null)isValid = false;

            return isValid;

        }
    }
}
