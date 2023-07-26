using System.Collections.Generic;

namespace Collections
{
    internal class GenericDictionary
    {
        public GenericDictionary()
        {
            CreatingDictionaryMethod();
            DictionaryRemoveMethod();
            ConvertArrayToDictionaryMethod();
            DictionaryParallelEnumerableMethod();            
            DictionaryWithComplexTypeMethod();
            DictionaryTryGetValueMethod();
            ConvertArrayToDictionaryMethod();
           

        }
        //---------------------------
        public void CreatingDictionaryMethod()
        {
            //Creating a Dictionary with Key and value both are string type
            Dictionary<string, string> dictionaryCountries = new Dictionary<string, string>();
            //Adding Elements to the Dictionary using Add Method of Dictionary class
            dictionaryCountries.Add("UK", "London, Manchester, Birmingham");
            dictionaryCountries.Add("USA", "Chicago, New York, Washington");
            dictionaryCountries.Add("IND", "Mumbai, Delhi, Bhubaneswar");

            /*
             //Creating a Dictionary with Key and value both are string type using Collection Initializer
            Dictionary<string, string> dictionaryCountries = new Dictionary<string, string>
            {
                { "UK", "London, Manchester, Birmingham" },
                { "USA", "Chicago, New York, Washington" },
                { "IND", "Mumbai, Delhi, Bhubaneswar" }
            };
             
             */

            /*
             
             //Assign Values to a Dictionary with Indexer 
            dictionaryCountries["IND"] = "India";
            dictionaryCountries["PAK"] = "Pakistan";
            dictionaryCountries["SL"] = "Srilanka";
             */


            //Accessing Dictionary Elements using For Each Loop
            Console.WriteLine("Accessing Dictionary Elements using For Each Loop");
            foreach (KeyValuePair<string, string> KVP in dictionaryCountries)
            {
                Console.WriteLine($"Key:{KVP.Key}, Value: {KVP.Value}");
            }
            //Accessing Dictionary Elements using For Loop
            Console.WriteLine("\nAccessing Dictionary Elements using For Loop");
            for (int i = 0; i < dictionaryCountries.Count; i++)
            {
                string key = dictionaryCountries.Keys.ElementAt(i);
                string value = dictionaryCountries[key];
                Console.WriteLine($"Key: {key}, Value: {value}");
            }
            //Accessing Dictionary Elements using Keys
            Console.WriteLine("\nAccessing Dictionary Elements using Keys");
            Console.WriteLine($"Key: UK, Value: {dictionaryCountries["UK"]}");
            Console.WriteLine($"Key: USA, Value: {dictionaryCountries["USA"]}");
            Console.WriteLine($"Key: IND, Value: {dictionaryCountries["IND"]}");

            //---------------------------------------

            //Checking the key using the ContainsKey methid
            Console.WriteLine("\nIs USA Key Exists : " + dictionaryCountries.ContainsKey("USA"));
            Console.WriteLine("Is PAK Key Exists : " + dictionaryCountries.ContainsKey("PAK"));
            //Checking the value using the ContainsValue method
            Console.WriteLine("\nIs India value Exists : " + dictionaryCountries.ContainsValue("India"));
            Console.WriteLine("Is Srilanka value Exists : " + dictionaryCountries.ContainsValue("Srilanka"));

            //-------------------------------------
            //Updating the key UK and USA using Indexer
            dictionaryCountries["UK"] = "United Kingdom Updated";
            dictionaryCountries["IND"] = "India Updated";
            Console.WriteLine("\nAfter Updating the Key UK and IND");
            Console.WriteLine($"USA: {dictionaryCountries["UK"]}");
            Console.WriteLine($"IND: {dictionaryCountries["IND"]}");
            //-------------------------------------------------------------
            Console.ReadKey();
        }
        //--------------------------
        public void DictionaryRemoveMethod()
        {
            //Creating a Dictionary with Key and value both are string type using Collection Initializer
            Dictionary<string, string> dictionaryCountries = new Dictionary<string, string>
            {
                { "UK", "United Kingdom" },
                { "USA", "United State of America" },
                { "IND", "India" },
                { "PAK", "Pakistan" },
                { "SL", "Srilanka" }
            };
            Console.WriteLine($"Dictionary Elements Count Before Removing: {dictionaryCountries.Count}");
            foreach (var item in dictionaryCountries)
            {
                Console.WriteLine($"Key:{item.Key}, Value:{item.Value}");
            }
            // Remove element PAK from Dictionary Using Remove() method
            if (dictionaryCountries.ContainsKey("PAK"))
            {
                dictionaryCountries.Remove("PAK");
                Console.WriteLine($"\nDictionary Elements Count After Removing PAK: {dictionaryCountries.Count}");
                foreach (var item in dictionaryCountries)
                {
                    Console.WriteLine($"Key:{item.Key}, Value:{item.Value}");
                }
            }
            // Remove all Elements from Dictionary Using Clear method
            dictionaryCountries.Clear();
            Console.WriteLine($"\nDictionary Elements Count After Clear: {dictionaryCountries.Count}");
            Console.ReadKey();

        }
        //-----------------------------
        public void DictionaryParallelEnumerableMethod()
        {
            //Creating a Dictionary with Key and value both are string type using Collection Initializer
            Dictionary<string, string> dictionaryCountries = new Dictionary<string, string>
            {
                { "UK", "United Kingdom" },
                { "USA", "United State of America" },
                { "IND", "India" },
                { "PAK", "Pakistan" },
                { "SL", "Srilanka" }
            };
            Console.WriteLine($"Iterating Dictionary Using AsParallel().ForAll Method");
            dictionaryCountries.AsParallel().ForAll(entry => Console.WriteLine(entry.Key + " : " + entry.Value));
            
            Console.ReadKey();
        }
        //-----------------------------------------
        public class Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Branch { get; set; }
        }
        //----------------------------------------------
        public void DictionaryWithComplexTypeMethod()
        {
            Dictionary<int, Student> dictionaryStudents = new Dictionary<int, Student>
            {
                { 101, new Student(){ ID = 101, Name ="Anurag", Branch="CSE"} },
                { 102, new Student(){ ID = 102, Name ="Mohanty", Branch="CSE"} },
                { 103, new Student(){ ID = 103, Name ="Sambit", Branch="ETC"}},
                //The following Statement will give runtime error
                //System.ArgumentException: 'An item with the same key has already been added. Key: 101'
                //{ 101, new Student(){ ID = 101, Name ="Anurag", Branch="CSE"}}
            };
            foreach (KeyValuePair<int, Student> item in dictionaryStudents)
            {
                Console.WriteLine($"Key: {item.Key}, ID: {item.Value.ID}, Name: {item.Value.Name}, Branch: {item.Value.Branch}");
            }
            Console.ReadKey();
        }
       
        //------------------------------------------------------------
        public void DictionaryTryGetValueMethod()
        {
            Dictionary<int, Student> dictionaryStudents = new Dictionary<int, Student>
            {
                { 101, new Student(){ ID = 101, Name ="Anurag", Branch="CSE"} },
                { 102, new Student(){ ID = 102, Name ="Mohanty", Branch="CSE"} },
                { 103, new Student(){ ID = 103, Name ="Sambit", Branch="ETC"}}
            };
            foreach (KeyValuePair<int, Student> item in dictionaryStudents)
            {
                Console.WriteLine($"Key: {item.Key}, ID: {item.Value.ID}, Name: {item.Value.Name}, Branch: {item.Value.Branch}");
            }
            Student std102;
            if (dictionaryStudents.TryGetValue(102, out std102))
            {
                Console.WriteLine("\nStudent with Key = 102 is found in the dictionary");
                Console.WriteLine($"ID: {std102.ID}, Name: {std102.Name}, Branch: {std102.Branch}");
            }
            else
            {
                Console.WriteLine("\nStudent with Key = 102 is not found in the dictionary");
            }
            Student std105;
            if (dictionaryStudents.TryGetValue(105, out std105))
            {
                Console.WriteLine("\nStudent with Key = 102 is found in the dictionary");
                Console.WriteLine($"ID: {std105.ID}, Name: {std105.Name}, Branch: {std105.Branch}");
            }
            else
            {
                Console.WriteLine("\nStudent with Key = 105 is not found in the dictionary");
            }
            Console.ReadKey();
        }

       

        //----------------------------------------------

        public void ConvertArrayToDictionaryMethod()
        {
            Student[] arrayStudents = new Student[3];
            arrayStudents[0] = new Student() { ID = 101, Name = "Anurag", Branch = "CSE" };
            arrayStudents[1] = new Student() { ID = 102, Name = "Mohanty", Branch = "CSE" };
            arrayStudents[2] = new Student() { ID = 103, Name = "Sambit", Branch = "ETC" };
            Dictionary<int, Student> dictionaryStudents = arrayStudents.ToDictionary(std => std.ID, std => std);
            // OR        
            // Dictionary<int, Student> dictionaryStudents = arrayStudents.ToDictionary(employee => employee.ID);
            //OR use a foreach loop
            //Dictionary<int, Student> dict = new Dictionary<int, Student>();
            //foreach (Student std in arrayStudents)
            //{
            //    dict.Add(std.ID, std);
            //}
            foreach (KeyValuePair<int, Student> item in dictionaryStudents)
            {
                Console.WriteLine($"Key: {item.Key}, ID: {item.Value.ID}, Name: {item.Value.Name}, Branch: {item.Value.Branch}");
            }
            Console.ReadKey();
        }


    }
        //-----------------------------
    
}
//https://dotnettutorials.net/lesson/dictionary-generic-collection-csharp/
