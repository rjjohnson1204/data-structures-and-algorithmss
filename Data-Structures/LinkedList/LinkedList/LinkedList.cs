using LinkedList.Classes;
using System;

namespace LinkedList
{
    class LinkedList
    {
        static void Main(string[] args)
        {
            NodeExample();
        }
        
        static void NodeExample()
        {

            LList list = new LList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);

            list.Print();

            list.Append(16);
            list.Append(23);
            list.Append(42);

            list.Print();

            list.InsertBefore(23, 53);
            list.InsertAfter(8, 3);

            list.Print();
        }
    }
        
        
}

