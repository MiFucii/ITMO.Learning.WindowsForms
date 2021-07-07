using System;
using System.Windows.Forms;

namespace Exercise4.CreatingCustomForm
{
    public partial class RubberyForm : Form
    {
        EllipseForm elps;
        RhombForm rhomb;

        public RubberyForm()
        {
            InitializeComponent();
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            elps = EllipseForm.OpenEllipse; elps.Show();
            this.Hide();
        }

        private void btnRhomb_Click(object sender, EventArgs e)
        {
            rhomb = RhombForm.OpenRhomb; rhomb.Show();
            //this.Hide();
        }
    }
}
