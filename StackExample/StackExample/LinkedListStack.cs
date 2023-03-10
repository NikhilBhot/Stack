using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StackExample
{
    internal class LinkedListStack
    {
        private Node top;
        
        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack ", value);
        }
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;//1400
            }
        }
    }
}
