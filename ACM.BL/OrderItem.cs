using ACM.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAndClass
{
    public class OrderItem : EntityBase
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }
        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice {get; set;}
        public int Quantity { get; set; }

        /// <summary>
        /// Saves the current order item.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //Code that saves the current order item.
            return true;
        }

        /// <summary>
        /// Retrieve one order item.
        /// </summary>
        /// <param name="orderItemId"></param>
        /// <returns></returns>
        public OrderItem Retrieve(int orderItemId)
        {
            //Code that retrieves the defined order item.
            return new OrderItem();
        }

        /// <summary>
        /// Validate the order item data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            bool isValid = true;

            if (Quantity <= 0 || ProductId <=0 || PurchasePrice == null)
            {
                isValid = false;
            }

            return isValid;
        }

    }
    //Validate, Retrieve & Save
}
