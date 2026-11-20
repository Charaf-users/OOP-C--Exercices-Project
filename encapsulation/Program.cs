using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    class clsAccount
    {
        private int _balance;

        public int balance
        {
            get
            {
         return _balance;
            }
        }
        public void deposit(int amount)
        {
            if(amount >0)
            {
                _balance += amount;
            }
        }
        public void withdraw (int amount)
        {
            if(amount>_balance)
            {
                Console.WriteLine(" you don't have money your balance is :"+_balance );
            }
            if(amount>0)
            {
                _balance-= amount;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsAccount Acc1=new clsAccount();
            Acc1.deposit(200);
            
            Acc1.withdraw(150);
            Console.WriteLine(" your balance is " + Acc1.balance);



            Console.ReadKey();

        }
    }
}
