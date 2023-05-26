namespace GuessTheNumber
{
    public class Controller
    {
        private int number;
        private IView view;

        public int Attempts {get; private set;}

        public Controller(int number)
        {
            this.number = number;
        }

        public void Run (IView view)
        {
            this.view = view;

            view.Intro();
            int guess = 0;
            do
            {
                guess = view.GetInput();
                Attempts++;

                if(guess < number)
                    view.ToLow();
                else if(guess > number)
                    view.ToHigh();
                else
                    break;
            }
            while(guess != number);

            view.End();
        }
    }
}