using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class ObNode
    {
        public object V;
        public ObNode L;
        public ObNode R;

        public ObNode()
        {
        }

        public ObNode(object x)
        {
            V = x;
        }
    }
}

