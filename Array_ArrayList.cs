using System.Collections;

namespace Collections
{
    internal class Array_ArrayList
    {
        public Array_ArrayList()
        {

            ArrayListMethod();
            ArrayListInsertMethod();
            ArrayListInsertRangeMethod();
            ArrayListRemoveMethod();
            ArrayListCleanMethod();
            ArrayListContainMethod();
            ArrayListCloneMethod();
            ArrayListCountMethod();
            ArrayListSortMethod();
        }
        public void ArrayListMethod()
        {
            //Adding elements to ArrayList using Add() method
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(101); //Adding Integer Value
            arrayList1.Add("James"); //Adding String Value
            arrayList1.Add("James"); //Adding Duplicate Value
            arrayList1.Add(" "); //Adding Empty
            arrayList1.Add(true); //Adding Boolean
            arrayList1.Add(4.5); //Adding double
            arrayList1.Add(null); //Adding null
            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }
            //*****************

            //Adding Elements to ArrayList using object initializer syntax
            var arrayList2 = new ArrayList()
            {
                102, "Smith", "Smith", true, 15.6
            };
            foreach (var item in arrayList2)
            {
                Console.WriteLine(item);
            }
            //************************

            //Accessing individual elements from ArrayList using Indexer
            int firstElement = (int)arrayList1[0]; //returns 101
            string secondElement = (string)arrayList1[1]; //returns "James"
            //int secondElement = (int) arrayList1[1]; //Error: cannot cover string to int
            Console.WriteLine($"First Element: {firstElement}, Second Element: {secondElement}");

            //**************
            Console.ReadKey();
        }
        //----------------------------------------
        public void ArrayListInsertMethod()
        {
            ArrayList arrayList = new ArrayList()
            {
                    101,
                    "James",
                    true,
                    10.20
            };

            //Insert "First Element" at First Position i.e. Index 0
            arrayList.Insert(0, "First Element");
            //Insert "Third Element" at Third Position i.e. Index 2
            arrayList.Insert(2, "Third Element");
            //Iterating through foreach loop
            foreach (var item in arrayList)
            {
                Console.WriteLine($"{item}");
            }
            Console.ReadKey();
        }
        //---------------------------------------

        public void ArrayListInsertRangeMethod()
        {
            ArrayList arrayList1 = new ArrayList()
            {
                    "India",
                    "USA",
                    "UK",
                    "Nepal"
            };
            Console.WriteLine("Array List Elements");
            foreach (var item in arrayList1)
            {
                Console.Write($"{item} ");
            }
            ArrayList arrayList2 = new ArrayList()
            {
                    "Srilanka",
                    "Japan",
                    "Britem"
            };
            arrayList1.InsertRange(2, arrayList2);

            Console.WriteLine("\n\nArray List Elements After InsertRange");
            foreach (var item in arrayList1)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }
        //--------------------------------------------------
        public void ArrayListRemoveMethod()
        {
            ArrayList arrayList = new ArrayList()
            {
                    "India",
                    "USA",
                    "UK",
                    "Nepal",
                    "HongKong",
                    "Srilanka",
                    "Japan",
                    "Britem",
                    "HongKong",
            };
            Console.WriteLine("Array List Elements");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            arrayList.Remove("HongKong"); //Removes first occurance of null
            Console.WriteLine("\n\nArray List Elements After Removing First Occurances of HongKong");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            arrayList.RemoveAt(3); //Removes element at index postion 3, it is 0 based index
            Console.WriteLine("\n\nArray List1 Elements After Removing Element from Index 3");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            arrayList.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)
            Console.WriteLine("\n\nArray List Elements After Removing First Two Elements");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }
        //--------------------------------------------
        public void ArrayListCleanMethod()
        {
            ArrayList arrayList = new ArrayList()
            {
                    "India",
                    "USA",
                    "UK",
                    "Denmark",
                    "Nepal",
            };
            int totalItems = arrayList.Count;
            Console.WriteLine(string.Format($"Total Items: {totalItems}, Capacity: {arrayList.Capacity}"));
            //Remove all items from the Array list             
            arrayList.Clear();
            totalItems = arrayList.Count;
            Console.WriteLine(string.Format($"Total Items After Clear(): {totalItems}, Capacity: {arrayList.Capacity}"));
            Console.ReadKey();
        }
        //---------------------------------------
        public void ArrayListContainMethod()
        {
            ArrayList arrayList = new ArrayList()
            {
                    "India",
                    "UK",
                    "Nepal",
                    101
            };
            Console.WriteLine("Array List Elements");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine($"\n\nIs ArrayList Contains India: {arrayList.Contains("India")}"); // true
            Console.WriteLine($"Is ArrayList Contains USA: {arrayList.Contains("USA")}"); // false
            Console.WriteLine($"Is ArrayList Contains 101: {arrayList.Contains(101)}"); // true
            Console.WriteLine($"Is ArrayList Contains 10.5: {arrayList.Contains(10.5)}"); // false
            Console.ReadKey();

        }
        //-------------------------
        public void ArrayListCloneMethod()
        {
            ArrayList arrayList = new ArrayList()
            {
                    "India",
                    "USA",
                    "UK",
                    "Denmark",
                    "HongKong",
            };
            Console.WriteLine("Array List Elements:");
            foreach (var item in arrayList)
            {
                Console.WriteLine($"{item} ");
            }
            //Creating a clone of the arrayList using Clone method
            ArrayList cloneArrayList = (ArrayList)arrayList.Clone();
            Console.WriteLine("\nCloned ArrayList Elements:");
            foreach (var item in cloneArrayList)
            {
                Console.WriteLine($"{item} ");
            }
            Console.ReadKey();
        }
        //-------------------------------------
        public void ArrayListCountMethod()
        {
            ArrayList arrayList = new ArrayList()
            {
                    "India",
                    "USA",
                    "UK",
                    "Denmark",
                    "HongKong",
            };
            Console.WriteLine("Array List Elements:");
            foreach (var item in arrayList)
            {
                Console.WriteLine($"{item} ");
            }
            //Copying the arrayList to an object array
            object[] arrayListCopy = new object[arrayList.Count];
            arrayList.CopyTo(arrayListCopy);
            Console.WriteLine("\nArrayList Copy Array Elements:");
            foreach (var item in arrayListCopy)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        //-----------------------------------
        public void ArrayListSortMethod()
        {
            ArrayList arrayList = new ArrayList()
            {
                    "India",
                    "USA",
                    "UK",
                    "Denmark",
                    "Nepal",
                    "HongKong",
                    "Austrailla",
                    "Srilanka",
                    "Japan",
                    "Britem",
                    "Brazil",
            };
            Console.WriteLine("Array List Elements Before Sorting");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            // Sorting the elements of  ArrayList Using sort() method
            arrayList.Sort();
            Console.WriteLine("\n\nArray List Elements After Sorting");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }
        //----------------------------------------

    }
}

//https://dotnettutorials.net/lesson/arraylist-collection-csharp/