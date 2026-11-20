using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance
{

    public class clsPerson
    {
        private string _name;
        private int _age;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        public clsPerson(string Name, int age)
        {
            this._age = age;
            this._name = Name;

        }



    }

    public class clsStudent : clsPerson
    {
        private string _level;

        public string Level
        {
            get
            {
                return _level;
            }
            set
            {
                _level = value;
            }
        }

        public clsStudent(string Name, int age,string level):base(Name,age)
        { 
            this._level = level;
        }
        public void info()
        {
            Console.WriteLine(" My name is " + Name + " ,I'am " + age + " i am currenty studying in " + _level);
        }
    }










        internal class Program
        {
        static void Main(string[] args)
        {
            clsStudent student1 = new clsStudent("charaf eddine Jador", 20, "2 année Ofppt");
            student1.info();
        }
       }
}

