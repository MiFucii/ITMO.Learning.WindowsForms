
namespace Exercise4.DataValidationForm
{
    partial class ValidationForm
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
            this.lbClientInfo = new System.Windows.Forms.ListBox();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.dataValidation1 = new Exercise4.DataValidationForm.DataValidation();
            this.SuspendLayout();
            // 
            // lbClientInfo
            // 
            this.lbClientInfo.FormattingEnabled = true;
            this.lbClientInfo.Location = new System.Drawing.Point(388, 12);
            this.lbClientInfo.Name = "lbClientInfo";
            this.lbClientInfo.Size = new System.Drawing.Size(304, 160);
            this.lbClientInfo.TabIndex = 2;
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateClient.Location = new System.Drawing.Point(388, 179);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(304, 28);
            this.btnUpdateClient.TabIndex = 3;
            this.btnUpdateClient.Text = "Обновить список клиентов";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // dataValidation1
            // 
            this.dataValidation1.Location = new System.Drawing.Point(12, 12);
            this.dataValidation1.MaximumSize = new System.Drawing.Size(0, 200);
            this.dataValidation1.MinimumSize = new System.Drawing.Size(370, 200);
            this.dataValidation1.Name = "dataValidation1";
            this.dataValidation1.Size = new System.Drawing.Size(370, 200);
            this.dataValidation1.TabIndex = 0;
            // 
            // ValidationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 211);
            this.Controls.Add(this.btnUpdateClient);
            this.Controls.Add(this.lbClientInfo);
            this.Controls.Add(this.dataValidation1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 250);
            this.MinimumSize = new System.Drawing.Size(720, 250);
            this.Name = "ValidationForm";
            this.Text = "Данные о клиентах";
            this.ResumeLayout(false);

        }

        #endregion

        private DataValidation dataValidation1;
        private System.Windows.Forms.ListBox lbClientInfo;
        private System.Windows.Forms.Button btnUpdateClient;
    }
}

