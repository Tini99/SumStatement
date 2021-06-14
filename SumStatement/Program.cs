using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number1, sum;
            sum = 0;

            for (Number1 = 1; Number1 <= 500; Number1 = Number1 + 1)
            {
                if (Number1 % 5 == 0)
                {
                    Console.WriteLine(Number1);
                    sum = sum + Number1;
                }
            }
            Console.WriteLine("sum of first 500 numbers those are divided by 5 are =" + sum.ToString());
        }
    }
}
