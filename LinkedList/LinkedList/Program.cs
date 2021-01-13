﻿using System;

namespace LinkedList
{
    public class LinkedList
    {

        Node head;
        public class Node
        {
            public int? data;
            public Node next;

            public Node(int? d)
            {
                data = d;
                next = null;
            }
        }
        public void printCurrentList()
        {
            Node printedNode = head;
            printList(printedNode);
        }
        public void printListBasedOnHead(Node head)
        {
            Node currentNode = head;
            printList(currentNode);
        }
        public int lengthOfLLIterative()
        {
            Node tmp = head;
            int length = 0;
            while(tmp != null){
                length += 1;
                tmp = tmp.next;
            }
            return length;
        }
        public int lengthOfLLRecursive(Node tmp, int length = 0)
        {
            if (tmp == null) {
                return length;
            }
            else
            {
                return lengthOfLLRecursive(tmp.next, length += 1);
            }
        }

        public void swapValuesInLinkedList(int x, int y) {
            Node tmp = head;
            Node next;            
            if (x == head.data) {
                tmp.data = x;
                next = head.next;
                tmp = head;
            }
        }
        public void insertAtFront(int data)
        {
            if (head == null)
            {
                head = new Node(data);
            }

            Node newHead = new Node(data);
            Node tmp = head;
            head = newHead;
            head.next = tmp;
        }
        public void insertAtEnd(int data)
        {
            Node newTail = new Node(data);
            Node tmp;
            tmp = head;

            while (tmp.next != null)
            {
                tmp = tmp.next;
            }

            tmp.next = newTail;
            newTail.next = null;
        }
        public void insertAfter(int position, int data)
        {
            Node After = new Node(data);
            Node tmp;
            Node previous;

            previous = head;

            itareteToNodePosition(position - 1, previous);

            tmp = previous;
            After.next = tmp.next;
            previous.next = After;
        }

        public void deleteLinkedList()
        {
            head = null;
        }

        public void deleteNodeByPosition(int? position)
        {
            if (position == null)
            {
                return;
            }

            if (position == 0)
            {
                head = head.next;
                return;
            }

            Node tmp;
            tmp = head;
            itareteToNodePosition(position, tmp);

            tmp.next = tmp.next.next;
        }

        public void deleteNodeByValue(int? value)
        {
            Node tmp = head;
            Node prev = null;

            if (head.data == value && head != null)
            {
                head = tmp.next;
            }

            while (tmp.next != null)
            {
                prev = tmp;
                tmp = tmp.next;
                if (tmp.data == value)
                {
                    prev.next = tmp.next;
                }
            }
        }
        public void itareteToNodePosition(int? position, Node tmp)
        {
            for (int i = 0; i < position - 1; i++)
            {
                tmp = tmp.next;
            }
        }
        private void printList(Node CurrentNode)
        {
            while (CurrentNode != null)
            {
                Console.WriteLine(CurrentNode.data + " ");
                CurrentNode = CurrentNode.next;
            }
        }


        public static void Main(string[] args)
        {
            LinkedList firstLinkedList = new LinkedList();

            firstLinkedList.head = new LinkedList.Node(1);
            Node second = new Node(2);
            Node third = new Node(3);


            int insertAtBeggining = 10;
            int insertAtEnd = 20;
            int insertAfterValue = 5;
            int insertAfterNodeNumber = 4;
            int? deleteNode = null;
            int? deleteNodeValue = null;
            int LLlengthIterative;
            int LLlengthRecursive;

            firstLinkedList.head.next = second;
            second.next = third;

            firstLinkedList.insertAtFront(insertAtBeggining);
            firstLinkedList.insertAtEnd(insertAtEnd);
            firstLinkedList.insertAfter(insertAfterNodeNumber, insertAfterValue);
            firstLinkedList.deleteNodeByPosition(deleteNode);
            firstLinkedList.deleteNodeByValue(deleteNodeValue);
            firstLinkedList.printCurrentList();

            // firstLinkedList.deleteLinkedList();
            LLlengthIterative = firstLinkedList.lengthOfLLIterative();
            Console.WriteLine("This Linked List have " + LLlengthIterative + ((LLlengthIterative > 1) ? " Nodes" : (LLlengthIterative == 0) ? " Nodes so it's empty" : " Node"));
            
            LLlengthRecursive = firstLinkedList.lengthOfLLRecursive(firstLinkedList.head);
            Console.WriteLine("This Linked List have " + LLlengthRecursive + ((LLlengthRecursive > 1) ? " Nodes" : (LLlengthRecursive == 0) ? " Nodes so it's empty" : " Node"));
            
        }

    }
}
 
