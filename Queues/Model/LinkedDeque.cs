using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues.Model
{
    /// <summary>
    /// Двусвязный дек.
    /// </summary>
    /// <typeparam name="T">Тип данных.</typeparam>
    class LinkedDeque<T>
    {
        /// <summary>
        /// Головной элемент.
        /// </summary>
        private DuplexItem<T> Head;

        /// <summary>
        /// Хвостовой элемент.
        /// </summary>
        private DuplexItem<T> Tail;

        /// <summary>
        /// Размер очереди.
        /// </summary>
        private int Count;

        /// <summary>
        /// Создать пустую очередь.
        /// </summary>
        public LinkedDeque()
        {

        }

        /// <summary>
        /// Создать новую очередь.
        /// </summary>
        /// <param name="data">Данны нового элемента.</param>
        public LinkedDeque(T data)
        {
            if (data.Equals(default(T)))
            {
                throw new ArgumentNullException(nameof(data), "Элемент не может быть нулевым");
            }

            GeatHeadAndTail(data);
        }

        /// <summary>
        /// Установить очередной и корневой элементы в качестве выбранного.
        /// </summary>
        /// <param name="data">Данные выбранного элемента.</param>
        private void GeatHeadAndTail(T data)
        {
            if (data.Equals(default(T)))
            {
                throw new ArgumentNullException(nameof(data), "Элемент не может быть нулевым");
            }

            var item = new DuplexItem<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        /// <summary>
        /// Поместить элемент в хвост.
        /// </summary>
        /// <param name="data">Данные нового элемента.</param>
        public void PushBack(T data)
        {
            if (data.Equals(default(T)))
            {
                throw new ArgumentNullException(nameof(data), "Элемент не может быть нулевым");
            }

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

        /// <summary>
        /// Поместить элемент в голову.
        /// </summary>
        /// <param name="data">Данные нового элемента.</param>
        public void PushFront(T data)
        {
            if (data.Equals(default(T)))
            {
                throw new ArgumentNullException(nameof(data), "Элемент не может быть нулевым");
            }

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

        /// <summary>
        /// Получить хвостовой элемент.
        /// </summary>
        /// <returns>Хвостовой элемент.</returns>
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

        /// <summary>
        /// Получить головной элемент.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Посмотреть хвостовой элемент.
        /// </summary>
        /// <returns>Хвостовой элемент.</returns>
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

        /// <summary>
        /// Посмотреть головной элемент.
        /// </summary>
        /// <returns>Головной элемент.</returns>
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
