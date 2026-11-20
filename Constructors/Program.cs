using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class clsEmploye
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public  clsEmploye()
        {
            this.ID= 0;
            this.Name= string.Empty;
            this.Description= string.Empty;

        }
        public clsEmploye(int ID)
        {
            this.ID = ID;
          
        }
        public clsEmploye(int ID,string name, string description)
        {
            this.ID= ID;
            this.Name= name;
            this.Description= description;

        }
         public clsEmploye(int ID, string name)
        {
            this.ID = ID;
            this.Name = name;
         

        }
        ~clsEmploye()
        {

        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsEmploye emp1 = new clsEmploye();
        }
    }
}
