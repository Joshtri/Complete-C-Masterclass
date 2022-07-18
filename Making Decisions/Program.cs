using System;

namespace Making_Decisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Logic and if statement.
            //Doing the temp weather. 


            int TempInput = 0 ;



            try
            {
                 Console.Write("Input the temp : ");
                 TempInput = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Input the number contains temp.");
            }
            finally
            {
                // if con if is true, so the other code cannot be true. so we should make it else if condts.
                if (TempInput < 10)
                {
                    Console.WriteLine("Use a coat"); 
                }

                else if (TempInput == 10)
                {
                    Console.WriteLine("Apa dah ");
                }

                else if (TempInput > 20)
                {
                    //Console.WriteLine("You dont have to wear a coat.");
                    Console.WriteLine("Shorts pants are enough for today");
                }
            }
            Console.Read();
            */

            /*
            //how about TryParse ==> Parsed is "menguraikan"
            string Numstring = "1283343434343434343434343434343434";
            int ParsedNum;

            bool? Success = int.TryParse(Numstring, out ParsedNum); // the returned boolean is true when parsing is success. 

            Console.WriteLine(Success);
            Console.WriteLine(ParsedNum);

            Console.Read();
            */

            //if and else if + TryParse.
            /*
            Console.Write("input your weight : ");
            string Weight = Console.ReadLine();

            int NumWeight =  0;
            int Heavy = 0 ; 

            if (int.TryParse(Weight, out NumWeight))
            {
                Heavy = NumWeight; 
            }
            Console.WriteLine(Heavy);
            */

            /*
            //Nested if statements.
            bool isadmin = false;
            bool isregistered = true;

            string Username = "";

            Console.Write("Please enter your name : ");
            Username = Console.ReadLine();
            if (isregistered)
            {
                Console.WriteLine("Hi There registered user");
                if (Username != "" || Username == "admin" )
                {
                    Console.WriteLine($"Hi there {Username}!");
                    if (Username.Equals("admin"))
                    {
                        Console.WriteLine($"Hi there {Username}!");
                    }
                }
            }
            */

            

            



        }
        public static void Check(int number)
        {
            // TODO
            if (number % 2 == 0 )
            {
                Console.WriteLine("Even");
            }
            else if (number % 2 != 0 )
            {
                Console.WriteLine("Odd");
            }
        }

        public static void NestedCheck(int number)
        {
            if (number % 3 == 0)
            {
                Console.WriteLine("Divisible by 3.");
            }

            else if (number % 7 == 0)
            {
                Console.WriteLine("Divisible by 7.");
            }

            else
            {
                if (number % 2 != 0)
                {
                    Console.WriteLine("Odd Number");
                }
                else
                {
                    Console.WriteLine("Even Number");
                }
            }
        }

    }
}
