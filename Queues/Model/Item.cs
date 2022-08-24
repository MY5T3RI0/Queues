using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues.Model
{
    /// <summary>
    /// Элемент очереди.
    /// </summary>
    /// <typeparam name="T">Тип элемента.</typeparam>
    public class Item<T>
    {
        /// <summary>
        /// Элемент.
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Ссылка на следующий элемент.
        /// </summary>
        public Item<T> Next { get; set; }

        /// <summary>
        /// Создать новый элемент.
        /// </summary>
        /// <param name="data">Элемент.</param>
        public Item(T data)
        {
            if (data.Equals(default(T)))
            {
                throw new ArgumentNullException(nameof(data), "Элемент не может быть нулевым");
            }

            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
