using System;
using System.Collections.Generic;
using System.Text;
using Tree;
using Tree.Classes;

namespace Tree
{
    public class BinaryTree : Trees
    {


        public BinaryTree()
        {
            Root = null;
        }
        public BinaryTree(Node node)
        {
            Root = node;
        }

        /// <summary>
        /// Pre order traversal(Root-Left-Right)
        /// </summary>
        /// <param name="node"></param>
        /// <param name="valueList"></param>
        public void PreOrder(Node node, List<int> valueList)
        {
            if (node != null)
            {
                valueList.Add(node.Value);
                PreOrder(node.Left, valueList);
                PreOrder(node.Right, valueList);
            }
        }
        /// <summary>
        /// Inorder traversal (left-root-right)
        /// </summary>
        /// <param name="node"></param>
        /// <param name="valueList"></param>
        public void InOrder(Node node, List<int> valueList)
        {
            if (node != null)
            {
                InOrder(node.Left, valueList);
                valueList.Add(node.Value);
                InOrder(node.Right, valueList);
            }
        }
        /// <summary>
        /// Post order(Left-Right-Root)
        /// </summary>
        /// <param name="node"></param>
        /// <param name="valueList"></param>++++++++++
        public void Postorder(Node node, List<int> valueList)
        {
            if (node != null)
            {
                Postorder(node.Left, valueList);
                Postorder(node.Right, valueList);
                valueList.Add(node.Value);
            }
        }
    }
