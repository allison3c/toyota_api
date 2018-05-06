using System;

namespace TOYOTA.API.Common
{
    public class DapperHelper
    {
        public static DateTime? ConvertStringToDate(string dateTime)
        {
            DateTime retDate;
            if (DateTime.TryParse(dateTime, out retDate))
            {
                return retDate;
            }
            return null;
        }
    }
}
