
namespace Exercise2.CustomControlElement
{
    partial class TimeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.userControlTimer1 = new Exercise2.CustomControlElement.UserControlTimer();
            this.SuspendLayout();
            // 
            // userControlTimer1
            // 
            this.userControlTimer1.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlTimer1.Location = new System.Drawing.Point(29, 24);
            this.userControlTimer1.Margin = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.userControlTimer1.Name = "userControlTimer1";
            this.userControlTimer1.Size = new System.Drawing.Size(280, 70);
            this.userControlTimer1.TabIndex = 0;
            // 
            // TimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 117);
            this.Controls.Add(this.userControlTimer1);
            this.Name = "TimeForm";
            this.Text = "Часы";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlTimer userControlTimer1;
    }
}

