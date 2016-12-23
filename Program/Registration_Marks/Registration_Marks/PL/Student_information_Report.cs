using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Registration_Marks.BL;

namespace Registration_Marks.PL
{
    public partial class Student_information_Report : Form
    {


        DataTable dt = new DataTable();
        Read_Data_BL read = new Read_Data_BL();


        public Student_information_Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           dt=    read.read_data_B_L("select first_name from student where student_id="+Convert.ToInt32(textBox1.Text));
           textBox2.Text = dt.Rows[0][0].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PL.View_Report myform = new View_Report();


            Crystale_R.studnet_Information myreport = new Crystale_R.studnet_Information();
            myreport.SetParameterValue("@id", Convert.ToInt32(textBox1.Text));
           

            myform.crystalReportViewer1.ReportSource = myreport;
            myform.ShowDialog();
        }
    }
}
