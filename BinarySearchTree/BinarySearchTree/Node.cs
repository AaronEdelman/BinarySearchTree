using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
        public class Node
        {
            public int data;
            public Node left;
            public Node right;
            public Node(int item)
            {
                data = item;
            }
            public Node()
            {
                //overloads Node Constructor, so that a null node can be created
            }
        }
}
