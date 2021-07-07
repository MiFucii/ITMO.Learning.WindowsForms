using System;
using System.Drawing;
using System.Windows.Forms;

namespace Exercise4.CreatingCustomForm
{
    public partial class RhombForm : Form
    {
        static RhombForm rhombNull = null;
        RubberyForm rb = new RubberyForm();
        RhombForm()
        {
            InitializeComponent();
        }

        public static RhombForm OpenRhomb
        {
            get
            {
                if (rhombNull == null) rhombNull = new RhombForm();
                return rhombNull;
            }
        }

        private void RhombForm_Load(object sender, EventArgs e)
        {
            Point[] pts = { new Point(40, 360), new Point(280, 40), new Point(520, 360), new Point(280, 680) };


            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddPolygon(pts);
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RhombForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            rhombNull = null;
            //rb.Show();
        }
    }
}
