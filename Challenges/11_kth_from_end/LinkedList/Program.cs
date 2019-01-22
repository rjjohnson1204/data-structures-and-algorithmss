 using System;
using LinkedList.Classes;
using System.Collections;


namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LList list = new LList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(23);
            list.Insert(21);

            Console.WriteLine(PosFrmEnd(list.Head, 3));

        }

        static int PosFrmEnd(Node head, int k)
        {
            if (head == null)
            {
                return 0;
            }
            Node runner = head;
            while (k >= 0)
            {
                runner = runner.Next;
                k--;
            }
            Node walker = head;
            while (runner != null)
            {
                runner = runner.Next;
                walker = walker.Next;

            }
            int i = walker.Value;
            return i;
        }
    }
}
