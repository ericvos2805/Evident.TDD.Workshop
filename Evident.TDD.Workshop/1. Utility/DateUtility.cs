using System;
using System.Globalization;

namespace Evident.TDD.Workshop.Utility
{
    public static class DateUtility
    {
        /// <summary>
        /// Gets the month display value for the given culture
        /// </summary>
        /// <param name="monthNumber"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public static string GetMonthDisplayValue(int monthNumber, string culture = "nl-NL")
        {
            if (monthNumber == 0)
                return string.Empty;

            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(culture);
            return cultureInfo.TextInfo.ToTitleCase(cultureInfo.DateTimeFormat.GetMonthName(monthNumber));
        }
    }
}
