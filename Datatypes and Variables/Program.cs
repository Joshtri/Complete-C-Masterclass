using System;

namespace Datatypes_and_Variables
{
	internal class Program
    {
        static void Main(string[] args)
        {
            //Datatypes.
            /*
			int a = 23;
			int b = 40;
			int sum = a + b;

			//using concatination.
			Console.WriteLine("a = "+ a + "b = "+ b +" sum = "+ sum);
			// Console.Read();

			//

			string myname = "Denis";

			string message = "My name is " + myname;

			string capsMessage = message.ToUpper();

			string lowerCaseMessage = message.ToLower();


			// Console.WriteLine(lowerCaseMessage);

			


			//Console.Write("Enter a characters : ");
			//char charac = Console.ReadLine()[0];

			//int asciinum = charac;

			//ASCI
            Console.Write("input long arrray do you want : ");
			int n = int.Parse(Console.ReadLine());

			char[] characters = new char[n];


            Console.WriteLine("\n");
			for (int i = 0; i < characters.Length; i++)
			{
				Console.Write($"data {i} :");
				characters[i] = Console.ReadLine()[0];

            }

			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Array.ForEach(characters, charac => Console.WriteLine(charac));
			Console.ResetColor();


            Console.WriteLine("Do you want to show the ASCII code ? (y/n) :");
			char option = Console.ReadLine()[0];


            switch (option)
            {
				case 'y':
                    for (int i = 0; i < characters.Length; i++)
                    {
						int asciinum = characters[i];
                        Console.WriteLine($"Input {i} : {characters[i]} {asciinum}");
                    }

					goto last;
				case 'n':
                    Console.WriteLine("click enter to get in another program....");
					ConsoleKey key = Console.ReadKey().Key;

					if (key == ConsoleKey.Enter) 
                    {
						goto second;
                    }
					break;
                default:
                    break;
            }

				second:
			*/

            Console.WriteLine();
            char[] PersonName = new char[] { 'a', 'r', 'p', 'a', 'k', 'h', 's', 'a', 'd' };

            
				
			//int iteration = 0;
            //while (iteration < PersonName.Length)
            //         {
            //             Console.Write($"char {iteration} : ");
            //	PersonName[iteration] = Console.ReadLine()[0];
            //	iteration++; 
            //         }

            CharNames(PersonName);


            //Console.WriteLine("ASCII of char that you input ({0}) is : {1}", charac, asciinum);

			//last:

			Console.WriteLine("End\n");
			 
            Console.Read();
		}

		private Char InputChar(char[] chars)
        {
            for (int i = 0; i < chars.Length; i++)
            {
				//this is for inputing the char, maybe you could input your name. 
                Console.Write($"input the char {i} : ", Char.ToUpper(chars[i]));
				chars[i] = Console.ReadLine()[0];
            }

			return 'A';
        }
		private static void CharNames(char[] PersonName)
		{
			
			Console.WriteLine("1.Upper case\n2.Lower case");
            Console.Write("CHOOSE : ");
			int Optional = int.Parse(Console.ReadLine());

			if (Optional == 1)
			{
				for (int i = 0; i < PersonName.Length; i++)
				{
					int asciinum = PersonName[i];

                    PersonName[i] = char.ToUpper(PersonName[i]);
                    Console.WriteLine($"{PersonName[i]} : {asciinum}" );
				}
				string Names = new string(PersonName);

				Console.WriteLine($"Name : {Names}");
			}

            else if (Optional == 2)
            {
				for (int i = 0; i < PersonName.Length; i++)
				{
					int asciinum = PersonName[i];

					PersonName[i] = char.ToLower(PersonName[i]);
					Console.WriteLine($"{PersonName[i]} : {asciinum}");
				}
				string Names = new string(PersonName);

				Console.WriteLine($"Name : {Names}");
			}

			

		}
    }
}
