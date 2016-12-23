namespace Registration_Marks.PL
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sectionManagmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marksManagmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursManagmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semesterReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allFailedSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectMarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.marksToolStripMenuItem,
            this.coursToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(878, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.addSubjectToolStripMenuItem,
            this.sectionManagmentToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.systemToolStripMenuItem.Text = "Adminstration";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.addUserToolStripMenuItem.Text = "User Managment";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // addSubjectToolStripMenuItem
            // 
            this.addSubjectToolStripMenuItem.Name = "addSubjectToolStripMenuItem";
            this.addSubjectToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.addSubjectToolStripMenuItem.Text = "Subject Managment";
            this.addSubjectToolStripMenuItem.Click += new System.EventHandler(this.addSubjectToolStripMenuItem_Click);
            // 
            // sectionManagmentToolStripMenuItem
            // 
            this.sectionManagmentToolStripMenuItem.Name = "sectionManagmentToolStripMenuItem";
            this.sectionManagmentToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.sectionManagmentToolStripMenuItem.Text = "Section Managment";
            this.sectionManagmentToolStripMenuItem.Click += new System.EventHandler(this.sectionManagmentToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.studentToolStripMenuItem.Text = "Student ";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.addStudentToolStripMenuItem.Text = "Student Managment";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // marksToolStripMenuItem
            // 
            this.marksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marksManagmentToolStripMenuItem});
            this.marksToolStripMenuItem.Name = "marksToolStripMenuItem";
            this.marksToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.marksToolStripMenuItem.Text = "Marks";
            // 
            // marksManagmentToolStripMenuItem
            // 
            this.marksManagmentToolStripMenuItem.Name = "marksManagmentToolStripMenuItem";
            this.marksManagmentToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.marksManagmentToolStripMenuItem.Text = "Marks Managment";
            this.marksManagmentToolStripMenuItem.Click += new System.EventHandler(this.marksManagmentToolStripMenuItem_Click);
            // 
            // coursToolStripMenuItem
            // 
            this.coursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coursManagmentToolStripMenuItem});
            this.coursToolStripMenuItem.Name = "coursToolStripMenuItem";
            this.coursToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.coursToolStripMenuItem.Text = "Cours";
            // 
            // coursManagmentToolStripMenuItem
            // 
            this.coursManagmentToolStripMenuItem.Name = "coursManagmentToolStripMenuItem";
            this.coursManagmentToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.coursManagmentToolStripMenuItem.Text = "Cours Managment";
            this.coursManagmentToolStripMenuItem.Click += new System.EventHandler(this.coursManagmentToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.semesterReportToolStripMenuItem,
            this.allFailedSubjectToolStripMenuItem,
            this.studentInformationToolStripMenuItem,
            this.subjectMarkToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // semesterReportToolStripMenuItem
            // 
            this.semesterReportToolStripMenuItem.Name = "semesterReportToolStripMenuItem";
            this.semesterReportToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.semesterReportToolStripMenuItem.Text = "Semester Report";
            this.semesterReportToolStripMenuItem.Click += new System.EventHandler(this.semesterReportToolStripMenuItem_Click);
            // 
            // allFailedSubjectToolStripMenuItem
            // 
            this.allFailedSubjectToolStripMenuItem.Name = "allFailedSubjectToolStripMenuItem";
            this.allFailedSubjectToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.allFailedSubjectToolStripMenuItem.Text = "All Failed Subject";
            this.allFailedSubjectToolStripMenuItem.Click += new System.EventHandler(this.allFailedSubjectToolStripMenuItem_Click);
            // 
            // studentInformationToolStripMenuItem
            // 
            this.studentInformationToolStripMenuItem.Name = "studentInformationToolStripMenuItem";
            this.studentInformationToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.studentInformationToolStripMenuItem.Text = "Student Information";
            this.studentInformationToolStripMenuItem.Click += new System.EventHandler(this.studentInformationToolStripMenuItem_Click);
            // 
            // subjectMarkToolStripMenuItem
            // 
            this.subjectMarkToolStripMenuItem.Name = "subjectMarkToolStripMenuItem";
            this.subjectMarkToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.subjectMarkToolStripMenuItem.Text = "Subject Mark";
            this.subjectMarkToolStripMenuItem.Click += new System.EventHandler(this.subjectMarkToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 501);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(878, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            this.toolStripStatusLabel.Click += new System.EventHandler(this.toolStripStatusLabel_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseProgramToolStripMenuItem,
            this.abutUsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToUseProgramToolStripMenuItem
            // 
            this.howToUseProgramToolStripMenuItem.Name = "howToUseProgramToolStripMenuItem";
            this.howToUseProgramToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.howToUseProgramToolStripMenuItem.Text = "How to use program";
            this.howToUseProgramToolStripMenuItem.Click += new System.EventHandler(this.howToUseProgramToolStripMenuItem_Click);
            // 
            // abutUsToolStripMenuItem
            // 
            this.abutUsToolStripMenuItem.Name = "abutUsToolStripMenuItem";
            this.abutUsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.abutUsToolStripMenuItem.Text = "About Us";
            this.abutUsToolStripMenuItem.Click += new System.EventHandler(this.abutUsToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 523);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSubjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sectionManagmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marksManagmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursManagmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semesterReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allFailedSubjectToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem studentInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectMarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abutUsToolStripMenuItem;
    }
}



