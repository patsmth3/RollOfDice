using System;

namespace RollOfDice
{
    public class Die
    {
        private static Random rand = new Random();

        public int DieRoll()
        {
            return rand.Next(1, 7);
        }
    }
}