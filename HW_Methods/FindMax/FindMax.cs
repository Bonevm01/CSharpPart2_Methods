using System;

class FindMax
{
    static int GetMax(int a, int b)
    {
        int max = a;
        if (b>a) max = b;
        return max;
       
    }

    static void Main()
    {
        int input1 = int.Parse(Console.ReadLine());
        int input2 = int.Parse(Console.ReadLine());
        int input3 = int.Parse(Console.ReadLine());
        Console.WriteLine("The biggest integer is {0}.", GetMax(input1,GetMax(input2,input3)));
    }
}
