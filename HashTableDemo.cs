using System.Collections;
using static System.Net.Mime.MediaTypeNames;

namespace Collections
{
    /// <summary>
    ///The Hashtable in C# is a Non-Generic Collection that stores the element in the form of “Key-Value Pairs”. 
    ///The data in the Hashtable are organized based on the hash code of the key. 
    ///The key in the HashTable is defined by us and more importantly, that key can be of any data type. 
    ///Once we created the Hashtable collection, then we can access the elements by using the keys. 
    ///The Hashtable class comes under the System.Collections namespace.
    ///The Hashtable computes a hash code for each key.
    ///Then it uses that hash code to look up the elements very quickly which increases the performance of the application.
    
    /// </summary>
    internal class HashTableDemo
    {
        public HashTableDemo()
        {
            HashtableMethod();
            AddingHashtableUsingDictionaryEntryMethod();
            HashtableContainsMethod();
            HashtableCastAndRemoveCastMethod();
            HashtableCloneMethod();
            HashtableCopyToMethod();
        }
        //-------------------
        public void HashtableMethod()
        {
            //Creating Hashtable collection with default constructor
            Hashtable hashtable = new Hashtable();
            //Adding elements to the Hash table using key value pair
            hashtable.Add("EId", 1001); //Here key is Eid and value is 1001
            hashtable.Add("Name", "James"); //Here key is Name and value is James
            hashtable.Add("Salary", 3500); //Here key is Salary and value is 3500
            hashtable.Add("Location", "Mumbai"); //Here key is Location and value is Mumbai
            hashtable.Add("EmailID", "a@a.com"); //Here key is EmailID and value is a@a.com

            //Printing the keys and their values using foreach loop
            Console.WriteLine("Printing Hashtable using Foreach Loop");
            foreach (object obj in hashtable.Keys)
            {
                Console.WriteLine(obj + " : " + hashtable[obj]);
            }
            //Or
            //foreach (DictionaryEntry de in hashtable)
            //{
            //    Console.WriteLine($"Key: {de.Key}, Value: {de.Value}");
            //}
            Console.WriteLine("\nPrinting Hashtable using Keys");
            //I want to print the Location by using the Location key
            Console.WriteLine("Location : " + hashtable["Location"]);
            //I want to print the Email ID by using the EmailID key
            Console.WriteLine("Emaild ID : " + hashtable["EmailID"]);
            Console.ReadKey();
        }
        //------------------------------------
        public void AddingHashtableUsingDictionaryEntryMethod()
        {
            //Creating a Hashtable using collection-initializer syntax
            Hashtable citiesHashtable = new Hashtable(){
                            {"UK", "London, Manchester, Birmingham"}, //Key:UK, Value:London, Manchester, Birmingham
                            {"USA", "Chicago, New York, Washington"}, //Key:USA, Value:Chicago, New York, Washington
                            {"India", "Mumbai, New Delhi, Pune"}      //Key:India, Value:Mumbai, New Delhi, Pune
                        };

            /*
              Hashtable hashtable = new Hashtable();
              hashtable[1] = "One";//key = 1 , value= "one"
              hashtable[5] = "Five"; // key=5, value="Five"
              hashtable[30] = "Thirty"; // key=30 , value="Thirty"
            */
            Console.WriteLine("Creating a Hashtable Using Collection-Initializer");
            foreach (DictionaryEntry city in citiesHashtable)
            {
                Console.WriteLine($"Key: {city.Key}, Value: {city.Value}");
            }
            Console.ReadKey();
        }
        //----------------------------------
        public void HashtableContainsMethod()
        {
            //Creating Hashtable collection with default constructor
            Hashtable hashtable = new Hashtable();
            //Adding elements to the Hash table using key value pair
            hashtable.Add("EId", 1001); //Here key is Eid and value is 1001
            hashtable.Add("Name", "James"); //Here key is Name and value is James
            hashtable.Add("Job", "Developer");
            hashtable.Add("Salary", 3500);
            hashtable.Add("Location", "Mumbai");
            hashtable.Add("Dept", "IT");
            hashtable.Add("EmailID", "a@a.com");

            //Checking the key using the Contains methid
            Console.WriteLine("Is EmailID Key Exists : " + hashtable.Contains("EmailID"));
            Console.WriteLine("Is Department Key Exists : " + hashtable.Contains("Department"));
            //Checking the key using the ContainsKey methid
            Console.WriteLine("Is EmailID Key Exists : " + hashtable.ContainsKey("EmailID"));
            Console.WriteLine("Is Department Key Exists : " + hashtable.ContainsKey("Department"));
            //Checking the value using the ContainsValue method
            Console.WriteLine("Is Mumbai value Exists : " + hashtable.ContainsValue("Mumbai"));
            Console.WriteLine("Is Technology value Exists : " + hashtable.ContainsValue("Technology"));
            Console.ReadKey();
        }
        //---------------------------------------
        public void HashtableCastAndRemoveCastMethod()
        {
            Hashtable employee = new Hashtable
            {
                { "EId", 1001 },
                { "Name", "James" },
                { "Salary", 3500 },
                { "Location", "Mumbai" },
                { "EmailID", "a@a.com" }
            };

            //Casting:
            string EmployeeName = (string)employee["Name"]; //Cast to String
            int EmployeeSalary = (int)employee["Salary"];   //Cast to Int
            Console.WriteLine("Before Updating Name and Salary");
            Console.WriteLine($"Employee Name: {EmployeeName}");
            Console.WriteLine($"Employee Salary: {EmployeeSalary}");
            //Updating the Name and Salary
            employee["Name"] = "Smith"; //Update value of Name key
            employee["Salary"] = 5000; //Update value of Salary key
            Console.WriteLine("\nAfter Updating Name and Salary");
            EmployeeName = (string)employee["Name"];
            EmployeeSalary = (int)employee["Salary"];
            Console.WriteLine($"Employee Name: {EmployeeName}");
            Console.WriteLine($"Employee Salary: {EmployeeSalary}");




            //Count Property returns the number of elements present in the collection
            Console.WriteLine($"Hashtable Total Elements: {employee.Count}");
            // Remove EId as this key exists
            employee.Remove("EId");
            Console.WriteLine($"After Removing EID Total Elements: {employee.Count}");
            //Following statement throws run-time exception: KeyNotFoundException
            //employee.Remove("City"); 
            //Check key before removing it
            if (employee.ContainsKey("City"))
            {
                employee.Remove("City");
            }
            else
            {
                Console.WriteLine("Hashtable doesnot contain City key");
            }
            //Removes all elements
            employee.Clear();
            Console.WriteLine($"After Clearing Hashtable Total Elements: {employee.Count}");
            Console.ReadKey();
        }
        //--------------------------------
        public void HashtableCloneMethod()
        {
            //Creating Hashtable collection with default constructor
            Hashtable hashtable = new Hashtable();
            //Adding elements to the Hash table using Add method
            hashtable.Add("EId", 1001);
            hashtable.Add("Name", "James");
            hashtable.Add("Job", "Developer");
            hashtable.Add("Salary", 3500);
            hashtable.Add("Location", "Mumbai");
            hashtable.Add("Dept", "IT");
            hashtable.Add("EmailID", "a@a.com");
            Console.WriteLine("Hashtable  Elements:");
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            //Creating a clone Hashtable using Clone method
            Hashtable cloneHashtable = (Hashtable)hashtable.Clone();
            Console.WriteLine("\nCloned Hashtable Elements:");
            foreach (DictionaryEntry item in cloneHashtable)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            Console.ReadKey();
        }
        //-------------------------------
        public void HashtableCopyToMethod()
        {
            //Creating Hashtable collection with default constructor
            Hashtable hashtable = new Hashtable();
            //Adding elements to the Hash table using Add method
            hashtable.Add("EId", 1001);
            hashtable.Add("Name", "James");
            hashtable.Add("Location", "Mumbai");
            //Printing All Queue Elements using For Each Loop
            Console.WriteLine("Hashtable Elements:");
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            //Copying the Hashtable to an object array
            DictionaryEntry[] myArray = new DictionaryEntry[hashtable.Count];

            hashtable.CopyTo(myArray, 0);
            Console.WriteLine("\nHashtable Copy Array Elements:");
            foreach (DictionaryEntry item in myArray)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            Object[] myObjArrayKey = new Object[hashtable.Count];
            Object[] myObjArrayValue = new Object[hashtable.Count];
            Console.WriteLine("\nCopyTo Method to Copy Keys:");
            hashtable.Keys.CopyTo(myObjArrayKey, 0);
            foreach (var key in myObjArrayKey)
            {
                Console.WriteLine($"{key} ");
            }
            Console.WriteLine("\nCopyTo Method to Copy Values:");
            hashtable.Values.CopyTo(myObjArrayValue, 0);
            foreach (var key in myObjArrayValue)
            {
                Console.WriteLine($"{key} ");
            }
            Console.ReadKey();
        }
    }
}
//https://dotnettutorials.net/lesson/hashtable-csharp/