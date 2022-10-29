using System;

namespace Drawing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter height: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write(" ");
                }
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
