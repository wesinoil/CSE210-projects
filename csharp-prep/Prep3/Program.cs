using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Guess the magic number between 1 - 100");
        Random randomGenerator = new Random();

        int magicNumber = randomGenerator.Next(1, 101);
        int guess = -1;

        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }

}