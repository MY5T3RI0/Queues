using System;
using System.Collections.Generic;
using System.Linq;

namespace Queues.Model
{
    /// <summary>
    /// Простой дек.
    /// </summary>
    /// <typeparam name="T">Тип элементов.</typeparam>
    class SimpleDeque<T>
    {
        /// <summary>
        /// Список элементов.
        /// </summary>
        private List<T> Items = new List<T>();

        /// <summary>
        /// Головной элемент.
        /// </summary>
        private T Head => Items.Last();

        /// <summary>
        /// Крайний элемент.
        /// </summary>
        private T Tail => Items.First();

        /// <summary>
        /// Размер очереди.
        /// </summary>
        private int Count => Items.Count();

        /// <summary>
        /// Создать пустую очередь.
        /// </summary>
        public SimpleDeque()
        {

        }

        /// <summary>
        /// Создать новую очередь.
        /// </summary>
        /// <param name="data">Данные нового элемента.</param>
        public SimpleDeque(T data)
        {
            if (data.Equals(default(T)))
            {
                throw new ArgumentNullException(nameof(data), "Элемент не может быть нулевым");
            }

            Items.Add(data);
        }

        /// <summary>
        /// Добавить элемент в хвост.
        /// </summary>
        /// <param name="data">Данные нового элемента.</param>
        public void PushBack(T data)
        {
            if (data.Equals(default(T)))
            {
                throw new ArgumentNullException(nameof(data), "Элемент не может быть нулевым");
            }

            Items.Insert(0, data);
        }

        /// <summary>
        /// Добавить элемент в голову.
        /// </summary>
        /// <param name="data">Данные нового элемента.</param>
        public void PushFront(T data)
        {
            if (data.Equals(default(T)))
            {
                throw new ArgumentNullException(nameof(data), "Элемент не может быть нулевым");
            }

            Items.Add(data);
        }

        /// <summary>
        /// Получить элемент с хвоста.
        /// </summary>
        /// <returns>Хвостовой элемент.</returns>
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

        /// <summary>
        /// Получить головной элемент.
        /// </summary>
        /// <returns>Головной элемент.</returns>
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

        /// <summary>
        /// Посмотреть хвостовой элемент.
        /// </summary>
        /// <returns>Хвостовой элемент.</returns>
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

        /// <summary>
        /// Посмотреть головной элемент.
        /// </summary>
        /// <returns>Головной элемент.</returns>
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
