using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry
{
    public class shippableProducts :  Products , IShippable
    {
        public double weight;

        public shippableProducts(string productName, float price, int quantity , double weight)
            : base(productName, price, quantity)
        {
          
           this.weight = weight;
        }

        public string getName()
        {
            return productName;
        }
        public double getWeight()
        {
            return weight;
        }
       
    
    }
}
