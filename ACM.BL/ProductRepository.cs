using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Saves the current product.
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            //Code that saves the current product.
            var success = true;
            if(product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        //Call an Insert Stored Procedure.
                    }
                    else
                    {
                        //Call an Update Stored Procedure.
                    }
                }
                else
                {
                    success = false;
                }

            }
            return success;
        }

        /// <summary>
        /// Retrieve one product.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            //Code that retrieves the defined product.
            var product = new Product(productId);

            if (productId ==2) {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers";
                product.CurrentPrice = 15.96m;
            }

            return product;
            
            


        }

        /// <summary>
        /// Retrieve all products.
        /// </summary>
        /// <returns></returns>
        public List<Product> Retrieve()
        {
            //Code that retrieves all of the products.
            return new List<Product>();
        }
    }
}
