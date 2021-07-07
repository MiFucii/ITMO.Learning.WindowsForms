
namespace Exercise3.ApiFunction
{
    partial class ApiForm
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
            this.btnDisplayFromCenter = new System.Windows.Forms.Button();
            this.btnHorizontalDisplay = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDisplayFromCenter
            // 
            this.btnDisplayFromCenter.Location = new System.Drawing.Point(13, 85);
            this.btnDisplayFromCenter.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplayFromCenter.Name = "btnDisplayFromCenter";
            this.btnDisplayFromCenter.Size = new System.Drawing.Size(256, 28);
            this.btnDisplayFromCenter.TabIndex = 5;
            this.btnDisplayFromCenter.Text = "Появление из центра";
            this.btnDisplayFromCenter.UseVisualStyleBackColor = true;
            this.btnDisplayFromCenter.Click += new System.EventHandler(this.btnDisplayFromCenter_Click);
            // 
            // btnHorizontalDisplay
            // 
            this.btnHorizontalDisplay.Location = new System.Drawing.Point(13, 49);
            this.btnHorizontalDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.btnHorizontalDisplay.Name = "btnHorizontalDisplay";
            this.btnHorizontalDisplay.Size = new System.Drawing.Size(256, 28);
            this.btnHorizontalDisplay.TabIndex = 4;
            this.btnHorizontalDisplay.Text = "Горизонтальное появление";
            this.btnHorizontalDisplay.UseVisualStyleBackColor = true;
            this.btnHorizontalDisplay.Click += new System.EventHandler(this.btnHorizontalDisplay_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(13, 13);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(256, 28);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "Проявление";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // ApiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnDisplayFromCenter);
            this.Controls.Add(this.btnHorizontalDisplay);
            this.Controls.Add(this.btnDisplay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ApiForm";
            this.Text = "Анимация формы";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayFromCenter;
        private System.Windows.Forms.Button btnHorizontalDisplay;
        private System.Windows.Forms.Button btnDisplay;
    }
}

