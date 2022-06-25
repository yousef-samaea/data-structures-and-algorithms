using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    public class Tree
    {
        public BTNode Root;

        public List<int> MyTree = new List<int>();


        public void Add(int value)
        {
            BTNode nNode = new BTNode();
            nNode.Value = value;
            if (Root == null)
            {
                Root = nNode;
            }
            else
            {
                BTNode current = Root;
                BTNode parent;
                while (true)
                {
                    parent = current;
                    if (value < current.Value)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = nNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.Righte;
                        if (current == null)
                        {
                            parent.Righte = nNode;
                            return;
                        }
                    }
                }
            }
        }



        public Tree()
        {
            Root = null;
        }
        public BTNode RetutnRoot()
        {
            return Root;
        }


        public List<int> Order(BTNode node)
        {
            if (node != null)
            {
                MyTree.Add(node.Value);
                //Console.Write($"{ node.Value},");
                Order(node.Left);
                Order(node.Righte);

            }
            return MyTree;

        }
        public bool Contains(int value)
        {
            try
            {
                BTNode Nood = Root;
                while (Nood != null)
                {
                    if (value > Nood.Value)
                    {
                        Nood = Nood.Righte;
                    }
                    else if (value < Nood.Value)
                    {
                        Nood = Nood.Left;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
    }
}
