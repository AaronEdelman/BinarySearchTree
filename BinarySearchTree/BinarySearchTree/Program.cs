using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BST bst = new BinarySearchTree.BST();
            bst.Add(1);
            bst.Add(2);
            bst.Add(3);
            bst.Add(4);

            bst.Search(5);
            Console.ReadLine();
        }
    }
}
