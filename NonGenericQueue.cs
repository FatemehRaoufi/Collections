using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    internal class NonGenericQueue
    {
        /// <summary>
        /// The Non-Generic Queue Collection Class in C# works in the FIFO(First-In-First-Out) principle.
        /// 
        /// </summary>
        public NonGenericQueue() {
            CreatingQueueMethod();
            DequeuePeekMethod();
            QueueContainsMethod();
            QueueCloneMethod();
            QueueCopyToMethod();

        }
        //---------------------------------

        public void CreatingQueueMethod()
        {
            //Creating a queue collection
            Queue queue = new Queue();
            //Adding item to the queue using the Enqueue method
            queue.Enqueue(101);
            queue.Enqueue("Hello");
            queue.Enqueue(3.14f);
            queue.Enqueue(true);
            queue.Enqueue(67.8);
            queue.Enqueue('A');
            //Printing the queue items using foreach loop
            Console.WriteLine($"All Queue Elements: Count {queue.Count}");
            foreach (var item in queue)
            {
                Console.Write($"{item} ");
            }
            //Removing and Returning an item from the queue using the Dequeue method
            Console.WriteLine($"\n\nDeleted Element: {queue.Dequeue()}");
            //Printing item after removing the first added item
            Console.WriteLine($"\nAll Queue Elements After Deletion: Count {queue.Count}");
            foreach (var item in queue)
            {
                Console.Write($"{item} ");
            }
            //Printing Items After Clearing the Queue
            queue.Clear();
            Console.WriteLine($"\n\nQueue Elements After Clear Operation: Count {queue.Count}");
            foreach (var item in queue)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }
        //--------------------------------------
        /// <summary>
        /// The Non-Generic Queue Collection class in C# provides the following two methods to get the first element of the queue collection
        ///Dequeue() : The Dequeue() method of the Queue class is used to Remove and return the object from the beginning of the Queue.
        ///If there is no object (or element) present in the Queue 
        ///and if we are trying to remove an item or object from the Queue using the pop() method then it will throw an exception i.e.System.
        ///InvalidOperationException
        ///Peek(): The peek() method of the Queue class is used to return the oldest object 
        ///i.e.the object present at the start of the Queue without removing it.If there is no object (or element) present in the Queue and if we are trying to return an item (object) from the Queue using the peek() method then it will throw an exception i.e.System.InvalidOperationException
        /// </summary>
        public void DequeuePeekMethod()
        {
            // Creating a Queue collection
            Queue queue = new Queue();
            //Adding item to the queue using the Enqueue method
            queue.Enqueue(101);
            queue.Enqueue("Hello");
            queue.Enqueue(3.14f);
            queue.Enqueue(true);
            queue.Enqueue(67.8);
            queue.Enqueue('A');
            Console.WriteLine($"Total Elements present in Queue : {queue.Count}");
            // Fetch First Element of Queue Using Dequeue method
            Console.WriteLine($"First Element of Queue is {queue.Dequeue()}");
            Console.WriteLine($"Total Elements present in Queue : {queue.Count}");
            // Fetch the topmost element from Queue Using Peek method
            Console.WriteLine($"First Element of Queue is {queue.Peek()}");
            Console.WriteLine($"Total Elements present in Queue : {queue.Count}");
            Console.ReadKey();
        }
        //--------------------------------
        public void QueueContainsMethod()
        {
            // Creating a Queue collection
            Queue queue = new Queue();
            //Adding item to the queue using the Enqueue method
            queue.Enqueue(101);
            queue.Enqueue("Hello");
            queue.Enqueue(3.14f);
            queue.Enqueue(true);
            queue.Enqueue(67.8);
            queue.Enqueue('A');
            Console.WriteLine("All Elements of Queue");
            foreach (var item in queue)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\nChecking if the element Hello is present in the queue or not");
            // Checking if the element Hello is present in the Stack or not
            if (queue.Contains("Hello"))
            {
                Console.WriteLine("Element Hello is found");
            }
            else
            {
                Console.WriteLine("Element Hello is not found");
            }
            if (queue.Contains("World"))
            {
                Console.WriteLine("Element World is found");
            }
            else
            {
                Console.WriteLine("Element World is not found");
            }
            Console.ReadKey();
        }
        //---------------------------------------
        public void QueueCloneMethod()
        {
            //Creating a queue collection
            Queue queue = new Queue();
            //Adding item to the queue using the Enqueue method
            queue.Enqueue(101);
            queue.Enqueue("Hello");
            queue.Enqueue(3.14f);
            queue.Enqueue(true);
            queue.Enqueue(67.8);
            //Printing All Queue Elements using For Each Loop
            Console.WriteLine("Queue Elements:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            //Creating a clone queue using Clone method
            Queue cloneQueue = (Queue)queue.Clone();
            Console.WriteLine("\nCloned Queue Elements:");
            foreach (var item in cloneQueue)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        //--------------------------------
        public void QueueCopyToMethod()
        {
            //Creating a queue collection
            Queue queue = new Queue();
            //Adding item to the queue using the Enqueue method
            queue.Enqueue(101);
            queue.Enqueue("Hello");
            queue.Enqueue(3.14f);
            queue.Enqueue(true);
            queue.Enqueue(67.8);
            //Printing All Queue Elements using For Each Loop
            Console.WriteLine("Queue Elements:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            //Copying the queue to an object array
            object[] queueCopy = new object[5];
            queue.CopyTo(queueCopy, 0);
            Console.WriteLine("\nQueue Copy Array Elements:");
            foreach (var item in queueCopy)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
//https://dotnettutorials.net/lesson/queue-collection-class-csharp/