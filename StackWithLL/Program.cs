using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackWithLL
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

    class StackLL
    {
        Node head;
        Node tail;
        int length;

        public StackLL()
        {
            head = null;
            tail = null;
        }

        public int LengthOfStack()
        {
            return length;
        }

        public bool IsEmpty()
        {
            return length == 0;
        }

        public void Push(int e)
        {
            Node newest = new Node(e);
            if(IsEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                newest.next = head;
                head = newest;
               
            }
            length++;
        }

        public void Pop()
        {
            if (IsEmpty())
            {
                return;
            }
            else
            {
                int e = head.element;
                head = head.next;
                Console.WriteLine(e);
                length--;
            }
        }

        public void Display()
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
            StackLL LL = new StackLL();
            LL.Push(10);
            LL.Push(20);
            LL.Push(30);
            
            LL.Display();
            LL.Pop();
            LL.Pop();
            Console.ReadLine();

        }
    }
}
