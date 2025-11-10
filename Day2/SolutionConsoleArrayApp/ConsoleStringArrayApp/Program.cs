using System;

class Program
{
    static void Main(String[] Names)
    {
        //String[] Names = { "I", "AM", "LEARNINGG", "DOTNET" };

        if (Names.Length < 5)
        {
            Console.WriteLine("Please provide atleast 5 names.");
        }

        else
        {
            foreach (String x in Names)
            {
                if (x.Length > 8)
                {
                    Console.WriteLine("Names wih more than 8 character are:" + x);

                }
                else if (x.Length < 8)
                {
                    Console.WriteLine("Names with less than 8 characters are:" + x);
                }
            }
        }    
        
        Console.WriteLine("End of Line.");
    }
}
