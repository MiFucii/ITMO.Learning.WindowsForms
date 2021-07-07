
namespace Exercise4.DataValidationForm
{
    partial class DataValidation
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbAge
            // 
            this.tbAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAge.Location = new System.Drawing.Point(160, 68);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(202, 20);
            this.tbAge.TabIndex = 2;
            this.tbAge.Enter += new System.EventHandler(this.tbAge_Enter);
            this.tbAge.Leave += new System.EventHandler(this.tbAge_Leave);
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbName.Location = new System.Drawing.Point(160, 3);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(202, 20);
            this.tbName.TabIndex = 0;
            this.tbName.Enter += new System.EventHandler(this.tbName_Enter);
            this.tbName.Leave += new System.EventHandler(this.tbName_Leave);
            // 
            // tbLastName
            // 
            this.tbLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLastName.Location = new System.Drawing.Point(160, 35);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(202, 20);
            this.tbLastName.TabIndex = 1;
            this.tbLastName.Enter += new System.EventHandler(this.tbLastName_Enter);
            this.tbLastName.Leave += new System.EventHandler(this.tbLastName_Leave);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(-1, 1);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(115, 20);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Введите Имя:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(0, 132);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(370, 29);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLastName.Location = new System.Drawing.Point(-1, 33);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(155, 20);
            this.lbLastName.TabIndex = 6;
            this.lbLastName.Text = "Введите Фамилию";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAge.Location = new System.Drawing.Point(-1, 66);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(107, 20);
            this.lbAge.TabIndex = 7;
            this.lbAge.Text = "Ваш возраст";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEmail.Location = new System.Drawing.Point(-1, 97);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(83, 20);
            this.lbEmail.TabIndex = 8;
            this.lbEmail.Text = "Ваш email";
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmail.Location = new System.Drawing.Point(160, 99);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(202, 20);
            this.tbEmail.TabIndex = 3;
            this.tbEmail.Enter += new System.EventHandler(this.tbEmail_Enter);
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(0, 167);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(370, 29);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // DataValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbAge);
            this.MaximumSize = new System.Drawing.Size(0, 200);
            this.MinimumSize = new System.Drawing.Size(370, 200);
            this.Name = "DataValidation";
            this.Size = new System.Drawing.Size(370, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbEmail;
        protected System.Windows.Forms.TextBox tbName;
        protected System.Windows.Forms.TextBox tbLastName;
        protected System.Windows.Forms.Button btnSave;
        protected System.Windows.Forms.TextBox tbAge;
        protected System.Windows.Forms.TextBox tbEmail;
        protected System.Windows.Forms.Button btnClear;
    }
}
