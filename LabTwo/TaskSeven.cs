using System;
namespace LabTwo
{
    public class TaskSeven
    {
        public TaskSeven()
        {
        }

        internal static void Do()
        {
            double a, b;
            Console.Write("Please enter a: ");
            while (true)
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                    if (a < 0)
                    {
                        throw new FormatException();
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.Write("Error!");
                }
            }
            Console.Write("Please enter b: ");
            while (true)
            {
                try
                {
                    b = int.Parse(Console.ReadLine());
                    if (b < 0)
                    {
                        throw new FormatException();
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.Write("Error!");
                }
            }
            if (a < b)
            {
                Console.WriteLine(Math.Sqrt(a));
            }
            else
            {
                Console.WriteLine(Math.Sqrt(b));
            }
        }
    }
}
