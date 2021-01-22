using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMethods
{
    public class LinkedList
    {
        public Node head;
        int count;

        public LinkedList()
        {
            head = null;
            count = 0;
        }

        #region PrintLinkedList
        public string PrintLinkedList()
        {
            Node currentNode = this.head; //this LinkedList's head
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Count: {0}<br />", count);
            int node = 0;

            while ((currentNode != null)) // && (currentNode.data != desiredValue) //To search for specific value
            {
                sb.AppendFormat("Node {0}: {1}<br />", node, currentNode.value); //Append a formatted string
                currentNode = currentNode.next;
                node++;
            }
            sb.Append("<br />");

            return sb.ToString();
        }
        #endregion

        #region InsertFront
        public void InsertFront(string new_data)
        {
            LinkedList singlyList = this;
            Node new_node = new Node();
            new_node.value = new_data;
            new_node.next = singlyList.head;
            singlyList.head = new_node;

            count++;
        }
        #endregion

        #region InsertAfter
        public void InsertAfter(Node prev_node, string new_data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node Cannot be null");
                return;
            }

            Node new_node = new Node();
            new_node.value = new_data;
            new_node.next = prev_node.next;
            prev_node.next = new_node;

            count++;
        }
        #endregion

        #region InsertLast
        public void InsertLast(string new_data)
        {
            LinkedList singlyList = this;

            Node new_node = new Node();
            new_node.value = new_data;

            if (singlyList.head == null)
            {
                singlyList.head = new_node;
                return;
            }

            Node lastNode = singlyList.GetLastNode();
            lastNode.next = new_node;

            count++;
        }
        #endregion

        #region GetLastNode
        public Node GetLastNode()
        {
            LinkedList singlyList = this;
            Node temp = singlyList.head;

            while (temp.next != null)
            {
                temp = temp.next;
            }

            return temp;
        }
        #endregion

        #region DeleteNodebyKey
        public void DeleteNodebyKey(string key)
        {
            LinkedList singlyList = this;
            Node temp = singlyList.head;
            Node prev = null;

            if (temp != null && temp.value == key)
            {
                singlyList.head = temp.next;
                return;
            }

            while (temp != null && temp.value != key)
            {
                prev = temp;
                temp = temp.next;
            }

            if (temp == null)
            {
                return;
            }

            prev.next = temp.next;

            count--;
        }
        #endregion

        #region //Find value or position of value in Linked List
        public string FindValue(string desiredValue)
        {
            if (this.head == null)
            {
                return "LinkedList is empty!";
            }

            LinkedList singlyList = this;
            int index = 0;
            Node currentNode = singlyList.head;

            while ((currentNode != null)) //To search for specific value
            {
                if (currentNode.value != desiredValue)
                {
                    currentNode = currentNode.next;
                    index++;
                }
                else
                {
                    break;
                }
            }
            //while ((currentNode != null) && (currentNode.val != desiredValue)){ currentNode = currentNode.next; }
            //return currentNode;

            return String.Format("Value {0} found at Index {1}", currentNode.value, index);
        }
        #endregion

        #region //Sort LinkedList in ABC order by 1st letter
        public void SortLinkedListAsc()
        {

        }
        #endregion

        #region ReverseLinkedList
        public void ReverseLinkedList()
        {
            LinkedList singlyList = this;
            Node prev = null;
            Node current = singlyList.head;
            Node temp = null;

            while (current != null)
            {
                temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }

            singlyList.head = prev;
        }
        #endregion


        #region //Swaps every other 2 nodes
        //https://www.geeksforgeeks.org/pairwise-swap-adjacent-nodes-of-a-linked-list-by-changing-pointers-set-2/?ref=rp
        public void SwapPairedNodes()
        {
            LinkedList singlyList = this;

            Node head = singlyList.head;

            // If linked list is empty or there is only one node in list 
            if (head == null || head.next == null)
            {
                return; //return temp;
            }

            // Fix the head and its next explicitly to avoid many if else in while loop
            Node curr = head.next.next;
            Node prev = head;
            head = head.next;
            head.next = prev;

            // Fix remaining nodes  
            while (curr != null && curr.next != null)
            {
                prev.next = curr.next;
                prev = curr;
                Node next = curr.next.next;
                curr.next.next = curr;
                curr = next;
            }

            prev.next = curr;
            //return head;
        }
        #endregion








    }
}
