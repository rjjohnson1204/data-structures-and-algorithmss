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
            // creates a tempiraty node to keep the original front of queue
            Node temp = Front;
            // changes the front refernece to the next node
            Front = Front.Next;
            // clears the next refernece for standalone
            temp.Next = null;

            //returns the temporary node value to the user
            return temp;
        }

        //Peek
        public Node Peek()
        {
            return Front;
        }

    }
}
