using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace hierarchical_Inheritance_override
{

    public class clsAnimal
    { 
        public virtual void Speak()
        {
            Console.WriteLine(" Animal sound :"); 
    
        }
    }
    public class clsCat : clsAnimal
    {
        public override void Speak()
        {
            Console.WriteLine(" mayaw");
          
        }
    }

    public class clsDog :clsAnimal
    {
        public override void Speak()
        {
            Console.WriteLine(" bark");

        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
