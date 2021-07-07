using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1.CompositeControlElement
{
    public partial class TimeForm : Form
    {
        bool timeOffOn = true;
        public TimeForm()
        {
            InitializeComponent();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (timeOffOn)
            {
                userControlTimer.TimeEnabled = false;
                timeOffOn = false;
                btnStop.Text = "Включить";
            }
            else
            {
                userControlTimer.TimeEnabled = true;
                timeOffOn = true;
                btnStop.Text = "Отключить";
            }
        }
    }
}
