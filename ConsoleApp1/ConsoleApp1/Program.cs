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

        static void Main(string[] args)
        {
            Console.WriteLine("Please chosee number");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Please enter number  {i + 1} / {arr.Length}");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(string.Join(",", arr));
            if(PerfectSequences(arr) == "yes")
            {
                Console.WriteLine("Yes Its Perfect Sequences");
            }
            else
            {
                Console.WriteLine("Its not Perfect Sequences");
            }

        }
    }
}
