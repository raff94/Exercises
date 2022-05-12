using System;

namespace Exercises
{
    public class Exercise004
    {
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            var gigaSec = Math.Pow(10, 9);

            if (dateTime.TimeOfDay.TotalSeconds == 0)
            {
                return dateTime.AddSeconds(gigaSec);
            }
            else if (dateTime.TimeOfDay.TotalSeconds == 1)
            {
                return dateTime.AddSeconds(gigaSec);
            }
            else
            {
                _ = dateTime > DateTime.Now;
                return dateTime.AddSeconds(gigaSec);
            }
        }
    }
}
