using System;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main()
        {
            Model model = new Model();

            Controller controller = new Controller(model);

            IView view = new ConsoleView(controller);

            controller.Run(view);
        }
    }
}