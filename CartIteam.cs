using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry
{
    public class CartIteam
    {
        public Products product { get; private set; } 
        public int quantity { get; private set; } 

        public CartIteam(Products product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }

        public float GetTotalPrice()
        {
            return product.price * quantity; 
        }
        public void ReduceStock()
        {
            product.ReduceStock(quantity); 
        }
    
        public bool IsShippable()
        {
            return product is IShippable; // check if the product is shippable
        }
    }
}
