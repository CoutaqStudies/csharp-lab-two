using System;
namespace LabTwo
{
    public class TaskThree
    {
        public TaskThree()
        {
        }

        internal static void Do()
        {
            int count = 0;
            ulong fib = 1;
            ulong fib_old = 0;
            ulong fib_temp;
            while (true)
            {
                fib_temp = fib;
                fib += fib_old;
                fib_old = fib_temp;
                if(fib>999 && fib < 10000)
                {
                    count++;
                }else if (fib >= 10000)
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
