using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedList
{
    class Node
    {
        public int element;
        public Node next;

        public Node(int e, Node node)
        {
            element = e;
            next = node;
        }
    }

    class CircularLinkedList
    {
        Node head;
        Node tail;
        int size;

        public CircularLinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public int LengthOfLL()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void AddLast(int e)
        {
            Node newest = new Node(e, null);
            if(IsEmpty())
            {
                newest.next = newest;
                head = newest;                
            }
            else
            {

                newest.next = tail.next;
                tail.next = newest;
              
            }
            tail = newest;
            size++;
        }

        public void AddFirst(int e)
        {
            Node newest = new Node(e, null);
            if (IsEmpty())
            {
               
                newest.next = newest;
                head = newest;
                tail = newest;

            }
            else
            {
                tail.next = newest;                
                newest.next = head;
                head = newest;             
            }
            size++;

        }

        public void AddAnywhere(int e, int position)
        {
            Node newest = new Node(e, null);
            if (IsEmpty())
            {
                newest.next = newest;
                head = newest;
                tail = newest;
            }
            else
            {
                int index = 1;
                Node p = head;
                while(index<position-1)
                {
                    p = p.next;
                    index++;
                }

                newest.next = p.next;
                p.next = newest;

                head = p;
                
            }
            size++;

        }

        public void RemoveFirst()
        {
            if(IsEmpty())
            {
                return;
            }

            else
            {
                tail.next = head.next;
                head = head.next;
                size--;
            }
        }

        public void RemoveAtEnd()
        {
            if (IsEmpty())
            {
                return;
            }

            else
            {
                int index = 1;
                Node p = head;
                while(index<size-1)
                {
                    index++;
                    p = p.next;

                }
                p.next = head;
                tail = p;
                size--;
            }
        }

        public void RemoveAtAny(int position)
        {
            if(IsEmpty())
            {
                return;
            }

            else
            {
                int index = 1;
                Node p = head;
                while (index<position-1)
                {
                    p = p.next;
                    index++;
                }

                p.next = p.next.next;
                head = p;
                size--;
            }
        }

        public void DisplayCLL()
        {
            Node q = head;
            int index = 0;

            while(index<size)
            {
                index++;
               
                Console.WriteLine(q.element);
                q = q.next;
            }
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CircularLinkedList cll = new CircularLinkedList();
          
            cll.AddLast(10);
            cll.AddLast(20);
            cll.AddLast(30);
            cll.AddLast(40);
            //cll.RemoveFirst();          
            //cll.DisplayCLL();
            //Console.WriteLine("Size" + cll.LengthOfLL());

            //cll.RemoveAtEnd();
            //cll.DisplayCLL();
            Console.WriteLine("Size"+cll.LengthOfLL());

            cll.DisplayCLL();

            cll.RemoveAtAny(1);
            cll.DisplayCLL();


        }
    }
}
