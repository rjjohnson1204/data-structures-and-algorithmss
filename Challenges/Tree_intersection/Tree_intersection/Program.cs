using System;
using Tree;
using Tree.Classes;

namespace Tree_intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BinaryTree tree1 = new BinaryTree();
            tree1.Root = new Node(1);
            tree1.Root.LeftChild = new Node(2);
            tree1.Root.RightChild = new Node(3);
            tree1.Root.LeftChild.LeftChild = new Node(4);
            tree1.Root.LeftChild.RightChild = new Node(5);
            tree1.Root.RightChild.RightChild = new Node(6);
            tree1.Root.RightChild.LeftChild = new Node(7);

            BinaryTree tree2 = new BinaryTree();
            tree2.Root = new Node(0);
            tree2.Root.LeftChild = new Node(2);
            tree2.Root.RightChild = new Node(4);
            tree2.Root.LeftChild.LeftChild = new Node(6);
            tree2.Root.LeftChild.RightChild = new Node(8);
            tree2.Root.RightChild.RightChild = new Node(10);
            tree2.Root.RightChild.LeftChild = new Node(12);

        }
    }
}
