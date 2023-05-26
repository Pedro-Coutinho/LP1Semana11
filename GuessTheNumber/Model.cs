using System;

namespace GuessTheNumber
{
    public class Model
    {
        public int Number{get;}
        public int Attempts{get; private set;}

        public Model()
        {
            Random rd = new Random();
            Number = rd.Next(1, 101);
        }

        public void IncreaseAttempts() => Attempts++;
    }
}