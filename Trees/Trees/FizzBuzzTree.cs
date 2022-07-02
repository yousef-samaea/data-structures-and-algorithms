using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class FizzBuzzTree
    {

        public List<string> FBTree()
        {
            return FBTree(Root);
        }

        public FNode Root;
        public List<string> FBTree(FNode root)
        {
            List<string> FBlist = new List<string>();

            if (root == null)
            {
                return null;
            }
            Queue<FNode> FBQueue = new Queue<FNode>();
            FBQueue.Enqueue(root);
            while (FBQueue.Count > 0)
            {
                for (int i = 0; i < FBQueue.Count(); i++)
                {
                    int value = Convert.ToInt32(FBQueue.First().Value);

                    if (value % 15 == 0)
                    {
                        FBlist.Add("FizzBuzz");
                    }
                    else if (value % 3 == 0)
                    {
                        FBlist.Add("Fizz");
                    }
                    else if (value % 5 == 0)
                    {
                        FBlist.Add("Buzz");
                    }
                    else
                    {
                        FBlist.Add(FBQueue.First().Value.ToString());
                    }


                    FNode node = FBQueue.Dequeue();
                    foreach (FNode item in node.Children)
                    {
                        FBQueue.Enqueue(item);
                    }
                }
            }
            return FBlist;
        }

        public List<string> FizzBuzz(FNode root)
        {
            List<string> FBTree = new List<string>();

            if (root == null)
            {
                return null;
            }

            Queue<FNode> FBQueue = new Queue<FNode>();
            FBQueue.Enqueue(root);

            while (FBQueue.Count > 0)
            {
                for (int i = 0; i < FBQueue.Count(); i++)
                {
                    FNode node = FBQueue.Dequeue();
                    FBTree.Add(node.Value.ToString());
                    foreach (FNode item in node.Children)
                    {
                        FBQueue.Enqueue(item);
                    }
                }
            }
            return FBTree;

        }
    }

}
