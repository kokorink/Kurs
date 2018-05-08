using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs
{
    class DigitalTime
    {
        public static string GetLongTime(DateTime t)
        {
            string timeString = "";
            if (t.Hour < 10)
                timeString += "0" + t.Hour;
            else
                timeString += t.Hour;
            if (t.Minute < 10)
                timeString += ":0" + t.Minute;
            else
                timeString += ":" + t.Minute;
            if (t.Second<10)
                timeString += ":0" + t.Second;
            else
                timeString += ":" + t.Second;
            return timeString;
        }

        public static string GetSmallTime(DateTime t)
        {
            string timeString = "";
            if (t.Hour < 10)
                timeString += "0" + t.Hour;
            else
                timeString += t.Hour;
            if (t.Minute < 10)
                timeString += ":0" + t.Minute;
            else
                timeString += ":" + t.Minute;
            return timeString;
        }

    }
}
