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
            Console.WriteLine("Insert at Last");
            linkedList.AddLast(56);
            linkedList.AddLast(30);
            linkedList.AddLast(70);
            Console.WriteLine();
            Console.WriteLine("insert at first");
            linkedList.AddFirstNode(70);
            linkedList.AddFirstNode(30);
            linkedList.AddFirstNode(56);
            //Console.WriteLine("append Operation");
            //linkedList.AppendLinkedList(56);
            //linkedList.AppendLinkedList(30);
            //linkedList.AppendLinkedList(70);
            //linkedList.DeleteFirstNode(56);
            Console.WriteLine("\n {0} is deleted from linkedlist", linkedList.DeleteLastNode());
            Console.WriteLine("\n {0} is deleted from linkedlist", linkedList.DeleteFirstNode());
            linkedList.Display();
            int res = linkedList.Search(90);
            if (res != 0)
                Console.WriteLine("\n {0} is present in linkedlist", res);
            Console.ReadLine();
        }
    }
}
