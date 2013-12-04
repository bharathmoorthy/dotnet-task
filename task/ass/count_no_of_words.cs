//read each word and count the number of times the word is appearing
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication7
{
    class calc
    {

        public static void Wcount(string Fpath)
        {
            if (File.Exists(Fpath))
            {

                //splitting the words using space, punctuation marks
                string[] Word = System.IO.File.ReadAllText(Fpath).ToLower().Split(new char[] { ' ', ',', ';', '.', '-' });


                //comparing the word with rest of the words
                for (int i = 0; i < Word.Length; i++)
                {
                    int count = 0;
                    for (int j = 0; j < Word.Length; j++)
                    {
                        if (Word[i] == Word[j]) // if the word matches then the count will be added
                        {
                            count++;    
                        }
                    }
                    Console.WriteLine("{0}   {1}", Word[i], count);
                }

                /*

                 var count = Word
                .GroupBy(x => x)
                .Select(g => new { Word = g.Key, Count = g.Count() })
                .ToList();

                 foreach (var p in count)
                 {
                     Console.WriteLine("{0} {1}", p.Word, p.Count);
                 }
                */





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
     string path = Console.ReadLine();
     calc calc= new calc();
  
     calc.Wcount(path);
  
      }

  }


}

 
