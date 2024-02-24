namespace Bacusmo_Prelim
{
    partial class StudentInfo
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
            groupBox1 = new GroupBox();
            label7 = new Label();
            cb_year = new ComboBox();
            cb_course = new ComboBox();
            txb_MI = new TextBox();
            txb_FN = new TextBox();
            txb_LN = new TextBox();
            txb_ID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_AddInfo = new Button();
            txb_c = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cb_year);
            groupBox1.Controls.Add(cb_course);
            groupBox1.Controls.Add(txb_MI);
            groupBox1.Controls.Add(txb_FN);
            groupBox1.Controls.Add(txb_LN);
            groupBox1.Controls.Add(txb_ID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(26, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 300);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Info";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(29, 256);
            label7.Name = "label7";
            label7.Size = new Size(190, 19);
            label7.TabIndex = 12;
            label7.Text = "**Press Add Info When Done.";
            // 
            // cb_year
            // 
            cb_year.FormattingEnabled = true;
            cb_year.Items.AddRange(new object[] { "1st Year", "2nd Year", "3rd Year", "4th Year", "5th Year" });
            cb_year.Location = new Point(104, 196);
            cb_year.Name = "cb_year";
            cb_year.Size = new Size(115, 23);
            cb_year.TabIndex = 11;
            // 
            // cb_course
            // 
            cb_course.FormattingEnabled = true;
            cb_course.Items.AddRange(new object[] { "BS Architecture", "BS Chemical Engineering", "BS Civil Engineering", "BS Computer Engineering", "BS Electrical Engineering", "BS Electronics Engineering", "BS Industrial Engineering", "BS Mechanical Engineering", "with Computational Science", "BS Mechanical Engineering", "with Mechatronics", "BS Mining Engineering", "BS Accounting Information Systems", "BS Management Accounting", "BS Business Administration", "Banking & Financial Management", "Business Analytics", "General Business Management", "Human Resource Management", "Marketing Management", "Operations Management", "Quality Management", "BS Hospitality Management", "BS Tourism Management", "BS Office Administration", "Associate in Office administration", "Bachelor in Public Administration", "AB Communication", "AB English with Applied Linguistics", "Bachelor of Elementary Education", "Bachelor of Secondary Education", "Major in English, Filipino, Mathematics and Science", "Bachelor of Multimedia Arts", "BS Biology", "BS Math with Applied Industrial Mathematics", "BS Psychology", "BS Computer Science", "BS Information Technology", "Master in Computer Science", "Master of Science in Computer Science", "Master in Information Technology" });
            cb_course.Location = new Point(104, 167);
            cb_course.Name = "cb_course";
            cb_course.Size = new Size(115, 23);
            cb_course.TabIndex = 10;
            // 
            // txb_MI
            // 
            txb_MI.Location = new Point(104, 138);
            txb_MI.Name = "txb_MI";
            txb_MI.Size = new Size(115, 23);
            txb_MI.TabIndex = 9;
            // 
            // txb_FN
            // 
            txb_FN.Location = new Point(104, 109);
            txb_FN.Name = "txb_FN";
            txb_FN.Size = new Size(115, 23);
            txb_FN.TabIndex = 8;
            // 
            // txb_LN
            // 
            txb_LN.Location = new Point(104, 80);
            txb_LN.Name = "txb_LN";
            txb_LN.Size = new Size(115, 23);
            txb_LN.TabIndex = 7;
            // 
            // txb_ID
            // 
            txb_ID.Location = new Point(104, 51);
            txb_ID.Name = "txb_ID";
            txb_ID.Size = new Size(115, 23);
            txb_ID.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 200);
            label6.Name = "label6";
            label6.Size = new Size(44, 19);
            label6.TabIndex = 5;
            label6.Text = "YEAR:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 171);
            label5.Name = "label5";
            label5.Size = new Size(64, 19);
            label5.TabIndex = 4;
            label5.Text = "COURSE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 142);
            label4.Name = "label4";
            label4.Size = new Size(29, 19);
            label4.TabIndex = 3;
            label4.Text = "MI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 113);
            label3.Name = "label3";
            label3.Size = new Size(84, 19);
            label3.TabIndex = 2;
            label3.Text = "FIRSTNAME:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 84);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 1;
            label2.Text = "LASTNAME:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 52);
            label1.Name = "label1";
            label1.Size = new Size(92, 19);
            label1.TabIndex = 0;
            label1.Text = "STUDENT ID: ";
            label1.Click += label1_Click;
            // 
            // btn_AddInfo
            // 
            btn_AddInfo.Location = new Point(67, 328);
            btn_AddInfo.Name = "btn_AddInfo";
            btn_AddInfo.Size = new Size(88, 28);
            btn_AddInfo.TabIndex = 1;
            btn_AddInfo.Text = "Add Info";
            btn_AddInfo.UseVisualStyleBackColor = true;
            btn_AddInfo.Click += button1_Click;
            // 
            // txb_c
            // 
            txb_c.Location = new Point(161, 328);
            txb_c.Name = "txb_c";
            txb_c.Size = new Size(88, 28);
            txb_c.TabIndex = 2;
            txb_c.Text = "Clear";
            txb_c.UseVisualStyleBackColor = true;
            txb_c.Click += txb_c_Click;
            // 
            // StudentInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 372);
            Controls.Add(txb_c);
            Controls.Add(btn_AddInfo);
            Controls.Add(groupBox1);
            Name = "StudentInfo";
            Text = "Student Info";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private ComboBox cb_year;
        private ComboBox cb_course;
        private TextBox txb_MI;
        private TextBox txb_FN;
        private TextBox txb_LN;
        private TextBox txb_ID;
        private Button btn_AddInfo;
        private Button txb_c;
    }
}