using System;

namespace Task03
{
    internal interface IDayLogger
    {
        public static bool CanWrite() => DayOfWeek.Friday == DateTime.Now.DayOfWeek;
    }
}
