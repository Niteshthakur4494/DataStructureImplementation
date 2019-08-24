using System;
namespace DataStructureImpelmentation{
 public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }

    public class LinkList
    {
        Node head;
        public void AddNode(int data)
        {
            if (head == null)
            {
                head = new Node(data);
                return;
            }

            Node temp = head;

            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = new Node(data);
        }

        public void InsertNodeAtPosition(int data, int position)
        {
            Node current = head, temp = null, newNode = new Node(data);
            int currentPosition = 1;

            if (head == null || position == 1)
            {
                AddNode(data);
                if (current != null)
                {
                    head.next = current;
                }
                return;
            }


            while (currentPosition < position && current.next != null)
            {
                currentPosition++;
                temp = current;
                current = current.next;
            }

            if (current.next == null)
            {
                current.next = newNode;
                return;
            }

            //Console.WriteLine($"Item : {newNode.data} Position at : {position}");
            newNode.next = current;
            temp.next = newNode;
        }

        public void DeleteNodeAtPosition(int position)
        {
            Node current = head, temp = null;
            int currentPosition = 1;

            if (position == 1)
            {
                head = head.next;
                return;
            }

            while (currentPosition < position && current.next != null)
            {
                currentPosition++;
                temp = current;
                current = current.next;
            }

            if (current.next == null)
            {
                current = null;
                return;
            }
            temp.next = current.next;
        }
        public void PrintAllNodes()
        {
            Node temp = head;
            int position = 1;
            while (temp != null)
            {
                Console.WriteLine($"Item : {temp.data} Position at : {position++}");
                temp = temp.next;
            }
        }
    }
}