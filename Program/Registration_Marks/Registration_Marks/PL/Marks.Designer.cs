namespace Registration_Marks.PL
{
    partial class Marks
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Seassion_mark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_exam_mark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_term = new System.Windows.Forms.ComboBox();
            this.btn_edite = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox_operation = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_subject = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.groupBox_cours = new System.Windows.Forms.GroupBox();
            this.groupBox_mark = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.date_time = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox_cours.SuspendLayout();
            this.groupBox_mark.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(65, 29);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 0;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(89, 19);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(93, 35);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_name
            // 
            this.txt_name.Enabled = false;
            this.txt_name.Location = new System.Drawing.Point(358, 29);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(184, 20);
            this.txt_name.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Subject Name :";
            // 
            // txt_Seassion_mark
            // 
            this.txt_Seassion_mark.Location = new System.Drawing.Point(106, 31);
            this.txt_Seassion_mark.Name = "txt_Seassion_mark";
            this.txt_Seassion_mark.Size = new System.Drawing.Size(143, 20);
            this.txt_Seassion_mark.TabIndex = 4;
            this.txt_Seassion_mark.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Seassion_mark_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Session Mark";
            // 
            // txt_exam_mark
            // 
            this.txt_exam_mark.Location = new System.Drawing.Point(106, 75);
            this.txt_exam_mark.Name = "txt_exam_mark";
            this.txt_exam_mark.Size = new System.Drawing.Size(143, 20);
            this.txt_exam_mark.TabIndex = 5;
            this.txt_exam_mark.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_exam_mark_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Exam Mark";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Term :";
            // 
            // comboBox_term
            // 
            this.comboBox_term.FormattingEnabled = true;
            this.comboBox_term.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox_term.Location = new System.Drawing.Point(102, 34);
            this.comboBox_term.Name = "comboBox_term";
            this.comboBox_term.Size = new System.Drawing.Size(121, 21);
            this.comboBox_term.TabIndex = 2;
            this.comboBox_term.SelectedIndexChanged += new System.EventHandler(this.comboBox_term_SelectedIndexChanged);
            // 
            // btn_edite
            // 
            this.btn_edite.Location = new System.Drawing.Point(230, 19);
            this.btn_edite.Name = "btn_edite";
            this.btn_edite.Size = new System.Drawing.Size(93, 35);
            this.btn_edite.TabIndex = 9;
            this.btn_edite.Text = "Edite ( Save )";
            this.btn_edite.UseVisualStyleBackColor = true;
            this.btn_edite.Click += new System.EventHandler(this.btn_edite_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(370, 19);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(88, 35);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(76, 528);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 150);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comboBox_operation
            // 
            this.comboBox_operation.FormattingEnabled = true;
            this.comboBox_operation.Items.AddRange(new object[] {
            "ADD",
            "UPDATE",
            "DELETE"});
            this.comboBox_operation.Location = new System.Drawing.Point(302, 410);
            this.comboBox_operation.Name = "comboBox_operation";
            this.comboBox_operation.Size = new System.Drawing.Size(121, 21);
            this.comboBox_operation.TabIndex = 7;
            this.comboBox_operation.SelectedIndexChanged += new System.EventHandler(this.comboBox_operation_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Operation";
            // 
            // comboBox_subject
            // 
            this.comboBox_subject.FormattingEnabled = true;
            this.comboBox_subject.Location = new System.Drawing.Point(102, 116);
            this.comboBox_subject.Name = "comboBox_subject";
            this.comboBox_subject.Size = new System.Drawing.Size(121, 21);
            this.comboBox_subject.TabIndex = 3;
            this.comboBox_subject.SelectedIndexChanged += new System.EventHandler(this.comboBox_subject_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ok);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(76, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 128);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(210, 74);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(119, 32);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "Search";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // groupBox_cours
            // 
            this.groupBox_cours.Controls.Add(this.comboBox_subject);
            this.groupBox_cours.Controls.Add(this.label3);
            this.groupBox_cours.Controls.Add(this.label7);
            this.groupBox_cours.Controls.Add(this.comboBox_term);
            this.groupBox_cours.Location = new System.Drawing.Point(76, 203);
            this.groupBox_cours.Name = "groupBox_cours";
            this.groupBox_cours.Size = new System.Drawing.Size(264, 188);
            this.groupBox_cours.TabIndex = 22;
            this.groupBox_cours.TabStop = false;
            this.groupBox_cours.Text = "Cours";
            // 
            // groupBox_mark
            // 
            this.groupBox_mark.Controls.Add(this.label9);
            this.groupBox_mark.Controls.Add(this.label5);
            this.groupBox_mark.Controls.Add(this.txt_note);
            this.groupBox_mark.Controls.Add(this.label4);
            this.groupBox_mark.Controls.Add(this.txt_Seassion_mark);
            this.groupBox_mark.Controls.Add(this.txt_exam_mark);
            this.groupBox_mark.Location = new System.Drawing.Point(353, 203);
            this.groupBox_mark.Name = "groupBox_mark";
            this.groupBox_mark.Size = new System.Drawing.Size(274, 188);
            this.groupBox_mark.TabIndex = 23;
            this.groupBox_mark.TabStop = false;
            this.groupBox_mark.Text = "Marks";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Note";
            // 
            // txt_note
            // 
            this.txt_note.Location = new System.Drawing.Point(106, 119);
            this.txt_note.Multiline = true;
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(143, 45);
            this.txt_note.TabIndex = 6;
            this.txt_note.Text = " ";
            // 
            // date_time
            // 
            this.date_time.AutoSize = true;
            this.date_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_time.Location = new System.Drawing.Point(561, 22);
            this.date_time.Name = "date_time";
            this.date_time.Size = new System.Drawing.Size(65, 13);
            this.date_time.TabIndex = 24;
            this.date_time.Text = "Date Time";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.btn_edite);
            this.groupBox2.Location = new System.Drawing.Point(76, 437);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 70);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Mark Informaion Managment";
            // 
            // Marks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 686);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.date_time);
            this.Controls.Add(this.groupBox_mark);
            this.Controls.Add(this.groupBox_cours);
            this.Controls.Add(this.comboBox_operation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Marks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marks";
            this.Load += new System.EventHandler(this.Marks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_cours.ResumeLayout(false);
            this.groupBox_cours.PerformLayout();
            this.groupBox_mark.ResumeLayout(false);
            this.groupBox_mark.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Seassion_mark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_exam_mark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_term;
        private System.Windows.Forms.Button btn_edite;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_operation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_subject;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.GroupBox groupBox_cours;
        private System.Windows.Forms.GroupBox groupBox_mark;
        private System.Windows.Forms.Label date_time;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
    }
}