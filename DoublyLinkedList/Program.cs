using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class Node
    {
        public int element;
        public Node next;
        public Node previous;

        public Node(int e, Node p, Node q)
        {
            element = e;
            next = p;
            previous = q;
        }
    }

    public class DoublyLinkedList
    {
        Node head;
        Node tail;
        int size;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public int LengthOfDLL()
        {
            return size;
        }

        public void AddLast(int e)
        {
            Node newest = new Node(e, null, null);
            if(IsEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                tail.next = newest;
                newest.previous = tail;
                tail = newest;
               
            }
            size++;
        }

        public void InsertAtBeginnning(int e)
        {
            Node newest = new Node(e, null, null);
            if(IsEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                newest.next = head;
                head.previous = newest;
                head = newest;
            }
            size++;
        }

        public void InsertElementAtAny(int e,int position)
        {
            Node newest = new Node(e, null, null);
            if(IsEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                int index = 1;
                Node p = head;
                while(index<position-1)
                {
                    index = index + 1;
                    p = p.next;
                }

                newest.next = p.next;
                p.next.previous = newest;
                p.next = newest;
                newest.previous = p;             

            }
            size++;
        }

        public void DeleteElementAtBeginning()
        {
            if(IsEmpty())
            {
                return;
            }
            else
            {
                head = head.next;
                size--;
                if(IsEmpty())
                {
                    tail = null;
                }
                else
                {
                    head.previous = null;
                }
               
            }
        }

        public void DeleteAtEnd()
        {
            if (IsEmpty())
            {
                return;
            }
            else
            {
                tail = tail.previous;
                tail.next = null;
                size--;

            }
        }

        public void DeleteAtAny(int position)
        {
            if(IsEmpty())
            {
                return;
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

                p.next = p.next.next;
                p.next.previous = p;
                size--;

            }
        }


        public void DisplayDLL()
        {
            Node p = head;
            while(p!=null)
            {
                Console.WriteLine(p.element);
                p = p.next;
            }
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList dll = new DoublyLinkedList();
            dll.AddLast(10);
            dll.AddLast(20);
            dll.AddLast(30);
            dll.InsertElementAtAny(2, 2);
            dll.InsertAtBeginnning(5);
            dll.DeleteElementAtBeginning();
            dll.DisplayDLL();
        }
    }
}
