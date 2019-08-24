using System;

namespace DataStructureImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            RunLinkedList();    
        }

        public static void RunLinkedList()
        {
            LinkList linkList = new LinkList();
            int items = 0;
            int Steps = 0;
            int position = 1;
            int item = 0;

            start:
            Console.Clear();
            Console.WriteLine("1. Create Singly Linked List");
            Console.WriteLine("2. Insert Node at any given location");
            Console.WriteLine("3. Delete Node at any given location");
            Console.WriteLine("4. Traverse All Nodes");
            Console.WriteLine("5. Close");


            int.TryParse(Console.ReadLine(), out Steps);
            switch (Steps)
            {
                case 1:
                    Console.WriteLine("Enter No. of Item in Linklist");
                    int.TryParse(Console.ReadLine(), out items);
                    for (int i = 0; i < items; i++)
                    {
                        int.TryParse(Console.ReadLine(), out item);
                        linkList.InsertNodeAtPosition(item, i + 1);
                    }
                    break;
                case 2:
                    Console.WriteLine(Environment.NewLine + "Enter the postion to Add item");
                    int.TryParse(Console.ReadLine(), out position);
                    Console.WriteLine(Environment.NewLine + "Enter the item to Add item");
                    int.TryParse(Console.ReadLine(), out item);
                    linkList.InsertNodeAtPosition(item, position);
                    break;
                case 3:
                    Console.WriteLine(Environment.NewLine + "Enter the postion to Delete the node");
                    position = 1;
                    int.TryParse(Console.ReadLine(), out position);
                    linkList.DeleteNodeAtPosition(position);
                    break;
                case 4:
                    linkList.PrintAllNodes();
                    break;
                case 5:
                    Console.WriteLine("Press any key to close");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
            if (Steps < 5)
                goto start;
        }

        public static void RunDLLLinkedList()
        {
            DLLLinkedList linkList = new DLLLinkedList();
            int items = 0;
            int Steps = 0;
            int position = 1;
            int item = 0;

            start:
            Console.WriteLine("1. Create Linked List");
            Console.WriteLine("2. Insert Node at any given location");
            Console.WriteLine("3. Delete Node at any given location");
            Console.WriteLine("4. Traverse All Nodes");
            Console.WriteLine("5. Close");


            int.TryParse(Console.ReadLine(), out Steps);
            switch (Steps)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Enter No. of Item in Linklist");
                    int.TryParse(Console.ReadLine(), out items);
                    for (int i = 0; i < items; i++)
                    {
                        int.TryParse(Console.ReadLine(), out item);
                        linkList.InsertNodeAt(item, i + 1);
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine(Environment.NewLine + "Enter the postion to Add item");
                    int.TryParse(Console.ReadLine(), out position);
                    Console.WriteLine(Environment.NewLine + "Enter the item to Add item");
                    int.TryParse(Console.ReadLine(), out item);
                    linkList.InsertNodeAt(item, position);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine(Environment.NewLine + "Enter the postion to Delete the node");
                    position = 1;
                    int.TryParse(Console.ReadLine(), out position);
                    linkList.DeleteNodeAt(position);
                    break;
                case 4:
                    Console.Clear();
                    linkList.PrintAllNodes();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Press any key to close");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
            if (Steps < 5)
                goto start;
        }
    }
}
