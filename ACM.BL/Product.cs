﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class Product
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;

        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }


        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public Product Retrieve(int productId)
        {
            return new Product();
        }
        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        public bool Save()
        {
            return true; 
        }
    }
}

