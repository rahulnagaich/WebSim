using System;

namespace WebSim.Common.Dates
{
    public class DateService : IDateService
    {
        public DateTime GetDate()
        {
            return DateTime.Now;
        }
    }
}