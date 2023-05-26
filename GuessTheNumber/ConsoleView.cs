using System;

namespace GuessTheNumber
{
    public class ConsoleView : IView
    {
        private readonly Controller controller;

        public ConsoleView(Controller controller)
        {
            this.controller = controller;
        }

        public void Intro()
        {
            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("I have chosen a number between 1 and 100.");;
        }
        public int GetInput()
        {
            int guess = 0;
            string input;
            bool valid = false;
        
            while(valid == false)
            {
                Console.Write("Take a guess: ");
                input = Console.ReadLine();
                valid = Int32.TryParse(input, out guess);
                if(!valid)
                    Console.WriteLine("Invalid input");
            }
            return guess;
        }

        public void ToLow()
        {
            Console.WriteLine("Too low! Try again.");
        }

        public void ToHigh()
        {
            Console.WriteLine("Too high! Try again.");
        }

        public void End()
        {
            Console.WriteLine(
                "Congratulations! You guessed the number correctly!");
            Console.WriteLine("Number of attempts: " + controller.Attempts);
            Console.WriteLine("Thank you for playing Guess the Number!");
        }
    }
}