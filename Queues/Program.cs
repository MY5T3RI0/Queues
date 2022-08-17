using Queues.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            var LinkedDeque = new LinkedDeque<int>();

            LinkedDeque.PushFront(1);
            LinkedDeque.PushFront(2);
            LinkedDeque.PushBack(3);
            LinkedDeque.PushBack(4);
            LinkedDeque.PushFront(5);

            Console.WriteLine(LinkedDeque.PopBack());
            Console.WriteLine(LinkedDeque.PopBack());
            Console.WriteLine(LinkedDeque.PopFront());
            Console.WriteLine(LinkedDeque.PopFront());
            Console.WriteLine(LinkedDeque.PeekFront());
            Console.WriteLine(LinkedDeque.PopBack());

            Console.ReadLine();

            var SimpleDeque = new SimpleDeque<int>();

            SimpleDeque.PushFront(1);
            SimpleDeque.PushFront(2);
            SimpleDeque.PushBack(3);
            SimpleDeque.PushBack(4);
            SimpleDeque.PushFront(5);

            Console.WriteLine(SimpleDeque.PopBack());
            Console.WriteLine(SimpleDeque.PopBack());
            Console.WriteLine(SimpleDeque.PopFront());
            Console.WriteLine(SimpleDeque.PopFront());
            Console.WriteLine(SimpleDeque.PeekFront());
            Console.WriteLine(SimpleDeque.PopBack());

            Console.ReadLine();

            var ArrayQueue = new ArrayQueue<int>();

            ArrayQueue.Enqueue(1);
            ArrayQueue.Enqueue(2);
            ArrayQueue.Enqueue(3);
            ArrayQueue.Enqueue(4);
            ArrayQueue.Enqueue(5);

            Console.WriteLine(ArrayQueue.Dequeue());
            Console.WriteLine(ArrayQueue.Dequeue());
            Console.WriteLine(ArrayQueue.Dequeue());
            Console.WriteLine(ArrayQueue.Dequeue());
            Console.WriteLine(ArrayQueue.Peek());
            Console.WriteLine(ArrayQueue.Dequeue());

            Console.ReadLine();

            var LinkedQueue = new LinkedQueue<int>();

            LinkedQueue.Enqueue(1);
            LinkedQueue.Enqueue(2);
            LinkedQueue.Enqueue(3);
            LinkedQueue.Enqueue(4);
            LinkedQueue.Enqueue(5);

            Console.WriteLine(LinkedQueue.Dequeue());
            Console.WriteLine(LinkedQueue.Dequeue());
            Console.WriteLine(LinkedQueue.Dequeue());
            Console.WriteLine(LinkedQueue.Dequeue());
            Console.WriteLine(LinkedQueue.Peek());
            Console.WriteLine(LinkedQueue.Dequeue());

            Console.ReadLine();

            var SimpleQueue = new SimpleQueue<int>();

            SimpleQueue.Enqueue(1);
            SimpleQueue.Enqueue(2);
            SimpleQueue.Enqueue(3);
            SimpleQueue.Enqueue(4);
            SimpleQueue.Enqueue(5);

            Console.WriteLine(SimpleQueue.Dequeue());
            Console.WriteLine(SimpleQueue.Dequeue());
            Console.WriteLine(SimpleQueue.Dequeue());
            Console.WriteLine(SimpleQueue.Dequeue());
            Console.WriteLine(SimpleQueue.Peek());
            Console.WriteLine(SimpleQueue.Dequeue());

            Console.ReadLine();    
        }
    }
}
