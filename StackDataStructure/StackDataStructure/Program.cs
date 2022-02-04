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
            linkedList.AddLast(40);
            linkedList.AddLast(70);
            linkedList.Display();
            linkedList.RemoveElement(40);
            linkedList.Size();
            linkedList.Display();
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
            //Console.WriteLine("\n {0} is deleted from linkedlist", linkedList.DeleteLastNode());
            //Console.WriteLine("\n {0} is deleted from linkedlist", linkedList.DeleteFirstNode());
            //linkedList.Display();
            //linkedList.Search(30);
            //if (res != 0)
            //Console.WriteLine("\n {0} is present in linkedlist");
            //linkedList.InsertAtMiddleOfLinkedList(60,90);
            
            //linkedList.Display();
            Console.ReadLine();
        }
    }
}
