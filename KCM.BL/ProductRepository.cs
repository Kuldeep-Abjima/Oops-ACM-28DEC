﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product= new Product(productId);


            if(productId == 2)
            {
                product.ProductName = "Sunflower";
                product.ProductDescription = "Assorted Size set of 4 bright yellow mini sunflowers";
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
