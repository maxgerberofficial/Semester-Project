using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreTest
{
    internal class BullsBookstore
    {
        //Fields
        private string name;
        private string campus;
        private double deliveryfee;

        //Properties
        public string Name { get; set; }
        public string Campus { get; set; }
        public double Deliveryfee
        {
            get
            {
                return deliveryfee;
            }
            set
            {
                if (value >= 0)
                {
                    deliveryfee = value;
                }
                else
                {
                    deliveryfee = 0;
                }
            }
        }

        //Constructors
        public BullsBookstore(string name, string campus, double deliveryfee)
        {
            Name = name;
            Campus = campus;
            Deliveryfee = deliveryfee;

        }

        //Methods
        public void CreateReceipt()
        {
            double subtotal = 0;
            string price_str = "0";
            double price_num = 0;
            double taxRate = 0;
            double taxAmount = 0;
            double grandtotal = 0;
            double discount = 0;

            while (price_str != "Done")
            {
                try
                {
                    price_num = Convert.ToDouble(price_str);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Value entered was not a number, please try again.");
                    price_num = 0;
                }
                subtotal = subtotal + price_num;
                Console.WriteLine("Enter price of textbook or other bookstore item (Enter \"Done\" to quit)");
                price_str = Console.ReadLine();
            }
            switch (Campus)
            {
                case "Tampa":
                    Console.WriteLine("\nTampa tax rate is 8%");
                    taxRate = .08;
                    break;
                case "Sarasota":
                    Console.WriteLine("\nSarasota tax rate is 6%");
                    taxRate = .06;
                    break;
                case "St. Pete":
                    Console.WriteLine("\nSt. Pete tax rate is 7%");
                    taxRate = .07;
                    break;
                default:
                    Console.WriteLine("\nUnknown campus, default tax rate applied at 10%.");
                    taxRate = .10;
                    break; 
            }

            if (subtotal >= 100 && subtotal <= 199.99)
            {
                discount = 5;
            }
            if (subtotal >= 200 && subtotal <= 299.99)
            {
                discount = 10;
            }
            if (subtotal >= 300)
            {
                discount = 20;
            }



            taxAmount = subtotal * taxRate;

            grandtotal = subtotal + taxAmount - discount + deliveryfee;

            Console.WriteLine("Subtotal: {0:C}", subtotal);
            Console.WriteLine("Discount: -{0:C}", discount);
            Console.WriteLine("Delivery fee {0:C}", deliveryfee);
            Console.WriteLine("{0:P} tax: {1:C}", taxRate, taxAmount);
            Console.WriteLine("Grand total: {0:C}", grandtotal);
        }
    }
}
