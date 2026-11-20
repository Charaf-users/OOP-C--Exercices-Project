using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Set_Get_
{
    class clsProductValidation
    {
        private int _Price;

        public int Price
        {
            get
            { 
                return _Price; 

            }

            set
            {
                if(_Price<=0)
                {
                    Console.WriteLine("enter bigger than zero :)");
                }
                else
                {
                    _Price=value;
                }
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsProductValidation productValidation = new clsProductValidation();
            productValidation.Price = -10;
            
            Console.ReadKey();
        }
    }
}
