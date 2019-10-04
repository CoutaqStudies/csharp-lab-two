using System;
namespace LabTwo
{
    public class TaskSix
    {
        public TaskSix()
        {
        }
        internal static void Do()
        {
            int n;
            Console.Write("Please enter n: ");
            while (true)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n < 1 && n > 100)
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
            if (n%10 == 1)
            {
                Console.WriteLine(n + " год.");
            }
            else if (n%10>=5)
            {
                Console.WriteLine(n + " лет.");
            }
            else
            {
                Console.WriteLine(n + " года.");
            }
        }
    }
}
