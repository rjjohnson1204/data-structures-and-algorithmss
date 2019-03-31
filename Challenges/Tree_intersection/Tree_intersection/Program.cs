using System;

namespace Tree_intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //building of the tree
            Node node = new Node(1);

            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);

            Node node5 = new Node(5);
            Node node6 = new Node(6);
            Node node7 = new Node(7);

            Node node8 = new Node(8);
            Node node9 = new Node(9);


            // (level 2)
            node.LeftChild = node2;
            node.RightChild = node3;

            // level 3
            node3.LeftChild = node4;
            node3.RightChild = node5;

            // level 4
            node5.LeftChild = node6;

            // level 5
            node6.LeftChild = node7;

            // level 6
            node7.RightChild = node8;

            //Level 7
            node8.LeftChild = node9;
        }
    }
}
