using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues.Model
{
    class ArrayQueue<T>
    {
        private T[] Items;
        private int Count;
        private T Head => Items[Count - 1];
        private int MaxCount => Items.Length;

        public ArrayQueue(int size = 10)
        {
            Items = new T[size];
            Count = 0;
        }
        public ArrayQueue(T data, int size = 10)
        {
            Items = new T[size];
            Items[0] = data;
            Count++;
        }

        public void Enqueue(T data)
        {
            if(Count < MaxCount)
            {
                var result = (new T[] { data }).Concat(Items).ToArray();
                Count++;
                for (int i = 0; i < Count; i++)
                {
                    Items[i] = result[i];
                }
            }
            else
            {
                throw new OverflowException("Очередь переполнена");
            }
        }

        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new NullReferenceException("Очередь пуста");
            }
            var item = Head;
            Count--;           
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
