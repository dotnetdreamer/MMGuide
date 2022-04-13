using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIk
{
    public class LinkedList
    {
        LinkListNode head;

        /// <summary>
        /// Add new node at the end
        /// </summary>
        /// <param name="node"></param>
        public void AddNode(LinkListNode node)
        {
            if (head == null)
                head = node;
            else
            {
                LinkListNode temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
        }

        /// <summary>
        /// Reverse
        /// </summary>
        public void ReverseList()
        {
            LinkListNode prev = null, current = head, next = null;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }

        public void ReverseListRecursion()
        {
            head = ReverseRecursive(head);
        }

        /// <summary>
        /// Print all nodes
        /// </summary>
        public void PrintList()
        {
            LinkListNode current = head;
            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
        }


        private LinkListNode ReverseRecursive(LinkListNode node)
        {
            var current = node.Next;
            if (current == null)
                return node;

            var rf = ReverseRecursive(current);
            current.Next = node;
            node.Next = null;
            return rf;
        }

        public class LinkListNode
        {
            public int Value;
            public LinkListNode Next;

            public LinkListNode(int d)
            {
                Value = d;
                Next = null;
            }
        }
    }

}
