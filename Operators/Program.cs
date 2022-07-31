using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 3;
            int num2 = 6;
            int num3 = 5;


            //unary operators.
            var tempnum = -num1;
            Console.WriteLine(tempnum);

            bool issunnyy = true;
            Console.WriteLine("is it sunny ? {0} ", !issunnyy);


            //increment operator. 
            int adding = 0;
            adding++;
            Console.WriteLine(adding);

            //decrement operator.
            int subtraction = 2;
            Console.WriteLine(subtraction);


            //pre increment. 
            subtraction--;
            Console.WriteLine(subtraction);


            //relational and type operators.
            bool IsLower;

            IsLower = adding < subtraction;

            Console.WriteLine(IsLower);

            //equality operator. 
            bool IsEquals;

            IsEquals = num1 == num2;

            //conditional operator


        }
    }
}
