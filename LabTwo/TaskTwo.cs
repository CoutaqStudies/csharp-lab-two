using System;
namespace LabTwo
{
    public class TaskTwo
    {
        public TaskTwo()
        {
        }

        internal static void Do()
        {
            int a;
            double pi = 1;
            Console.Write("Please enter your number: ");
            while (true)
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                    if (a <= 0)
                    {
                        throw new FormatException();
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }
            for(int i = 1; i <= a; i++)
            {
                if (i % 2 == 0)
                {
                    pi += Math.Pow(i * 2 + 1, -1);
                }
                else
                {
                    pi -= Math.Pow(i * 2 + 1, -1);
                }
            }
            pi *= 4;
            Console.WriteLine("Pi = "+pi);
        }
    }
}
