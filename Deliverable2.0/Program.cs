using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Coin Flip Challenge!");

        // Ask for the user's name and store it
        Console.Write("What's your name? ");
        string Name = Console.ReadLine();

        // Display a greeting using the user's name
        Console.WriteLine("Hello, " + Name + "! ");

        // Ask the user if they want to participate in the Coin Flip Challenge
        Console.Write("Do you accept the COIN FLIP CHALLENGE? (yes/no) ");
        string YN = Console.ReadLine();

        // Check if the user agreed to the challenge
        if (YN.ToLower() == "yes")
        {
            int score = 0;

            // Loop the challenge 5 times
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Round" + i + ":");

                // Generate a random number (0 or 1) for the coin flip
                int rng = new Random().Next(1, 3);

                // Ask the user for heads or tails
                Console.Write("Heads or Tails? ");
                string Guess = Console.ReadLine().ToLower();

                // Check if the user's guess is correct
                if ((rng == 1 && (Guess == "heads" || Guess == "head")) || (rng == 2 && (Guess == "tails" || Guess == "tail")))
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }
            }

            // Display the final score
            Console.WriteLine("Challenge completed," + Name + "!");
            Console.WriteLine("Your final score is: " + score + " out of 5.");
        }
        else
        {
            Console.WriteLine(Name + ", you are a coward !");
        }
    }
}
