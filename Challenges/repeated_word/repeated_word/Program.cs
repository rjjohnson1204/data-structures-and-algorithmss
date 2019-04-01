using System;
using System.Collections;

using System.Linq;





namespace repeated_word
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // string to be evaluated
            string gnirts = "jack sprat could eat no fat and his wife could eat no lean";
            RepeatedWord(gnirts);

            // displays the repeated word
            Console.WriteLine($"The repeated word is {RepeatedWord(gnirts)}");
            

        }
        // method to find the repeated word
        public static string RepeatedWord(string gnirts)
        {
            //splits string into individual strings
            string[] words = gnirts.Split(' ');
            HashTable table = new HashTable(100);

            for (int i = 0; i < words.Length; i++)
            {
                string maybe = words[i];

                if (table.Contains(maybe))
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
