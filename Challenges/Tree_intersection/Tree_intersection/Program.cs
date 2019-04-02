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

            //tree 1
            BinaryTree tree1 = new BinaryTree();
            tree1.Root = new Node(1);
            tree1.Root.LeftChild = new Node(2);
            tree1.Root.RightChild = new Node(3);
            tree1.Root.LeftChild.LeftChild = new Node(4);
            tree1.Root.LeftChild.RightChild = new Node(5);
            tree1.Root.RightChild.RightChild = new Node(6);
            tree1.Root.RightChild.LeftChild = new Node(7);

            //tree 2
            BinaryTree tree2 = new BinaryTree();
            tree2.Root = new Node(0);
            tree2.Root.LeftChild = new Node(2);
            tree2.Root.RightChild = new Node(4);
            tree2.Root.LeftChild.LeftChild = new Node(6);
            tree2.Root.LeftChild.RightChild = new Node(8);
            tree2.Root.RightChild.RightChild = new Node(10);
            tree2.Root.RightChild.LeftChild = new Node(12);


            // result of method to find intersects
            List<object> valueIntersect = TreeIntersection(tree1, tree2);

            //writes the contents of the above list to display the intersect values
            foreach (var item in valueIntersect)
            {
                Console.Write($" Value {item}");
            }
        }


        // method to find intersections in trees
        public static List<object> TreeIntersection(BinaryTree tree1, BinaryTree tree2)
        {

            List<object> CommonValues = new List<object>();

            //creates new hashtable
            HashTable table = new HashTable(50);


            // traverse tree 1
            void TraverseTree1(Node Root)
            {
                //checks if root is null
                if (Root == null)
                {
                    return;
                }

                //checks for all the left children
                TraverseTree1(Root.LeftChild);

                //checks for all the right children
                TraverseTree1(Root.RightChild);

                //adds node to hashtable 
                table.Add(Root.Value.ToString(), Root.Value);
            }
            // calls itself to run again
            TraverseTree1(tree1.Root);

            // traverse tree 2
            void TraverseTree2(Node Root)
            {
                //checks if root is null
                if (Root == null)
                {
                    return;
                }

                //checks for all the left children
                TraverseTree2(Root.LeftChild);

                //checks for all the right children
                TraverseTree2(Root.RightChild);

                //checks to see if tree2 contains values that are in tree1.
                if (table.Contains(Root.Value.ToString()))
                {
                    // collects common values 
                    CommonValues.Add(Root.Value);
                }

            }
            // calls itself to run again
            TraverseTree2(tree2.Root);

            // returns common values to list
            return CommonValues;
        }
    }
}
