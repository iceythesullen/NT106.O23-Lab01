namespace Lab1
{
    partial class Lab01_Bai05
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnMultiplicationTable = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập B:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(178, 74);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(521, 75);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(109, 167);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(136, 42);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Tính các giá trị";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnMultiplicationTable
            // 
            this.btnMultiplicationTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicationTable.Location = new System.Drawing.Point(296, 167);
            this.btnMultiplicationTable.Name = "btnMultiplicationTable";
            this.btnMultiplicationTable.Size = new System.Drawing.Size(146, 42);
            this.btnMultiplicationTable.TabIndex = 5;
            this.btnMultiplicationTable.Text = "Bảng cửu chương";
            this.btnMultiplicationTable.UseVisualStyleBackColor = true;
            this.btnMultiplicationTable.Click += new System.EventHandler(this.btnMultiplicationTable_Click);
            // 
            // lstResults
            // 
            this.lstResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 16;
            this.lstResults.Location = new System.Drawing.Point(109, 269);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(512, 148);
            this.lstResults.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(485, 167);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 42);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // Lab01_Bai05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnMultiplicationTable);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lab01_Bai05";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Lab01_Bai05_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnMultiplicationTable;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Button btnDelete;
    }
}