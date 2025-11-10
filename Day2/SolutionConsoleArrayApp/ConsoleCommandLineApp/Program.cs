
using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;
class Program
{

    static void Main(string[] usernames)
    {
        foreach (string p in usernames)
        {
            Console.WriteLine(p);
        }

        //if (usernames.Length == 2) 
       // {
       //     string username
       // PrintNameNTimes("Hemang",10);


    }

    static void PrintNameNTimes(string name, int times)
    {
        for (int Counter = 0; Counter <= 10; Counter++)
        {
            Console.WriteLine(name.ToUpper() + ":" + Counter);
        }
            
    }
}
