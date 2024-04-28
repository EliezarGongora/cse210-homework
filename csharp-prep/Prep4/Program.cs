using System;

class Program
{
    static void Main(string[] args)
     {
        
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach(int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"the total is {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is : {average}");


        int higher = numbers[0];

        foreach(int number in numbers)
        {
            if(number > higher)
            {
                higher = number;
            }
        }
        
            Console.WriteLine($"The higher number is: {higher} ");


        int lower = numbers[0];

        foreach(int number in numbers)
        {
            if(number < lower)
            {
                lower = number;
            }
        }
        
            Console.WriteLine($"The lowest number is: {lower} ");


    }
}