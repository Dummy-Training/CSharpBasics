using System;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main()
    {
        string[] sumArray = { "11.2", "20.2", "30.1" };


        if (sumArray.Length < 1)
        {
            Console.WriteLine("Please enter some numbers:");
        }

        float sum = 0;
        float[] numbers = new float[sumArray.Length];

        for (int i = 0; i < sumArray.Length; i++)
        {
            sum = sum + float.Parse(sumArray[i]);
            numbers[i] = float.Parse(sumArray[i]);

        }
        Console.WriteLine("Sum of Float numbers is:" + sum);

        float max = numbers[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            //if (numbers[i]) > max)
            float v = numbers[i];
            if (v > max)
            {
                max = numbers[i];
            }
        }
    
        Console.WriteLine("Maximum value:" + max);
        Console.WriteLine("End of Line.");
    }
    

           
}




