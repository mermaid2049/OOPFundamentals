﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            var product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assoreted Size set of 4 Yellow Mini Sunflowers";
                product.CurrentPrice = 15.96M;
            }

            return product;
        }
        public bool Save(Product product)
        {
            return true; 
        }
    }
}
