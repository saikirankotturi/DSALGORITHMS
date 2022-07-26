using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeRecursion
{
    class Node
    {
        public int element;
        public Node left;
        public Node right;

        public Node(int e, Node l, Node r)
        {
            element = e;
            left = l;
            right = r;
        }
    }

    class BinarySearchTreeRecursion
    {
        public Node root;
        public BinarySearchTreeRecursion()
        {
            root = null;
        }

        public Node Insert(Node tempRoot, int e)
        {
           

            if(tempRoot!=null)
            {
                if(e<tempRoot.element)
                {
                    tempRoot.left = Insert(tempRoot.left, e);
                }
                else if (e>tempRoot.element)
                {
                    tempRoot.right = Insert(tempRoot.right, e);
                }
            }
            else
            {
                Node n = new Node(e, null, null);
                tempRoot = n;
            }
            return tempRoot;
          

        }

        public void Inorder(Node tempRoot)
        {
            if (tempRoot != null)
            {
                Inorder(tempRoot.left);
                Console.WriteLine(tempRoot.element + " ");
                Inorder(tempRoot.right);
            }
        }

        public void PreOrder(Node tempRoot)
        {
            if (tempRoot != null)
            {
                Console.WriteLine(tempRoot.element + " ");
                PreOrder(tempRoot.left);
                PreOrder(tempRoot.right);
            }
        }

        public void PostOrder(Node tempRoot)
        {
            if(tempRoot!=null)
            {
                PostOrder(tempRoot.left);
                PostOrder(tempRoot.right);
                Console.WriteLine(tempRoot.element + " ");
            }
        }

        public void LevelOrder(Node tempRoot)
        {
            System.Collections.Queue q = new System.Collections.Queue();
            Node t = tempRoot;
            Console.WriteLine(t.element + "");
            q.Enqueue(t);

            while (q.Count != 0)
            {
              Node y =  (Node)q.Dequeue();
                if (y.left!=null)
                {
                    Console.WriteLine(y.left.element + "");
                    q.Enqueue(y.left);
                }
                if(y.right!=null)
                {
                    Console.WriteLine(y.right.element + "");
                    q.Enqueue(y.right);
                }            
              
            }

        }

        public bool Search(Node tempRoot, int key)
        {
           
            if(tempRoot != null)
            {
                if(tempRoot.element==key)
                {
                    return true;
                }
                else if (key< tempRoot.element)
                {
                   return Search(tempRoot.left,key);
                }
                else
                {
                  return  Search(tempRoot.right,key);
                }
            }
            return false;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTreeRecursion tree = new BinarySearchTreeRecursion();
            tree.root=  tree.Insert(tree.root, 10);
            tree.Insert(tree.root, 5);
            tree.Insert(tree.root, 30);
            tree.Insert(tree.root, 20);
            tree.Insert(tree.root, 90);
            tree.Insert(tree.root, 70);
            tree.Insert(tree.root, 50);
            tree.Insert(tree.root, 200);

            tree.Inorder(tree.root);
            tree.PreOrder(tree.root);
            tree.PostOrder(tree.root);
            tree.LevelOrder(tree.root);

            Console.WriteLine("Search" + tree.Search(tree.root,200));
            Console.ReadLine();

        }
    }
}
