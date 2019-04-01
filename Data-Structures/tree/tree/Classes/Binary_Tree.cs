using System;
using System.Collections.Generic;
using System.Text;
using Tree;
using Tree.Classes;

namespace Tree
{
    public class BinaryTree : Node
    {
        public Node Root { get; set; }
        public List<object> ArrayList = new List<object>();

        public BinaryTree(Node node)
        {
            Root = node;
        }

        public BinaryTree()
        {

        }

        public object[] PreOrder(Node root)
        {
            try
            {
                ArrayList.Add(root.Value);
                if (root.LeftChild != null)
                {
                    PreOrder(root.LeftChild);
                }
                if (root.RightChild != null)
                {
                    PreOrder(root.RightChild);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ArrayList.ToArray();
        }

        public object[] InOrder(Node root)
        {
            try
            {
                if (root.LeftChild != null)
                {
                    InOrder(root.LeftChild);
                }
                ArrayList.Add(root.Value);
                if (root.RightChild != null)
                {
                    InOrder(root.RightChild);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ArrayList.ToArray();
        }

        public object[] PostOrder(Node root)
        {
            try
            {
                if (root.LeftChild != null)
                {
                    PostOrder(root.LeftChild);
                }
                if (root.RightChild != null)
                {
                    PostOrder(root.RightChild);
                }
                ArrayList.Add(root.Value);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ArrayList.ToArray();
        }
    }
}
