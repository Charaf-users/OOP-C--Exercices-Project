using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace class_Object
{
    class Car
    {
        public string _Brand;
        public string _Model;
        public int _year;
        
       

       public void showInfo()
        {
            Console.WriteLine("Brand :" + _Brand + "  Model: " + _Model + " Year : " + _year);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car._Brand = "Mercedes";
            car._Model = "claA";
            car._year = 2026;

            car.showInfo();
            Car car2 = new Car();
            car2._Brand = "porches";
            car2._Model = "proches300";
            car2._year = 2026;

            car2.showInfo();
            Car car3 = new Car();
            car3._Brand = "BMW";
            car3._Model = "M6";
            car3._year = 2026;
            car3.showInfo();
            // Object in Memory
            Car Car4 = car3;
            Car4.showInfo();
            Console.ReadKey(); ;
            
        }
    }
}
