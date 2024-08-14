using BE072024.DataAcceess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_07.ConsoleApp
{
    class Program
    {
        static List<Product> products = new List<Product>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Product Management System");
                Console.WriteLine("1. Add Phone");
                Console.WriteLine("2. Add Laptop");
                Console.WriteLine("3. Display All Products");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        products.Add(Bai7.AddPhone());
                        break;
                    case "2":

                        products.Add(Bai7.AddLaptop());
                        break;
                    case "3":
                        Bai7.DisplayProducts(products);
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
