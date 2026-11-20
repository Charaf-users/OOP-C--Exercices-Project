using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Project
{

    class clsCalculator
    {
        private float _result = 0;
        private float _lastNum = 0;
        private string _nameOpera = "clearing";
        private float lastOper;

        private bool _isZero(float num)
        {
            return (num == 0);
        }

    
        public void Adding(float num)
        {
            _lastNum = num;
            _nameOpera = "Adding";
            _result += _lastNum;
            lastOper = _result;


        }
        public void Subtracting(float num)
        {
            _lastNum = num;
            _nameOpera = "Subtracting";
            _result -= _lastNum;
            lastOper = _result;
        }
        public void Mutiply(float num)
        {
            _lastNum = num;
            _nameOpera = "Mutiplaying";
            _result *= _lastNum;
            lastOper = _result;
        }
        public bool Divide(float num)
        {
            bool succeed = true;
            _nameOpera = "Dividing";

            if(_isZero(num))
            {
                _lastNum = num;
                _result /= 1;

                succeed = false;
            }
            else
            {
                _lastNum = num;
                _result /= _lastNum;
                lastOper = _result;

            }

           
            return succeed; 
        }

       public float GetFinalresult()
        {
            return _result;
        }
        public void Clear()
        {
            _lastNum = 0;
            _result = 0;
            lastOper = 0;
            _nameOpera = "clearing";
        }
        public void GetLastOperration()
        {
            Console.WriteLine("the last operation is " + lastOper+" after "+ _nameOpera + " "+ _lastNum);
        }

        public void PrintResult()
        {
            Console.WriteLine("Result After  "+ _nameOpera + " " +_lastNum+ " is :"+ _result);
             }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsCalculator calculator = new clsCalculator();
            calculator.Adding(10);
            calculator.PrintResult();
            calculator.Adding(100);
            calculator.PrintResult();
            calculator.Subtracting(20);
            calculator.PrintResult();
            calculator.Mutiply(2);
            calculator.PrintResult();
            calculator.Divide(0);
            calculator.PrintResult();
            calculator.Divide(2);
            calculator.PrintResult();
            calculator.GetLastOperration();
           
            calculator.Clear();
            calculator.PrintResult();
            calculator.Adding(10);
            calculator.PrintResult();
            calculator.Adding(100);
            calculator.PrintResult();
            Console.ReadKey();
        }
    }
}
