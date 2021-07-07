
namespace Exercise1.CreatingRectangularForm
{
    partial class nForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxClose = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxClose
            // 
            this.checkBoxClose.AutoSize = true;
            this.checkBoxClose.Location = new System.Drawing.Point(12, 12);
            this.checkBoxClose.Name = "checkBoxClose";
            this.checkBoxClose.Size = new System.Drawing.Size(112, 17);
            this.checkBoxClose.TabIndex = 0;
            this.checkBoxClose.Text = "Закрыть форму?";
            this.checkBoxClose.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(13, 36);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрыть форму";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // nForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.checkBoxClose);
            this.Name = "nForm";
            this.Text = "nForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.nForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxClose;
        private System.Windows.Forms.Button btnClose;
    }
}