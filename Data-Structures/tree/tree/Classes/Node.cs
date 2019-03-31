using System;
using System.Collections.Generic;
using System.Text;
using Tree.Classes;



namespace Tree. Classes
{
    public class Node
    {
        public int Value { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }

        public Node(int value)
        {
            Value = value;
         
        }

        public Node()
        {

        }

    }
}
