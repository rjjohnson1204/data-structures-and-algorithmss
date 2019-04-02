using System;
using System.Collections.Generic;
using Tree;
using Tree.Classes;
using Tree_intersection;
using Xunit;




namespace Tree_intersection_test
{
    public class UnitTest1
    {
        [Fact]
        public void Intersection()
        {

            //tree 1
            BinaryTree tree1 = new BinaryTree();
            tree1.Root = new Node(3);
            tree1.Root.LeftChild = new Node(6);
            tree1.Root.RightChild = new Node(9);
            tree1.Root.LeftChild.LeftChild = new Node(12);
            tree1.Root.LeftChild.RightChild = new Node(15);
            tree1.Root.RightChild.RightChild = new Node(18);
            tree1.Root.RightChild.LeftChild = new Node(21);

            //tree 2
            BinaryTree tree2 = new BinaryTree();
            tree2.Root = new Node(7);
            tree2.Root.LeftChild = new Node(14);
            tree2.Root.RightChild = new Node(21);
            tree2.Root.LeftChild.LeftChild = new Node(28);
            tree2.Root.LeftChild.RightChild = new Node(35);
            tree2.Root.RightChild.RightChild = new Node(42);
            tree2.Root.RightChild.LeftChild = new Node(49);

            List<object> result = new List<object> {21};

            Assert.Equal(result, Program.TreeIntersection(tree1, tree2));

        }
        [Fact]
        public void Intersection2()
        {

            //tree 1
            BinaryTree tree1 = new BinaryTree();
            tree1.Root = new Node(3);
            tree1.Root.LeftChild = new Node(6);
            tree1.Root.RightChild = new Node(9);
            tree1.Root.LeftChild.LeftChild = new Node(12);
            tree1.Root.LeftChild.RightChild = new Node(15);
            tree1.Root.RightChild.RightChild = new Node(18);
            tree1.Root.RightChild.LeftChild = new Node(21);

            //tree 2
            BinaryTree tree2 = new BinaryTree();
            tree2.Root = new Node(9);
            tree2.Root.LeftChild = new Node(18);
            tree2.Root.RightChild = new Node(27);
            tree2.Root.LeftChild.LeftChild = new Node(36);
            tree2.Root.LeftChild.RightChild = new Node(45);
            tree2.Root.RightChild.RightChild = new Node(54);
            tree2.Root.RightChild.LeftChild = new Node(63);

            List<object> result = new List<object> {18, 9}; // likes [18, 9] but not [9, 18]   why??

            Assert.Equal(result, Program.TreeIntersection(tree1, tree2));

        }
        [Fact]
        public void IntersectionNone()
        {

            //tree 1
            BinaryTree tree1 = new BinaryTree();
            tree1.Root = new Node(3);
            tree1.Root.LeftChild = new Node(6);
            tree1.Root.RightChild = new Node(9);
            tree1.Root.LeftChild.LeftChild = new Node(12);
            tree1.Root.LeftChild.RightChild = new Node(15);
            tree1.Root.RightChild.RightChild = new Node(18);
            tree1.Root.RightChild.LeftChild = new Node(21);

            //tree 2
            BinaryTree tree2 = new BinaryTree();
            tree2.Root = new Node(10);
            tree2.Root.LeftChild = new Node(20);
            tree2.Root.RightChild = new Node(30);
            tree2.Root.LeftChild.LeftChild = new Node(40);
            tree2.Root.LeftChild.RightChild = new Node(50);
            tree2.Root.RightChild.RightChild = new Node(60);
            tree2.Root.RightChild.LeftChild = new Node(70);

            List<object> result = new List<object> {  };

            Assert.Equal(result, Program.TreeIntersection(tree1, tree2));

        }
    }
}
