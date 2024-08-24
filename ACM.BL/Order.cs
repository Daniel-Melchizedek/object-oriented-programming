using Acme.Common;
using ObjectAndClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order : EntityBase, ILoggable
    {
        public Order(): this(0)
        {
            
        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems= new List<OrderItem>();
        }
        
        public int ShippingAddressId { get; set; }
        public int CustomerId { get; set; }

        List<OrderItem> OrderItems { get; set; }
        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
        /* To create later
        string ShippingAddress { get; set; }
        List<OrderItem> Items { get; set; }
        */



        /// <summary>
        /// Validate the order data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            bool isValid = true;

            if (OrderDate == null)
            {
                isValid = false;
            }

            return isValid;
        }

        public string Log() => $"{OrderId}: Date: {OrderDate.Value.Date} Status: {EntityState.ToString()}";
        
    }
    //Validate, Retrieve & Save
}
