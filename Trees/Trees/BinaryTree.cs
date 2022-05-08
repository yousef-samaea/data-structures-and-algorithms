using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class BinaryTree
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

        

        public BinaryTree()
        {
            Root = null;
        }
        public BTNode RetutnRoot()
        {
            return Root;
        }

        //public void PreOrder(BTNode root)
        //{
        //    //if (root == null)
        //    //{
        //    //    Console.WriteLine("Tree is empty!");
        //    //    //return null;
        //    //}
        //    if (root != null)
        //    {
        //        Console.Write(root.Value + " ");
        //        PreOrder(root.Left);

        //        PreOrder(root.Righte);
        //    }
        //    //return MyTree;
        //}
        public List<int> PreOrder(BTNode node)
        {
            if (node != null)
            {
                MyTree.Add(node.Value);
                Console.Write($"{ node.Value},");
                PreOrder(node.Left);
                PreOrder(node.Righte);

            }
            return MyTree;

        }




        //public void InOrder()
        //{

        //}

        public void InOrder(BTNode root)
        {
            //if (root == null)
            //{
            //    Console.WriteLine("Tree is empty!");
            //    //return null;
            //}
            if (root != null)
            {

                InOrder(root.Left);
                Console.Write(root.Value + " ");
                InOrder(root.Righte);
            }
            //return MyTree;
        }

        public void POSTOrder(BTNode root)
        {
            //if (root == null)
            //{
            //    Console.WriteLine("Tree is empty!");
            //    //return null;
            //}
            if (root != null)
            {

                POSTOrder(root.Left);

                POSTOrder(root.Righte);
                Console.Write(root.Value + " ");
            }
            //return MyTree;
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

        public int MaxTree(BTNode node)
        {
            if (node == null)
            {
                return int.MinValue;
            }

            int max = node.Value;
            int left = MaxTree(node.Left);
            int right = MaxTree(node.Righte);

            if (left > max)
            {
                max = left;
            }
            if (right > max)
            {
                max = right;
            }

            return max;
        }

        //public List<object> BreadthFirst()
        //{
        //    BreadthFirst(Root);
        //    return MyTreee;
        //}

        //private List<object> BreadthFirst(BTNode root)
        //{
        //    Queue<BTNode> queue = new Queue<BTNode>();
        //    queue.Enqueue(root);

        //    while (queue.Count > 0)
        //    {
        //        BTNode node = queue.Dequeue();

        //        if (node.Left != null)
        //        {
        //            queue.Enqueue(node.Left);
        //        }
        //        if (node.Righte != null)
        //        {
        //            queue.Enqueue(node.Righte);
        //        }
        //        MyTree.Add(node.Value);
        //        Console.Write($"{ node.Value},");
        //    }
        //    return MyTreee;

        //}

    }
}
