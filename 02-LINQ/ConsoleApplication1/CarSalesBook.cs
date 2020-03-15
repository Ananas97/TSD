using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ConsoleApplication1;
using TSD.Linq.Cars;

namespace TSD.Linq.Cars
{
    public class CarSalesBook
    {
        public IList<Car> Cars { get; private set; }

        //public CarSalesBook()
        //{
        //    this.Cars = GenerateCars();
        //}

        public CarSalesBook()
        {
            this.Cars = ReadCarsFromFile();
        }

        private IList<Car> GenerateCars()
        {
            var cars = new List<Car>()
            {
            new Car("Skoda") { Sales2014 = 44243, Sales2015 = 45529 },
            new Car("Toyota") { Sales2014 = 31484, Sales2015 = 36465},
            new Car("BMW") { Sales2014 = 7714, Sales2015 = 9549 }
            };

            IList<Car> sortedCars = cars.OrderBy(c => c.Sales2015).ToList();
            Car myCar = new Car("Toyota") { NumberOfSeats = 5 };
            int numOfSeats = myCar.NumberOfSeats ?? default;
            return cars;
        }

        private IList<Car> ReadCarsFromFile()
        {
            return CarDataFileReader.ReadCarsFromCSVFile();
        }

        public void WriteToXMLFile()
        {
            XmlWriter xmlWriter = XmlWriter.Create("cars.xml");

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("cars");

            foreach (var c in Cars)
            {
                string sale2014 = c.Sales2014.ToString();
                string sale2015 = c.Sales2015.ToString();
                xmlWriter.WriteStartElement("car");
                xmlWriter.WriteAttributeString("Make", c.Make);
                xmlWriter.WriteElementString("Sales2014", sale2014);
                xmlWriter.WriteElementString("Sales2015", sale2015);
                xmlWriter.WriteEndElement();
            }

            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }
    }
}
