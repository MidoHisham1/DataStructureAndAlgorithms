using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms
{
    public class Queue<T> : IEnumerable<T> where T : IComparable<T>
    {
        private LinkedList<T> _list;
        public Queue()
        {
            _list = new LinkedList<T>();
        }
        public void Enqueue(T item)
        {
            _list.AddLast(item);
        }
        public T Dequeue()
        {
            if (_list.IsEmpty())
                throw new EmptyLinkedListException("Queue is empty");
            var value = _list.RemoveFirst();
            return value;
        }
        public T Peek()
        {
            if (_list.IsEmpty())
                throw new EmptyLinkedListException("Queue is empty");
            return _list.PeekFirst();
        }
        public int Count => _list.GetListSize();
        public bool IsEmpty => _list.IsEmpty();


        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
