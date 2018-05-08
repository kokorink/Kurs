using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kurs
{
    public partial class FormAddAlarm : Form
    {

        public FormAddAlarm()
        {
            //dateTimePicker1.Text = DigitalTime.GetSmallTime(DateTime.Now);
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alarm alm = new Alarm(Convert.ToDateTime(dateTimePicker1.Text));
            alm.StartAlarm();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alarm.Stop();
            this.Close();
        }
    }
}
