using System;
using System.Windows.Forms;

namespace Exercise2.COMСomponent
{
    public partial class COMForm : Form
    {
        public COMForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Файлы pdf|*.pdf";
            openFileDialog.ShowDialog();
            //axAcroPDF.LoadFile(openFileDialog.FileName);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
