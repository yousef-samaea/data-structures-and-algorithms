using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NODE
{
    public class LinkedList
    {
        //public int data;
        //public Node next;
        //public Node(int data) 
        //{
        //    this.data = data;
        //    next = null;
        //}
        Node head;
        public LinkedList()
        {
            head = null;
        }
        public void Insert(int value)
        {

            Node node = new Node(value);
            if (head == null)
            {
                head = node;
            }
            else
            {
                node.next = head;
                head = node;
            }
        }

        public string lToString()
        {
            string fullNude = "";
            Node temp = head;

            while (temp != null)
            {
                fullNude += $"[ {temp.data} ] -> ";

                temp = temp.next;
            }
            fullNude += "NULL";

            return fullNude;
        }

        public bool Includes(int data)
        {
            Boolean result = false;
            Node temp = head;
            while (temp != null)
            {
                if (temp.data == data)
                {
                    result = true;
                }
                temp = temp.next;
            }
            return result;
        }


        //public void PrintList()
        //{
        //    Node temp = head;
        //    while (temp != null)
        //    {
        //        Console.WriteLine(temp.data);
        //    }
        //}

        public void AppendInEnd(int data)
        {
            if (head == null)
            {
                Node aNode = new Node(data);
                head = aNode;
                head.next = null;
            }
            else
            {
                Node aNode = new Node(data);
                Node temp;
                temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = aNode;
            }
        }

        public void AddAfter(int after, int value)
        {
            Node temp = new Node(value);
            Node current = head;
            if (current == null)
            {
                Console.WriteLine("the list is empty!,try to append");
            }
            else 
            {
                while (current.data != after) {

                    current = current.next;
                }
                temp.next = current.next;
                current.next = temp;

            }

        }

        public void InsertBefore(int abefore, int value)
        {
            Node temp = new Node(value);
            Node current = head;
            if (current == null)
            {
                Console.WriteLine("the list is empty!,try to append");
            }
            else if(current.data == abefore)
            {
                temp.next = current;
                current = temp;
            }
            else
            {
                while (current.next.data != abefore)
                {

                    current = current.next;
                }
                temp.next = current.next;
                current.next = temp;

            }
            //while(current.next.data !=abefore)
            //{

            //        current = current.next;
            //}
            //    temp.next = current.next;
            //    current.next = temp;
        }


        public int kthFromEnd(int k)
        {
            int cauntar = 0;
            Node current = head;
            while (current != null)
            {
                current = current.next;
                cauntar++;
            }
            if (k < 0 || k >= cauntar)
            {
                throw new ArgumentException("you cant inter a negative value or bigaar than or eqal to " + cauntar);
            }
            else
            {
                Node temp = head;
                for (int i = 0; i < k; i++)
                {
                    temp = temp.next;
                }
                int kth = temp.data;
                //Console.WriteLine("the search resalt is " + kth);
                return kth;
               
            }


        }


    }
}

