//read each word and count the number of times the word is appearing

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication7
{
 class Program
{
 static void Main(string[] args)
 {
     
     Console.WriteLine("Enter the file path");
     string path = Console.ReadLine();

     if (File.Exists(path))
     {


         string[] text = System.IO.File.ReadAllText(path).ToLower().Split(new char[] { ' ', ',', ';', '.', '-' });



         for (int i = 0; i < text.Length; i++)
         {
             int count = 0;
             for (int j = 0; j < text.Length; j++)
             {
                 if (text[i] == text[j])
                 {
                     count++;
                 }
             }
             Console.WriteLine("{0}   {1}", text[i], count);
         }

         /*

          var count = text
         .GroupBy(x => x)
         .Select(g => new { text = g.Key, Count = g.Count() })
         .ToList();

          foreach (var p in counts)
          {
              Console.WriteLine("{0} {1}", p.text, p.Count);
          }



          */


     }
     else
         Console.WriteLine("File not exist");

 }

  }


}

 
