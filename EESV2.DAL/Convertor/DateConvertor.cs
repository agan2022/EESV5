using System;
using System.Globalization;
using MD.PersianDateTime.Core;

namespace EESV2.DAL.Convertor
{
    public static class DateConvertor
    {
        public static DateTime ConvertPersianDateToChristianDate(this string value)
        {
            PersianDateTime pd=PersianDateTime.Parse(value);

            return pd;
        }
    }
}
