using System;
namespace DataStructureImpelmentation
{
     public class DLLNode
    {
        public int data;
        public DLLNode prev;
        public DLLNode next;
        public DLLNode(int data)
        {
            this.data = data;
            next = null;
            prev = null;
        }
    }

    public class DLLLinkedList
    {
        DLLNode head;

        public void AddNode(int data)
        {
            if (head == null)
            {
                head = new DLLNode(data);
                return;
            }
            DLLNode current = head, temp = null;
            while (current.next != null)
            {
                temp = current;
                current = current.next;
            }
            current.next = new DLLNode(data);
            current.prev = temp;
        }

        public void InsertNodeAt(int data, int position)
        {
            DLLNode current = head, temp = null, newNode = new DLLNode(data);
            int cuurentPosition = 1;

            if (head == null || position == 1)
            {
                head = new DLLNode(data);
                if (current != null)
                {
                    current.prev = head;
                    head.next = current;
                }
                return;
            }

            while (cuurentPosition < position && current.next != null)
            {
                cuurentPosition++;
                temp = current;
                current = current.next;
            }

            if (current.next == null)
            {
                newNode.prev = current;
                current.next = newNode;
                return;
            }
            newNode.prev = temp;
            if (temp == null)
                temp = newNode;
            else
                temp.next = newNode;
            current.prev = newNode;
            newNode.next = current;
        }

        public void DeleteNodeAt(int position)
        {
            DLLNode current = head, temp = null;
            int currentPosition = 1;

            if (position == 1)
            {
                head = head.next;
                head.prev = null;
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
                temp.next = null;
                return;
            }
            temp.next = current.next;
        }

        public void PrintAllNodes()
        {
            DLLNode temp = head;
            int position = 1;
            while (temp != null)
            {
                Console.WriteLine($"Item : {temp.data} Position at : {position++}");
                temp = temp.next;
            }
        }
    }   
}