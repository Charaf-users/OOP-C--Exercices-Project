using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    public abstract class clsAccount
    {
        private int _balance;
        public int Balance { get; set; }
        public abstract  void withdraw(int amount);
        

        
    }
    public interface Itransaction
    {
        void deposit(int amount);
    }
    public class  clsSavingAccount:clsAccount,Itransaction
    {
       public override void withdraw(int amount)
        {
            if (amount >Balance)
            {
                Console.WriteLine("you d'ont have money sorry :(");
            }
            if(amount<=Balance)
            {
                Balance-=amount;
                Console.WriteLine(" you operation done succesfully :)");
              
            }
        }
        public void deposit(int amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine(" you Deposit done succesfully :)");
              
            }
        }
    }
    public class clsCurrentAccount : clsAccount, Itransaction
    {
        public override void withdraw(int amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("you d'ont have money sorry :(");
            }

            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine(" you operation done succesfully :)");
            }
        }
        public void deposit(int amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine(" you Deposit done succesfully :)");
                
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsSavingAccount ACC1= new clsSavingAccount();
            ACC1.deposit(230);
            ACC1.withdraw(330);

            Console.ReadKey();

        }
    }
}
