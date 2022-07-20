using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackWithArray
{
    class StackArray
    {
        public int[] Data;
        public int top;

        public StackArray(int size)
        {
            Data = new int[size];
            top = 0;
        }

        public int Length()
        {
            return top;
        }

        public bool IsFull()
        {
            return top == Data.Length;
        }

        public bool IsEmpty()
        {
            return top == 0;
        }

        public void Push(int e)
        {
            if(IsFull())
            {
                Console.WriteLine("Stack is full");
                return;
            }
            else
            {
                Data[top] = e;
                top = top + 1;
                Console.WriteLine("Pushed");
            }
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                return -1;
            }
            else
            {
               int e= Data[top-1];                
                top--;
                return e;
            }
        }

        public void Display()
        {
            foreach(var item in Data)
            {
                Console.WriteLine(item);
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            StackArray stackArray = new StackArray(4);
            stackArray.Push(10);
            stackArray.Push(20);
            stackArray.Push(30);
            stackArray.Push(40);
            Console.WriteLine(stackArray.Pop());
            stackArray.Display();
            Console.ReadLine();

        }
    }
}
