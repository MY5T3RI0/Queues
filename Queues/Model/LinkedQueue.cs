using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues.Model
{
    /// <summary>
    /// Очередь связных элементов.
    /// </summary>
    /// <typeparam name="T">Тип элементов.</typeparam>
    class LinkedQueue<T>
    {
        /// <summary>
        /// Крайний элемент.
        /// </summary>
        private Item<T> Tail;

        /// <summary>
        /// Очередной элемент.
        /// </summary>
        private Item<T> Head;

        /// <summary>
        /// Размер очереди.
        /// </summary>
        private int Count;

        /// <summary>
        /// Создать пустую очередь.
        /// </summary>
        public LinkedQueue()
        {
           
        }

        /// <summary>
        /// Создать новую очередь.
        /// </summary>
        /// <param name="data">Данные нового элемента.</param>
        public LinkedQueue(T data)
        {
            if (data.Equals(default(T)))
            {
                throw new ArgumentNullException(nameof(data), "Элемент не может быть нулевым");
            }

            SetHeadAndTail(data);
        }

        /// <summary>
        /// Установить очередной и корневой элементы в качестве выбранного.
        /// </summary>
        /// <param name="data">Данные элемента.</param>
        private void SetHeadAndTail(T data)
        {
            if (data.Equals(default(T)))
            {
                throw new ArgumentNullException(nameof(data), "Элемент не может быть нулевым");
            }

            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        /// <summary>
        /// Добавить элемент в очередь.
        /// </summary>
        /// <param name="data">Данные нового элемента.</param>
        public void Enqueue(T data)
        {
            if (data.Equals(default(T)))
            {
                throw new ArgumentNullException(nameof(data), "Элемент не может быть нулевым");
            }

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

        /// <summary>
        /// Получить очередной элемент.
        /// </summary>
        /// <returns>Очередной элемент.</returns>
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

        /// <summary>
        /// Посмотреть очередной элемент.
        /// </summary>
        /// <returns>Очередной элемент.</returns>
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
