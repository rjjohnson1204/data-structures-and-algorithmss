using System;

namespace AreCharatersUnique
{
    class Program
    {

        static bool AreCharactersUnique(string input)
        {
            //using int as value while counting letter in array
            int[] count = new int[256];

            //starts array at 0
            Array.Clear(count, 0, count.Length - 1);

            //loops over the string and counts each instance of the letters in the string
            foreach (char letter in input)
            {
                if (++count[letter] > 1)

                    // if string contains more than one of the same letter the string does not have all unique letters
                    return false;

            }   

                  // there are no dupicate letters in the string
                  return true;

        }

        static void Main(string[] args)
        {
            string input = "pizza";

            Console.WriteLine("{0} : Does string contain unique letters? {1}", input, AreCharactersUnique(input) ? "Yes" : "No");

        }
    }
}
