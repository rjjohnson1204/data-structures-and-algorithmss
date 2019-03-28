using System;


namespace repeated_word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string gnirts = "jack sprat could eat no fat and his wife could eat no lean";

        }

        public static string RepeatedWord(string gnirts)
        {
            string[] words = gnirts.Split(' ');
            HashTable table = new HashTable(1000);

        }
    }
}
