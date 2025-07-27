using System.Collections;
using System.Collections.Generic;

namespace DataStructureAndAlgorithms
{
    public class LinkedList<T> : IEnumerable<T> where T : class
    {


        private Node? head;
        private Node? tail;
        private int currentSize = 0;


        public LinkedList()
        {
            head = null;
            currentSize = 0;

        }
        private class Node
        {
            public T data;
            public Node? next;

            public Node(T nodeData)
            {
                data = nodeData;
                next = null;
            }
        }



        public T AddFirst(T data)
        {
            if (data == null)
                throw new NullReferenceException("data` parameter shouldn't be null");

            Node node = new Node(data)
            {
                next = head
            };

            if (IsEmpty())
            {
                tail = node;
            }
            head = node;
            currentSize++;
            return data;
        }

        public T AddLast(T data)
        {
            if (data == null)
                throw new NullReferenceException("data` parameter shouldn't be null");

            if (IsEmpty())
            {
                AddFirst(data);
                return data;
            }

            Node node = new(data);
            tail.next = node;
            tail = node;
            currentSize++;

            return data;
        }



        public bool Contain(T data)
        {
            if (IsEmpty())
                throw new EmptyLinkedListException("the list is empty");

            if (data == null)
                throw new NullReferenceException("data` parameter shouldn't be null");

            EqualityComparer<T> comparer = EqualityComparer<T>.Default;

            Node pointer = head;

            while (pointer != null)
            {
                if (comparer.Equals(pointer.data, data))
                    return true;

                pointer = pointer.next;

            }

            return false;

        }




        public int GetListSize()
        {
            return currentSize;
        }

        public bool IsEmpty()
        {
            if (head == null)
                return true;

            return false;
        }

        public T PeekFirst()
        {

            if (IsEmpty())
                throw new EmptyLinkedListException("the list is empty");

            return head.data;

        }



        public T Remove(T data)
        {
            if (data == null)
                throw new NullReferenceException("data` parameter shouldn't be null");

            if (head == null)
                throw new EmptyLinkedListException("the list is empty");

            if (head == tail)
                RemoveFirst();

            EqualityComparer<T> comparer = EqualityComparer<T>.Default;

            Node? current = head;
            Node? previous = null;

            while (head.next != null)
            {

                if (comparer.Equals(current.data, data))
                {
                    previous.next = current.next;
                    current = current.next;

                    return data;
                }

                previous = current;
                current = current.next;

            }

            return null;

        }


        public T RemoveFirst()
        {

            if (head == null)
                throw new EmptyLinkedListException("the list is empty");

            T data = head.data;

            if (head == tail)
            {
                head = tail = null;
                currentSize--;
                return data;
            }

            head = head.next;
            currentSize--;


            return data;


        }

        public T RemoveLast()
        {
            if (IsEmpty())
                throw new EmptyLinkedListException("the list is empty");

            T data = tail.data;

            if (head.next == null)
            {
                data = RemoveFirst();
                return data;
            }

            Node current = head;
            Node previous = null;



            while (current.next != tail)
            {
                current = current.next;
            }

            previous = current;
            previous.next = null;
            tail = previous;
            currentSize--;

            return data;

        }

        public IEnumerator<T> GetEnumerator()
        {
            Node? pointer = head;

            while (pointer != null)
            {

                yield return pointer.data;
                pointer = pointer.next;

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}
