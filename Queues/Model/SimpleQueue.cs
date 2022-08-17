using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues.Model
{
    class SimpleQueue<T>
    {
        private List<T> Items = new List<T>();
        private T Head => Items.Last();
        private int Count => Items.Count();

        public SimpleQueue()
        {

        }

        public SimpleQueue(T data)
        {
            Items.Add(data);
        }

        public void Enqueue(T data)
        {
            Items.Insert(0, data);
        }

        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new NullReferenceException("Очередь пуста");
            }
            var item = Head;
            Items.Remove(item);
            return item;
        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new NullReferenceException("Очередь пуста");
            }
            return Head;
        }
    }
}
