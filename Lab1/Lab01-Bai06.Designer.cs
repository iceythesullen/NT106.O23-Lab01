namespace Lab1
{
    partial class Lab01_Bai06
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
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(246, 149);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(281, 20);
            this.dtpDateOfBirth.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn ngày tháng năm sinh:";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(344, 216);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(91, 41);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Kiểm tra";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Lab01_Bai06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Name = "Lab01_Bai06";
            this.Text = "Lab01_Bai06";
            this.Load += new System.EventHandler(this.Lab01_Bai06_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheck;
    }
}