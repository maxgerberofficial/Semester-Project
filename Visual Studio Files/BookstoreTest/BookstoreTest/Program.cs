using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreTest
{

    internal class Program
    {

        static void Main(string[] args)
        {
            BullsBookstore myOrder = new BullsBookstore("Max", "St. Pete", 12.00);
            Console.WriteLine("Hello {0}!  Place your Bulls Bookstore order for the {1} campus.", myOrder.Name, myOrder.Campus);
            Console.WriteLine("Discounts Available! $100 = $5 off, $200 = $10 off, and $300+ = $20 off!");
            myOrder.CreateReceipt();
        }
    }
}
