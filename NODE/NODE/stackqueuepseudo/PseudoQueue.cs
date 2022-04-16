using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NODE.StacksandQueues;

namespace NODE.stackqueuepseudo
{
    public class PseudoQueue
    {
        Stack stack1 = new();
        Stack stack2 = new();
        public void Enqueue(int data)
        {
            if ( stack1.top == null )
            {
                stack1.Push(data);
            }
            else
            {
                while ( stack1.top != null )
                {
                    stack2.Push( stack1.Pop()) ;
                }
                stack1.Push(data);
                while ( stack2.top != null )
                {
                    stack1.Push( stack2.Pop() );
                }
            }
        }


        public void Dequeue()
        {
            if (stack1.top == null)
            {
                throw new InvalidOperationException("the Stack is empty! you cant Dequeue");
            }
            else
            {
                stack1.Pop();
            }


        }
        public int Peek()
        {
            if (stack1.top == null)
            {
                throw new InvalidOperationException("the Stack is empty! you cant Peek");

            }
            return stack1.top.data;
        }

        public string PseudoQueuePrint()
        {
            string fullNude = "";
            Node temp = stack1.top;

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
