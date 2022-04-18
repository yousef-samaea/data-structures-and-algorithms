using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StcskAndQueue.StacksandQueues
{
   public class Queue
    {
        public Node front;
        public Node rear;

        public Queue()
        {
            front = rear = null;
            
        }

        public void Enqueue(int data)
        {
            Node queuenode = new Node(data);

            if (rear == null)
            {
                front = rear = queuenode;
            }
            else
            {
                rear.next = queuenode;
                rear = queuenode;
            }
        }

        public int Dequeue()
        {
            if (front == null)
            {
                throw new InvalidOperationException("the Queue is empty! you cant Pop");
            }
            else
            {
                Node temp = front;
                front = front.next;
                temp.next = null;
                return temp.data;
            }
        }

        public int Peek()
        {
            if (front == null)
            {
                throw new InvalidOperationException("the Queue is empty! you cant Peek");
            }
            else
                return front.data;
        }

        public bool IsEmpty()
        {
            return front == null;
        }

        public string QueuePrint()
        {
            string fullNude = "";
            Node temp = front;

            while (temp != null)
            {
                fullNude += $"[ {temp.data} ] -> ";

                temp = temp.next;
            }
            fullNude += "NULL";

            return fullNude;
        }





    }

   



}
