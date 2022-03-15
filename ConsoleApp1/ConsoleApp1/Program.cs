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

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter year");
            int year = Int32.Parse(Console.ReadLine());
            LeapYear(year);
        }
    }
}
