using System;

namespace Login_System
{
    internal class Program
    {
        public static string Username;
        public static string Password;
        static void Main(string[] args)
        {
            Console.WriteLine("Register\n");
            Register();

            Console.WriteLine("\nLogin\n");
            Login();

        }

        public static void Register()
        {
            Console.Write("Please enter the username :");
            Username = Console.ReadLine();

            Console.Write("Please enter the password : ");
            Password = Console.ReadLine();
        
        }

        public static void Login()
        {
            Console.Write("Please enter the username :");
            bool NameUserRight = Username == Console.ReadLine();
            bool NameUserFalse = Username != Console.ReadLine();

            if (NameUserRight)
            {
                Console.Write("Please enter the password : ");
                bool PasswordUserRight = Password == Console.ReadLine();
                bool PasswordUserFalse = Password != Console.ReadLine();

                if (PasswordUserRight && NameUserRight)
                {
                    Console.WriteLine("Welcome to the program. ");
                }

                else if (NameUserFalse && PasswordUserFalse)
                {
                    Console.WriteLine("Input the correct data.");
                }
            }

          
        }
    }
}
