using System;
using System.Threading.Tasks.Dataflow;
class Program
{
    static void Main()
    {
        Console.WriteLine("WELCOME TO ARRAY PROGRAM");
        //CaseStudy1();
        //CaseStudy2();
        //CaseStudy3();
        CaseStudy4();

                //int age = 35;
        //string name = "Sachin";
        //Console.WriteLine("Player name is " + name);
        //Console.WriteLine("Player age is " + age);
        //Console.Write("Player name is " + name);
        //Console.Write(", Player age is " + age);
        //Console.Write("\n" + "End of program");

    }

    static void CaseStudy3()
    {
        int[] ages = { 1, 2, 3, 4, 5, 6, };
        
        //for loop : for (initializaion;conditions;increment)
        for(int i = 0;i<ages.Length;i++)
        {
            Console.WriteLine(ages[i]);
        }

    }

    static void CaseStudy4()
    {
        string[] userNames = { "A", "B", "C", "D" };
        foreach (string temp in userNames)
        {
                        Console.WriteLine(temp); 
        }

    }

    static void CaseStudy2()
    {
        int[] ages = { 1, 2, 3, 4 };
        Console.WriteLine(ages.Length+ " Length of array" );
        Console.WriteLine("Age 1:" + ages[0]);//hardcoded
        Console.WriteLine(ages[1]);
        Console.WriteLine(ages[2]);
        Console.WriteLine(ages[3]);

    }
    static void CaseStudy1()
    {
        int age = 35;
        string name = "Sachin";
        Console.WriteLine("Player name is " + name);
        Console.WriteLine("Player age is " + age);
    }
}
