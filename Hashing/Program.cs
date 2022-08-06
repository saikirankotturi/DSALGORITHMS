using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace Hashing
{
    class Hash
    {
        int hashTableSize;
        LinkedListCustom[] hashTable;

        public Hash()
        {
            hashTableSize = 10;
            hashTable = new LinkedListCustom[hashTableSize];
            for (int i = 0; i < hashTableSize; i++)
            {
                hashTable[i] = new LinkedListCustom();
            }
        }

        public int HashCode(int key)
        {
            return key % hashTableSize;
        }
        public void Insert(int e)
        {
            int i = HashCode(e);
            hashTable[i].InsertElementAtSortedOrder(e);
        }

        public void Display()
        {
            for (int i = 0; i < hashTableSize; i++)
            {
                Console.WriteLine("i" + i);
                hashTable[i].DisplayLL();
            }
            Console.WriteLine("");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hash hash = new Hash();
            hash.Insert(20);
            hash.Insert(30);
            hash.Insert(22);
            hash.Display();
            Console.ReadLine();
        }
    }
}
