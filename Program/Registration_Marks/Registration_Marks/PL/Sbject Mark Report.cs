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
    public partial class Sbject_Mark_Report : Form
    {

        Read_Data_BL read = new Read_Data_BL();
        DataTable dt = new DataTable();

        public Sbject_Mark_Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crystale_R.subject_mark myreport = new Crystale_R.subject_mark();
            myreport.SetParameterValue("@dep",combox_section.Text);
            myreport.SetParameterValue("@term", Convert.ToInt32(comboBox_term.Text));
            myreport.SetParameterValue("@subject", comboBox_subject.Text);

            


            PL.View_Report myform = new View_Report();
            myform.crystalReportViewer1.ReportSource = myreport;
            myform.ShowDialog();
        }

        private void Sbject_Mark_Report_Load(object sender, EventArgs e)
        {


            dt = read.read_data_B_L("select short_DP_Name from Section");
            int i;
            for (i = 0; i < dt.Rows.Count; i++)
            {
                combox_section.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void comboBox_term_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_subject.Enabled = true;

            dt = read.read_data_B_L("select distinct subject from View_Semeter_report where short_DP_Name='" + combox_section.Text + "' and term=" + Convert.ToInt32(comboBox_term.Text));
            int i;
            comboBox_subject.Items.Clear();
            comboBox_subject.Text = "";
            for (i = 0; i < dt.Rows.Count; i++)
            {
                comboBox_subject.Items.Add(dt.Rows[i][0].ToString());
            }
        }
    }
}
