namespace Bacusmo_Prelim
{
    partial class StudentDB
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_database = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            btn_entry = new Button();
            btn_save = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_database).BeginInit();
            SuspendLayout();
            // 
            // dgv_database
            // 
            dgv_database.BackgroundColor = SystemColors.Info;
            dgv_database.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_database.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgv_database.Location = new Point(12, 50);
            dgv_database.Name = "dgv_database";
            dgv_database.RowTemplate.Height = 25;
            dgv_database.Size = new Size(644, 268);
            dgv_database.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "LASTNAME";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "FIRSTNAME";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "MI";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "COURSE";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "YEAR";
            Column6.Name = "Column6";
            // 
            // btn_entry
            // 
            btn_entry.BackColor = Color.LemonChiffon;
            btn_entry.Location = new Point(37, 334);
            btn_entry.Name = "btn_entry";
            btn_entry.Size = new Size(90, 28);
            btn_entry.TabIndex = 1;
            btn_entry.Text = "Add Entry";
            btn_entry.UseVisualStyleBackColor = false;
            btn_entry.Click += button1_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.LemonChiffon;
            btn_save.Location = new Point(153, 334);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(90, 28);
            btn_save.TabIndex = 2;
            btn_save.Text = "Save to file";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(211, 18);
            label1.Name = "label1";
            label1.Size = new Size(247, 19);
            label1.TabIndex = 3;
            label1.Text = "STUDENT INFORMATION DATABASE";
            label1.Click += label1_Click;
            // 
            // StudentDB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(668, 377);
            Controls.Add(label1);
            Controls.Add(btn_save);
            Controls.Add(btn_entry);
            Controls.Add(dgv_database);
            Name = "StudentDB";
            Text = "Student Information DataBase";
            ((System.ComponentModel.ISupportInitialize)dgv_database).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        public DataGridView dgv_database;
        private Button btn_entry;
        private Button btn_save;
        private Label label1;
    }
}