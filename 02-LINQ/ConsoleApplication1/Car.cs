using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TSD.Linq.Cars
{

    public class Car
    {
        public string Make { get; private set; }
        public int Sales2014 { get; set; }
        public int Sales2015 { get; set; }
        public int? NumberOfSeats { get; set; }

        public Car() { 
        }
        public Car(string make) {
            this.Make = make;
        }

    }

  
}
