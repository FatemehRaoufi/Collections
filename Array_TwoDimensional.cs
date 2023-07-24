namespace Collections
{
    internal class Array_TwoDimensional
    {
        public Array_TwoDimensional() {

            //RectangularTwoDimensionalArrayMethod();
            //AssigningDefaultValueRectangular2DArrayMethod();
            //AddTwoMatrixMethod();
            JaggedArrayMethod();
        } 
        public void RectangularTwoDimensionalArrayMethod() 
        {
            //Creating a 2D Array with 4 Rows and 5 Columns
            int[,] RectangleArray = new int[4, 5];
            int a = 0;
            //Printing the values of 2D array using foreach loop
            //It will print the default values as we are not assigning
            //any values to the array
            foreach (int i in RectangleArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
            //Assigning values to the 2D array by using nested for loop
            //arr.GetLength(0): Returns the size of the Row
            //arr.GetLength(0): Returns the size of the Column
            for (int i = 0; i < RectangleArray.GetLength(0); i++)
            {
                for (int j = 0; j < RectangleArray.GetLength(1); j++)
                {
                    a += 5;
                    RectangleArray[i, j] = a;
                }
            }
            //Printing the values of array by using nested for loop
            //arr.GetLength(0): Returns the size of the Row
            //arr.GetLength(0): Returns the size of the Column
            for (int i = 0; i < RectangleArray.GetLength(0); i++)
            {
                for (int j = 0; j < RectangleArray.GetLength(1); j++)
                {
                    Console.Write(RectangleArray[i, j] + " ");
                }
            }
            Console.ReadKey();

        }
        //------------------------------
        public void AssigningDefaultValueRectangular2DArrayMethod()
        {
            //Assigning default value the Array Elements at the time of declaration
            //Row Size: 3
            //Column Size: 4
            int[,] NumbersArray = {{11,12,13,14},
                          {21,22,23,24},
                          {31,32,33,34}};
            //Printing Array Elements using for each loop
            Console.WriteLine("Printing Array Elements using ForEach loop");
            foreach (int i in NumbersArray)
            {
                Console.Write(i + " ");
            }
            //Printing Array Elements using nested for each
            Console.WriteLine("\n\nPrinting Array Elements using Nested For Loop");
            for (int i = 0; i < NumbersArray.GetLength(0); i++)
            {
                for (int j = 0; j < NumbersArray.GetLength(1); j++)
                {
                    Console.Write(NumbersArray[i, j] + " ");
                }
            }
            Console.ReadKey();
        }
        //-------------------------------------
        public void AddTwoMatrixMethod()
        {
            Console.WriteLine("Enter rows and column of Matrices: ");
            int Rows = Convert.ToInt32(Console.ReadLine());
            int Columns = Convert.ToInt32(Console.ReadLine());
            //Create 3 2D Arrays with the above size
            int[,] Matrix1 = new int[Rows, Columns];
            int[,] Matrix2 = new int[Rows, Columns];
            int[,] ResultMatrix = new int[Rows, Columns];
            //Enter Matrix 1 Elements
            Console.WriteLine("\nEnter Elements of 1st Matrix:");
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //Enter Matrix 2 Elements
            Console.WriteLine("\nEnter Elements of 2nd Matrix:");
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //Adding Both Matrix Elements and Store the Result in ResultMatrix
            Console.WriteLine("\nSum of Both the Matrics:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    ResultMatrix[i, j] = Matrix1[i, j] + Matrix2[i, j];
                    Console.Write($"{ResultMatrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        //------------------------------
        public void JaggedArrayMethod()
        {
            //Creating An jagged array with four Rows
            int[][] arr = new int[4][];
            //Initializing each row with different column size
            //Uisng one dimensional array
            arr[0] = new int[5];
            arr[1] = new int[6];
            arr[2] = new int[4];
            arr[3] = new int[5];
            //Printing the values of Jagged array using nested for loop
            //It will print the default values as we are not assigning any
            //values to the array
            //GetLength(0): Returns the Size of the Rows (4)
            Console.WriteLine("Printing the Default Values of Jagged Array:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                //arr[i].Length: Returns the Length of Each Row
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
            }

            //Assigning values to the Jagged array by using nested for loop
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int num = 10;
                for (int j = 0; j < arr[i].Length; j++)
                {
                    num++;
                    arr[i][j] = num;
                }
            }
            //Printing the values of Jagged array by using foreach loop within for loop
            Console.WriteLine("\n\nPrinting the Values of Jagged Array:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                foreach (int x in arr[i])
                {
                    Console.Write(x + " ");
                }
            }
            //You cannot simply use a foreach loop to Print the Values of a foreach loop
            //foreach (var item in arr)
            //{
            //    Console.Write(item);
            //}
            Console.ReadKey();
        }
    }
    
}
//https://dotnettutorials.net/lesson/two-dimensional-array-in-csharp/