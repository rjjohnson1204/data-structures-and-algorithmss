﻿using System;
using StacksAndQueues.Classes;

namespace StacksAndQueues
{
    public class Program
    {
        public static void Main(string[] args)
        {
        
            
        }
         ///<summary
         ///Creates a stack with a single node
         ///</summary>
         ///<param name="Node"></param>
         ///<returns>New stack has been created</returns>
        
         public static Stack CreateNewStack()
         {
             Stack newStack= new Stack(new Node(1));
             return newStack;
         }

        ///<summary
        ///Creates a queue with a single node
        ///</summary>
        ///<param name="Node"></param>
        ///<returns>New stack is being created</returns>
        
        public static Queue CreateNewQueue()
        {
            Queue newQueue = new Queue(new Node(2));
            return newQueue;
        }

        public static void Stack()
        {
            Stack createStack = CreateNewStack();


        }







    }
}
