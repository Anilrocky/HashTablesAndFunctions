using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTablesAndFunctions
{
    public class Node
    {
        public Node left;
        public int val;
        public Node right;
        public Node(int val)
        { 
            this.val = val; 
        }
    }
}
