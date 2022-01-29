using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDataStructure
{
    public class LinkedListStack
    {
        public Node top;
        //customlinkedlist linked
        public void push(int newData)
        {
            Node newNode = new Node(newData);
            if(this.top != null)
            {
                newNode.next = this.top;
            }
            this.top=newNode;
            Console.WriteLine("New node {0} is added",newNode.data);
        }
        //public void Display()
        //{
        //    Node temp=this.top
        //}
    }
}
