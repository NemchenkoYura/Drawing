using System;

namespace yg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter height: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("_");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
