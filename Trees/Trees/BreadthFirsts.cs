using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class BreadthFirsts
    {
        public ObNode Root;
        public List<object> MyTreee = new List<object>();

        public void Addob(object v)
        {
            ObNode bnNode = new ObNode();
            bnNode.V = v;
            if (Root == null)
            {
                Root = bnNode;
            }
            else
            {
                ObNode ocurrent = Root;
                ObNode oparent;
                while (true)
                {
                    oparent = ocurrent;
                    if ((int)v < (int)ocurrent.V)
                    {
                        ocurrent = ocurrent.L;
                        if (ocurrent == null)
                        {
                            oparent.L = bnNode;
                            return;
                        }
                    }
                    else
                    {
                        ocurrent = ocurrent.R;
                        if (ocurrent == null)
                        {
                            oparent.R = bnNode;
                            return;
                        }
                    }
                }
            }
        }

        public List<object> BreadthFirst()
        {
            BreadthFirst(Root);
            return MyTreee;
        }

        public List<object> BreadthFirst(ObNode root)
        {
            Queue<ObNode> queue = new Queue<ObNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                ObNode node = queue.Dequeue();

                if (node.L != null)
                {
                    queue.Enqueue(node.L);
                }
                if (node.R != null)
                {
                    queue.Enqueue(node.R);
                }
                MyTreee.Add(node.V);
                Console.Write($"{ node.V},");
            }
            return MyTreee;

        }

    }
}
