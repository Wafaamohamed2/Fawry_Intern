using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry
{
    public class ExpirableProducts : Products
    {
        private DateTime expirationDate;  // to store the expiration date of the product and pervent direct modification of it

        public ExpirableProducts(string productName, float price, int quantity, DateTime expirationDate)
            : base(productName, price, quantity)
        {
            this.expirationDate = expirationDate;
        }

        public bool IsExpired()
        {
            return DateTime.Now > expirationDate;
        }

     
    }
}
