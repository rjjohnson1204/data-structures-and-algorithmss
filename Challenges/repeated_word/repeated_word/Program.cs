using System;
using System.Linq;
using Hashtable.Classes;

namespace repeated_word
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string gnirts = "jack sprat could eat no fat and his wife could eat no lean";
          
            Console.ReadLine();

        }

        public static string RepeatedWord(string gnirts)
        {
            string[] words = gnirts.Split(' ');
            HashTable table = new HashTable(100);

            for (int i = 0; i < words.Length; i++)
            {
                string maybe = words[i];

                if (words.Contains(maybe))
                {
                    return maybe;

                }
                else
                {
                    table.Add(maybe, maybe);
                }

            }
            return "no duplicates";
        }
    }
}
