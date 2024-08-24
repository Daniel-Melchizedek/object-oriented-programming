using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// Saves the current order.
        /// </summary>
        /// <returns></returns>
        public bool Save(Order order)
        {
            //Code that saves the current order.
            return true;
        }

        /// <summary>
        /// Retrieve one order.
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            //Code that retrieves the defined order.
            var order= new Order(orderId);
            if (orderId == 10) 
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00,00, new TimeSpan(7,0,0));
            }
            return order;
        }
    }
}
