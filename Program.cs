using System;
using System.Collections.Generic;
using System.IO;

class Person
{

    public static int simpleArraySum(List<int> ar)
    {
        int sum = 0;
        for (int i = 0; i < ar.Count(); i++)
        {
            sum += ar[i];
        }
        return sum;
    }

    public static void sayMoreThanOneTime(int iterationNumber)
    {
        for(int i = 0;i<= iterationNumber;i++)
        {
            Console.WriteLine($"the number of iteration of this Program is {i}:");
        }
    }

    static void Main(String[] args)
    {
        Console.WriteLine(simpleArraySum(new List<int>() { 1, 2, 3 }));
        Console.ReadLine();

        // the changes from this code


        // the sayThanOneTime method:
        sayMoreThanOneTime(4);
    }
}
