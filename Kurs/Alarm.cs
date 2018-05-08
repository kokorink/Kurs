using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Kurs
{
    class Alarm
    {
        static System.Timers.Timer timer;

        public Alarm()
        {

        }


        public Alarm(DateTime t)
        {
            TimeSpan r = new TimeSpan(t.TimeOfDay.Hours - DateTime.Now.Hour, t.TimeOfDay.Minutes - DateTime.Now.Minute, -DateTime.Now.Second);
            if (t.TimeOfDay < DateTime.Now.TimeOfDay)
                r = r.Add(new TimeSpan(1, 0, 0, 0));

            timer = new System.Timers.Timer(r.TotalMilliseconds);
        }
        

        public void StartAlarm()
        {

            timer.Start();
            timer.Elapsed += StopElapsed;

        }

        private static void StopElapsed(Object source, ElapsedEventArgs e)
        {
            SoundPlayer s = new SoundPlayer(Properties.Resources.Ring02);
            s.Load();
            s.Play();
            DialogResult dr = MessageBox.Show("Будильник");
            if (dr == DialogResult.OK)
            {
                Stop();
                s.Stop();
            }
        }

        public static void Stop()
        {
            timer.Stop();
        }



    }


}
