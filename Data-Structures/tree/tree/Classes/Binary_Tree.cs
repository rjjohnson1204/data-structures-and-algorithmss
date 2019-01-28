using System;
using System.Collections.Generic;
using System.Text;
using tree;

namespace tree
{
    class Binary_Tree
    {
        Node = root
            new Node
            
            new node


        public void PreOrder()
        {
            
                if (root.LeftChild != null)
                {

                PreOrder(root.LeftChild);
                }

                if (root.RightChild != null)
                {

                PreOrder(root.RightChild);
                }
            
            return root.Value;
        }

        public void InOrder()
        {
            if (Node.LeftChild != null)
            {
                InOrder(Node.LeftChild);

            }

            if (Node.RightChild != null)
            {

                InOrder(Node.RightChild);
            }

                    return Node.Value;

        }

        public void PostOrder()
        {
            if (Node.LeftChild != null)
            {

                InOrder(Node.LeftChild);
            }
              
            if (Node.RightChild != null)
            {

                InOrder(Node.RightChild);
            }

                return Node.Value;


        }
    }
}
