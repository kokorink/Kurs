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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            timerTime.Start();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            Text = "Текущее время: " + DigitalTime.GetFullTime();
        }
    }
}
