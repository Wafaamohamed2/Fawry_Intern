using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry
{
    public class ShippableExpirableProduct : ExpirableProducts , IShippable
    {

        public double weight;

        public ShippableExpirableProduct(string productName, float price, int quantity, DateTime expirationDate, double weight)
            : base(productName, price, quantity, expirationDate)
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
