using System;
namespace LabTwo
    //Written by coutaq
{
    public class TaskOne
    {
        internal static void Do()
        {
            int a, b, c;
            double x1, x2, x,y;
            Console.Write("Please enter a: ");
            while (true)
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }
            Console.Write("Please enter b: ");
            while (true)
            {
                try
                {
                    b= int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }
            Console.Write("Please enter c: ");
            while (true)
            {
                try
                {
                    c = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }
            int D = b * b - 4 * a * c;
            if (D < 0)
            {
                x = -b/2;
                y = Math.Sqrt(Math.Abs(D))/2;
                Console.WriteLine("X1: " + x + "+" + y + "i;");
                Console.WriteLine("X2: " + x + "-" + y + "i;");
            }
            else if(D == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("X: "+x1);
            }
            else
            {
                x1 = (-b + Math.Sqrt(D))/(2*a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("X1: " + x1);
                Console.WriteLine("X2: " + x2);
            }
        }
    }
}
