using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = CreateArr(4, 4);
            Print(arr1);
            int[] arr2 = GetDiagonal(arr1);
            int max = GetMaxOffDiagonal(arr2);
            Print("Max off diagonal = ", max);
            Console.ReadKey();
        }
        /// <summary>
        /// Creating two-dimensional array
        /// </summary>
        /// <param name="height"> array size of Int32 type</param>
        /// <param name="width">array size of Int32 type</param>
        /// <returns></returns>
        public static int[,] CreateArr(int height, int width)
        {
            Random rnd = new Random();
            int[,] arr = new int[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    arr[i, j] = rnd.Next(10, 99);
                }
            }
            return arr;
        }

        /// <summary>
        /// Findes max element
        /// </summary>
        /// <param name="arr">given max element of Int32 type</param>
        /// <returns></returns>
        public static int GetMax(int[,] arr)
        {
            int max = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        arr[i, j] = max;
                    }
                }
            }
            return max;

        }
        /// <summary>
        /// Findes min element
        /// </summary>
        /// <param name="arr">given min element of Int32 type</param>
        /// <returns></returns>
        public static int GetMin(int[,] arr)
        {
            int min = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < min)
                    {
                        arr[i, j] = min;
                    }
                }
            }
            return min;
        }
        /// <summary>
        /// Findes indexes of the max element
        /// </summary>
        /// <param name="arr">type of Int32</param>
        /// <returns>Return indexes of the max element</returns>
        public static int MaxIndex(int[,] arr)
        {
            int maxIndexI = 0;
            int maxIndexJ = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > arr[maxIndexI, maxIndexJ])
                    {
                        maxIndexI = i;
                        maxIndexJ = j;
                    }
                }

            }
            return maxIndexI; return maxIndexJ;
        }
        /// <summary>
        /// Findes indexes of the min element
        /// </summary>
        /// <param name="arr">type of Int32</param>
        /// <returns>return indexes of the max element</returns>
        public static int MinIndex(int[,] arr)
        {
            int minIndexI = 0;
            int minIndexJ = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < arr[minIndexI, minIndexJ])
                    {
                        minIndexI = i;
                        minIndexJ = j;
                    }
                }
            }
            return minIndexI; return minIndexJ;
        }
        /// <summary>
        /// Find diagonal elements ot two-dimensional array
        /// </summary>
        /// <param name="arr">any array of Int32 type</param>
        /// <returns>Return two-dimensional elements of array </returns>
        public static int[] GetDiagonal(int[,] arr)
        {
            int[] diagonal = new int[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                diagonal[i] = arr[i,i];
            }

            return diagonal;
        }
        /// <summary>
        /// Find max of diagonal elements
        /// </summary>
        /// <param name="arr"given any value of Int32 type
        /// <returns>return max of diagonal elements
        public static int GetMaxOffDiagonal(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        /// <summary>
        ///  Find min of diagonal elements
        /// </summary>
        /// <param name="arr">given any value of Int32 type</param>
        /// <returns>return min of diagonal elements      
        public static int GetMinOffDiagonal(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        /// <summary>
        /// Print two-dimensional array elements
        /// </summary>
        /// <param name="arr">two-dimensional elements of Int32 type</param>
        public static void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Print diagonal of two-dimensonal array
        /// </summary>
        /// <param name="arr">given array of Int32 type</param>
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}  ");
            }
        }
        /// <summary>
        /// Print name and value   
        /// </summary>
        /// <param name="name">given any string</param>  
        /// <param name="value">given any value of Int32 type</param>
        public static void Print(string name, int value)
        {
            Console.WriteLine($"{name} {value}");
        }
    }
}

