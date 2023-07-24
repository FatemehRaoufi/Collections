using System;

namespace Collections
{
    internal class Arrays
    {
        public Arrays() {

            ArryasMethod1();
            StringArrayMethod();
            ArrayClassMethod();
        }
    
    public void ArryasMethod1()
    {
        int[] Numbers = new int[3];
        //Accessing the Array Elements Before Initialization
        Console.WriteLine("Accessing the Array Elements Before Initialization");
        for (int i = 0; i <= Numbers.Length - 1; i++)
        {
            Console.WriteLine($"Numbers[{i}] = {Numbers[i]}");
        }
        //Initializing the Array Elements using the Index Position
        Numbers[0] = 10;
        Numbers[1] = 20;
        Numbers[2] = 30;
        //Accessing the Array Elements After Initialization
        Console.WriteLine("\nAccessing the Array Elements After Initialization");
        for (int i = 0; i <= Numbers.Length - 1; i++)
        {
            Console.WriteLine($"Numbers[{i}] = {Numbers[i]}");
        }

        Console.ReadKey();
         

        }
        //--------------------
        public void StringArrayMethod()
        {            
           /* 
            string[] Countries = new string[3];//Creating an array with size 3
            Countries[2] = "India";
            */
            //------------------------
            //Creating an array with size 3 and with deafult values
            string[] Countries = { "Iran", "Germany", "France" };
            

            //Accessing array values using for loop
            //Here, the loop variable is of integer type
            for (int i = 0; i < Countries.Length; i++)
            {
                Console.Write(Countries[i] + " ");
            }
            Console.WriteLine();
            //accessing array values using foreach loop
            //Here, the loop variable is of type string
            foreach (string country in Countries)
            {
                Console.Write(country + " ");
            }
            Console.ReadKey();
        }
        //--------------------------------------
        public void ArrayClassMethod()
        {
            //Creating and Initializing an Array of Integers
            //Size of the Array is 10
            int[] Numbers = { 17, 23, 4, 59, 27, 36, 96, 9, 1, 3 };
            //Printing the Array Elements using a for Loop
            Console.WriteLine("Original Array Elements :");
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write(Numbers[i] + " ");
            }
            Console.WriteLine();
            //Sorting the Array Elements by using the Sort method of Array Class
            Array.Sort(Numbers);
            //Printing the Array Elements After Sorting using a foreach loop
            Console.WriteLine("\nArray Elements After Sorting :");
            foreach (int i in Numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //Reversing the array elements by using the Reverse method of Array Class
            Array.Reverse(Numbers);
            //Printing the Array Elements in Reverse Order
            Console.WriteLine("\nArray Elements in the Reverse Order :");
            foreach (int i in Numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //Creating a New Array
            int[] NewNumbers = new int[10];
            //Copying Some of the Elements from Old array to new array
            //We declare the array with size 10 and we copy only 5 elements. 
            //So the rest 5 elements will take the default value. In this array, it will take 0
            Array.Copy(Numbers, NewNumbers, 5);
            //Printing the Array Elements using for Each Loop
            Console.WriteLine("\nNew Array Elements :");
            foreach (int i in NewNumbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"\nNew Array Length using Length Property :{NewNumbers.Length}");
            Console.WriteLine($"New Array Length using GetLength Method :{NewNumbers.GetLength(0)}");
            Console.ReadKey();
        }
        //--------------------
        public void ImplicitlyTypedArrayMethod()
        {
            var Numbers = new[] { 10, 20, 30, 40, 50 };
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write(Numbers[i] + " ");
            }
            Console.ReadKey();
        }
        //--------------------------------
    }
}

//https://dotnettutorials.net/lesson/arrays-csharp/