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

        public bool Delete(int e)
        {
            Node p = root;
            Node pp = null;

            while (p != null & p.element != e)
            {
               pp = p;
               if(e<p.element)
               {
                    p = p.left;
               }
               else
               {
                    p = p.right;
               }
            }

            if (p==null)
            {
                return false;
            }

            if(p.left==null && p.right==null)
            {
                if(p!=root)
                {
                    if(pp.left==p)
                    {
                        pp.left = null;
                    }
                    else
                    {
                        pp.right = null;
                    }
                }
                else
                {
                    root = null; 
                }
            }

            else if(p.left!=null && p.right!=null)
            {

                Node s = p.left;
                Node ps = p;

                if(s.right==null)
                {
                    p.element = s.element;
                    p.left = s.left;
                    return true;
                }

                while(s.right!=null)
                {
                    ps = s;
                    s = s.right;
                }

                p.element = s.element;
                p = s;
                ps.right = null;
                
            }

            else  
            {
                Node c = null;
                if(p.left==null)
                {
                    c = p.right;
                }
                else
                {
                    c = p.left;
                }
                if(p!=root)
                {
                    if (pp.left == p)
                    {
                        pp.left = c;
                    }
                    else
                    {
                        pp.right = c;
                    }
                }   
                else
                {
                    root = c;
                }
                
            }
          
            return true;

        }

        public int Count(Node troot)
        {
            int x = 0;
            int y = 0;
            if(troot!=null)
            {
                x = Count(troot.left);
                y = Count(troot.right);
                return x + y + 1;
            }
            return 0;
        }

        public int Height(Node troot)
        {
            int x = 0;
            int y = 0;
            if(troot!=null)
            {
                x = Height(troot.left);
                y = Height(troot.right);

                if(x>y)
                {
                    return x + 1;
                }
                else
                {
                    return y + 1;
                }
            }
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Insert(tree.root, 14);
            tree.Insert(tree.root, 10);
            tree.Insert(tree.root, 15);
            tree.Insert(tree.root, 7);
            tree.Insert(tree.root, 12);  
            tree.Insert(tree.root, 6);
            tree.Insert(tree.root, 8);
            tree.Insert(tree.root, 11);
            tree.Insert(tree.root, 13);

            //tree.Insert(tree.root, 4);
            //tree.Insert(tree.root, 6);
            tree.Delete(10);
            //tree.Insert(tree.root, 30);
            //tree.Insert(tree.root, 20);
            //tree.Insert(tree.root, 90);
            //tree.Insert(tree.root, 70);
            //tree.Insert(tree.root, 50);
            //tree.Insert(tree.root, 200);
            //Console.WriteLine("Count"+tree.Count(tree.root));
            //Console.WriteLine("Height of Tree" + tree.Height(tree.root));

            tree.Inorder(tree.root);

            //Console.WriteLine("Search" + tree.Search(100));
            Console.ReadLine();

        }
    }
}
