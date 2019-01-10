using System;

namespace array_binary_search
{
    class Program
    {
        static void Main(string[] args)
        {   //array to be sorted through
            int[] binaryArray = new int[] { 3, 5, 7, 9, 12, 15 };
            // key to be found in the array
            int key = 7;
            int[] newArray = ArrayInsert(binaryArray, key);
            for (int i = 0; i < newArray.Length; i++);
            {
                Console.Write($"{newArray[i]}, ");

            }
            Console.WriteLine();

        }

        public static void BinarySearch(int[] binaryArray, int key)
             {
            // the shortest the array can be
            int min = 0;
            // the longest the array can be
            int max = binaryArray.Length - 1;
            int [] newArray = ArrayInsert( )
            }
    }
}
