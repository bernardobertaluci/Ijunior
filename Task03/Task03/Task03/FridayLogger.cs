using System;

namespace Task03
{
    internal class FridayLogger : IDayLogger
    {
        public bool CanWrite() => DayOfWeek.Friday == DateTime.Now.DayOfWeek;
    }
}
