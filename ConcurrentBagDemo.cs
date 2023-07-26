using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Collections
{
    internal class ConcurrentBagDemo
    {
        /// <summary>
        /// The ConcurrentBag<T> is a Thread-Safe Collection Class in C#.
        /// The working of the ConcurrentBag<T> is very much similar to the working of the Generic List<T> Collection Class in C#. 
        /// The only difference between them is that the Generic List<T> Collection is not thread-safe 
        /// whereas the ConcurrentBag<T> is thread-safe. 
        /// So, we can use the Generic List class instead of ConcurrentBag with multiple threads, but in that case, 
        /// as a programmer, it is our responsibility to use explicitly locks to provide thread safety 
        /// which is not only time-consuming but also error-prone. 
        /// So, the ideal choice is to use ConcurrentBag<T> instead of Generic List<T> in a multi-threaded environment, 
        /// and with ConcurrentBag<T>, as a programmer, we don’t require to implement any locking mechanism explicitly. 
        /// The ConcurrentBag<T> collection class will take care of the thread safety internally
        /// </summary>
        public ConcurrentBagDemo() {

            //GenericListwithLockingMechanismMethod();
            // ConcurrentBagwithMultipleThreadsMethod();
            //AddElementToConcurrentBagMethod();
            // RemoveElementFromConcurrentBagMethod();
            //GetElementfromConcurrentBagMethod();
        }
        //------------------
        static object lockObject = new object();
        public void GenericListwithLockingMechanismMethod()
        {
            ListTestBag();
            Console.ReadKey();
        }
        public static void ListTestBag()
        {
            List<string> MobileOrders = new List<string>();
            Task t1 = Task.Run(() => GetOrders("Pranaya", MobileOrders));
            Task t2 = Task.Run(() => GetOrders("Anurag", MobileOrders));
            Task.WaitAll(t1, t2); //Wait till both the task completed

            foreach (var mobileOrder in MobileOrders)
            {
                Console.WriteLine($"Order Placed: {mobileOrder}");
            }
        }
        private static void GetOrders(string custName, List<string> MobileOrders)
        {
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(100);
                string order = string.Format($"{custName} Needs {i + 3} Mobiles");
                lock (lockObject)
                {
                    MobileOrders.Add(order);
                }
            }
        }
        //---------------------------------------------------
        public void ConcurrentBagwithMultipleThreadsMethod()

        {
            ConcurrentTestBag();
            Console.ReadKey();
        }
        public static void ConcurrentTestBag()
        {
            ConcurrentBag<string> MobileOrders = new ConcurrentBag<string>();
            Task t1 = Task.Run(() => GetOrders("Pranaya", MobileOrders));
            Task t2 = Task.Run(() => GetOrders("Anurag", MobileOrders));
            Task.WaitAll(t1, t2); //Wait till both the task completed
            foreach (var mobileOrder in MobileOrders)
            {
                Console.WriteLine($"Order Placed: {mobileOrder}");
            }
        }
        private static void GetOrders(string custName, ConcurrentBag<string> MobileOrders)
        {
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(100);
                string order = string.Format($"{custName} Needs {i + 3} Mobiles");
                MobileOrders.Add(order);
            }
        }
        //-----------------------------------
        public void AddElementToConcurrentBagMethod()
        {
            //Creating ConcurrentBag collection to store string values
            ConcurrentBag<string> concurrentBag = new ConcurrentBag<string>();
            //Adding Element using Add Method of ConcurrentBag Class
            concurrentBag.Add("India");
            concurrentBag.Add("USA");
            concurrentBag.Add("UK");
            //concurrentBag.Add(100); //Compile-Time Error
            Console.WriteLine("ConcurrentBag Elements");
            foreach (var item in concurrentBag)
            {
                Console.WriteLine(item);
            }
            //Creating a string array and passing the array to ConcurrentBag Constructor
            string[] countriesArray = { "Canada", "NZ", "Japan" };
            ConcurrentBag<string> concurrentBag2 = new ConcurrentBag<string>(countriesArray);
            Console.WriteLine("\nConcurrentBag Elements");
            foreach (var item in concurrentBag2)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        //----------------------------------
        /// <summary>
        /// TryTake(out T result): This method attempts to remove and return an object from the ConcurrentBag collection. 
        /// When this method returns, the result contains the object removed 
        /// from the ConcurrentBag or the default value of T if the bag is empty. 
        /// It returns true if an object was removed successfully; otherwise, false.
        /// </summary>
        public void RemoveElementFromConcurrentBagMethod()
        {
            //Creating ConcurrentBag collection and Initialize with Collection Initializer
            ConcurrentBag<string> concurrentBag = new ConcurrentBag<string>
            {
                "India",
                "USA",
                "UK",
                "Canada"
            };

            Console.WriteLine("All ConcurrentBag Elements");
            foreach (var item in concurrentBag)
            {
                Console.WriteLine(item);
            }
            //Removing element using TryTake Method
            bool IsRemoved = concurrentBag.TryTake(out string Result);
            Console.WriteLine($"\nTryTake Return : {IsRemoved}");
            Console.WriteLine($"TryTake Result Value : {Result}");
            Console.WriteLine("\nConcurrentBag Elements After TryTake Method");
            foreach (var item in concurrentBag)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
        //----------------------------------
        /// <summary>
        /// TryPeek(out T result): This method attempt to return an object from the ConcurrentBag without removing it. 
        /// When this method returns, the parameter result contains an object from the ConcurrentBag 
        /// or the default value of T if the operation failed. I
        /// t returns true if an object was returned successfully; otherwise, false.
        /// </summary>
        public void GetElementfromConcurrentBagMethod()
        {
            //Creating ConcurrentBag collection and Initialize with Collection Initializer
            ConcurrentBag<string> concurrentBag = new ConcurrentBag<string>
            {
                "India",
                "USA",
                "UK",
                "Canada",
                "Japan"
            };
            //Printing Elements After TryPeek the Element
            Console.WriteLine($"ConcurrentBag All Elements: Count {concurrentBag.Count}");
            foreach (var element in concurrentBag)
            {
                Console.WriteLine($"{element} ");
            }

            // Removing and Returning the Element from ConcurrentBag using TryPop method
            bool IsRemoved = concurrentBag.TryTake(out string Result1);
            Console.WriteLine($"\nTryTake Return : {IsRemoved}");
            Console.WriteLine($"TryTake Result Value : {Result1}");
            //Printing Elements After Removing the Element
            Console.WriteLine($"\nConcurrentBag Elements After TryTake: Count {concurrentBag.Count}");
            foreach (var element in concurrentBag)
            {
                Console.WriteLine($"{element} ");
            }
            //Returning the Element from ConcurrentBag using TryPeek method
            bool IsPeeked = concurrentBag.TryPeek(out string Result2);
            Console.WriteLine($"\nTryPeek Return : {IsPeeked}");
            Console.WriteLine($"TryPeek Result Value : {Result2}");
            //Printing Elements After TryPeek the Element
            Console.WriteLine($"\nConcurrentBag Elements After TryPeek: Count {concurrentBag.Count}");
            foreach (var element in concurrentBag)
            {
                Console.WriteLine($"{element} ");
            }

            Console.ReadKey();
        }
    }
}
//https://dotnettutorials.net/lesson/concurrentbag-collection-class-in-csharp/