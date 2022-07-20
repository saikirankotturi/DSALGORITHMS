using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueWithArray
{
    class QueueArray
    {
        int[] Data;
        int front;
        int rear;
        int size;

        public QueueArray(int e)
        {
            Data = new int[e];
            front = 0;
            rear = 0;
            size = 0;
        }

        public int Length()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public bool IsFull()
        {
            return size == Data.Length;
        }

        public void EnQueue(int e)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full");
            }
            else
            {
                Data[rear] = e;
                rear = rear + 1;
                size++;
            }
           
        }
        public void DeQueue()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine(Data[front]);
                front = front + 1;
                size--;
            }
           
        }

        public void Display()
        {
            foreach (var item in Data)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            QueueArray q = new QueueArray(4);
            q.EnQueue(1);
            q.EnQueue(3);
            q.DeQueue();
            q.Display();
            Console.ReadLine();
        }
    }
}
