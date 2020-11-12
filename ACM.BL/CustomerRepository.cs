using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {

        //Retrieve and Save 


        public Customer Retrieve(int customerId)
        {
            var customer = new Customer (customerId);

            if (customerId==1)
            {

                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }

            return customer;
        }


        public bool Save(Customer customer)
        {
            return true;
        }
    }

}
