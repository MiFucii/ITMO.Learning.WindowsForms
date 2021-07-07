
namespace Exercise3.WinAsynchMethod
{
    partial class AsyncMethodForm
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
            this.btnWork = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.tbB = new System.Windows.Forms.TextBox();
            this.lbB = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.lbA = new System.Windows.Forms.Label();
            this.lbRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWork
            // 
            this.btnWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWork.Location = new System.Drawing.Point(245, 99);
            this.btnWork.Margin = new System.Windows.Forms.Padding(4);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(124, 44);
            this.btnWork.TabIndex = 9;
            this.btnWork.Text = "Работа";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRun.Location = new System.Drawing.Point(18, 104);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(124, 39);
            this.btnRun.TabIndex = 8;
            this.btnRun.Text = "Сумма";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // tbB
            // 
            this.tbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbB.Location = new System.Drawing.Point(164, 51);
            this.tbB.Margin = new System.Windows.Forms.Padding(4);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(205, 30);
            this.tbB.TabIndex = 6;
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbB.Location = new System.Drawing.Point(13, 54);
            this.lbB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(118, 25);
            this.lbB.TabIndex = 4;
            this.lbB.Text = "Значение В";
            // 
            // tbA
            // 
            this.tbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbA.Location = new System.Drawing.Point(164, 9);
            this.tbA.Margin = new System.Windows.Forms.Padding(4);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(205, 30);
            this.tbA.TabIndex = 7;
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbA.Location = new System.Drawing.Point(13, 9);
            this.lbA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(119, 25);
            this.lbA.TabIndex = 5;
            this.lbA.Text = "Значение А";
            // 
            // lbRes
            // 
            this.lbRes.AutoSize = true;
            this.lbRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRes.Location = new System.Drawing.Point(13, 160);
            this.lbRes.Name = "lbRes";
            this.lbRes.Size = new System.Drawing.Size(0, 25);
            this.lbRes.TabIndex = 10;
            // 
            // AsyncMethodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 213);
            this.Controls.Add(this.lbRes);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.lbA);
            this.MaximizeBox = false;
            this.Name = "AsyncMethodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Асинхронный запуск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbRes;
    }
}

