using System;

class LastDigit
{
    static string SayLastDigit(int a)
    {
        string[] name = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        return name[a % 10];
    }
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine(SayLastDigit(input));
    }
}
