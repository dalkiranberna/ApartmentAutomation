namespace ApartmentAutomation
{
    partial class Expenses
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Amount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_AddExpense = new System.Windows.Forms.Button();
            this.radio_Electric = new System.Windows.Forms.RadioButton();
            this.radio_Water = new System.Windows.Forms.RadioButton();
            this.radio_Elevator = new System.Windows.Forms.RadioButton();
            this.radio_Cleanliness = new System.Windows.Forms.RadioButton();
            this.cbox_Mounths = new System.Windows.Forms.ComboBox();
            this.btn_Watch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(584, 220);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_Cleanliness);
            this.groupBox1.Controls.Add(this.radio_Elevator);
            this.groupBox1.Controls.Add(this.radio_Water);
            this.groupBox1.Controls.Add(this.radio_Electric);
            this.groupBox1.Controls.Add(this.btn_AddExpense);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_Amount);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 185);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Expense";
            // 
            // tb_Amount
            // 
            this.tb_Amount.Location = new System.Drawing.Point(314, 21);
            this.tb_Amount.Name = "tb_Amount";
            this.tb_Amount.Size = new System.Drawing.Size(77, 20);
            this.tb_Amount.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(314, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(183, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // btn_AddExpense
            // 
            this.btn_AddExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AddExpense.Location = new System.Drawing.Point(249, 134);
            this.btn_AddExpense.Name = "btn_AddExpense";
            this.btn_AddExpense.Size = new System.Drawing.Size(248, 32);
            this.btn_AddExpense.TabIndex = 8;
            this.btn_AddExpense.Text = "Add";
            this.btn_AddExpense.UseVisualStyleBackColor = true;
            this.btn_AddExpense.Click += new System.EventHandler(this.btn_AddExpense_Click);
            // 
            // radio_Electric
            // 
            this.radio_Electric.AutoSize = true;
            this.radio_Electric.Cursor = System.Windows.Forms.Cursors.Default;
            this.radio_Electric.Location = new System.Drawing.Point(22, 28);
            this.radio_Electric.Name = "radio_Electric";
            this.radio_Electric.Size = new System.Drawing.Size(60, 17);
            this.radio_Electric.TabIndex = 9;
            this.radio_Electric.Text = "Electric";
            this.radio_Electric.UseVisualStyleBackColor = true;
            // 
            // radio_Water
            // 
            this.radio_Water.AutoSize = true;
            this.radio_Water.Cursor = System.Windows.Forms.Cursors.Default;
            this.radio_Water.Location = new System.Drawing.Point(22, 65);
            this.radio_Water.Name = "radio_Water";
            this.radio_Water.Size = new System.Drawing.Size(54, 17);
            this.radio_Water.TabIndex = 10;
            this.radio_Water.Text = "Water";
            this.radio_Water.UseVisualStyleBackColor = true;
            // 
            // radio_Elevator
            // 
            this.radio_Elevator.AutoSize = true;
            this.radio_Elevator.Cursor = System.Windows.Forms.Cursors.Default;
            this.radio_Elevator.Location = new System.Drawing.Point(22, 108);
            this.radio_Elevator.Name = "radio_Elevator";
            this.radio_Elevator.Size = new System.Drawing.Size(64, 17);
            this.radio_Elevator.TabIndex = 11;
            this.radio_Elevator.Text = "Elevator";
            this.radio_Elevator.UseVisualStyleBackColor = true;
            // 
            // radio_Cleanliness
            // 
            this.radio_Cleanliness.AutoSize = true;
            this.radio_Cleanliness.Cursor = System.Windows.Forms.Cursors.Default;
            this.radio_Cleanliness.Location = new System.Drawing.Point(22, 143);
            this.radio_Cleanliness.Name = "radio_Cleanliness";
            this.radio_Cleanliness.Size = new System.Drawing.Size(78, 17);
            this.radio_Cleanliness.TabIndex = 12;
            this.radio_Cleanliness.Text = "Cleanliness";
            this.radio_Cleanliness.UseVisualStyleBackColor = true;
            // 
            // cbox_Mounths
            // 
            this.cbox_Mounths.FormattingEnabled = true;
            this.cbox_Mounths.Location = new System.Drawing.Point(69, 209);
            this.cbox_Mounths.Name = "cbox_Mounths";
            this.cbox_Mounths.Size = new System.Drawing.Size(121, 21);
            this.cbox_Mounths.TabIndex = 2;
            this.cbox_Mounths.SelectedIndexChanged += new System.EventHandler(this.cbox_Mounths_SelectedIndexChanged);
            // 
            // btn_Watch
            // 
            this.btn_Watch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Watch.Location = new System.Drawing.Point(249, 200);
            this.btn_Watch.Name = "btn_Watch";
            this.btn_Watch.Size = new System.Drawing.Size(248, 30);
            this.btn_Watch.TabIndex = 3;
            this.btn_Watch.Text = "Watch";
            this.btn_Watch.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mounths:";
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 467);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Watch);
            this.Controls.Add(this.cbox_Mounths);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Expenses";
            this.Text = "Expenses";
            this.Load += new System.EventHandler(this.Expenses_Load);
            this.Shown += new System.EventHandler(this.Expenses_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_AddExpense;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Amount;
        private System.Windows.Forms.RadioButton radio_Cleanliness;
        private System.Windows.Forms.RadioButton radio_Elevator;
        private System.Windows.Forms.RadioButton radio_Water;
        private System.Windows.Forms.RadioButton radio_Electric;
        private System.Windows.Forms.ComboBox cbox_Mounths;
        private System.Windows.Forms.Button btn_Watch;
        private System.Windows.Forms.Label label3;
    }
}