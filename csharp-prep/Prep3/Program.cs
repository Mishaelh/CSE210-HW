using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.WriteLine("Guess the magic number! ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber < guess)
            {
                Console.WriteLine("So close but guess lower!");
            }

            else if (magicNumber > guess)
            {
                Console.WriteLine("Keep trying that`s not the right number guess higher!");
            }
            else
            {
                Console.WriteLine("You have asserted. Congratulations!");
            }
        }                  
    }
}