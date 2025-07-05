using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry
{
    public class ShippingService
    {
         public void ShipProducts(List<CartIteam> items)
        {

            double totalPackageWeight = 0;

            Console.WriteLine("** Shipment notice **");
            foreach (var item in items)
            {
                if (item.product is IShippable shippable)
                {
                   double totalWeight = shippable.getWeight() * item.quantity;
                    Console.WriteLine($"{item.quantity}x   {shippable.getName()}      {totalWeight}");
                    totalPackageWeight += totalWeight/1000;
                }
            }
            Console.WriteLine($"Total package weight {totalPackageWeight:F2}kg \n\n");

        }

    }
}
