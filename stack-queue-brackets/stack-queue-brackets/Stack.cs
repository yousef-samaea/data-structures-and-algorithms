using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_queue_brackets
{
    public class Stack
    {
        public Node top;
        public Stack()
        {
            top = null;
        }

        public void Push(int data)
        {
            Node stackNode = new Node(data);
            stackNode.next = top;
            top = stackNode;
        }

        public int Pop()
        {
            if (top == null)
            {
                throw new InvalidOperationException("the Stack is empty! you cant Pop");

            }
            else
            {
                Node temp = top;

                top = top.next;
                temp.next = null;

                return temp.data;
            }

        }

        public int Peek()
        {
            if (top == null)
            {
                throw new InvalidOperationException("the Stack is empty! you cant Peek");

            }
            return top.data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public string StackPrint()
        {
            string fullNude = "";
            Node temp = top;

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
