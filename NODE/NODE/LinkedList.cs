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

    }
}

