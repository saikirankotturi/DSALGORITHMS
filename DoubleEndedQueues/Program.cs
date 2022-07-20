using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleEndedQueues
{
    class Node
    {
        public int element;
        public Node next;

        public Node(int e)
        {
            element = e;
            next = null;
        }
    }

    class DoubleEndedQueue
    {
        Node front;
        Node rear;
        int size;

        public DoubleEndedQueue()
        {
            front = null;
            rear = null;
            size = 0;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public int Length()
        {
            return size;
        }

        public void AddLast(int e)
        {
            Node newest = new Node(e);
            if(IsEmpty())
            {
                front = newest;                
            }
            else
            {
                rear.next = newest;

            }

            rear = newest;
            size++;
        }

        public void AddFirst(int e)
        {
            Node newest = new Node(e);
            if (IsEmpty())
            {
                front = newest;
                rear = newest;
            }
            else
            {
                newest.next = front;
                front = newest;
            }

            size++;            
        }

        public int RemoveFirst()
        {
            if(IsEmpty())
            {
                return -1;
            }

            else
            {
               int e = front.element;
                front = front.next;
                size--;
                return e;
            }
        }

        public int RemoveLast()
        {
            if (IsEmpty())
            {
                return -1;
            }
            else
            {
                int index = 1;
                Node p = front;
                while (index < size - 1)
                {

                    p = p.next;
                    index++;
                }
                rear = p;
                int e = p.next.element;
                rear.next = null;

                size--;
                return e;

            }
        }
        public void Display()
        {
            Node p = front;
            while (p != null)
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
            DoubleEndedQueue dll = new DoubleEndedQueue();
            dll.AddFirst(1);
            dll.AddFirst(2);
            dll.AddLast(3);
            dll.AddLast(5);
            dll.RemoveFirst();
            dll.RemoveLast();
            dll.Display();
        }
    }
}
