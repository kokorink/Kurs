using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs
{
    class DigitalTime
    {
        public static string GetFullTime()
        {
            if (DateTime.Now.Hour < 10)
                if (DateTime.Now.Minute < 10)
                    if (DateTime.Now.Second < 10)
                        return "0" + DateTime.Now.Hour + ":0" + DateTime.Now.Minute + "0:" + DateTime.Now.Second;
                    else return "0" + DateTime.Now.Hour + ":0" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
                else
                    if (DateTime.Now.Second < 10)
                        return "0" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + "0:" + DateTime.Now.Second;
                    else
                        return "0" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            else
                if (DateTime.Now.Minute < 10)
                if (DateTime.Now.Second < 10)
                    return DateTime.Now.Hour + ":0" + DateTime.Now.Minute + "0:" + DateTime.Now.Second;
                else
                    return "0" + DateTime.Now.Hour + ":0" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            else
                    if (DateTime.Now.Second < 10)
                        return DateTime.Now.Hour + ":" + DateTime.Now.Minute + "0:" + DateTime.Now.Second;
                    else
                        return DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
        }
    }
}
