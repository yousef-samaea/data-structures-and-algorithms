using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
   public class BTNode
    {
        public int Value;
        public BTNode Left;
        public BTNode Righte;

        public BTNode()
        {
        }

        public BTNode(int x)
        {
            Value = x;
        }
    }
}
