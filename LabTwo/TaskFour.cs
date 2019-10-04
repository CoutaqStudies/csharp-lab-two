using System;
namespace LabTwo
{
    public class TaskFour
    {
        public TaskFour()
        {
        }

        internal static void Do()
        {
            int q;
            double x;
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
                    q = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }
            for (int i = 0; i < q; i++)
            {
                double num = Math.Pow(x, 2 * i) / Factorial(i * 2);
                if (Math.Abs(num) < q)
                {
                    Console.WriteLine("q: " +i+1);
                    break;
                }
                if (i % 2 == 0)
                {
                    cos -= num;
                }
                else
                {
                    cos += num;
                }
            }
            Console.WriteLine("cos(" + x + ") = " + cos);
        }
        public static int Factorial(int number)
        {
            int result = 1;
            while (number != 1)
            {
                result *= number;
                number -= 1;
            }
            return result;
        }
    }
}
