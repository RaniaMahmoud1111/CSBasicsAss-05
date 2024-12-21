namespace CSBasicsAss_05
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


        }
    }
}
