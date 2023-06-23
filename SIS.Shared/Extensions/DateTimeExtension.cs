using System;
namespace SIS.Shared.Extensions
{
    public static class DateTimeExtension
    {
        //public static long ToMilliseconds(this DateTime? dateTime)
        //{
        //    if (!dateTime.HasValue)
        //        return 0;
        //    return dateTime.ToMilliseconds();
        //}

        public static long ToMilliseconds(this DateTime dateTime)
        {
            return (long)dateTime.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
        }

        //public static DateTime ToDateTime(this long? milliseconds)
        //{
        //    return milliseconds.ToDateTime();
        //}

        public static DateTime ToDateTime(this long milliseconds)
        {
            var date = (new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds(milliseconds);
            return date;
        }
    }
}
