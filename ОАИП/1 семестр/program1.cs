using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void task1()
        {
            int n = int.Parse(Console.ReadLine());

            int count = 0;
            int maxCount = 0;

            for (int i = 0; i < n; i++)
            {
                int num = Math.Abs(int.Parse(Console.ReadLine()));
                if (num % 2 == 0)
                {
                    count++;
                }
                else
                {
                    maxCount = Math.Max(maxCount, count);
                    count = 0;
                }
            }


            //дз 2
            static void task2()
            {
                int n = int.Parse(Console.ReadLine());

                int count = 0;
                int length = 0;
                int currSum = 0;
                int maxSum = 0;

                for (int i = 0; i < n; i++)
                {
                    int num = Math.Abs(int.Parse(Console.ReadLine()));

                    if (num % 2 == 0)
                    {
                        currSum += num;
                        count++;
                    }
                    else
                    {
                        length = (currSum > maxSum) ? count : length;
                        maxSum = Math.Max(maxSum, currSum);
                        currSum = 0;
                        count = 0;

                    }
                }

                Console.WriteLine(length);
            }


            //дз3
            static void task3()
            {
                int n = int.Parse(Console.ReadLine());

                int curr = int.Parse(Console.ReadLine());
                int next;

                int count = 1;
                int minLen = 9999;

                for (int i = 0; i < n - 1; i++)
                {
                    next = int.Parse(Console.ReadLine());

                    if (next == curr)
                    {
                        count++;
                    }
                    else
                    {
                        minLen = Math.Min(minLen, count);
                        count = 1;
                    }

                    curr = next;

                }
                minLen = Math.Min(minLen, count);
                Console.WriteLine(minLen);
            }
            static void Main(string[] args)
            {
                task1();
                task2();
                task3();
            }
        }
    }
}
