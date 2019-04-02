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

            //runs function
            RepeatedWord(gnirts);

            // displays the repeated word
            Console.WriteLine($"Repeated word {RepeatedWord(gnirts)}");
            

        }
        // method to find the repeated word
        public static string RepeatedWord(string gnirts) 
        {
            //splits string into individual strings only accounting for spaces
            string[] words = gnirts.Split(' ');

            //creates new hashtable
            HashTable table = new HashTable(50);

            // loops through the array of words
            for (int i = 0; i < words.Length; i++)
            {

                //assigns index to word in the hashtable
                int index = table.Hash(words[i]);


                //checks to see of the hashtable already containts the word in question
                if (table.Contains(words[i]))
                {
                    // returns repeated word
                    return words[i];

                }
                else
                {
                    // adds word to hashtable if the word is not already in the table
                    table.Add(words[i], index);

                }

            }
            //if no repeated words found
            return "no repeated words found";
        }
    }
}
