namespace GuessTheNumber
{
    public class Controller
    {
        private int number;
        private IView view;

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
                //Do logic
            }
            while(guess != number);
        }
    }
}