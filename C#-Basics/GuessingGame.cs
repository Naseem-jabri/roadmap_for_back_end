using System;

namespace MyFirstProject
{
    public class GuessingGame
    {
        public static void RunGame()
        {
            
          Random random = new Random();

            int secertNum = random.Next(1, 10);
            int attempt = 0;
            int guess = 0;

            Console.WriteLine("Guess a number from 1 to 10.");

            while(guess != secertNum)
            {
                Console.WriteLine("enter the your guess");
                guess = int.Parse(Console.ReadLine());
                attempt++;

                if(guess < secertNum)
                {
                    Console.WriteLine("Your guess is too low! Try again.");
                }
                else if (guess > secertNum)
                {
                    Console.WriteLine("Your guess is too highe! Try again.");
            }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number in {attempt} attempts.");
                }

             
        }

    }
}
}