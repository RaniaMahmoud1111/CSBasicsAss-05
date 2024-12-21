namespace CSBasicsAss_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--------------Arrays---------------------

            #region 19. Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //int n;
            //Console.Write("enter number represent size of identity Matrix: ");
            //n = int.TryParse(Console.ReadLine(), out n) ? n : 0;

            //int[,] matrix = new int[n, n];
            //if (n > 0)
            //{
            //    Console.Write("[");
            //    for (int i = 0; i < n; i++)
            //    {
            //        for (int j = 0; j < n; j++)
            //        {
            //            if (i == j)
            //                matrix[i, j] = 1;

            //            Console.Write($"{matrix[i, j]} ");
            //        }
            //        Console.WriteLine("\n");
            //    }
            //    Console.Write("]");
            //}

            #endregion

            #region 20- Write a program in C# Sharp to find the sum of all elements of the array.

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            //long sum=0;
            //for (int i = 0; i < arr.Length; i++) 
            //{
            //    sum += arr[i];
            //}
            //Console.WriteLine($"Sum of array elements: {sum} " );


            #endregion

            #region 21- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            //int[] arr01 = { 10, 5, 8, 1 };
            //int[] arr02 = { 33, 50, 3, 42 };

            //int[] merged=new int[8];

            //Array.Copy(arr01, merged, 4);
            //Array.ConstrainedCopy(arr02,0, merged, 3, 4);

            //Array.Sort(merged);

            //for (int i = 0;i< merged.Length;i++)
            //{
            //    Console.WriteLine(merged[i]);

            //}

            #endregion

            #region 22- Write a program in C# Sharp to count the frequency of each element of an array.

            //int[] arr = { 1, 2, 5, 2, 4, 1, 1, 5, 7 };            
            //Array.Sort(arr);
            //int len = arr[arr.Length - 1]+1;
            //Console.WriteLine(len);
            //int[] freqArr = new int[len];


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    freqArr[arr[i]]++;
            //}

            //for (int i = 0; i < freqArr.Length; i++)
            //{
            //    Console.WriteLine($"the repeatation of {i} is {freqArr[i]}");
            //}


            #endregion

            #region 23- Write a program in C# Sharp to find maximum and minimum element in an array

            //int[] numbers = { 1, 2, 30, 3, 4, -5, 90, 8 };

            //int mx = numbers[0];
            //int mn = numbers[0];


            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i]> mx)
            //    {
            //        mx= numbers[i];
            //    }
            //    if (numbers[i] < mn)
            //    {
            //        mn = numbers[i];
            //    }

            //}
            //Console.WriteLine($"the Max num : {mx} \nthe min num : {mn}");



            #endregion

            #region 24- Write a program in C# Sharp to find the second largest element in an array.


            //int[] numbers = { 1, 2, 30, 3, 4, -5, 90, 8 };

            //int mx1 = numbers[0];
            //int mx2 = numbers[1];
            //if(numbers[0]< numbers[1])
            //{
            //    mx1 = numbers[1];
            //    mx2= numbers[0];
            //}
            //for (int i = 2; i <(numbers.Length); i++)
            //{
            //    if (numbers[i] >mx1 )
            //    {
            //        mx1 = numbers[i];
            //    }               
            //}
            //for (int i = 2; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > mx2 && mx1!= numbers[i])
            //    {
            //        mx2 = numbers[i];
            //    }
            //}
            //Console.WriteLine($"First max: {mx1}\nSecond Max: {mx2}");

            #endregion

            #region 25-. Consider an Array of Integer values with size N, having values as in this Example write a program find the longest distance between Two equal cells. 
            //int size;
            //Console.Write($"enter the size of the array: ");
            //size=int.TryParse( Console.ReadLine(), out size )?size:0;

            //int[] arr = new int[size];
            //Console.WriteLine("enter array numbers ");
            //// enterning the array values
            //for (int i = 0; i <size; i++)
            //{
            //    bool check = int.TryParse(Console.ReadLine(), out arr[i]);
            //    if (!check)
            //    {
            //        Console.WriteLine("you must enter an integer number");
            //    }              
            //}
            ////find longest dist
            //int LongDist = -1;

            //int len=arr.Max();
            //int[] LDistArr = new int[len+1];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    LongDist = (Array.LastIndexOf(arr, arr[i]) - Array.IndexOf(arr, arr[i]))-1;
            //    LDistArr[arr[i]]= LongDist;
            //}

            //Console.Write($"enter the value of Two equal cells to find  the longest distance between them:  ");
            //int val=int.TryParse(Console.ReadLine() ,out val)? val:0;
            //Console.WriteLine($"the longest distance of that value: {LDistArr[val]} cells! .");


            #endregion

            #region 26- Given a list of space separated words, reverse the order of the words.

            //string wordList;
            //string[] reversedList;

            //Console.WriteLine("Enter your string or list of words. ");
            //wordList = Console.ReadLine();

            //reversedList=wordList.Split(' ');
            //for (int i =reversedList.Length-1;i>0; i--)
            //{
            //    Console.Write($"{reversedList[i]} ");
            //}

            #endregion

            #region 27- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

            //int[,] ar1=new int[2,3];
            //int[,] ar2=new int[2,3];
            //Console.WriteLine("enter values of the array :  ");
            //for (int i = 0; i < ar1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < ar1.GetLength(1); j++)
            //    {
            //     ar1[i,j] = int.TryParse(Console.ReadLine(), out ar1[i,j]) ? ar1[i,j] : 0;

            //    }
            //}

            //Array.Copy(ar1, ar2, 6);
            //Console.WriteLine("here is hte ar2 after copied from ar1 .");

            //for (int i = 0; i < ar2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < ar2.GetLength(1); j++)
            //    {
            //        Console.Write($"{ar2[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}


            #endregion


            #region 28- Write a Program to Print One Dimensional Array in Reverse Order

            //int size;
            //Console.Write("Enter the size of array: ");
            //size =int.TryParse(Console.ReadLine(), out size)?size:0;
            //int[] nums=new int[size];

            //Console.WriteLine("Enter values of your array.");
            //for (int i = 0; i < size; i++)
            //{
            //    bool check=int.TryParse(Console.ReadLine(), out nums[i]);
            //    if (!check)
            //    {
            //        Console.WriteLine("you must enter integer numbers !");
            //    }

            //}

            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"{nums[size-i-1]} ");
            //}


            #endregion



            //--------------Functions------------------

            #region 1-  Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            ////passing by Value type parameters: like take a copy of variables so i need to stack fram to store these copys.
            //// suitable c# example:Swap

            //int n1 = 5;
            //int n2 = 10;
            //static void SwapFunc(int x, int y)
            //{
            //    int temp=x;
            //    x = y;
            //    y = temp;
            //    Console.WriteLine($"First num: {x}, Second num: {y}");
            //}
            //Console.WriteLine("By Value!!");
            //SwapFunc(n1, n2);
            //Console.WriteLine($"First num: {n1}, Second num: {n2}");

            ////passing by reference parameters: i put a reference of the variables means i have the address of the varables and can directly modify them 
            //static void SwapFunc2(ref int x, ref int y)
            //{
            //    int temp = x;
            //    x = y;
            //    y = temp;
            //    Console.WriteLine($"First num: {x}, Second num: {y}");
            //}
            //Console.WriteLine("By Reference!!");
            //SwapFunc2(ref n1, ref n2);
            //Console.WriteLine($"First num: {n1}, Second num: {n2}");

            #endregion

            #region 2-	Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

            int num;
            Console.WriteLine("enter a number !");
            bool check = int.TryParse(Console.ReadLine(), out num);
            if(check)
            {
                Console.WriteLine($"Sum= {SumDigit(num)}");
            }
            else
            {
                Console.WriteLine("You must enter  an integer number ");
            }

            static long SumDigit(int n)
            {
                long sum = 0;
                while (n > 0)
                {
                    int temp = n % 10;
                    n /= 10;
                    sum += temp;
                }
                return sum;
            }

            #endregion
        }
    }
}
