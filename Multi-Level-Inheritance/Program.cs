using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Level_Inheritance
{

    public class clsPeron
    {
        private string _Name;

        public string Name { get; set; }
        public clsPeron(string Name) {
        this._Name = Name;
        }



    }
    public class clsEmploye:clsPeron
    {
        private int _salary;
        public int salary { get; set; }

        public clsEmploye(string Name,int salary) : base(Name)
        {
            this._salary = salary;
        }

    }
    public class clsManager : clsEmploye
    {
        private string _departement;
        public string Departement { get; set; }

        public clsManager(string Name, int salary, string departement) : base(Name, salary)
        {
            this._departement = departement;
            base.Name = Name;
            base.salary = salary;
        }

        public void Info()
        {
            Console.WriteLine("Name :" + Name + " My salary is :" + salary + " Departement :" + Departement);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsManager manager = new clsManager("charaf eddine jador", 1500, "chef Projet");
            manager.Info();

            Console.ReadKey();
        }


       

    }
}
