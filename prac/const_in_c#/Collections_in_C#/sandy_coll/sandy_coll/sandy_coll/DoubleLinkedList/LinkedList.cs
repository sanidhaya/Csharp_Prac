using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandy_coll.DoubleLinkedList
{
    internal class DLinkedList<T> : IEnumerable<T>
    {
        private Node<T> head { get; set; }
        private Node<T> tail { get; set; }

        public void DoubleLinkedList()
        {
            head = null;
            tail = null;
        }
    
        public void AddFirst(T data)
        {
            var newNode = new Node<T>(data);

            if(head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Prev = newNode;
                head = newNode;
            }
        }

        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (tail == null)
            {
                head = newNode;
                tail = newNode;
            }else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }
        }

        public void RemoveFirst()
        {
            if (head == null)
            {
                return;
            }else if (head ==tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                head = head.Next;
                head.Prev = null;
            }
        }

        public void RemoveLast()
        {
            if (tail == null)
            {
                return;
            }
            else if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                tail = tail.Prev;
                tail.Next = null;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;
            while(current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() {return GetEnumerator(); }
    }
}
