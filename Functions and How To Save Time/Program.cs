using System;

namespace Functions_and_How_To_Save_Time
{
    internal class Program
    {
        //
        public static void Main(string[] args)
        {
            /*
            var FirstName = "Arpakhsad";
            var LastName = "Lenggu";

            var Names = String.Join("U+002C", FirstName, LastName);

            string FullName = String.Format(Names);
            Writing();
            WritingText(FullName);


            int a = 3;
            int b = 4;

            var results = Multiply(a, b);

            Console.WriteLine(results);
            

            string[] names = new string[] { "Frank", "Michael", "Eric" };

            GreetFriend(names[0], names[1], names[2]);

            */
            // We encourage you to test your code with different strings,
            // but don't forget to put the default string back at the end of your testing.
            string s = "HeY ThErE !";

            /// Change nothing down here 
            s = LowUpper(s);
            Console.WriteLine(s);
            Count(s);



            Console.Read();
        }

        public static void GreetFriend(string Name1, string Name2, string Name3)
        {
            
            Console.WriteLine("Hi {0}, my friend!",Name1);
            Console.WriteLine("Hi {0}, my friend!", Name2);
            Console.WriteLine("Hi {0}, my friend!", Name3);

        }



        //apabila methodnya hanya void (tanpa static), maka pada main program tidak terbaca. 
        public static void Writing() => Console.WriteLine("i wrote anything i want.");

        //With parameter.
        public static void WritingText(string text) => Console.WriteLine(text);

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        // Place for your methods
        public static string LowUpper(string s)
        {
            return s.ToLower() + s.ToUpper();
        }

        public static void Count(string s)
        {
            Console.WriteLine("The amount of the characters : {0}", s.Length);
        }

    }
}
