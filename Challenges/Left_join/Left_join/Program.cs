using System;
using System.Collections.Generic;
using Hashtable.Classes;

namespace Left_join
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            HashTable tableS = new HashTable(50);
            tableS.Add("lazy", "active");
            tableS.Add("mean", "difficult");
            tableS.Add("old", "acient");
            tableS.Add("true", "real");

            HashTable tableA = new HashTable(50);
            tableA.Add("lazy", "active");
            tableA.Add("mean", "nice");
            tableA.Add("old", "young");
            tableA.Add("true", "false");
        }

        public static List<object> LeftJoin(HashTable tableS, HashTable tableA)
        {
            return();
        }
    }
}
