using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSD.Linq.Cars;

namespace ConsoleApplication1
{
    public class CarDataFileReader
    {
        public static IList<Car> ReadCarsFromCSVFile()
        {
            var cars = new List<Car>();
            TextReader textReader = new StreamReader(@"C:\Users\Ananas\Downloads\cars.csv");
            textReader.ReadLine();
            string[] linesFromFile = textReader.ReadToEnd().Split('\n');
            foreach (var line in linesFromFile)
            {
                string[] fields = line.Split(';');
                Car newCar = new Car(fields[0])
                {
                Sales2014 = int.Parse(fields[1]),
                Sales2015 = int.Parse(fields[2])
            };
                cars.Add(newCar);
            }

            return cars;
        }
    }
}
