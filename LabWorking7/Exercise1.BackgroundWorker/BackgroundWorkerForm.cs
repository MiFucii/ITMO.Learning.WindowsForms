using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackgroundWorker
{
    public partial class BackgroundWorkerForm : Form
    {
        public BackgroundWorkerForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!(tbValue.Text == ""))
            {
                int i = int.Parse(tbValue.Text);
                BackgroundWorker.RunWorkerAsync(i);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            BackgroundWorker.CancelAsync();
        }

        private void tbValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле должно содержать цифры");
            }
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int i;
            i = int.Parse(e.Argument.ToString());
            for (int j = 1; j <= i; j++)
            {
                if (BackgroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                System.Threading.Thread.Sleep(1000);
                BackgroundWorker.ReportProgress((int)(j * 100 / i));
            }

        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!(e.Cancelled))
                MessageBox.Show("Run Completed!");
            else
                MessageBox.Show("Run Cancelled");

        }
    }
}
