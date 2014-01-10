using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication11
{
    class Program
    {

        public static void display(int dage)
        {
            Console.WriteLine("thread for display");
            Console.WriteLine(dage);
        }
        
        public static void get()
        {
            Console.WriteLine("Child Thread");
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
               

            
            ThreadStart start = new ThreadStart(delegate { display(age); });
            
            Thread thrd2 = new Thread(start);
            thrd2.Start();

        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread");
            Thread thrd1 = new Thread(get);
            thrd1.Start();
                    
         
            
        }
    }
}
