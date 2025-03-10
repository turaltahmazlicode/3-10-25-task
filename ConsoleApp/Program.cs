using Microsoft.VisualBasic.FileIO;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace ConsoleApp
{
    internal class Program
    {
        #region task1
        //4. 1 - den 100 - e qeder ededler arasinda cut ededleri tapan alqoritm yazirsiz. (hem for loop, hem while)
        private static void task1()
        {
            {
                Console.WriteLine("method 1 (while)");
                sbyte i = 1;
                while (i <= 100)
                {
                    if (i % 2 == 0)
                        Console.Write($"{i} ");
                    i++;
                }
                Console.WriteLine('\n');

                Console.WriteLine("method 2 (while)");
                i = 2;
                while (i <= 100)
                {
                    Console.Write($"{i} ");
                    i += 2;
                }
                Console.WriteLine('\n');
            }

            Console.WriteLine("method 1 (for)");
            for (sbyte i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                    Console.Write($"{i} ");
            }
            Console.WriteLine('\n');

            Console.WriteLine("method 2 (for)");
            for (sbyte i = 2; i <= 100; i += 2)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine('\n');
        }
        #endregion



        #region task2
        //5.Array daxilinde yalniz sade ededleri capa veren alqoritm yazirsiz(hem for loop, hem while))
        private static bool IsPrimeFor(int num)
        {
            int absNum = Math.Abs(num);
            if (absNum == 1 || absNum == 0)
                return false;
            int length = (int)Math.Sqrt(absNum);
            for (int i = 2; i <= length; i++)
                if (num % i == 0)
                    return false;
            return true;
        }
        private static bool IsPrimeWhile(int num)
        {
            int absNum = Math.Abs(num);
            if (absNum == 1 || absNum == 0)
                return false;
            int length = (int)Math.Sqrt(absNum);
            int i = 2;
            while (i <= length)
            {
                if (num % i == 0)
                    return false;
                i++;
            }
            return true;
        }
        private static void task2()
        {
            int[] arr = new int[20];
            Console.Write("Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(0, 100);
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine('\n');

            Console.Write("Prime array (for): ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrimeFor(arr[i]))
                    Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();

            {
                Console.Write("Prime array (while): ");
                int i = 0;
                while (i < arr.Length)
                {
                    if (IsPrimeWhile(arr[i]))
                        Console.Write($"{arr[i]} ");
                    i++;
                }
                Console.WriteLine();
            }
        }
        #endregion
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("task1");
            Console.ForegroundColor = ConsoleColor.Gray;
            task1();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("task2");
            Console.ForegroundColor = ConsoleColor.Gray;
            task2();
        }
    }
}
