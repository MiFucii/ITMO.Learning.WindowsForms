
namespace Exercise1.CompositeControlElement
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
            this.btnStop = new System.Windows.Forms.Button();
            this.userControlTimer = new Exercise1.CompositeControlElement.UserControlTimer();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(12, 82);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(178, 28);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Отключить";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // userControlTimer
            // 
            this.userControlTimer.Location = new System.Drawing.Point(12, 12);
            this.userControlTimer.Name = "userControlTimer";
            this.userControlTimer.Size = new System.Drawing.Size(178, 64);
            this.userControlTimer.TabIndex = 0;
            this.userControlTimer.TimeEnabled = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 121);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.userControlTimer);
            this.Name = "Form1";
            this.Text = "Часы";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlTimer userControlTimer;
        private System.Windows.Forms.Button btnStop;
    }
}

