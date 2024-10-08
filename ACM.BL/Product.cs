﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace ACM.BL
{
    public class Product :EntityBase, ILoggable
    {
        public Product()
        {
            
        }

        public Product(int productId)
        {
           ProductId = productId;
        }

        public int ProductId { get; private set; }

        private string _productName;
        public string ProductName 
        { 
            
            get
            {
                return _productName.InsertSpaces();
            }

            set
            {
                _productName = value;
            }

        }

        

        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        //Methods
        /// <summary>
        /// Validate the product data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName) || CurrentPrice == null)
            {
                isValid = false;
            }

            return isValid;
        }

        public override string ToString()
        {
            return ProductName;
        }

        public string Log() => $"{ProductId}: {ProductName} Detail: {ProductDescription} Status: {EntityState.ToString()}";


    }
    //Validate, Retrieve & Save
}
