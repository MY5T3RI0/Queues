using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues.Model
{
    class LinkedQueue<T>
    {
        private Item<T> Tail;
        private Item<T> Head;
        private int Count;

        public LinkedQueue()
        {
           
        }

        public LinkedQueue(T data)
        {
            SetHeadAndTail(data);
        }

        private void SetHeadAndTail(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public void Enqueue(T data)
        {
            if (Count == 0)
            {
                SetHeadAndTail(data);
                return;
            }
            var item = new Item<T>(data);
            item.Next = Tail;
            Tail = item;
            Count++;
        }

        public T Dequeue() 
        {
            if (Count == 0)
            {
                throw new NullReferenceException("Очередь пуста");
            }

            var previous = Tail;
            var current = Tail.Next;

            while (current != null && current.Next != null)
            {
                previous = previous.Next;
                current = current.Next;
            }
            var data = Head.Data;
            Head = previous;
            Head.Next = null;
            Count--;
            return data;
        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new NullReferenceException("Очередь пуста");
            }
            return Head.Data;
        }
    }
}
