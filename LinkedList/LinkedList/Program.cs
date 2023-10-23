using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{

    public class Node
    {
        public int data;
        public Node next;


        public Node(int data) {
            this.data = data;
            next = null;
        }
    }

    public class singlyList{
        public static Node head=null;
        public static Node tail=null;
        public static void addNode(int data) {
            //Console.WriteLine("data="+data);
            Node newNode = new Node(data);
            if (head == null) {
                head = newNode;
                //Console.WriteLine("in head="+head.data);
                tail = head;
            }
            else {
                tail.next = newNode;
                tail = newNode;
                //Console.WriteLine("in tail="+tail.data);
            }
        }

        public static void display() {
            Node currentNode = head;
            if (currentNode == null)
            {
                Console.WriteLine("List is Empty.....");
            }
            else {
                while (currentNode!=null) {
                    Console.WriteLine(currentNode.data);
                    currentNode = currentNode.next;
                }
            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            string choice;
            int option,data;
            do
            {
                Console.Write("1.Add Node\n2.Display Node\n3.Exit\nEnter the Option:");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Write("Enter the Data You want to insert on a List:");
                        data = int.Parse(Console.ReadLine());
                        //Console.WriteLine(data);
                        singlyList.addNode(data);
                        Console.WriteLine("Successfully Added.....");
                        break;
                    case 2:
                        Console.WriteLine("The Stored data's are.....");
                        singlyList.display();
                        break;
                    default:
                        Console.WriteLine("Bye....");
                        goto Exit;
                }
                Console.Write("If you want to Cosntinue (y/n):");
                choice = Console.ReadLine();
            } while (choice == "y");
        Exit:
            Console.WriteLine("Bye...");
        }
    }
}
