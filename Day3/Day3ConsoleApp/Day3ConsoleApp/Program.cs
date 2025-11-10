using System;

class Program
{
    static void Main()
    {
        PrintInfo("hemang");
        PrintInfo(100);
        //PrintInfo();
        PrintInfo(10.3);
        PrintInfo(10.55d);
        PrintInfo(10.78f);
        PrintInfo(10.89m);
        Console.WriteLine("End of line.");
    }

    static void PrintInfo(string input)

    {
        Console.WriteLine("Overload #1");
        Console.WriteLine($"Input passed is: {input}");
    }

    static void PrintInfo(int input)
    {
        Console.WriteLine("Ovearload #2");
        Console.WriteLine($"int passed is: {input}");
        Console.WriteLine($"size of integer is: {sizeof(int)}");

    }

    static void PrintInfo(double input)
    {
        Console.WriteLine("Overloading #3");
        Console.WriteLine($"double input passed is: {input} \n size of double is:{sizeof(double)}");
    }

    static void PrintInfo(decimal input)
    {
        Console.WriteLine("Overload #4");
        Console.WriteLine($"decimal input passed is: {input} \n size of double is:{sizeof(decimal)}");
    }

    //static void Printinfo()
    //{
    //    Console.WriteLine();
    //}
   
}




