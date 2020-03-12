using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TSD.Linq.Cars
{
   
    public class Car
    {
        private string _make;
        private int _sales2015;
        private int _sales2014;

        public void SetMake(string make)
        {
            this._make = make;
        }

        public string GetMake()
        {
            return _make;
        }

        public void SetSales2014(int saleNum)
        {
            this._sales2014 = saleNum;
        }

        public int GetSales2014()
        {
            return _sales2014;
        }

        public void SetSales2015(int saleNum)
        {
            this._sales2015 = saleNum;
        }

        public int GetSales2015()
        {
            return _sales2015;
        }


    }

   
}
