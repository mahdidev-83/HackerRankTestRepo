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

    static void Main(String[] args)
    {
        Console.WriteLine(simpleArraySum(new List<int>() { 1, 2, 3 }));
        Console.ReadLine();
    }
}