using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node
    {
       public  int element;
       public  Node next;

        public Node(int e, Node node)
        {
            element = e;
            next = node;
        }
    }

    class LinkedList
    {
        int size;
        Node head;
        Node tail;
        int element;

        public LinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public int TotalLength()
        {
            return size;
        }

        public void AddFirst(int e)
        {
            Node newest = new Node(e, null);
            if(IsEmpty())
            {
                head = newest;
            }
            else
            {
                Node n = head;
                head = newest;

                head.next = n;
            }
            size = size + 1;
        }
        public void AddLast(int e)
        {
            Node newest = new Node(e, null);
            if (IsEmpty())
            {
               
                head = newest;
              
            }
            else
            {
                tail.next = newest;
            }
            tail = newest;
            size = size + 1;
        }
            
        public void DisplayLL()
        {
            while(head!=null)
            {
                Console.WriteLine(head.element);
                head = head.next;
            }
            Console.ReadLine();
        }

        public void InsertElementAt(int e, int position)
        {
            int index = 1;
            Node n = head;
            while (index<position-1)
            {
                index = index + 1;

                n = n.next;
            }

            Node insertNode= new Node(e, null);

            insertNode.next = n.next;
            n.next = insertNode;
            size = size + 1;
        }

        public void DeleteElementAtBeginnning()
        {
            if(IsEmpty())
            {
                return;
            }
            else
            {
                head = head.next;
                size = size - 1;
                if(IsEmpty())
                {
                    tail = null;
                }
            }
        }

        public void DeleteElementAtEnd()
        {
            if(IsEmpty())
            {
                return ;
            }
            else
            {
                Node p = head;
                int index = 1;
                 while(index<size-1)
                 {
                  
                    p = p.next;
                    index = index + 1;
                 }

                tail = p;
                p = p.next;
                tail.next = null;
                size = size - 1;
                return;
            }
        }

        public void DeleteElementAtAny(int position)
        {
            int index = 1;
            Node node = head;
            while(index<position-1)
            {
                node = node.next;
                index = index + 1;
            }
            node.next = node.next.next;
            size = size - 1;

        }

        public void InsertElementAtSortedOrder(int e)
        {
            Node p = head;
            Node q = null;
            int index = 1;
            while (p!=null&&p.element<e)
            {
                q = p;
                p = p.next;
                index = index + 1;
            }

            if(index==1)
            {
                Node newest = new Node(e, null);
                newest.next = head;
                head = newest;

                size = size + 1;
            }
            else
            {
                Node newest = new Node(e,null);
                q.next = newest;
                newest.next = p;
                size = size + 1;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList l = new LinkedList();
            l.AddLast(1);
            l.AddLast(2);
            l.AddFirst(4);
            // l.InsertElementAt(3, 2);
            //l.DeleteElementAtBeginnning();
            l.InsertElementAtSortedOrder(2);
            //Console.WriteLine("DeleteFirst ");
            //l.DeleteElementAtBeginnning();
          
            //l.DeleteElementAtAny(1);
            Console.WriteLine("Size" + l.TotalLength());
            l.DisplayLL();
         
          
        }
    }
}
