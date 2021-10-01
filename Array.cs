using System;

namespace Array_N
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. Single Dimentional Array

            int[] arr1 = new int[5];
            arr1[0] = 10;
            arr1[1] = 20;
            arr1[2] = 30;

            int[] arr2 = new int[5] { 10, 20, 30, 40, 50 };
            int[] arr3 = new int[] { 10, 20, 30, 40, 50 };


            2. Multi Dimentional Array

            int[,] arr1 = new int[2, 3] { { 1, 2, 3 }, { 11, 12, 13 } };

            int[,] arr2 = new int[,] { { 1, 2, 3 }, { 11, 12, 13 } };

            int[,] arr3 = new int[2, 3];
            arr3[0, 0] = 1;
            arr3[0, 1] = 2;


            3. Jagged Array

                  int[][] arr = new int[3][];
            arr[0] = new int[3] { 1, 2, 3};
            arr[1] = new int[2] { 10, 20 };
            arr[2] = new int[2] { 10, 40 };
            */

            /*
            int[] arr = new int[] { 74, 5, 1, 88, 2, 36 };

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(arr[i]);
            }

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            */

            /*
            int[,] arr = new int[3, 4] { { 1, 2, 3, 4}, { 10, 20, 30, 40}, {11, 22, 33, 44 } };

            for (int i=0; i<3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            */

            int[][] arr = new int[3][];
            arr[0] = new int[3] { 1, 2, 3 };
            arr[1] = new int[2] { 10, 20 };
            arr[2] = new int[2] { 10, 40 };

            foreach (int[] i in arr)
            {
                foreach (int j in i)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

           // foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
           // }
           // Console.WriteLine();

        }
    }
}
