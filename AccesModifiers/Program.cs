using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModifiers
{

    class User
    {
        public string UserName;
        private string _Password="1234";


        public bool checkPassword(string password)
        {
            if (_Password == password)
            {
                Console.WriteLine(UserName + " Your Password est correct ");
                return true;
                
            }
            else

                Console.WriteLine(UserName + " Your Password est incorrect " + password);
            return false;


        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.UserName = "charaf";
            user.checkPassword("1234");

            Console.ReadKey();
            
        }
    }
}
