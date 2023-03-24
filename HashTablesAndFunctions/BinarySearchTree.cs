using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTablesAndFunctions
{  
    public class BinarySearchTree
    {
        public Node root;

        public void Insert(int key)
        {
            Node node = new Node(key);
            if (root == null)
            {
                root = node;
                return;
            }
            Node prev = null;
            Node temp = root;
            while (temp != null)
            {
                if (temp.val > key)
                {
                    prev = temp;
                    temp = temp.left;
                }
                else if (temp.val < key)
                {
                    prev = temp;
                    temp = temp.right;
                }
            }
            if (prev.val > key)
                prev.left = node;
            else
                prev.right = node;
        }

        public void Inorder()
        {
            Node temp = root;
            Stack<Node> stack = new Stack<Node>();
            while (temp != null || stack.Count != 0)
            {
                if (temp != null)
                {
                    stack.Push(temp);
                    temp = temp.left;
                }
                else
                {
                    temp = stack.Pop();
                    Console.Write(temp.val + " ");
                    temp = temp.right;
                }
            }
        }
    }   
}
