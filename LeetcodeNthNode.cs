using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FindNthNode
{
    //Find Nth node from the end of a linked list
    public sealed class NthNodeFinder
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find Nth node from the end of a linked list");

            Console.WriteLine();

            Console.WriteLine("From our Linked list ");

            SinglyLinkedList myList = new SinglyLinkedList();
            myList.AddFront(6);
            myList.AddFront(13);
            myList.AddFront(30);
            myList.AddFront(23);
            myList.AddFront(26);
            myList.AddFront(38);
            myList.AddFront(57);
            myList.AddFront(17);
            myList.printList();

            myList.Nthnode(myList);

            myList.printList();


        }
    }
    public class Node
    {
        //data
        private int data;
        public Node next;
        //public Node prev;
        public int mydata { get; set;}

        //methods
        //constructor
        public Node(int newVal)
        {
            this.data = newVal;
            next = null;
        }
    }
    public class SinglyLinkedList
    {
        public Node head = null;

        //this method adds new nodes at the front of the linked list
        public void AddFront(int newVal)
        {
            Node newNode = new Node(newVal);

            newNode.next = head;
            head = newNode;

        }
        //this method counts all the nodes that we have in our linked list
        public int Countnode(SinglyLinkedList list)
        {
            
            int count = 0;
            
            Node current = head;
           
            while(current != null)
            {
                count++;
                current = current.next;
            }
            return count;
           
        }
        public void Nthnode(SinglyLinkedList list)
        {
            Console.WriteLine();
            int n = 3; //we set n equal to 3 to test our methode

            
            int llength = list.Countnode(list) - (n - 1);
            int count = 0;

            //we initilized our current node to head
            Node current = head;
            while(current != null)
            {
                count++;
                if(count == llength)
                {
                    Console.WriteLine($"At n = {n}, our node is equal to { current.data}");
                }
                else
                {
                    current = current.next;
                }
            }
            Console.WriteLine();
        }
        //this method prints our linked list
        public void printList()
        {
            //we initilized our current node to head
            Node curr = head;

            //we are itirating through each node in our linked list
            while (curr != null)
            {
                Console.Write(curr.data + " ");//display value
                curr = curr.next; //moves curr to the next in the list
            }

            Console.WriteLine();
        }
       
    }
}
