using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.DataStructure
{
   public class Node
    {
        public Node Next;
        public object Value;
    }

    public class LinkedList
    {
        private Node head;
        private Node current;
        public int count;

        public LinkedList()
        {
            head = new Node();
            current = head;
        }

        public void AddList(object data)
        {
            Node newNode = new Node();
            newNode.Value = data;
            current.Next = newNode;
            current=newNode;
            count++;
        }

        public void AddatFirst(object data)
        {
            Node newNode = new Node() { Value = data };
            newNode.Next = head.Next;
            head.Next = newNode;
            count++;
        }

        public void RemovefromStart()
        {
            if (count > 0)
            {
                head.Next = head.Next.Next;
                count--;
            }
            else
                Console.WriteLine("no element present");
        }

        public void insertAtIndex(int index,object data)
        {
            Node newNode =new Node();
            newNode.Value=data;
            newNode.Next = null;

            Node temp = head;
            for (int i=0;i<index-1;i++)
            {
                if(temp != null)
                    temp=temp.Next;
            }
            if (temp != null)
            {
                newNode.Next = temp.Next;
                temp.Next=newNode;
            }
        }
        public void removeatIndex( int index)
        {
            
            Node temp = head;
            for(int i=0;i<index-1;i++)
            {
                if(temp!=null)
                    temp=temp.Next;

            }
            if(temp!=null )
            {
                Node nodeToDelete = temp.Next;
                temp.Next = temp.Next.Next;
                nodeToDelete = null;

            }
        }
        public void PrintNode()
        {
            Console.Write("Head->");
            Node curr = head;
            while (curr.Next != null)
            {
                curr=curr.Next;
                Console.Write(curr.Value);
                Console.Write("->");
            }
            Console.Write("NULL");
            Console.WriteLine();
        }

       
        public void AllOp()
        {
            LinkedList LL = new LinkedList();
            //LL.PrintNode();
            LL.AddList(10);
            LL.AddList(20);
            LL.AddList(30);
            LL.AddatFirst("jack");
            LL.AddList(40);
            LL.PrintNode();
            //LL.RemovefromStart();
            //LL.PrintNode();
            LL.removeatIndex(3);
            LL.PrintNode();
            LL.insertAtIndex(4,100);
            LL.PrintNode();
        }
    }
}
