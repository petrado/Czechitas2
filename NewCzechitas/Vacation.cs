using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCzechitas
{
    internal class Vacation
    {
        public DateTime VacationStart;
        public DateTime VacationEnd;
        public DateTime RealTime;

        public Vacation(DateTime vacationStart, DateTime vacationEnd, DateTime realTime) 
        {
            VacationStart = vacationStart;
            VacationEnd = vacationEnd;
            RealTime = realTime;
            WriteResult();
        }

        public void WriteResult() 
        {
            TimeSpan vacationLength = VacationEnd - VacationStart;
            TimeSpan daysRemain = VacationStart - RealTime;
            Console.WriteLine($"Vacation starts in {daysRemain.Days} days and wil be long {vacationLength.Days} days");
        }
    }
}
