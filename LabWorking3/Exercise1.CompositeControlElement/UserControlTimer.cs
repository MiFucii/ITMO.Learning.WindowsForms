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
    public partial class UserControlTimer : UserControl
    {
        public UserControlTimer()
        {
            InitializeComponent();
        }
        public bool TimeEnabled
        {
            get { return Timer.Enabled; }
            set { Timer.Enabled = value; }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
