using System;

namespace Implicit_and_Explicit_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implicit and explicit conversion

            //implicit. 
            int num = 234;
            long bignum = num;

            float floatnum = 34.4f;
            double doublenum = 34.2d;


            //explicit. 
            int myint;

            myint = (int)bignum;
            Console.WriteLine(myint);


            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            int numerics = int.Parse(stringForInt);
            float ss = float.Parse(stringForFloat); 


            

            
            

        }
    }
}
