using System;

class Program
{
    static void Main(string[] args)
     {
        Random randomGenertator = new Random();
        int magicNumber = randomGenertator.Next(1, 100);
        
        int adivina = 0;
        
        while (adivina != magicNumber)
        {
            Console.Write("what is your guess? ");
            adivina = int.Parse(Console.ReadLine());

            if (adivina == magicNumber)
            {
                Console.Write("You guessed it right!");
            }    
            else if (magicNumber > adivina)
            {
                Console.WriteLine("Go higher!");
            }
            else 
            {
                Console.WriteLine("Go lower!");
            }

        }
        
        
    }
}