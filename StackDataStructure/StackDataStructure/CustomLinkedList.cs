using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDataStructure
{
    class CustomLinkedList
    {
        public Node head;
        //summary
        //inserts the last
        public void AddLast(int new_data)
        {
            Node new_node = new Node(new_data);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = new_node;
            }
            Console.WriteLine("inserted into list" + new_node.data);

        }
        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        public void Display()
        {
            Console.WriteLine("Displaying node");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("linked list is empty");
                return;
            }
            else
            {
                while (temp.next != null)
                {
                    Console.WriteLine(" " + temp.data + "");
                    temp = temp.next;
                }
                Console.Write(" " + temp.data);
            }

        }
        //Method to Add Node at First in Linked List
        public void AddFirstNode(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
            Console.WriteLine("{0} : Nodes inserted in Linked list ", newNode.data);
        }
        //Method to Append Linked List
        public void AppendLinkedList(int data)
        {
            AddLast(data);
            Console.WriteLine("{0} node Appended", data);

        }
    }
}
