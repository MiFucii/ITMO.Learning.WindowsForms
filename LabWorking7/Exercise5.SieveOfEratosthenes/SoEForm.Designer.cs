
namespace Exercise5.SieveOfEratosthenes
{
    partial class SoEForm
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
            this.btnResult = new System.Windows.Forms.Button();
            this.tbMaxValue = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(158, 19);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(132, 35);
            this.btnResult.TabIndex = 1;
            this.btnResult.Text = "Рассчитать";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // tbMaxValue
            // 
            this.tbMaxValue.Location = new System.Drawing.Point(12, 21);
            this.tbMaxValue.Name = "tbMaxValue";
            this.tbMaxValue.Size = new System.Drawing.Size(100, 30);
            this.tbMaxValue.TabIndex = 0;
            this.tbMaxValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaxValue_KeyPress);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(12, 71);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(268, 212);
            this.tbResult.TabIndex = 2;
            this.tbResult.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 289);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(278, 38);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // SoEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 338);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbMaxValue);
            this.Controls.Add(this.btnResult);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 385);
            this.MinimumSize = new System.Drawing.Size(320, 385);
            this.Name = "SoEForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Решето Эратосфена";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox tbMaxValue;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btnClear;
    }
}

