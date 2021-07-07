using System;
using System.Windows.Forms;

namespace Exercise2.WinAsynchDelegate
{
    public partial class AsyncForm : Form
    {
        bool Cancel;
        public AsyncForm()
        {
            InitializeComponent();
        }

        private void TimeConsumingMethod(int seconds)
        {
            for (int j = 1; j <= seconds; j++)
            {
                if (Cancel)
                    break;
                SetProgress((int)(j * 100) / seconds);
                System.Threading.Thread.Sleep(1000);
            }
            if (Cancel)
            {
                MessageBox.Show("Cancelled");
                Cancel = false;
            }
            else
            {
                MessageBox.Show("Complete");
            }
        }
        private delegate void TimeConsumingMethodDelegate(int seconds);

        public delegate void SetProgressDelegate(int val);
        public void SetProgress(int val)
        {
            if (ProgressBar.InvokeRequired)
            {
                SetProgressDelegate del = new SetProgressDelegate(SetProgress);
                this.Invoke(del, new object[] { val });
            }
            else
            {
                ProgressBar.Value = val;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            TimeConsumingMethodDelegate del = new
            TimeConsumingMethodDelegate(TimeConsumingMethod);
            del.BeginInvoke(int.Parse(tbValue.Text), null, null);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel = true;
        }

        private void tbValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле должно содержать цифры");
            }
        }
    }
}
