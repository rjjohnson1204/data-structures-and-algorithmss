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
