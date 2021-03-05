using System;
using System.Collections.Generic;
namespace SnailSort
{
    class Program
    {
        public static int[] Snail(int[][] array)
        {
            if (array == null || array.Length == 0)
                return Array.Empty<int>();
            else if (array.Length == 1)
                return array[0];
            var output = new List<int>();
            int i = 0, j = 0, n = array.Length, count = 0, step = 1;
            while (count < n * n)
            {
                while (j <= n - step)
                {
                    output.Add(array[i][j]);
                    count++;
                    if (count == n * n) return output.ToArray();
                    if (j == n - step)
                    {
                        i++;
                        break;
                    }
                    j++;
                }
                while (i <= n - step)
                {
                    output.Add(array[i][j]);
                    count++;
                    if (count == n * n) return output.ToArray();
                    if (i == n - step)
                    {
                        j--;
                        break;
                    }
                    i++;
                }
                while (j >= step - 1)
                {
                    output.Add(array[i][j]);
                    count++;
                    if (count == n * n) return output.ToArray();
                    if (j == step - 1)
                    {
                        i--;
                        break;
                    }
                    j--;
                }
                while (i >= step)
                {
                    output.Add(array[i][j]);
                    count++;
                    if (count == n * n) return output.ToArray();
                    if (i == step)
                    {
                        j++;
                        break;
                    }
                    i--;
                }
                step++;
            }
            return output.ToArray();
        }
        static void Main(string[] args)
        {
            var arr = new int[][] { Array.Empty<int>() };
            //var arr = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } };
            //var arr = new int[][] { new int[] { 1, 2, 3}, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
            //var arr = new int[][] { new int[] { 1, 2, 3, 4}, new int[] { 5, 6, 7, 8 }, new int[] { 9, 10, 11, 12 }, new int[] { 13, 14, 15, 16 } };
            var array = Snail(arr);
            for (int i=0; i<array.Length;i++)
                Console.Write("{0} ",array[i]);
        }
    }
}
