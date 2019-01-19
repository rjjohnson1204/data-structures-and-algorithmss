using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    class Queue
    {   
        // properties 
        public Node Front { get; set; }
        public Node Rear  { get; set; }

        /// <summary>
        /// constructor
        /// <param Node="node">value</param>
        /// </summary>
        /// <returns></returns>
        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }

        /// <summary>
        /// enqueue
        /// <param int="value">value</param>
        /// </summary>
        /// <returns></returns>
        public void Enqueue(int value)
        {
            Node node = new Node(value);
            Rear.Next = node;
            Rear = node;
        }

        /// <summary>
        /// dequeue
        /// <param ="">value</param>
        /// </summary>
        /// <returns> temp </returns>
        public Node Dequeue()
        {
            // creates a tempiraty node to keep the original front of queue
            Node temp = Front;
            // changes the front refernece to the next node
            Front = Front.Next;
            // clears the next refernece for standalone
            temp.Next = null;

            //returns the temporary node value to the user
            return temp;
        }

        /// <summary>
        ///Peek
        /// <param ="">value</param>
        /// </summary>
        /// <returns> Front </returns>
        public Node Peek()
        {
            return Front;
        }

    }
}
