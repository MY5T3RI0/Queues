using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues.Model
{
    /// <summary>
    /// Очередь на массиве.
    /// </summary>
    /// <typeparam name="T">Тип элементов.</typeparam>
    class ArrayQueue<T>
    {
        /// <summary>
        /// Массив элементов.
        /// </summary>
        private T[] Items;

        /// <summary>
        /// Размер очереди.
        /// </summary>
        private int Count;

        /// <summary>
        /// Очередной элемент.
        /// </summary>
        private T Head => Items[Count - 1];

        /// <summary>
        /// Длинна массива.
        /// </summary>
        private int MaxCount => Items.Length;

        /// <summary>
        /// Создать пустую очередь.
        /// </summary>
        /// <param name="size">Размер очереди.</param>
        public ArrayQueue(int size = 10)
        {
            Items = new T[size];
            Count = 0;
        }

        /// <summary>
        /// Создать новую очередь.
        /// </summary>
        /// <param name="data">Новый элемент.</param>
        /// <param name="size">Размер очереди.</param>
        public ArrayQueue(T data, int size = 10)
        {
            if (data.Equals(default(T)))
            {
                throw new ArgumentNullException(nameof(data), "Элемент не может быть нулевым");
            }

            Items = new T[size];
            Items[0] = data;
            Count++;
        }

        /// <summary>
        /// Добавить элемент в очередь.
        /// </summary>
        /// <param name="data">Элемент.</param>
        public void Enqueue(T data)
        {
            if (data.Equals(default(T)))
            {
                throw new ArgumentNullException(nameof(data), "Элемент не может быть нулевым");
            }

            if (Count < MaxCount)
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
            var item = Head;
            Count--;           
            return item;
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
            return Head;
        }
    }
}
