using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    class Queues
    {   
        // properties 
        public Node Front { get; set; }
        public Node Rear  { get; set; }

        // constructor
        public Queues(Node node)
        {
            Front = node;
            Rear = node;
        }

        // enqueue
        public void Enqueue(int value)
        {
            Node node = new Node(value);
            Rear.Next = node;
            Rear = node;
        }

        // dequeue
        public Node Dequeue()
        {

        }

    }
}
