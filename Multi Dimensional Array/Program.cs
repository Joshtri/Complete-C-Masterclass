using System;

namespace Multi_Dimensional_Array
{
    internal class Program
    {
        static int[,] matrixs =
        {
            {1,2,3 },
            {4,5,6 }
        };
        static void Main(string[] args)
        {
            //declare 2D Array
            string[] matrix = new string[]
            {
                "ap"
            };

            //3D Array
            int[,,] ThreeD;

            //two dimensional array
            int[,] array2D = new int[,]
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };

            Console.WriteLine("Central value is {0}", array2D[0, 0]);
            Console.WriteLine("Central value is {0}", array2D[1, 1]);

            


            string[,,] Poem3D = new string[,,]
            {
                {
                    {"000","002","003"},
                    {"001","004","005"},
                    {"002","006","009"}
                }
            };

            Console.WriteLine("Central value is {0}", Poem3D[0, 0, 0]);
            Console.WriteLine("Central value is {0}", Poem3D[0, 1, 0]);
            Console.WriteLine("Central value is {0}", Poem3D[0, 1, 1]);

            Console.WriteLine("Central value is {0}", array2D[1, 1]);

            Console.ReadKey();

            ConsoleKey key = ConsoleKey.Enter;

            if (ConsoleKey.Enter == key)
            {
                Console.Clear();
            }

            else if (key != ConsoleKey.Enter)
            {
                Console.WriteLine("Fill the correct inputs.");
            }

            int[,,] Rand3D = new int[,,]
            {
                {
                    {113,145,156},
                    {141,135,212}
                }
            };



            //Console.WriteLine(Rand3D[0, 1, 0]);
            Console.WriteLine(Rand3D[0,1,2]);
            Console.WriteLine("This is our 2D array without nested for loop");
            foreach (var item in matrixs)
            {
                Console.Write(item+ " ");
            }


            Console.WriteLine("This is our 2D array printed using nested for loop.");

            for (var i = 0; i < matrixs.GetLength(0); i++)
            {
                //inner for loop.
                for (var j = 0; j < matrixs.GetLength(1); j++)
                {
                    Console.Write(matrixs[i, j]+ " ");
                }
            }

            //for (int k = 0; k < matrixs.Length; k++)
            //{
            //    Console.WriteLine(matrixs);
            //}
        }
    }
}
