using System;

namespace String_Manipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int age = 23;
            string name = "Alberto Lamberts";

            //1. string concatination. 
            Console.WriteLine("hello, my name is "+name+" and my age is "+age);

            //2. string formatting ==> use an index. 
            Console.WriteLine("hello, my name is {0} and my age is {1}",name,age);

            //3. string interpolation ==> use a dollar $
            Console.WriteLine($"hello, my name is {name} and my age is {age}");

            //4. Verbatim strings ==> starting by using @
            Console.WriteLine(@"");


            //some string methods. 

            /*string is an object of the System.String class. Here in programming terms 
             * string means sequence of characters
             * Function of the String class are used to manipulate and to perfomr various
             * actions on a given string
             */

            string myName;
            Console.Write("Please enter your name and  press enter : ");
            myName = Console.ReadLine();

            string UpperCasing = String.Format("Upper case : {0}",myName.ToUpper());
            string LowerCasing = String.Format("Upper case : {0}", myName.ToLower());
            string Trimming = String.Format("Trimmed : {0}",myName.Trim());
            string Subsstringname = String.Format("Subsiding name : {0}", myName.Substring(0));


            //challenge 2. 

            Console.Write("Enter a string here : ");
            string InputsName = Console.ReadLine();


            Console.Write("Enter the characters to search : ");
            char search = Console.ReadLine()[0];
            
            var finding = InputsName.IndexOf(search);

          
           

           

            //final write. 
            Console.WriteLine();

        }
    }
}
