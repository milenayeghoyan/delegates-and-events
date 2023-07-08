using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatesAndevents
{
    /*// Task 1    

   delegate void PrintDelegate(string str);*/


    // Task 2 
   /* public class Button
    {
        public event Action ConsoleReadEvent;
        public void ClickButton()
        {

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleReadEvent();
                    break;

                }
            }
        }

    }*/

    /* // Task 3
    delegate int OperationDelegate(int a, int b);*/

    // Task  4

    // delegate int ComparisonDelegate(double x, double y);
   
    
    //Task 5 
  /*  class Balance
    {
        public event Action BalanceRefillEvent;
        public string PhoneNumber { get; set; }
        public int Amount { get; set; }
        public Balance(string str, int amount)
        {
            PhoneNumber = str;
            Amount = amount;
        }
        public void Information()
        {
            BalanceRefillEvent();
            Console.WriteLine($"the PhoneNumber is {PhoneNumber}, tha amount is {Amount}");
        }
    }*/

    internal class Program
    { /* //new task 1 
        static void Foo(string s)
        {
            Console.WriteLine(s);
        }*/

        static void Main(string[] args)
        {
            // new task 1 
            /*PrintDelegate printDelegate = Foo;
            printDelegate("Hello");*/

            // Task 2
            //Task 2

            /* Button button = new Button();
             button.ConsoleReadEvent += () =>
             {
                 Console.WriteLine("Button is clicked");
             };
             button.ClickButton();*/




            /* //TASK 3
              OperationDelegate addition = delegate (int arg1,int arg2)
              {
                  return arg1 + arg2;

              };
              OperationDelegate subtraction = delegate (int arg1, int arg2)
              {
                  return arg1 - arg2;

              };
              int a=addition(6, 5);
              Console.WriteLine(a);
              int b=subtraction(6, 5);
              Console.WriteLine(b);

              */

            /* //Task 4
             ComparisonDelegate del = (a, b) =>
             {
                 double value = a - b;
                 if(value > 0)
                 {
                     return 1;
                 }
                 if(value < 0) { return -1;}
                 else { return 0; }

             };

             int comparison=del(5, 5);
             Console.WriteLine(comparison);*/

            //Task 5 
           /* Balance balance = new Balance("09455214", 4000);
            balance.BalanceRefillEvent += () =>
            {
                Console.WriteLine("Balance Refill is received");
            };

            balance.Information();*/
        }
    }
}
