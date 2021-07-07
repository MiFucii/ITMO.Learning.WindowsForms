
namespace Exercise3.ExtendedControlElement
{
    partial class ClickForm
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
            this.clickButton1 = new Exercise3.ExtendedControlElement.ClickButton();
            this.SuspendLayout();
            // 
            // clickButton1
            // 
            this.clickButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.clickButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clickButton1.Location = new System.Drawing.Point(12, 12);
            this.clickButton1.Name = "clickButton1";
            this.clickButton1.Size = new System.Drawing.Size(177, 71);
            this.clickButton1.TabIndex = 0;
            this.clickButton1.Text = "КликедMe";
            this.clickButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 105);
            this.Controls.Add(this.clickButton1);
            this.Name = "Form1";
            this.Text = "Кликед";
            this.ResumeLayout(false);

        }

        #endregion

        private ClickButton clickButton1;
    }
}

