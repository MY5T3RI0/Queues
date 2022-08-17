using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues.Model
{
    class LinkedDeque<T>
    {
        private DuplexItem<T> Head;
        private DuplexItem<T> Tail;
        private int Count;

        public LinkedDeque()
        {

        }

        public LinkedDeque(T data)
        {
            GeatHeadAndTail(data);
        }

        private void GeatHeadAndTail(T data)
        {
            var item = new DuplexItem<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public void PushBack(T data)
        {
            if (Count == 0)
            {
                GeatHeadAndTail(data);
                return;
            }

            var item = new DuplexItem<T>(data);
            Tail.Previous = item;
            item.Next = Tail;
            Tail = item;
            Count++;
        }

        public void PushFront(T data)
        {
            if (Count == 0)
            {
                GeatHeadAndTail(data);
                return;
            }

            var item = new DuplexItem<T>(data);
            Head.Next = item;
            item.Previous = Head;
            Head = item;
            Count++;
        }

        public T PopBack()
        {
            if (Count > 0)
            {
                var item = Tail;
                Tail = Tail.Next;
                Count--;
                return item.Data;
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
                Head = Head.Previous;
                Count--;
                return item.Data;
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
                return Tail.Data; 
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
                return Head.Data;
            }
            else
            {
                throw new NullReferenceException("Очередь пуста");
            }
        }
    }
}
