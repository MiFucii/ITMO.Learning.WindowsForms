using System;
using System.Windows.Forms;

namespace Exercise3.WinAsynchMethod
{
    public partial class AsyncMethodForm : Form
    {
        public AsyncMethodForm()
        {
            InitializeComponent();
            PrintDlegateFunc = new PrintLabel(PrintFunc);
        }

        private delegate int AsyncSumm(int a, int b);
        delegate void PrintLabel(string str);
        private PrintLabel PrintDlegateFunc;

        

        private int Summ(int a, int b)
        {
            System.Threading.Thread.Sleep(9000);
            return a + b;
        }

        void PrintFunc(string str)
        {
            lbRes.Text = str;
            
        }


        private void CallBackMethod(IAsyncResult ar)
        {
            string str;
            AsyncSumm summdelegate = (AsyncSumm)ar.AsyncState;
            str = String.Format("Сумма введенных чисел равна: {0}", summdelegate.EndInvoke(ar));
            lbRes.Invoke(PrintDlegateFunc, new object[] { str });
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                // Преобразование типов данных.
                a = Int32.Parse(tbA.Text);
                b = Int32.Parse(tbB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("При выполнении преобразования типов возникла ошибка");
                tbA.Text = tbB.Text = "";
                return;
            }
            AsyncSumm summdelegate = new AsyncSumm(Summ);
            AsyncCallback cb = new AsyncCallback(CallBackMethod);
            summdelegate.BeginInvoke(a, b, cb, summdelegate);
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Идет работа.....");
        }
    }
}
