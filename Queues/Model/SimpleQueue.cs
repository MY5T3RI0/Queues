using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues.Model
{
    /// <summary>
    /// Простая очередь.
    /// </summary>
    /// <typeparam name="T">Тип данных.</typeparam>
    class SimpleQueue<T>
    {
        /// <summary>
        /// Список элементов.
        /// </summary>
        private List<T> Items = new List<T>();

        /// <summary>
        /// Очередной элемент.
        /// </summary>
        private T Head => Items.Last();

        /// <summary>
        /// Размер.
        /// </summary>
        private int Count => Items.Count();

        /// <summary>
        /// Создать пустую очередь.
        /// </summary>
        public SimpleQueue()
        {

        }

        /// <summary>
        /// Создать новую очередь.
        /// </summary>
        /// <param name="data">Элемент.</param>
        public SimpleQueue(T data)
        {
            if (data.Equals(default(T)))
            {
                throw new ArgumentNullException(nameof(data), "Элемент не может быть нулевым");
            }

            Items.Add(data);
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

            Items.Insert(0, data);
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
            Items.Remove(item);
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
