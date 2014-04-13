using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {

            SingletonPatern Singletonobject = SingletonPatern.Getobject();
            Singletonobject.Disp("Welcome to Singleton pattern");
            Console.ReadLine();
        }
    }
    public class SingletonPatern
    {
        private static SingletonPatern UniqObj; //static variable to hold one instant of singleton class
        private SingletonPatern()  ///constructor
        {
        }
        public static SingletonPatern Getobject()
        {
            if (UniqObj == null)
            {
                UniqObj = new SingletonPatern(); //single object
            }
            return UniqObj;
           
        }
        public void Disp(string s)
        {
            Console.WriteLine(s);
        }
    }

}
