using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    internal class FridayLogger : IDayLogger
    {
        public bool CanWrite() => DayOfWeek.Friday == DateTime.Now.DayOfWeek;
    }
}
