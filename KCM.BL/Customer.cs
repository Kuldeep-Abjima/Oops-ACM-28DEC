using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCM.BL
{
    public class Customer
    {
        public Customer()
        {
            
        }
        public Customer(int customerId)
        {
            CustomerID = customerId;
        }
        public List<Address> Addresses { get; set; }
        public int CustomerID { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                string fullName = FirstName;
                if(!string.IsNullOrWhiteSpace(LastName)) {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName+= LastName;
                
                }
                return fullName;

            }
        }
        public static int InstanceCount { get; set; }

        private string _lastName;
        public string LastName
        {
            get
            {

                return _lastName;

            }
            set
            {
                _lastName = value;
            }



        }
        //public bool Save()
        //{
        //    return true;
        //}
        //public Customer Retrieve(int customerID)
        //{
        //    return new Customer();
        //}
        //public List<Customer> Retrieve()
        //{
        //    return new List<Customer>();
        //}
        public bool Validate()
        {
            var isValid = true;

            if(string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if(string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
   
    }
}