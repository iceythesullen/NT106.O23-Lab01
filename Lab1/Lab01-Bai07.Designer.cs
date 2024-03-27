namespace Lab1
{
    partial class Lab01_Bai07
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên, danh sách điểm sinh viên: ";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(40, 74);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(511, 20);
            this.txtInput.TabIndex = 1;
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(40, 226);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(715, 212);
            this.lstResults.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kết quả:";
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(40, 110);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(133, 43);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Xử lý";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(200, 110);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 43);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Lab01_Bai07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "Lab01_Bai07";
            this.Text = "Lab01_Bai07";
            this.Load += new System.EventHandler(this.Lab01_Bai07_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnDelete;
    }
}