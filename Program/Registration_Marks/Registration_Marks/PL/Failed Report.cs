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
    public partial class Failed_Report : Form
    {
        public Failed_Report()
        {
            InitializeComponent();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            PL.View_Report myform = new View_Report();
            if (comboBox_group_by.Text == "section")
            {
                Crystale_R.Section myreport = new Crystale_R.Section();
                myreport.Refresh();
               
                myform.crystalReportViewer1.ReportSource = myreport;
                myform.ShowDialog();
            }
            else if (comboBox_group_by.Text == "student_id")
            {
                Crystale_R.ByID myreport = new Crystale_R.ByID();
                myreport.Refresh();
                myform.crystalReportViewer1.ReportSource = myreport;
                myform.ShowDialog();
            }
            else if (comboBox_group_by.Text == "subject")
            {
                Crystale_R.By_subject myreport = new Crystale_R.By_subject();
                myreport.Refresh();
                myform.crystalReportViewer1.ReportSource = myreport;
                myform.ShowDialog();

            }
           




        }

        private void Failed_Report_Load(object sender, EventArgs e)
        {
            comboBox_group_by.Text = "section";

        }
    }
}
