namespace Registration_Marks.PL
{
    partial class Cours
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cours_id = new System.Windows.Forms.TextBox();
            this.txt_subject_id = new System.Windows.Forms.TextBox();
            this.comboBox_semester = new System.Windows.Forms.ComboBox();
            this.combox_section = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edite = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.comboBox_operation = new System.Windows.Forms.ComboBox();
            this.Operation = new System.Windows.Forms.Label();
            this.date_time = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cours ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Section";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Semester";
            // 
            // txt_cours_id
            // 
            this.txt_cours_id.Location = new System.Drawing.Point(116, 30);
            this.txt_cours_id.Name = "txt_cours_id";
            this.txt_cours_id.Size = new System.Drawing.Size(121, 20);
            this.txt_cours_id.TabIndex = 0;
            // 
            // txt_subject_id
            // 
            this.txt_subject_id.Location = new System.Drawing.Point(116, 77);
            this.txt_subject_id.Name = "txt_subject_id";
            this.txt_subject_id.Size = new System.Drawing.Size(121, 20);
            this.txt_subject_id.TabIndex = 1;
            // 
            // comboBox_semester
            // 
            this.comboBox_semester.FormattingEnabled = true;
            this.comboBox_semester.Items.AddRange(new object[] {
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
            this.comboBox_semester.Location = new System.Drawing.Point(374, 80);
            this.comboBox_semester.Name = "comboBox_semester";
            this.comboBox_semester.Size = new System.Drawing.Size(121, 21);
            this.comboBox_semester.TabIndex = 3;
            // 
            // combox_section
            // 
            this.combox_section.FormattingEnabled = true;
            this.combox_section.Location = new System.Drawing.Point(374, 37);
            this.combox_section.Name = "combox_section";
            this.combox_section.Size = new System.Drawing.Size(121, 21);
            this.combox_section.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(79, 416);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(531, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Location = new System.Drawing.Point(360, 36);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(106, 32);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edite
            // 
            this.btn_Edite.Enabled = false;
            this.btn_Edite.Location = new System.Drawing.Point(196, 36);
            this.btn_Edite.Name = "btn_Edite";
            this.btn_Edite.Size = new System.Drawing.Size(106, 32);
            this.btn_Edite.TabIndex = 6;
            this.btn_Edite.Text = "Edite ( Save )";
            this.btn_Edite.UseVisualStyleBackColor = true;
            this.btn_Edite.Click += new System.EventHandler(this.btn_Edite_Click);
            // 
            // btn_add
            // 
            this.btn_add.Enabled = false;
            this.btn_add.Location = new System.Drawing.Point(24, 36);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(105, 32);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // comboBox_operation
            // 
            this.comboBox_operation.FormattingEnabled = true;
            this.comboBox_operation.Items.AddRange(new object[] {
            "ADD",
            "UPDATE",
            "DELETE"});
            this.comboBox_operation.Location = new System.Drawing.Point(293, 238);
            this.comboBox_operation.Name = "comboBox_operation";
            this.comboBox_operation.Size = new System.Drawing.Size(121, 21);
            this.comboBox_operation.TabIndex = 4;
            this.comboBox_operation.SelectedIndexChanged += new System.EventHandler(this.comboBox_operation_SelectedIndexChanged);
            // 
            // Operation
            // 
            this.Operation.AutoSize = true;
            this.Operation.Location = new System.Drawing.Point(221, 241);
            this.Operation.Name = "Operation";
            this.Operation.Size = new System.Drawing.Size(53, 13);
            this.Operation.TabIndex = 15;
            this.Operation.Text = "Operation";
            // 
            // date_time
            // 
            this.date_time.AutoSize = true;
            this.date_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_time.Location = new System.Drawing.Point(535, 18);
            this.date_time.Name = "date_time";
            this.date_time.Size = new System.Drawing.Size(65, 13);
            this.date_time.TabIndex = 17;
            this.date_time.Text = "Date Time";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_subject_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_cours_id);
            this.groupBox1.Controls.Add(this.comboBox_semester);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.combox_section);
            this.groupBox1.Location = new System.Drawing.Point(79, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 126);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.btn_Edite);
            this.groupBox2.Location = new System.Drawing.Point(79, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 100);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Course Managment";
            // 
            // Cours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 577);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.date_time);
            this.Controls.Add(this.comboBox_operation);
            this.Controls.Add(this.Operation);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Cours";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cours";
            this.Load += new System.EventHandler(this.Cours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cours_id;
        private System.Windows.Forms.TextBox txt_subject_id;
        private System.Windows.Forms.ComboBox comboBox_semester;
        private System.Windows.Forms.ComboBox combox_section;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edite;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox comboBox_operation;
        private System.Windows.Forms.Label Operation;
        private System.Windows.Forms.Label date_time;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
    }
}