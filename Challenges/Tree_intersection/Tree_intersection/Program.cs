using Hashtable.Classes;
using System;
using System.Collections.Generic;
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



            List<object> intersectedValues = TreeIntersection(tree1, tree2);
            foreach (var item in intersectedValues)
            {
                Console.Write($" Intersected values {item}");
            }
        }



        public static List<object> TreeIntersection(BinaryTree tree1, BinaryTree tree2)
        {
            List<object> CommonValues = new List<object>();
            HashTable table = new HashTable(100);

            Node root1 = tree1.Root;
            Node root2 = tree2.Root;

            /// first helper method to traverse first tree adding to hash table
            void TraverseOne(Node Root)
            {
                if (Root == null)
                {
                    return;
                }

                TraverseOne(Root.LeftChild);
                TraverseOne(Root.RightChild);
                table.Add(Root.Value.ToString(), Root.Value);
            }
            TraverseOne(root1);
            ///second helper method to traverse second tree to cross reference table
            void TraverseTwo(Node Root)
            {
                if (Root == null)
                {
                    return;
                }

                TraverseTwo(Root.LeftChild);
                TraverseTwo(Root.RightChild);
                if (table.Contains(Root.Value.ToString()))
                {
                    CommonValues.Add(Root.Value);
                }

            }
            TraverseTwo(root2);
            return CommonValues;
        }
    }
}
