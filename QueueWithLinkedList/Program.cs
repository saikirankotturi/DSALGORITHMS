using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueWithLinkedList
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

    class QueueLL
    {
        Node front;
        Node rear;
        int size;

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void Enqueue(int e)
        {
            Node newest = new Node(e);
            if(IsEmpty())
            {
                front = newest;                
            }
            else
            {
                rear.next= newest;
              
            }
            rear = newest;
            size = size + 1;
        }

        public int DeQueue()
        {
           
            if(IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
               
                int  e = front.element;
                front = front.next;
                size--;
                return e;
            }
          
        }
        public void Display()
        {
            Node f = front;
            while (f!=null)
            {
                Console.WriteLine(f.element);
                f = f.next;
            }
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            QueueLL ll = new QueueLL();
            ll.Enqueue(10);
           
            ll.Enqueue(20);
            ll.Display();
            Console.WriteLine(ll.DeQueue());
            Console.WriteLine(ll.DeQueue());
            Console.ReadLine();
        }
    }
}
