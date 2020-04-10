using System;

namespace Testing
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int x = 1; x < 57; x += 5)
            {
                if (x == 1)
                {
                    Console.WriteLine(x);
                }

                if (x < 56 && x > 5)
                {
                    Console.WriteLine(Convert.ToInt32(x - 1) + ", " + x + ", ");
                }
                else if ( x == 56)
                {
                    Console.WriteLine(Convert.ToInt32(x -1));
                }
            }
            Console.ReadLine();
        }
    }
}