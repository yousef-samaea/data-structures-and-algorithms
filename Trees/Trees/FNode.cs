using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class FNode
    {
        public string Value;
        public List<FNode> Children;
        public FNode()
        {

        }
        public FNode(string data)
        {
            Value = data;
            Children = new List<FNode>();

        }


    }
}
