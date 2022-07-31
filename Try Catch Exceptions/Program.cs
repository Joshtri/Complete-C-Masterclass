using System;


namespace Try_Catch_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            inputmenu: 
            Console.Write("Masukkan angka : ");
            string inputstringnum = Console.ReadLine();

            try
            {
                int getintegernum = int.Parse(inputstringnum);
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\tMasukkan data berupa angka :) \n");
                Console.ResetColor();
                goto inputmenu;

            }
            Console.Read();
        }
    }
}
