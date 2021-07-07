
namespace Exercise1.ConnectionMicrosoftExcel
{
    partial class ExcelForm
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
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lbFileName = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(18, 19);
            this.btnGetInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(112, 36);
            this.btnGetInfo.TabIndex = 0;
            this.btnGetInfo.Text = "Открыть";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // tbPath
            // 
            this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath.Location = new System.Drawing.Point(138, 523);
            this.tbPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(633, 26);
            this.tbPath.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(138, 19);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(633, 494);
            this.dataGridView.TabIndex = 2;
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Location = new System.Drawing.Point(14, 523);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(100, 20);
            this.lbFileName.TabIndex = 3;
            this.lbFileName.Text = "Имя файла:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "*.xls;*.xlsx";
            this.openFileDialog.Filter = "Excel 2010(*.xlsx)|*.xlsx|Excel 2003(*.xls)|*.xls";
            this.openFileDialog.Title = "Выберите документ для загрузки данных:";
            // 
            // ExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lbFileName);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btnGetInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.Name = "ExcelForm";
            this.Text = "Просмотр Excel файлов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

