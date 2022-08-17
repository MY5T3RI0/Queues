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

            var SimpleQueue = new SimpleQueue<int>();

            SimpleQueue.Enqueque(1);
            SimpleQueue.Enqueque(2);
            SimpleQueue.Enqueque(3);
            SimpleQueue.Enqueque(4);
            SimpleQueue.Enqueque(5);

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
