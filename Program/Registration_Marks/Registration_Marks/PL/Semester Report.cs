using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Registration_Marks.BL;
using CrystalDecisions.CrystalReports.Engine;



namespace Registration_Marks.PL
{
    public partial class Semester_Report : Form
    {
        Read_Data_BL read = new Read_Data_BL();
        DataTable dt = new DataTable();


        public Semester_Report()
        {
            InitializeComponent();
        }

        

        private void btn_Print_Click(object sender, EventArgs e)
        {

            // send parameter
            Crystale_R.semester_report myreport = new Crystale_R.semester_report();
            myreport.SetParameterValue("@id", Convert.ToInt32(txt_id.Text));
            myreport.SetParameterValue("@term", Convert.ToInt32(comboBox_term.Text));


            PL.View_Report myform = new View_Report();
            myform.crystalReportViewer1.ReportSource = myreport;
            myform.ShowDialog();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            //dt = read.read_data_B_L("select first_name ,Department_name from View_2_Semeter_report where student_id=" + Convert.ToInt32(txt_id.Text) + "and term=" + Convert.ToInt32(comboBox_term.Text));
            dataGridView1.DataSource = read.read_data_B_L("select subject ,exam_mark,Season_mark,exam_mark+Season_mark as total  ,note from View_Semeter_report where student_id=" + Convert.ToInt32(txt_id.Text) + "and term=" + Convert.ToInt32(comboBox_term.Text));
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
           

          
            try
            {
                dt = read.read_data_B_L("select first_name ,Department_name from View_Semeter_report where student_id=" + Convert.ToInt32(txt_id.Text));
                txt_name.Text = Convert.ToString(dt.Rows[0][0]);
                txt_department.Text = Convert.ToString(dt.Rows[0][1]);
                if (txt_name.Text.Length > 1)
                {
                    comboBox_term.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Not Found");
            }



        }

        private void Semester_Report_Load(object sender, EventArgs e)
        {
            date_time.Text = Convert.ToString(DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year);

            btn_Print.Enabled = false;
            btn_show.Enabled = false;
            comboBox_term.Enabled = false;
        }

        private void comboBox_term_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_show.Enabled = true;
            btn_Print.Enabled = true;
        }

        private void txt_id_Click(object sender, EventArgs e)
        {
            btn_Print.Enabled = false;
            btn_show.Enabled = false;
        }

      

       
        
            
 

            
            

            


       
    }
}
