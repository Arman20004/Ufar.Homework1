using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ufar.Homework
{
    public class EasyQueue<T>
    {
        private List<T> _elements = new List<T>();

        // Pushes an item onto the top of this stack.
        public void Push(T item)
        {
            _elements.Add(item);
            Trace.WriteLine($"Adding \'{item}\' to queue");
        }


        public T Pop()
        {
            if (_elements.Count == 0)
                throw new InvalidOperationException("Queue is empty.");

            T item = _elements[_elements.Count - 1];
            _elements.RemoveAt(0);
            Trace.WriteLine($"Removed \'{item}\' from queue");
            return item;
        }

        public T Peek()
        {
            if (_elements.Count == 0)
                throw new InvalidOperationException("Queue is empty.");
            Trace.WriteLine("\n\nQueue consists of");
            foreach (T item in _elements)
            {
                Trace.Write($"\'{item}\' ");
            }
            Trace.WriteLine("\n");
            return _elements[0];
        }

        public int Count => _elements.Count;

        public bool IsEmpty => _elements.Count == 0;
    }
}
