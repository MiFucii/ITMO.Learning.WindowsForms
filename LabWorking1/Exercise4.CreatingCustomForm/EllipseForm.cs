using System;
using System.Drawing;
using System.Windows.Forms;

namespace Exercise4.CreatingCustomForm
{
    public partial class EllipseForm : Form
    {
        static EllipseForm elpsNull = null;
        RubberyForm rb = new RubberyForm();
        EllipseForm()
        {
            InitializeComponent();
        }

        public static EllipseForm OpenEllipse
        {
            get
            {
                if (elpsNull == null) elpsNull = new EllipseForm();
                return elpsNull;
            }
        }
        private void EllipseForm_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(0, 0, this.Width, this.Height);
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EllipseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            elpsNull = null;
            rb.Show();
        }
    }
}
