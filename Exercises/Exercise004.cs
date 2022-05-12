using System;

namespace Exercises
{
    public class Exercise004
    {
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            DateTime result = dateTime;
            var gigaSec = Math.Pow(10, 9);

            if (dateTime.TimeOfDay.TotalSeconds == 0) 
            {
                return dateTime.AddSeconds(gigaSec);
            }
            else if (dateTime.TimeOfDay.TotalSeconds > 1 && result.AddSeconds(gigaSec).Day < dateTime.Day) 
            {
                return dateTime.AddSeconds(gigaSec);
            }
            else
            {
                return dateTime.AddSeconds(gigaSec);
            }
        }
    }
}
