using System;

namespace array_shift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        
        
            int[] array1 = new int[] { 1, 3, 2, 9, 49, 88 };
            int searchKey = 15;
            Console.WriteLine(BinarySearch(array1, searchKey));

        }

    }
}
