using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Tree
    {
        public Node root;
        public Tree()
        {
            root = null;
        }
        public Node ReturnRoot()
        {
            return root;
        }
        public void Insert(int id)
        {
            Node node = new Node(id);
            if(root == null)
            {
                root=node;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if(id < current.item)
                    {
                        current = current.left;
                        if(current == null)
                        {
                            parent.left = node;
                            return;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if(current == null)
                        {
                            parent.right = node;
                            return;
                        }
                    }

                }
            }

        }
        public void Display(Node root)
        {
            if(root != null)
            {
                Console.WriteLine(root.item + " |");
                Display(root.left);
                Display(root.right);

            }
        }
        public void Post(Node root)
        {
            if (root != null)
            {
                Post(root.left);
                Post(root.right);
                Console.WriteLine(root.item + " |");
            }

        }
        public void InOrder(Node root)
        {
            if (root != null)
            {
                Post(root.left);
                Console.WriteLine(root.item + " |");
                Post(root.right);
                
            }

        }


    }
}
