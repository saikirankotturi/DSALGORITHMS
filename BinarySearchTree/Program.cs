using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{

    class Node
    {
        public int element;
        public Node left;
        public  Node right;

        public Node(int e, Node l, Node r)
        {
            element = e;
            left = l;
            right = r;
        }
    }

    class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(Node tempRoot,int e)
        {
            Node temp = null;
           

            while (tempRoot!=null)
            {
                temp = tempRoot;
                if(tempRoot.element==e)
                {
                    return;
                }
                else if (e<tempRoot.element)
                {
                    tempRoot = tempRoot.left;
                }
                else if(e>tempRoot.element)
                {
                    tempRoot = tempRoot.right;
                }
            }

            Node n = new Node(e, null, null);
           if(root!=null)
            {
                if(e<temp.element)
                {
                    temp.left = n;
                }
                else
                {
                    temp.right = n;
                }
            }
            else
            {
                root = n;
            }

        }

        public void Inorder(Node tempRoot)
        {
            if(tempRoot!=null)
            {
                Inorder(tempRoot.left);
                Console.WriteLine(tempRoot.element+" ");
                Inorder(tempRoot.right);
            }
        }

        public bool Search(int key)
        {
            Node tempRoot = root;
            while(tempRoot!=null)
            {
                if(key==tempRoot.element)
                {
                    return true;
                }
                else if(key<tempRoot.element)
                {
                    tempRoot = tempRoot.left;
                }
                else
                {
                    tempRoot = tempRoot.right;
                }
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Insert(tree.root, 10);
            tree.Insert(tree.root, 5);
            tree.Insert(tree.root, 30);
            tree.Insert(tree.root, 20);
            tree.Insert(tree.root, 90);
            tree.Insert(tree.root, 70);
            tree.Insert(tree.root, 50);
            tree.Insert(tree.root, 200);

            tree.Inorder(tree.root);

            Console.WriteLine("Search" + tree.Search(100));
            Console.ReadLine();

        }
    }
}
