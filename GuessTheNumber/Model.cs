using System;

namespace GuessTheNumber
{
    public class Model
    {
        public int Number{get;}

        public Model()
        {
            Random rd = new Random();
            Number = rd.Next(1, 101);
        }
    }
}