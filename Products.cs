using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry
{
    public class Products
    {
        public string productName { get; private set; } 
        public float price { get; private set; } 
        public int quantity { get; private set; }
        public Products(string productName, float price, int quantity)
        {
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
        }
        public void ReduceStock(int amount)
        {
            if (amount <= quantity)
            {
                quantity -= amount;
            }
           
        }


     
    }
}
