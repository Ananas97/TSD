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
            List<Car> cars = new List<Car>();
            Car car1 = new Car();
            car1.SetMake("Skoda");
            car1.SetSales2015(45529);
            car1.SetSales2014(44243);

            cars.Add(car1);

            Car car2 = new Car();
            car2.SetMake("Toyota");
            car2.SetSales2015(36465);
            car2.SetSales2014(31484);

            cars.Add(car2);

            Car car3 = new Car();
            car3.SetMake("BMW");
            car3.SetSales2015(9549);
            car3.SetSales2014(7714);

            cars.Add(car3);


            IList<Car> sortedCars = cars.OrderBy(c => c.GetSales2015()).ToList();

            return cars;
        }

        private IList<Car> ReadCarsFromFile()
        {
            return CarDataFileReader.ReadCarsFromCSVFile();
        }
    }
}
