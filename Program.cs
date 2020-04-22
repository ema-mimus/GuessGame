using System.Security.Cryptography;
using System;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber;
            int guess;
            int numberOfGuesses;
            string difficulty;
            bool gameOver = false;

            Console.WriteLine("Welcome to Ema Guessing Game");
            Console.Write("Choose difficulty between Easy, Medium and Hard");
            difficulty = (Console.ReadLine());

            if (difficulty == "Easy"){
                randomNumber = random.Next(1, 11);
                numberOfGuesses = 6;
                Console.WriteLine("You are to guess a number between 1 and 10, and you have 6 guesses");
                Console.Write("What is your guess");
                try {
                    while(gameOver == false && numberOfGuesses != 0){
                    guess = int.Parse(Console.ReadLine());
                    numberOfGuesses--;

                    if(randomNumber == guess){
                        Console.WriteLine("You got it right!");
                        gameOver = true;
                    }
                    else if(randomNumber != guess){
                        Console.WriteLine("That was wrong!");
                        Console.WriteLine("You have " + numberOfGuesses + " trial(s) left");
                    }
                    }
                    Console.WriteLine("Game over");
                    Console.WriteLine("The random number was " + randomNumber);

                    }

                catch (System.FormatException) {
                    Console.WriteLine("Only integers are allowed");
                }

            }

            if (difficulty == "Medium"){
                randomNumber = random.Next(1, 21);
                numberOfGuesses = 4;
                Console.WriteLine("You are to guess a number between 1 and 20, and you have 4 guesses");
                Console.Write("What is your guess");
                try {
                    while(gameOver == false && numberOfGuesses != 0){
                    guess = int.Parse(Console.ReadLine());
                    numberOfGuesses--;

                    if(randomNumber == guess){
                        Console.WriteLine("You got it right!");
                        gameOver = true;
                    }
                    else if(randomNumber != guess){
                        Console.WriteLine("That was wrong!");
                        Console.WriteLine("You have " + numberOfGuesses + " trial(s) left");
                    }
                    }
                    Console.WriteLine("Game over");
                    Console.WriteLine("The random number was " + randomNumber);

                    }

                catch (System.FormatException) {
                    Console.WriteLine("Only integers are allowed");
                }

            }

            if (difficulty == "Hard"){
                randomNumber = random.Next(1, 51);
                numberOfGuesses = 3;
                Console.WriteLine("You are to guess a number between 1 and 50, and you have 3 guesses");
                Console.Write("What is your guess");
                try {
                    while(gameOver == false && numberOfGuesses != 0){
                    guess = int.Parse(Console.ReadLine());
                    numberOfGuesses--;

                    if(randomNumber == guess){
                        Console.WriteLine("You got it right!");
                        gameOver = true;
                    }
                    else if(randomNumber != guess){
                        Console.WriteLine("That was wrong!");
                        Console.WriteLine("You have " + numberOfGuesses + " trial(s) left");
                    }
                    }
                    Console.WriteLine("Game over");
                    Console.WriteLine("The random number was " + randomNumber);

                    }

                catch (System.FormatException) {
                    Console.WriteLine("Only integers are allowed");
                }

            }

        }
    }
}
