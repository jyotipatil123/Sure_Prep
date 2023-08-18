using ConsoleApp_SurePrep;
using System;
using System.Collections.Generic;
using System.Text;

namespace Phase1Section4._7b
{
    public class SingleLinkedList
    {
        private Node root = null;
        private Node current = null;
        private int length;

        public Node Root
        {
            get { return this.root; }
            set { this.root = value; }
        }

        public int Length
        {
            get { return this.length; }
            set { this.length = value; }
        }

        public void add(Node node)
        {
            node.Next = null;
            if (root == null)
            {
                root = node;
                length = 1;
                current = root;
            }
            else
            {
                current.Next = node;
                current = node;
                length++;
            }
        }

        public Node getCurrent()
        {
            return this.current;
        }

        public Node getRoot()
        {
            current = root;
            return this.root;
        }

        public Node getNext()
        {
            if (current.Next != null)
            {
                current = current.Next;
                return current;
            }
            else
                return null;
        }

        public int getLengthOfList()
        {
            return this.length;
        }
    }
}
