namespace GuessTheNumber
{
    public class Controller
    {
        private Model model;
        private IView view;
        public Controller(Model model)
        {
            this.model = model;
        }

        public void Run (IView view)
        {
            this.view = view;

            view.Intro();
            int guess = 0;
            do
            {
                guess = view.GetInput();
                model.IncreaseAttempts();

                if(guess < model.Number)
                    view.ToLow();
                else if(guess > model.Number)
                    view.ToHigh();
                else
                    break;
            }
            while(guess != model.Number);

            view.End();
        }
    }
}