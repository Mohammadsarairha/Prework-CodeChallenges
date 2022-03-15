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

        public static void LeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine($"{year} is Leap year ");
            }
            else
            {
                Console.WriteLine($"{year} is not Leap year ");
            }
        }

        public static string PerfectSequences(int[] arr)
        {
            int sum = 0;
            int check = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    sum += arr[i];
                }
                else
                {
                    return "no";
                }
            }
            if (sum == 0)
            {
                return "yes";
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    continue;
                }
                else if (sum % arr[i] == 0)
                {
                    check += 1;
                }
                else
                {
                    return "no";
                }
            }
            return check >= 1 ? "yes" : "no";
        }

        public static int[] SumofRows(int[,] myArray)
        {

            int[] sum = new int[myArray.GetLength(0)];
            int total = 0;
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    total += myArray[i, j];
                }
                sum[i] = total;
                total = 0;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            Console.WriteLine($"Sum = {string.Join(",", SumofRows(myArray))}");

        }
    }
}
