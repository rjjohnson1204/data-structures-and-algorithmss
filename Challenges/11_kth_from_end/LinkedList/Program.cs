using System;
using LinkedList;
using System.Collections;
using LinkedList.Classes;

namespace LinkedList
{
    class Program
    {
       public static void Main(string[] args)
       {
            Node node = new node;

       }

        public int PosFrmEnd(Node head, int k)
        {
            if (head == null)
            {
                return 0;
            }
                Node current = head;
                while (k > 0)
                {
                current = current.next;
                k--;
                }
                Node walker = head;
                while( current != null)
                {
                current = current.next;
                walker = walker.next;

                }
            int i = walker.value;
            return i;
        }
