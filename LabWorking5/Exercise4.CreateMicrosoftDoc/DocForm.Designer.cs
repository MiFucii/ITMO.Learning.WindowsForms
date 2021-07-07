
namespace Exercise4.CreateMicrosoftDoc
{
    partial class DocForm
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
            this.btnCreateDoc = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnCreateDoc
            // 
            this.btnCreateDoc.Location = new System.Drawing.Point(12, 12);
            this.btnCreateDoc.Name = "btnCreateDoc";
            this.btnCreateDoc.Size = new System.Drawing.Size(198, 35);
            this.btnCreateDoc.TabIndex = 0;
            this.btnCreateDoc.Text = "Создать документ";
            this.btnCreateDoc.UseVisualStyleBackColor = true;
            this.btnCreateDoc.Click += new System.EventHandler(this.btnCreateDoc_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "otchet1.docx";
            this.saveFileDialog.Title = "Выберите место для сохранения:";
            // 
            // DocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 61);
            this.Controls.Add(this.btnCreateDoc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(455, 100);
            this.MinimumSize = new System.Drawing.Size(455, 100);
            this.Name = "DocForm";
            this.Text = "Создание отчета";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateDoc;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

