

using System;
using System.Runtime.Intrinsics.X86;

class Program
{

    static void Main(string[] sumArray)
    {
        //string[] sumArray = { "10", "20", "30" };
       
        if (sumArray.Length < 1)
        {
            Console.WriteLine("Please pass some arguments.");
        }

        int sum = 0;
        int avg = 0;

        for (int i = 0; i < sumArray.Length; i++)
            {
                sum = sum + int.Parse(sumArray[i]);
               
        }
        Console.WriteLine("Sum of the Numbers is:" + sum);

        if (sumArray.Length > 1)
        {
            avg = sum / sumArray.Length;
            Console.WriteLine("Avg of the Numbers is:" + avg);
        }
        Console.WriteLine("Avg of the Numbers is:" + avg);

        Console.WriteLine("End of Line");

        

        
    }

}

    



