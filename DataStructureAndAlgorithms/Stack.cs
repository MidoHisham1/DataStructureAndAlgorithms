using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms
{
     public class Stack<T> : IEnumerable<T> where T : IComparable<T>
    {

        private LinkedList<T> _list;
        public Stack()
        {
            _list = new LinkedList<T>();
        }
        public void Push(T item)
        {
            _list.AddFirst(item);
        }
        public T Pop()
        {
            if (_list.IsEmpty())
                throw new EmptyLinkedListException("Stack is empty");
            var value = _list.RemoveFirst();
            return value;
        }
        public T Peek()
        {
            if (_list.IsEmpty())
                throw new EmptyLinkedListException("Stack is empty");
            return _list.PeekFirst();
        }
        public int Count => _list.GetListSize();
        public bool IsEmpty => _list.IsEmpty();
        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
