using System;
using System.Drawing;
using System.Windows.Forms;

namespace Exercise2.CreatingTriangularForm
{
    public partial class TriangularForm : Form
    {
        public TriangularForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TriangularForm_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddPolygon(new Point[] { new Point(0, 0), new Point(0, this.Height), new Point(this.Width, 0) });
            Region myRegion = new Region(myPath);
            this.Region = myRegion;

        }
    }
}
