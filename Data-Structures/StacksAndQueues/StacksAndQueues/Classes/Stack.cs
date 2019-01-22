using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack
    {
        // top reference to know where the top is
        public Node Top { get; set; }

        /// <summary>
        ///gives us a stack with at least one node in it
        /// <param Node="node">value</param>
        /// </summary>
        /// <returns></returns>
        public Stack(Node node)
        {
            Top = node;
        }

        // gives us an empty stack
        public Stack()
        {

        }

        /// <summary>
        ///inserts new node in queue
        /// <param int="value">value</param>
        /// </summary>
        /// <returns></returns>
        public void Push(int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node; 
        }

        /// <summary>
        /// removes a node from queue
        /// <param ="">value</param>
        /// </summary>
        /// <returns> temp </returns>
        public Node Pop()
        {
            // creates a temporary node
            Node temp = Top;
            // sets top to the next node in the stack
            Top = Top.Next;
            // clears the reference of the next on the temporary node
            temp.Next = null;
            // return the node
            return temp;
        }

        /// <summary>
        /// peek
        /// <param ="">value</param>
        /// </summary>
        /// <returns>Top</returns>
        public Node Peek()
        {
            //shows us the top node of a stack
            return Top;
        }
    }
}

