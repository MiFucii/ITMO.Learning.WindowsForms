using System;
using System.Windows.Forms;

namespace Exercise3.ApiFunction
{
    public partial class ApiForm : Form
    {
        public ApiForm()
        {
            InitializeComponent();
        }

        private void btnDisplayFromCenter_Click(object sender, EventArgs e)
        {
            this.Hide();
            WinAPIClass.AnimateWindow(this, 3000, WinAPIClass.AnimateWindowFlags.AW_CENTER | WinAPIClass.AnimateWindowFlags.AW_SLIDE);
            this.btnDisplay.Invalidate();
            this.btnHorizontalDisplay.Invalidate();
            this.btnDisplayFromCenter.Invalidate();
        }

        private void btnHorizontalDisplay_Click(object sender, EventArgs e)
        {
            this.Hide();
            WinAPIClass.AnimateWindow(this, 3000, WinAPIClass.AnimateWindowFlags.AW_HOR_POSITIVE | WinAPIClass.AnimateWindowFlags.AW_SLIDE);
            this.btnDisplay.Invalidate();
            this.btnHorizontalDisplay.Invalidate();
            this.btnDisplayFromCenter.Invalidate();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // Скрываем окно
            this.Hide();
            // Запускаем анимацию. Второй параметр в скобках — время анимации в миллисекундах.
            WinAPIClass.AnimateWindow(this, 3000, WinAPIClass.AnimateWindowFlags.AW_ACTIVATE | WinAPIClass.AnimateWindowFlags.AW_BLEND);
            // Отображаем кнопки после анимации
            this.btnDisplay.Invalidate();
            this.btnHorizontalDisplay.Invalidate();
            this.btnDisplayFromCenter.Invalidate();
        }
    }
}
