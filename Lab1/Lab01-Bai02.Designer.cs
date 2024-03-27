namespace Lab1
{
    partial class Lab01_Bai02
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
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtNumber3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.btnMinMax = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(133, 105);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 20);
            this.txtNumber1.TabIndex = 0;
            this.txtNumber1.TextChanged += new System.EventHandler(this.txtNumber1_TextChanged);
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(331, 105);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 20);
            this.txtNumber2.TabIndex = 1;
            this.txtNumber2.TextChanged += new System.EventHandler(this.txtNumber2_TextChanged);
            // 
            // txtNumber3
            // 
            this.txtNumber3.Location = new System.Drawing.Point(552, 105);
            this.txtNumber3.Name = "txtNumber3";
            this.txtNumber3.Size = new System.Drawing.Size(100, 20);
            this.txtNumber3.TabIndex = 2;
            this.txtNumber3.TextChanged += new System.EventHandler(this.txtNumber3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số thứ 1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số thứ 2:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(473, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số thứ 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số lớn nhất:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(446, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số nhỏ nhất:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(133, 245);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 20);
            this.txtMax.TabIndex = 8;
            this.txtMax.TextChanged += new System.EventHandler(this.txtMax_TextChanged);
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(552, 245);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 20);
            this.txtMin.TabIndex = 9;
            this.txtMin.TextChanged += new System.EventHandler(this.txtMin_TextChanged);
            // 
            // btnMinMax
            // 
            this.btnMinMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinMax.Location = new System.Drawing.Point(228, 311);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(97, 52);
            this.btnMinMax.TabIndex = 10;
            this.btnMinMax.Text = "Tìm";
            this.btnMinMax.UseVisualStyleBackColor = true;
            this.btnMinMax.Click += new System.EventHandler(this.btnMinMax_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(367, 311);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 52);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Lab01_Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnMinMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumber3);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Lab01_Bai02";
            this.Text = "Bai2";
            this.Load += new System.EventHandler(this.Lab01_Bai02_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtNumber3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Button btnMinMax;
        private System.Windows.Forms.Button btnDelete;
    }
}