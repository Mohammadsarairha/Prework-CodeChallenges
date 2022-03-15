using System;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int Scoring(int[] arr, int num)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    count++;
                }
            }

            return num * count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please chosee number");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int [size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Please enter number  {i+1} / {arr.Length}");
                arr [i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Please choose number {string.Join(",", arr)}");
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Your score is {Scoring(arr, num)}");
        }
    }
}
