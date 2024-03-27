namespace Lab1
{
    partial class Lab01_Bai08
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
            this.txtNewFood = new System.Windows.Forms.TextBox();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.lstFavoriteFoods = new System.Windows.Forms.ListBox();
            this.btnPickFood = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSelectedFood = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập món ăn:";
            // 
            // txtNewFood
            // 
            this.txtNewFood.Location = new System.Drawing.Point(171, 45);
            this.txtNewFood.Name = "txtNewFood";
            this.txtNewFood.Size = new System.Drawing.Size(219, 20);
            this.txtNewFood.TabIndex = 1;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.Location = new System.Drawing.Point(406, 36);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(89, 34);
            this.btnAddFood.TabIndex = 2;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // lstFavoriteFoods
            // 
            this.lstFavoriteFoods.FormattingEnabled = true;
            this.lstFavoriteFoods.Location = new System.Drawing.Point(512, 38);
            this.lstFavoriteFoods.Name = "lstFavoriteFoods";
            this.lstFavoriteFoods.Size = new System.Drawing.Size(259, 225);
            this.lstFavoriteFoods.TabIndex = 3;
            // 
            // btnPickFood
            // 
            this.btnPickFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPickFood.Location = new System.Drawing.Point(52, 287);
            this.btnPickFood.Name = "btnPickFood";
            this.btnPickFood.Size = new System.Drawing.Size(159, 34);
            this.btnPickFood.TabIndex = 4;
            this.btnPickFood.Text = "Tìm món ăn";
            this.btnPickFood.UseVisualStyleBackColor = true;
            this.btnPickFood.Click += new System.EventHandler(this.btnPickFood_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(569, 287);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(159, 34);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSelectedFood
            // 
            this.txtSelectedFood.Location = new System.Drawing.Point(264, 380);
            this.txtSelectedFood.Name = "txtSelectedFood";
            this.txtSelectedFood.Size = new System.Drawing.Size(219, 20);
            this.txtSelectedFood.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Món ăn hôm nay ăn là:";
            // 
            // Lab01_Bai08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSelectedFood);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPickFood);
            this.Controls.Add(this.lstFavoriteFoods);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.txtNewFood);
            this.Controls.Add(this.label1);
            this.Name = "Lab01_Bai08";
            this.Text = "Lab01_Bai08";
            this.Load += new System.EventHandler(this.Lab01_Bai08_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ListBox lstFavoriteFoods;
        private System.Windows.Forms.Button btnPickFood;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSelectedFood;
        private System.Windows.Forms.Label label2;
    }
}