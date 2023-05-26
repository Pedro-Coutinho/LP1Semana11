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
    }
}