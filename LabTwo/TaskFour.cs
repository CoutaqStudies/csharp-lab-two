using System;
using System.Globalization;

namespace LabTwo
{
    public class TaskFour
    {
        public TaskFour()
        {
        }
        internal static void Do()
        {
            double x, q;
            double cos = 1;
            Console.Write("Please enter x: ");
            while (true)
            {
                try
                {
                    x = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }
            Console.Write("Please enter q: ");
            while (true)
            {
                try
                {
                    q = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    break;
                }
                catch (FormatException)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }
            int i = 0;
            while (true)
            {
            i++;
                double num = Math.Pow(x, 2 * i) / Factorial(i * 2);
                if (i % 2 != 0)
                {
                    cos -= num;
                }
                else
                {
                    cos += num;
                }
                if (Math.Abs(num) < q)
                {
                    break;
                }
            }
            Console.WriteLine("cos(" + x + ") = " + cos);
        }
        public static ulong Factorial(int ff)
        {
            ulong f = 1;
            for (int i = 1; i <= ff; i++)
                f = f * (ulong)i;
            return f;
        }
    }
}
