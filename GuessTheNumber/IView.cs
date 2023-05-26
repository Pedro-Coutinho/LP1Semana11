namespace GuessTheNumber
{
    public interface IView
    {
        void Intro();
        void ToLow();
        void ToHigh();
        void End();
        int GetInput();
    }
}