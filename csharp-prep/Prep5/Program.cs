using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessege();

        string Name = UserName();

        int number = UserNumber();

        int SquareNumbers = SquareNumber(number);

        DisplayResult(Name, SquareNumbers);

    }
    
    static void DisplayWelcomeMessege()

    {
        Console.WriteLine("Welcome to the program!");
    }

    static string UserName()

    {
        Console.WriteLine("What is your name? ");
        string user = Console.ReadLine();

        return user;
    }
    
    static int UserNumber()
    {
        Console.WriteLine("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
        
    }

    static void DisplayResult(string user, int square )
    {
        Console.WriteLine($"{user}, The square of your number is {square}.");
    }
}