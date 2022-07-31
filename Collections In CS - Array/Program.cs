    //array, arraylist, and list. 

//give an output ODD and EVEN number. 
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//GetOdd(array);
//GetEven(array);


Console.Write("Enter a value :");
string? Inputing = Console.ReadLine();



Console.Write("Select datatype : ");
int? Num = int.Parse(Console.ReadLine()!);
string[] ListOption = new string[] { "1. String", "2. Integer", "3. Boolean" };



try
{
    if (Num == 1 && Num != null)
    {
        Console.WriteLine("");
    }
}
catch
{
    Console.WriteLine("Fill the number right!");
    throw;
}

foreach (string k in ListOption)
{
    Console.WriteLine(k);
}
 
switch (Num)
{
    case 1:
        Console.WriteLine("You have entered a value: {0}",Inputing);
        Console.WriteLine("It's a valid string  {0}", Inputing!.GetTypeCode());
        break;
    case 2:
        Console.WriteLine(" ");
        break;
    case 3:
        break;
    default:
        break;
}



#pragma warning disable CS8321 // Local function is declared but never used
static void GetOdd(int[] Array)
{
    // TODO
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] % 2 != 0)
        {
            Console.WriteLine(Array[i]);
        }
    }
}
#pragma warning restore CS8321 // Local function is declared but never used

#pragma warning disable CS8321 // Local function is declared but never used
static void GetEven(int[] Array)
{
    // TODO
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] % 2 == 0)
        {
            Console.WriteLine(Array[i]);
        }
    }
}
#pragma warning restore CS8321 // Local function is declared but never used

//The right answer !!!. 

Boolean valid = false; 