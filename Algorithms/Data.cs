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

        public LinkedList()
        {
            this.head = null;
        }

        static void Main(string[] args)
        {
            LinkedList temp = new LinkedList();
            temp.AppendNode(1);
            temp.AppendNode(2);
            temp.Insert(1, 3);
            Console.WriteLine(temp.head.next.data);
            //Console.WriteLine(temp.head.data);
            //temp.AppendNode(2);
            //Console.WriteLine(temp.head.next.data);
            //Node removed_node = temp.Pop();
            //Console.WriteLine(removed_node.data);
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

        public Node Shift()
        {
            if(this.head == null)
            {
                return null;
            }
            Node temp = this.head;
            this.head = temp.next;
            return temp;
        }

        public Node Insert(int idx, int data)
        {
            if(this.head == null)
            {
                return null;
            }
            Node temp = new Node(data);
            if(idx == 0)
            {
                Node temp_two = this.head;
                temp_two.next = temp;
                this.head = temp_two;
                return this.head;
            }
            Node walker = this.head;
            int next_node_idx = 1;

            while(walker.next != null && next_node_idx < idx)
            {
                walker = walker.next;
                next_node_idx++;
            }
            Node walker_tracker = walker.next;
            temp.next = walker_tracker;
            walker.next = temp;
            return temp;
        }

        public Node Remove(int idx)
        {
            if(this.head == null)
            {
                return null;
            }
            if(idx == 0)
            {
                Node temp = this.head;
                this.head = temp.next;
                return temp;
            }
            Node walker = this.head;
            int index = 1;
            while(walker.next != null && index < idx)
            {
                walker = walker.next;
                index++;
            }
            Node temp_two = walker.next;
            walker.next = temp_two.next;
            return temp_two;
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
