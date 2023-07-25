using System.Collections;
using System.Xml.Linq;

namespace Collections
{
    internal class NonGenericStack
    {
        /// <summary>
        /// The Stack in C# is a Non-Generic collection class that works in the LIFO (Last in First out) principle. 
        /// So, we need to use the Stack Collection Class in C#, 
        /// when we want Last-In-First-Out access to the items of a collection. 
        /// That means the item which is added last to the collection will be the first item to be removed from the collection. 
        /// </summary>
        public NonGenericStack()
        {
            StackMethod();
            StackCloneMethod();
            StackCopyToMethod();
        }
        //---------------
        /// <summary>
        /// How to get the topmost element of a Stack in C#?
        ///The Stack class in C# provides the following two methods to get the topmost element of the Stack.

        ///Pop(): This method is used to remove and return the object at the top of the Stack.
        ///It returns the Object(element) removed from the top of the Stack.If there is no object (or element) present in the stack 
        ///and if you are trying to remove an item or object from the stack using the pop() method 
        ///then it will throw an exception i.e.System.InvalidOperationException
        ///
        ///Peek(): The peek() method is used to return the object from the top of the Stack without removing it.
        ///If there is no object (or element) present in the stack and if you are trying to return an item (object) from the stack using the peek() method 
        ///then it will throw an exception i.e.System.InvalidOperationException
        /// </summary>
        public void StackMethod()
        {
            // Creating a stack collection
            Stack stack = new Stack();
            //Adding item to the stack using the push method
            stack.Push(10);
            stack.Push("Hello");
            stack.Push(3.14f);
            stack.Push(true);
            stack.Push(67.8);
            stack.Push('A');
            //Printing the stack items using foreach loop
            Console.WriteLine($"All Stack Elements: Count {stack.Count}");

            foreach (object item in stack)
            {
                Console.Write($"{item} ");
                //Console.WriteLine(item);
            }
            //Removing and Returning an item from the stack using the pop method
            Console.WriteLine($"\n\nDeleted Element: {stack.Pop()}");
            //Printing item after removing the last added item
            Console.WriteLine($"\nAll Stack Elements After Deletion: Count {stack.Count}");
            foreach (var item in stack)
            {
                Console.Write($"{item} ");
            }

            Console.Write('\n');
            // Fetch the topmost element of stack Using Pop method
            //Console.WriteLine($"Topmost element of stack is {stack.Pop()}");
            //Console.WriteLine($"Total elements present in stack : {stack.Count}");
            // Fetch the topmost element from Stacj Using Peek method
            Console.WriteLine($"Topmost element of Stack is {stack.Peek()}");
            Console.WriteLine($"Total elements present in stack : {stack.Count}");

            // Checking if the element Hello is present in the Stack or not
            if (stack.Contains("Hello"))
            {
                Console.WriteLine("Element Hello is found");
            }
            else
            {
                Console.WriteLine("Element Hello is not found");
            }
            // Checking if the element Hello is present in the Stack or not
            if (stack.Contains("World"))
            {
                Console.WriteLine("Element World is found");
            }
            else
            {
                Console.WriteLine("Element World is not found");
            }

            Console.ReadKey();
        }
        //-----------------------------------------
        public void StackCloneMethod()
        {
            // Creating a stack collection
            Stack stack = new Stack();
            //Adding item to the stack using the push method
            stack.Push(10);
            stack.Push("Hello");
            stack.Push(3.14f);
            stack.Push(67.8);
            //Printing All Stack Elements using For Each Loop
            Console.WriteLine("Stack Elements:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            //Creating a clone queue using Clone method
            Stack cloneStack = (Stack)stack.Clone();
            Console.WriteLine("\nCloned Stack Elements:");
            foreach (var item in cloneStack)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        //---------------------------
        public void StackCopyToMethod()
        {
            // Creating a stack collection
            Stack stack = new Stack();
            //Adding item to the stack using the push method
            stack.Push(10);
            stack.Push("Hello");
            stack.Push(3.14f);
            stack.Push(true);
            stack.Push(67.8);
            //Printing All Queue Elements using For Each Loop
            Console.WriteLine("Stack Elements:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            //Copying the queue to an object array
            object[] stackCopy = new object[5];
            stack.CopyTo(stackCopy, 0);
            Console.WriteLine("\nStack Copy Array Elements:");
            foreach (var item in stackCopy)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        //----------------------------------
    }
}
//https://dotnettutorials.net/lesson/stack-collection-csharp/