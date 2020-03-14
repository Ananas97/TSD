using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1;
using TSD.Linq.Cars;

namespace TSD.Linq.Cars
{
    public class CarSalesBook
    {
        private IList<Car> _cars;

        public CarSalesBook()
        {
            _cars = GenerateCars();
        }

        private IList<Car> GenerateCars()
        {
            var cars = new List<Car>()
            {
            new Car("Skoda") { Sales2014 = 44243, Sales2015= 45529 },
            new Car("Toyota") { Sales2014 = 31484, Sales2015 = 36465, NumberOfSeats = 5 },
            new Car("BMW") { Sales2014 = 7714, Sales2015 = 9549 }
            };

            IList<Car> sortedCars = cars.OrderBy(car => car.Sales2015).ToList();
            return cars;
        }

        private IList<Car> ReadCarsFromFile()
        {
            return CarDataFileReader.ReadCarsFromCSVFile();
        }
    }
}
