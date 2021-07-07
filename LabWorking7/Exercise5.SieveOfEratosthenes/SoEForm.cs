using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise5.SieveOfEratosthenes
{
    public partial class SoEForm : Form
    {
        public SoEForm()
        {
            InitializeComponent();
            PrintDlegateFunc = new Print(PrintEratosthenes);
        }

        private delegate string AsyncEratosthenes(int a);
        delegate void Print(string str);
        private Print PrintDlegateFunc;

        private void CallBackMethod(IAsyncResult ar)
        {
            string str;
            AsyncEratosthenes eratDelegate = (AsyncEratosthenes)ar.AsyncState;
            str = eratDelegate.EndInvoke(ar);
            tbResult.Invoke(PrintDlegateFunc, new object[] { str });
        }

        void PrintEratosthenes(string str)
        {
            tbResult.Text = str;
        }

        private void tbMaxValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 08) tbMaxValue.BackColor = Color.White;
            else
            {
                e.Handled = true;
                tbMaxValue.BackColor = Color.FromArgb(255, 153, 153);
                tbMaxValue.Text.Trim();
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            
            AsyncEratosthenes eratDelegate = new AsyncEratosthenes(Eratosthenes.GoButt);
            AsyncCallback cb = new AsyncCallback(CallBackMethod);
            eratDelegate.BeginInvoke(int.Parse(tbMaxValue.Text), cb, eratDelegate);
            Clear();
        }

        private void Clear()
        {
            tbResult.Clear();
            tbMaxValue.Clear();
            tbMaxValue.Focus();
            tbMaxValue.BackColor = Color.White;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
