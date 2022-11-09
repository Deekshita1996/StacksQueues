using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StackProblem1
{
    public class StackUC_1
    {
        private Node top;
        public StackUC_1()
        {
            this.top = null;
        }
        //30
        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} pushed to stack ", value);
        }
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " "); //56 30 70 
                temp = temp.next;//1400
            }
        }
    }

}

