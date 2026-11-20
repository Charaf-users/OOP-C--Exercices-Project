using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class clsCarEngine
    {
        private void _startEngine()
        {
            Console.WriteLine("welcome to tesla ");
            Console.WriteLine("your battery 60%  ");
           
        }

        public void start()
        {
            _startEngine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsCarEngine carEngine = new clsCarEngine();
            carEngine.start();
        }
    }
}
