using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{

    public abstract class PaymentSystem
    {

        public abstract void Pay();
        
    }
    
        
 
     

        
 

    public class VisaPayment : PaymentSystem
    {
          public override void Pay()
        {
            Console.WriteLine("welcome to Visa Payment ");
        }
    }
    public abstract class clsPaypal: PaymentSystem
    {
        public override void Pay()
        {
            Console.WriteLine("welcome to PayPal Payment ");
          
        }
    }
    public  class clsCash: PaymentSystem
    {
        public  override void Pay()
        {
            Console.WriteLine("welcome to cash Payment ");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

