using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDataStructure
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            CustomLinkedList linkedList = new CustomLinkedList();
            linkedList.AddLast(56);
            linkedList.AddLast(30);
            linkedList.AddLast(70);
            Console.WriteLine();
            Console.WriteLine("insert at first");
            linkedList.AddLast(70);
            linkedList.AddLast(30);
            linkedList.AddLast(56);
        }
    }
}
