using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class LinkedList
    {
        public Node head { get; set; }

        public LinkedList(Node head)
        {
            this.head = null;
        }

        static void Main(string[] args)
        {

        }

        public Node AppendNode(int data)
        {
            Node temp = new Node(data);

            if(this.head == null)
            {
                this.head = temp;
                return this.head;
            }

            Node walker = this.head;

            while(walker.next != null)
            {
                walker = walker.next;
            }

            walker.next = temp;
            return walker.next;
        }

        public Node PrependNode(int data)
        {
            Node temp = new Node(data);

            if(this.head == null)
            {
                this.head = temp;
                return this.head;
            }

            temp.next = this.head;
            this.head = temp;
            return this.head;
        }

        public Node Pop()
        {
            if(this.head == null)
            {
                return null;
            }
            if(this.head.next == null)
            {
                return this.head;
            }

            Node walker = this.head;
            while(walker.next.next != null)
            {
                walker = walker.next;
            }
            Node temp = walker.next;
            walker.next = null;
            return temp;
        }
    }

    internal class Node
    {
        public int data { get; set; }
        public Node next { get; set; }

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
