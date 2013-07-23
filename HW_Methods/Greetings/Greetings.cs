using System;

class Greetings
{
    static void SayHello()
    {
        Console.Write("Please enter your name: ");
        string input = Console.ReadLine();
        string line = new string('-', 20);
        Console.WriteLine(line);
        Console.WriteLine("Hello {0}!", input);

    }
    static void Main()
    {
        SayHello();
    }
}