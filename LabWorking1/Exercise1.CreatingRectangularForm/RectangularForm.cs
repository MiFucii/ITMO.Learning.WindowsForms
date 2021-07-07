using System;
using System.Drawing;
using System.Windows.Forms;

namespace Exercise1.CreatingRectangularForm
{
    public partial class RectangularForm : Form
    {
        nForm myF2;
        private int frmCreateCount = 0; 
        public RectangularForm()
        {
            myF2 = new nForm();
            InitializeComponent();
        }

        private void btnBorderStyle_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            this.Size = new Size(300, 500);
        }

        private void btnOpacity_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void btnSecondForm_Click(object sender, EventArgs e)
        {
            try
            {
                myF2.Show();
                myF2.Activate();                
            }
            catch (ObjectDisposedException)
            {
                myF2 = new nForm();
                frmCreateCount++;
                myF2.Text = string.Concat("Форма создана ", frmCreateCount, " раз");
                myF2.Show();
                myF2.Activate();
            }
            finally
            {
                myF2.StartPosition = FormStartPosition.Manual;
                myF2.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            }

        }
    }
}
