namespace Sample01
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Manager_Save = new System.Windows.Forms.Button();
            this.Txt_Manager_LName = new System.Windows.Forms.TextBox();
            this.Txt_Manager_FName = new System.Windows.Forms.TextBox();
            this.Txt_Manager_Id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Teacher_Save = new System.Windows.Forms.Button();
            this.Txt_Teacher_LName = new System.Windows.Forms.TextBox();
            this.Txt_Teacher_FName = new System.Windows.Forms.TextBox();
            this.Txt_Teacher_Id = new System.Windows.Forms.TextBox();
            this.RDB_3 = new System.Windows.Forms.RadioButton();
            this.RDB_2 = new System.Windows.Forms.RadioButton();
            this.RDB_1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_Student_Save = new System.Windows.Forms.Button();
            this.Txt_Student_LName = new System.Windows.Forms.TextBox();
            this.Txt_Student_FName = new System.Windows.Forms.TextBox();
            this.Txt_Student_Id = new System.Windows.Forms.TextBox();
            this.Txt_Show_Result = new System.Windows.Forms.RichTextBox();
            this.Btn_Print = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Manager_Save);
            this.groupBox1.Controls.Add(this.Txt_Manager_LName);
            this.groupBox1.Controls.Add(this.Txt_Manager_FName);
            this.groupBox1.Controls.Add(this.Txt_Manager_Id);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manager";
            // 
            // Btn_Manager_Save
            // 
            this.Btn_Manager_Save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Manager_Save.Location = new System.Drawing.Point(6, 195);
            this.Btn_Manager_Save.Name = "Btn_Manager_Save";
            this.Btn_Manager_Save.Size = new System.Drawing.Size(75, 28);
            this.Btn_Manager_Save.TabIndex = 3;
            this.Btn_Manager_Save.Text = "save";
            this.Btn_Manager_Save.UseVisualStyleBackColor = true;
            this.Btn_Manager_Save.Click += new System.EventHandler(this.Button_click);
            // 
            // Txt_Manager_LName
            // 
            this.Txt_Manager_LName.Location = new System.Drawing.Point(50, 100);
            this.Txt_Manager_LName.Name = "Txt_Manager_LName";
            this.Txt_Manager_LName.Size = new System.Drawing.Size(100, 23);
            this.Txt_Manager_LName.TabIndex = 2;
            // 
            // Txt_Manager_FName
            // 
            this.Txt_Manager_FName.Location = new System.Drawing.Point(50, 62);
            this.Txt_Manager_FName.Name = "Txt_Manager_FName";
            this.Txt_Manager_FName.Size = new System.Drawing.Size(100, 23);
            this.Txt_Manager_FName.TabIndex = 1;
            // 
            // Txt_Manager_Id
            // 
            this.Txt_Manager_Id.Location = new System.Drawing.Point(50, 20);
            this.Txt_Manager_Id.Name = "Txt_Manager_Id";
            this.Txt_Manager_Id.Size = new System.Drawing.Size(100, 23);
            this.Txt_Manager_Id.TabIndex = 0;
            this.Txt_Manager_Id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Id_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "LName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "FName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Btn_Teacher_Save);
            this.groupBox2.Controls.Add(this.Txt_Teacher_LName);
            this.groupBox2.Controls.Add(this.Txt_Teacher_FName);
            this.groupBox2.Controls.Add(this.Txt_Teacher_Id);
            this.groupBox2.Location = new System.Drawing.Point(227, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "teacher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "LName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "FName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Id";
            // 
            // Btn_Teacher_Save
            // 
            this.Btn_Teacher_Save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Teacher_Save.Location = new System.Drawing.Point(6, 195);
            this.Btn_Teacher_Save.Name = "Btn_Teacher_Save";
            this.Btn_Teacher_Save.Size = new System.Drawing.Size(75, 28);
            this.Btn_Teacher_Save.TabIndex = 3;
            this.Btn_Teacher_Save.Text = "save";
            this.Btn_Teacher_Save.UseVisualStyleBackColor = true;
            this.Btn_Teacher_Save.Click += new System.EventHandler(this.Button_click);
            // 
            // Txt_Teacher_LName
            // 
            this.Txt_Teacher_LName.Location = new System.Drawing.Point(57, 97);
            this.Txt_Teacher_LName.Name = "Txt_Teacher_LName";
            this.Txt_Teacher_LName.Size = new System.Drawing.Size(100, 23);
            this.Txt_Teacher_LName.TabIndex = 2;
            // 
            // Txt_Teacher_FName
            // 
            this.Txt_Teacher_FName.Location = new System.Drawing.Point(57, 59);
            this.Txt_Teacher_FName.Name = "Txt_Teacher_FName";
            this.Txt_Teacher_FName.Size = new System.Drawing.Size(100, 23);
            this.Txt_Teacher_FName.TabIndex = 1;
            // 
            // Txt_Teacher_Id
            // 
            this.Txt_Teacher_Id.Location = new System.Drawing.Point(57, 17);
            this.Txt_Teacher_Id.Name = "Txt_Teacher_Id";
            this.Txt_Teacher_Id.Size = new System.Drawing.Size(100, 23);
            this.Txt_Teacher_Id.TabIndex = 0;
            this.Txt_Teacher_Id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Id_KeyDown);
            // 
            // RDB_3
            // 
            this.RDB_3.AutoSize = true;
            this.RDB_3.Location = new System.Drawing.Point(81, 126);
            this.RDB_3.Name = "RDB_3";
            this.RDB_3.Size = new System.Drawing.Size(31, 19);
            this.RDB_3.TabIndex = 19;
            this.RDB_3.Text = "3";
            this.RDB_3.UseVisualStyleBackColor = true;
            // 
            // RDB_2
            // 
            this.RDB_2.AutoSize = true;
            this.RDB_2.Location = new System.Drawing.Point(44, 126);
            this.RDB_2.Name = "RDB_2";
            this.RDB_2.Size = new System.Drawing.Size(31, 19);
            this.RDB_2.TabIndex = 18;
            this.RDB_2.Text = "2";
            this.RDB_2.UseVisualStyleBackColor = true;
            // 
            // RDB_1
            // 
            this.RDB_1.AutoSize = true;
            this.RDB_1.Checked = true;
            this.RDB_1.Location = new System.Drawing.Point(7, 126);
            this.RDB_1.Name = "RDB_1";
            this.RDB_1.Size = new System.Drawing.Size(31, 19);
            this.RDB_1.TabIndex = 17;
            this.RDB_1.TabStop = true;
            this.RDB_1.Text = "1";
            this.RDB_1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RDB_3);
            this.groupBox3.Controls.Add(this.RDB_2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.RDB_1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.Btn_Student_Save);
            this.groupBox3.Controls.Add(this.Txt_Student_LName);
            this.groupBox3.Controls.Add(this.Txt_Student_FName);
            this.groupBox3.Controls.Add(this.Txt_Student_Id);
            this.groupBox3.Location = new System.Drawing.Point(438, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 229);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "student";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "LName";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "FName";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Id";
            // 
            // Btn_Student_Save
            // 
            this.Btn_Student_Save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Student_Save.Location = new System.Drawing.Point(6, 195);
            this.Btn_Student_Save.Name = "Btn_Student_Save";
            this.Btn_Student_Save.Size = new System.Drawing.Size(75, 28);
            this.Btn_Student_Save.TabIndex = 3;
            this.Btn_Student_Save.Text = "save";
            this.Btn_Student_Save.UseVisualStyleBackColor = true;
            this.Btn_Student_Save.Click += new System.EventHandler(this.Button_click);
            // 
            // Txt_Student_LName
            // 
            this.Txt_Student_LName.Location = new System.Drawing.Point(57, 97);
            this.Txt_Student_LName.Name = "Txt_Student_LName";
            this.Txt_Student_LName.Size = new System.Drawing.Size(100, 23);
            this.Txt_Student_LName.TabIndex = 2;
            // 
            // Txt_Student_FName
            // 
            this.Txt_Student_FName.Location = new System.Drawing.Point(57, 59);
            this.Txt_Student_FName.Name = "Txt_Student_FName";
            this.Txt_Student_FName.Size = new System.Drawing.Size(100, 23);
            this.Txt_Student_FName.TabIndex = 1;
            // 
            // Txt_Student_Id
            // 
            this.Txt_Student_Id.Location = new System.Drawing.Point(57, 17);
            this.Txt_Student_Id.Name = "Txt_Student_Id";
            this.Txt_Student_Id.Size = new System.Drawing.Size(100, 23);
            this.Txt_Student_Id.TabIndex = 0;
            this.Txt_Student_Id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Id_KeyDown);
            // 
            // Txt_Show_Result
            // 
            this.Txt_Show_Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(83)))), ((int)(((byte)(128)))));
            this.Txt_Show_Result.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Txt_Show_Result.Location = new System.Drawing.Point(0, 255);
            this.Txt_Show_Result.Name = "Txt_Show_Result";
            this.Txt_Show_Result.ReadOnly = true;
            this.Txt_Show_Result.Size = new System.Drawing.Size(621, 195);
            this.Txt_Show_Result.TabIndex = 2;
            this.Txt_Show_Result.Text = "";
            this.Txt_Show_Result.Visible = false;
            // 
            // Btn_Print
            // 
            this.Btn_Print.Enabled = false;
            this.Btn_Print.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Print.Location = new System.Drawing.Point(284, 276);
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(75, 28);
            this.Btn_Print.TabIndex = 0;
            this.Btn_Print.Text = "print";
            this.Btn_Print.UseVisualStyleBackColor = true;
            this.Btn_Print.Click += new System.EventHandler(this.Button_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(621, 450);
            this.Controls.Add(this.Btn_Print);
            this.Controls.Add(this.Txt_Show_Result);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox Txt_Manager_LName;
        private TextBox Txt_Manager_FName;
        private TextBox Txt_Manager_Id;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button Btn_Manager_Save;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button Btn_Teacher_Save;
        private TextBox Txt_Teacher_LName;
        private TextBox Txt_Teacher_FName;
        private TextBox Txt_Teacher_Id;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button Btn_Student_Save;
        private TextBox Txt_Student_LName;
        private TextBox Txt_Student_FName;
        private TextBox Txt_Student_Id;
        private RichTextBox Txt_Show_Result;
        private Button Btn_Print;
        private RadioButton RDB_3;
        private RadioButton RDB_2;
        private RadioButton RDB_1;
    }
}