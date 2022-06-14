using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    public class HashTable
    {
        public Node[] node { get; set; }
        int Size = 2048;

        public HashTable()
        {
            node = new Node[Size];
        }

        public int Hash(string key)
        {
            int hashing = 0;

            foreach (int x in key)
            {
                hashing += x;
            }
            int ahashing = hashing * 599 % 2048;

            return ahashing;
        }

        public void Set(string key, string value)
        {
            int index = Hash(key);
            Node newNode = new Node(key, value);

            if (node[index] == null)
            {
                node[index] = newNode;
            }
            else
            {
                Node Current = node[index];
                while (Current.Next != null)
                {
                    Current = Current.Next;
                }
                Current.Next = new Node(key, value);
            }
        }
        public Node Get(string key)
        {
            int index = Hash(key);
            Node Target = node[index];

            while (Target != null)
            {
                if (Target.Key == key)
                {
                    return Target;
                }
                Target = Target.Next;
            }

            return null;
        }

        public bool Contains(string key)
        {
            int index = Hash(key);
            Node Target = node[index];

            while (Target != null)
            {
                if (Target.Key == key)
                {
                    return true;
                }
                Target = Target.Next;
            }
            return false;
        }
    }
}
