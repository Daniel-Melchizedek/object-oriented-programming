using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    //Customer class is a business object
    //A business object is a class created to solve a business problem.
    public class Customer : EntityBase, ILoggable
    {
        public Customer(): this(0)
        {
            
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new();
        }

        public List<Address> AddressList { get; set; }

        //Members = Propertis and Methods

        //Properties
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }

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

        public string FullName 
        {
            get
            {
                if (string.IsNullOrWhiteSpace(LastName))
                {
                    return  FirstName;
                }
                else if (string.IsNullOrWhiteSpace(FirstName))
                {
                    return  LastName;
                }
                else
                {
                    return $"{LastName}, {FirstName}";
                }
            }
        }

        public static int InstanceCount { get; set; }

        

        //Methods
        /// <summary>
        /// Validate the customer data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
            }


            return isValid;
        }

        public string Log() => $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";
    }

    //Entity - Things that are significant enough to consider.
    //Anything in the realworld which is significant enough to be represented as a class is referred to as an entity.
    //Validate, Retrieve & Save
}
