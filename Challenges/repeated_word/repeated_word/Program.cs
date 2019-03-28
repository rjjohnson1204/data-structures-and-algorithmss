using System;
using System.Linq;
using Hashtable.Classes;
using Hashtable;

namespace repeated_word
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string gnirts = "jack sprat could eat no fat and his wife could eat no lean";

            //Console.ReadLine();
            RepeatedWord(gnirts);

        }

        public static string RepeatedWord(string gnirts)
        {
            string[] words = gnirts.Split(' ');
            HashTablez table = new HashTablez(100);

            for (int i = 0; i < words.Length; i++)
            {
                int index = table.Hash(words[i]);

 

                if (table.Contains(words[i]))
                {
                    return words[i];

                }
                else
                {
                    table.Add(words[i], index);
                }

            }
            return "no duplicates";
        }
    }
}
