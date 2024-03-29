﻿using System;
namespace LabTwo
{
    public class TaskFive
    {
        public TaskFive()
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
                    if (n < 0)
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
            Boolean comb = false;
            for(int i = 0; i <= n; i++)
            {
                for(int j = 0; j <= n; j++)
                {
                    for(int k = 0; k <= n; k++)
                    {
                        if((Math.Pow(i, 3) + Math.Pow(j, 3) + Math.Pow(k, 3) == n))
                        {
                            Console.WriteLine("x: " + i+"; y: "+j+"; z: "+k+";");
                            comb = true;
                        }
                    }
                }
            }
            if (!comb)
            {
                Console.WriteLine("No such combinations!");
            }
        }
    }
}
