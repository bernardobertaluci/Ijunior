using System;

namespace Task11
{
    internal class Program
    {
        public static void Instantiate()
        {
            //Создание объекта на карте
        }

        public static void DetermineChance()
        {
            _chance = Random.Range(0, 100);
        }

        public static int Salary(int hoursWorked)
        {
            return _hourlyRate * hoursWorked;
        }
    }
}
