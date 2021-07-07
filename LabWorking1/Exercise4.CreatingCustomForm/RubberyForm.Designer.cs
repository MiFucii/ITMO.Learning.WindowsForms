
namespace Exercise4.CreatingCustomForm
{
    partial class RubberyForm
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
            this.lbDate = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbDate = new System.Windows.Forms.RichTextBox();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnRhomb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDate.Location = new System.Drawing.Point(13, 13);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(142, 20);
            this.lbDate.TabIndex = 0;
            this.lbDate.Text = "Введите данные:";
            // 
            // tbDate
            // 
            this.tbDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDate.Location = new System.Drawing.Point(161, 15);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(311, 20);
            this.tbDate.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(352, 58);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(120, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Отправить";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // rtbDate
            // 
            this.rtbDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDate.Location = new System.Drawing.Point(17, 58);
            this.rtbDate.Name = "rtbDate";
            this.rtbDate.Size = new System.Drawing.Size(329, 191);
            this.rtbDate.TabIndex = 3;
            this.rtbDate.Text = "";
            // 
            // btnEllipse
            // 
            this.btnEllipse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEllipse.Location = new System.Drawing.Point(352, 88);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(120, 23);
            this.btnEllipse.TabIndex = 4;
            this.btnEllipse.Text = "Овальная форма";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnRhomb
            // 
            this.btnRhomb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRhomb.Location = new System.Drawing.Point(352, 118);
            this.btnRhomb.Name = "btnRhomb";
            this.btnRhomb.Size = new System.Drawing.Size(120, 23);
            this.btnRhomb.TabIndex = 5;
            this.btnRhomb.Text = "Ромб форма";
            this.btnRhomb.UseVisualStyleBackColor = true;
            this.btnRhomb.Click += new System.EventHandler(this.btnRhomb_Click);
            // 
            // RubberyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btnRhomb);
            this.Controls.Add(this.btnEllipse);
            this.Controls.Add(this.rtbDate);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.lbDate);
            this.MinimumSize = new System.Drawing.Size(350, 200);
            this.Name = "RubberyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "RubberyForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtbDate;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnRhomb;
    }
}