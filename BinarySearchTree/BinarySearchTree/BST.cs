using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BST
    {
        Node head = null;
        Node current;

        public BST()
        {

        }
        public void Add (int item)
        {
            Node node = new Node(item);
            if(head == null)
            {
                head = node;
                return;
            }
            current = head;
            Traverse(current, node);
            if (current.data > node.data)
            {
                current.left = node;
            }
            else
            {
                current.right = node;
            }
        }
        public void Traverse(Node current, Node node)
        {
            if (current.data > node.data && current.left != null)
            {
               
                current = current.left;
                Traverse(current, node);
            }
            else if (current.data >= node.data && current.right != null)
            {
                current = current.right;
                Traverse(current, node);
            }
            else
            {
            }
        }
        public bool Search(int searchData)
        {
            current = head;
            while (current.left != null || current.right != null)
            {
                if (current.data == searchData)
                {
                    Console.WriteLine("This value exists");
                    Console.ReadLine();
                    return true;
                }
                else if (searchData < current.data)
                {
                    Console.WriteLine("left");
                    current = current.left;
                }
                else
                {
                    Console.WriteLine("right");
                    current = current.right;
                }
            }
            if (current.data == searchData)
            {
                Console.WriteLine("This value exists");
                Console.ReadLine();
                return true;
            }
            else
            {
                Console.WriteLine("This value does not exist");
                return false;
            }
        }
    }
}
