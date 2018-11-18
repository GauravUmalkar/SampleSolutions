using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelvifyTreeTraversal_Console
{
    public class NodeModel
    {
        public int item;
        public NodeModel left;
        public NodeModel right;
        public void NodeDisplay()
        {
            Console.Write("[");
            Console.Write(item);
            Console.Write("]");
        }
    }
}
