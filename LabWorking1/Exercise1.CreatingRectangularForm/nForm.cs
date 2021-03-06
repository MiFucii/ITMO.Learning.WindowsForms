using System;
using System.Windows.Forms;

namespace Exercise1.CreatingRectangularForm
{
    public partial class nForm : Form
    {
        private bool nclose = false;
        public nForm()
        {
            InitializeComponent();
        }

        public new void Close()
        {
            nclose = true;
            base.Close();
        }

        private void nForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (nclose || checkBoxClose.Checked) return;
            e.Cancel = true;
            Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
