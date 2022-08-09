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
            Console.WriteLine(temp.Search(3));
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

        public int Search(int data)
        {
            if(this.head == null)
            {
                return -1;
            }
            Node walker = this.head;
            int index = 0;
            while(walker != null)
            {
                if(walker.data == data)
                {
                    return index;
                }
                walker = walker.next;
                index++;
            }
            return -1;
        }
        public void Sort()
        {
            if(this.head == null)
            {
                return;
            }
            bool swap = true;
            while(swap)
            {
                swap = false;
                Node walker = this.head;
                Node previous;
                while(walker != null && walker.next != null)
                {
                    swap = true;
                    if(walker == this.head)
                    {
                        Node temp_next = this.head;
                        Node temp_head = this.head.next;
                        temp_next.next = temp_head.next;
                        temp_head.next = temp_next;
                        this.head = temp_head;
                    }
                    else
                    {
                        Node temp_next = walker;
                        Node temp_cur = walker.next;
                        temp_next.next = temp_cur.next;
                        temp_cur.next = temp_next;
                        // running into an error and not sure how to proceed.  Will comment out for now.
                        //previous.next = temp_cur;
                    }
                    previous = walker;
                    walker = walker.next;
                }
            }
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
