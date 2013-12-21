using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication8
{

    class calc
    {

        public void Wcount(string FilePath)
        {
            if (File.Exists(FilePath))
            {

                string[] FileOpen = System.IO.File.ReadAllText(FilePath).ToLower().Split(new char[] { ' ', ',', ';', '.', '-', '?', '/', '\n', '\r', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);




                for (int i = 0; i < FileOpen.Length; i++)
                {
                    int page = 0;


                    page = 1 + (i / 1024);  //dividing the current word position with 1024 to get page number

                    Console.WriteLine("{0}  {1}", FileOpen[i], page);


                }


                //Console.WriteLine(FileOpen.Length);
            }
            else
                Console.WriteLine("File not exist");

        }
    }




    class WordCount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the file path");
            string FilePath = Console.ReadLine();

            calc calc = new calc();

            calc.Wcount(FilePath);

        }

    }
}



   
