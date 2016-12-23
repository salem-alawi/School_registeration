using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Registration_Marks.PL
{
    public partial class Home : Form
    {
        private int childFormNumber = 0;

        public Home()
        {
            InitializeComponent();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_User ob = new Add_User();
            ob.MdiParent = this;
            ob.Show();
        }

        private void addSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enter_Subject_Information ob = new Enter_Subject_Information();
            ob.MdiParent = this;
            ob.Show();
        }

        private void sectionManagmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sections ob = new Sections();
            ob.MdiParent = this;
            ob.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Information ob = new Student_Information();
            ob.MdiParent = this;
            ob.Show();
        }

        private void marksManagmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marks ob = new Marks();
            ob.MdiParent = this;
            ob.Show();
        }

        private void coursManagmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cours ob = new Cours();
            ob.MdiParent = this;
            ob.Show();
        }

        private void semesterReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Semester_Report ob = new Semester_Report();
            ob.MdiParent = this;
            ob.Show();
        }

        private void allFailedSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Failed_Report ob = new Failed_Report();
            ob.MdiParent = this;
            ob.Show();
        }

        private void toolStripStatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = Convert.ToString(DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            toolStripStatusLabel.Text = Convert.ToString(DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "                                                                                                                                                                    " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second);

        }

        private void studentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_information_Report ob = new Student_information_Report();
            ob.MdiParent = this;
            ob.Show();
        
          
        }

        private void subjectMarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sbject_Mark_Report ob = new Sbject_Mark_Report();
            ob.MdiParent = this;
            ob.Show();
        }

        private void howToUseProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        
      

        

       
      
    }
}
