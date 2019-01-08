namespace ApartmentAutomation
{
    partial class Form1
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
            this.btn_Incomes = new System.Windows.Forms.Button();
            this.btn_Expenses = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Incomes
            // 
            this.btn_Incomes.BackColor = System.Drawing.Color.Peru;
            this.btn_Incomes.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Incomes.Location = new System.Drawing.Point(89, 259);
            this.btn_Incomes.Name = "btn_Incomes";
            this.btn_Incomes.Size = new System.Drawing.Size(155, 94);
            this.btn_Incomes.TabIndex = 0;
            this.btn_Incomes.Text = "Incomes";
            this.btn_Incomes.UseVisualStyleBackColor = false;
            this.btn_Incomes.Click += new System.EventHandler(this.btn_Incomes_Click);
            // 
            // btn_Expenses
            // 
            this.btn_Expenses.BackColor = System.Drawing.Color.Peru;
            this.btn_Expenses.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Expenses.Location = new System.Drawing.Point(286, 259);
            this.btn_Expenses.Name = "btn_Expenses";
            this.btn_Expenses.Size = new System.Drawing.Size(155, 94);
            this.btn_Expenses.TabIndex = 1;
            this.btn_Expenses.Text = "Expenses";
            this.btn_Expenses.UseVisualStyleBackColor = false;
            this.btn_Expenses.Click += new System.EventHandler(this.btn_Expenses_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "      Aparment Automation";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ApartmentAutomation.Properties.Resources.bina;
            this.pictureBox1.Location = new System.Drawing.Point(144, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(556, 393);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Expenses);
            this.Controls.Add(this.btn_Incomes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Incomes;
        private System.Windows.Forms.Button btn_Expenses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

