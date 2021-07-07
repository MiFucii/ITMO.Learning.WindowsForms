using System;
using System.Drawing;
using System.Windows.Forms;

namespace Exercise4.DataValidationForm
{
    
    public partial class DataValidation : UserControl
    {
        public DataValidation()
        {
            InitializeComponent();
        }
        bool blockName = false, blockLastName = false, blockAge = false, blockEmail = false;

        //системные методы.
        //Метод устанавливает цвет BackColor. Если true то белый если false то красный
        private void SetColor(TextBox obj, bool flag)
        {
            if(flag) obj.BackColor = Color.White;
            else obj.BackColor = Color.FromArgb(255, 153, 153);
        }
        //Метод проверяет присутсвует ли в строке цифра и возвращает результат
        private bool IsNumber(string str)
        {
            bool res = false;
            foreach (char i in str)
            {
                if (char.IsDigit(i)) res = true;
            }
            return res;
        }


        private void tbName_Enter(object sender, EventArgs e)
        {
            SetColor(tbName, true);
            blockName = false;
        }
        private void tbName_Leave(object sender, EventArgs e)
        {
            if (IsNumber(tbName.Text))
            {
                SetColor(tbName, false);
                blockName = true;
            }
        }



        private void tbLastName_Enter(object sender, EventArgs e)
        {
            SetColor(tbLastName, true);
            blockLastName = false;
        }
        private void tbLastName_Leave(object sender, EventArgs e)
        {
            if (IsNumber(tbLastName.Text))
            {
                SetColor(tbLastName, false);
                blockLastName = true;
            }
        }


        private void tbAge_Enter(object sender, EventArgs e)
        {
            SetColor(tbAge, true);
            blockAge = false;
        }
        private void tbAge_Leave(object sender, EventArgs e)
        {
            int controlNumber;
            if(!Int32.TryParse(tbAge.Text, out controlNumber) || (int.Parse(tbAge.Text) < 1) || (int.Parse(tbAge.Text) > 99))
            {
                    SetColor(tbAge, false);
                    blockAge = true;
            }

        }

        private void tbEmail_Enter(object sender, EventArgs e)
        {
            SetColor(tbEmail, true);
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(tbEmail.Text);
                blockEmail = false;
                
            }
            catch
            {
                SetColor(tbEmail, false);
                blockEmail = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbLastName.Text = "";
            SetColor(tbLastName, true);
            tbName.Text = "";
            SetColor(tbName, true);
            tbEmail.Text = "";
            SetColor(tbEmail, true);
            tbAge.Text = "";
            SetColor(tbAge, true);
            tbName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "" && tbLastName.Text != "" && tbEmail.Text != "" && tbAge.Text != "")
            {
                if (!blockName && !blockLastName && !blockEmail && !blockAge)
                {
                   ClientRepository.arrayClient.Add(new Client(tbName.Text, tbLastName.Text, tbEmail.Text, byte.Parse(tbAge.Text)));
                }
                else MessageBox.Show("У вас не правильно заполнено одно из полей! Пожалуйста, исправте это.", "Предупреждение:", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("У вас не заполнено одно из полей! Пожалуйста, исправте это.", "Предупреждение:", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
    }
}
