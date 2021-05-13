using System;
using System.Globalization;
using System.Threading;

namespace Models.Tools
{
    public static class Utility
    {
        public static DateTime Now
        {
            get
            {
                var currentCulture =
                    Thread.CurrentThread.CurrentCulture;

                var englishCulture =
                    new CultureInfo("en-US");

                Thread.CurrentThread.CurrentCulture = englishCulture;

                var now = DateTime.Now;

                Thread.CurrentThread.CurrentUICulture = currentCulture;

                return now;
            }
        }
    }
}