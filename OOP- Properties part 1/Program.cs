using System;

namespace OOP__Properties_part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box bx = new Box();

            bx.volume = 0;
            bx.height = 0;
            bx.width = 0;

            bx.SetLength(3);

            Console.WriteLine(bx.GetLength());
            Console.WriteLine("Hello World!");
        }
    }
}
