using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSD.Linq.Cars;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            CarSalesBook carSalesBook = new CarSalesBook();
            IEnumerable<Car> top3Sales2014 = carSalesBook.Cars.OrderByDescending(c => c.Sales2014).Take(3);
            Console.WriteLine(" ---- Solution for TOP 3 makes whose sales with regard to the amount of sold cars in 2014(2.4) ---- ");
            foreach (Car c in top3Sales2014)
            {
                Console.WriteLine(c.Make);
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------");


            Console.WriteLine(" ---- Solution for the sales of which makes increased by at least 50% in 2015 comparing to 2014(2.5) ---- ");
            IEnumerable<Car> salesOfMakesIncreasedInComparison2015to2014 = carSalesBook.Cars.Where(c => c.Sales2015 >= 1 * c.Sales2014 + 0.5 * c.Sales2014);
            foreach (Car c in salesOfMakesIncreasedInComparison2015to2014)
            {
                Console.WriteLine(c.Make);
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            Console.WriteLine(" ---- Solution for which 3 makes opens the second ten of the sales ranking in 2015(2.6)  ---- ");
            IEnumerable<Car> salesFirst3SecondTOP10 = carSalesBook.Cars.OrderByDescending(c => c.Sales2015).Skip(10).Take(3);
            foreach (Car c in salesFirst3SecondTOP10)
            {
                Console.WriteLine(c.Make);
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            Console.WriteLine(" ---- Solution for What are the totals of sold cars in 2014 and 2015(2.7)  ---- ");
            int soldCarsInTotalIn2014 = carSalesBook.Cars.Sum(c => c.Sales2014);
            int soldCarsInTotalIn2015 = carSalesBook.Cars.Sum(c => c.Sales2015);
            Console.WriteLine("Totals of sold cars in 2014 are {0}.\n Totals of sold cars in 2015 are {1}.",
                soldCarsInTotalIn2014, soldCarsInTotalIn2015);
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            Console.ReadLine();

        }
    }
}
