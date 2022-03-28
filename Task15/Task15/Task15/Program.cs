using System;

namespace Task15
{
    internal class Program
    {
        public void Shoot(Player player)
        {
            if (player == null)
                new ArgumentNullException(nameof(player));
        }
        public string Find(int number) 
        {
            if(number < 0)
                throw new ArgumentOutOfRangeException(nameof(number));

            return string;
        }
    }
}
