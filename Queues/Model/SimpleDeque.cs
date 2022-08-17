using System;
using System.Collections.Generic;
using System.Linq;

namespace Queues.Model
{
    class SimpleDeque<T>
    {
        private List<T> Items = new List<T>();
        private T Head => Items.Last();
        private T Tail => Items.First();
        private int Count => Items.Count();

        public SimpleDeque()
        {

        }

        public SimpleDeque(T data)
        {
            Items.Add(data);
        }

        public void PushBack(T data)
        {
            Items.Insert(0, data);
        }

        public void PushFront(T data)
        {
                Items.Add(data);
        }

        public T PopBack()
        {
            if (Count > 0)
            {
                var item = Tail;
                Items.Remove(item);
                return item;
            }
            else
            {
                throw new NullReferenceException("Очередь пуста");
            }
        }

        public T PopFront()
        {
            if (Count > 0)
            {
                var item = Head;
                Items.Remove(item);
                return item;
            }
            else
            {
                throw new NullReferenceException("Очередь пуста");
            }
        }

        public T PeekBack()
        {
            if (Count > 0)
            {
                return Tail;
            }
            else
            {
                throw new NullReferenceException("Очередь пуста");
            }
        }

        public T PeekFront()
        {
            if (Count > 0)
            {
                return Head;
            }
            else
            {
                throw new NullReferenceException("Очередь пуста");
            }
        }
    }
}
