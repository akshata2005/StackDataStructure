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
        //method to display the linked list
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
        //Method To delete First Node
        public int DeleteFirstNode()
        {
            if (this.head == null)
            {
                return 0;
            }
            int deleteNode = this.head.data;
            this.head = this.head.next;
            return deleteNode;
        }
        // method to delete last node
        public int DeleteLastNode()
        {
            Node newNode = this.head;
            if (this.head == null)
            {
                return 0;
            }
            if (this.head.next == null)
            {
                this.head = null;
                return 0;
            }
            //checking for tail Node.
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            int deleteLastNode = newNode.next.data;
            newNode.next = null;
            return deleteLastNode;
        }
        //method to search element in linked list
        public int Search(int value)
        {
            Node temp = this.head;
            int count = 0;
            while(temp != null)
            {
                Console.WriteLine("\n Node is present");
                return count;
            }
            temp=temp.next;
            count++;
            Console.WriteLine("\n {0} is not present" ,value);
            return count;
        }
        public Node InsertAtMiddleOfLinkedList(int data,int position)
        {
            Node newnode = new Node(data);
            Node previousnode=null;
            Node currentnode=this.head;
            int count = 0;
            while(currentnode != null && count<position)
            {
                previousnode = currentnode;
                currentnode = currentnode.next;
                count++;
            }
            newnode.next = previousnode;
            previousnode = newnode;
            Console.WriteLine("\n Element {0} Inserted at position {1}.", data, position);
            Display();
            return this.head;
        }
        public void RemoveElement(int element)
        {
            Node temp = head, prev = null;
            if (temp != null && temp.data == element)
            {
                head = temp.next;
                return;
            }
            while (temp != null && temp.data != element)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
                return;

            prev.next = temp.next;
            Console.WriteLine(" Element : {0} is Removed..", element);
        }
        public int Size()
        {
            Node temp = this.head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine(" LinkedList is empty...");
                return 0;
            }
            while (temp != null)
            {
                temp = temp.next;
                count++;
            }
            Console.WriteLine(" Length of LinkedList is : " + " " + count);
            return count;
        }
    }
}
