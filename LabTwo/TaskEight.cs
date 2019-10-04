using System;
namespace LabTwo
{
    public class TaskEight
    {
        public TaskEight()
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
                    if (n < 1 && n > 10000)
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
            for(int i = 1; i <= n; i+=2)
            {
                if (n % i == 0 )
                {
                        Console.WriteLine(i);
                }
            }
            Boolean a  = true;
            switch (a)
            {
                default:
                    break;
            }
        }
    }
}