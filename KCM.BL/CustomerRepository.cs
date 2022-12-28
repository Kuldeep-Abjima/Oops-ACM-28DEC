using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCM.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
            

            if(customerId ==1)
            {
                customer.EmailAddress = "Hulk@gmail.com";
                customer.FirstName = "Tony";
                customer.LastName = "Stark";

            }
            return customer;
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
