using System.Windows.Forms;

namespace Exercise4.DataValidationForm
{
    public partial class ValidationForm : Form
    {
        public ValidationForm()
        {
            InitializeComponent();
        }

        private void btnUpdateClient_Click(object sender, System.EventArgs e)
        {
            lbClientInfo.Items.Clear();
            foreach (Client cl in ClientRepository.arrayClient)
            {
                lbClientInfo.Items.Add(string.Concat(cl.Fname, " ", cl.Lname, ", ", cl.age, ", ", cl.email));
            }
        }
    }
}
