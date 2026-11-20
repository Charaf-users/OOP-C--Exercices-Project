using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Class
{

    public class clsCar
    {


        public class clsEngine
        {
            public void start()
            {
                Console.WriteLine(" Engin Start ...");
            }
            public void Stop()
            {
                Console.WriteLine(" Engine Off");
            }
        }
        public void startCar()
        {
           clsEngine engine=new clsEngine();
            engine.start();
        }
        public void stopCar()
        {
            clsEngine engine = new clsEngine();
            engine.Stop();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsCar car1=new clsCar();
            car1.startCar();
            car1.stopCar();
            Console.ReadKey();
        }
    }
}
