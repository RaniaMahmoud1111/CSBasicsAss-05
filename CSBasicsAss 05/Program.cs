﻿namespace CSBasicsAss_05
{
    internal class Program
    {
        static void Main(string[] args)
        {

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




        }
    }
}
