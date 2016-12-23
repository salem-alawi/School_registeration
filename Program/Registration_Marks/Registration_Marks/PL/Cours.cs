using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Registration_Marks.BL;  // to access business layer

namespace Registration_Marks.PL
{
    public partial class Cours : Form
    {
        int index;
        Insert_Data_BL insert = new Insert_Data_BL();
        Read_Data_BL read = new Read_Data_BL();
        DataTable dt = new DataTable();



        public Cours()
        {
            InitializeComponent();
        }

        private void Cours_Load(object sender, EventArgs e)
        {
            // to increas id automatic
            date_time.Text = Convert.ToString(DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year);

           dt= read.read_data_B_L("select max(cours_id) from course ");
            try
            {
                index = Convert.ToInt32(dt.Rows[0][0]);
            }
            catch
            {
                index = 0;
            }
            index++;
            txt_cours_id.Text = index.ToString();

        


            // to inert datato Datagradview in first run
            dataGridView1.DataSource = read.read_data_B_L("select * from course");

            // defualt value ADD
            comboBox_operation.Text = "ADD";


            dt = read.read_data_B_L("select short_DP_Name from Section");
            int i;
            for (i = 0; i < dt.Rows.Count; i++)
            {
                combox_section.Items.Add(dt.Rows[i][0].ToString());
            }

           
            btn_add.Enabled = true;
            btn_Delete.Enabled = false;
            btn_Edite.Enabled = false;



        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {

                if (DialogResult.Yes == MessageBox.Show("Are You Sure You Want to Save  to DataBase ? ", " Save ", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    insert.insert_data_B_L("insert into course values (" + Convert.ToInt32(txt_cours_id.Text) + "," + Convert.ToInt32(txt_subject_id.Text) + ",'" + combox_section.Text + "'," + Convert.ToInt32(comboBox_semester.Text) + ")");
                    dataGridView1.DataSource = read.read_data_B_L("select * from course");
                    
                    combox_section.Text = "";
                    txt_subject_id.Text = "";
                    
                     index++;
                     txt_cours_id.Text = index.ToString();



                }
                else
                {
                    
                }
            }
            catch
            {
                MessageBox.Show("d");
            }
        }

        private void btn_Edite_Click(object sender, EventArgs e)
        {
            insert.insert_data_B_L("update course set subject_id="+Convert.ToInt32( txt_subject_id.Text)+",  section_id="+Convert.ToInt32(combox_section.Text)+",semester="+Convert.ToInt32(comboBox_semester.Text));
            dataGridView1.DataSource = read.read_data_B_L("select * from course");
         
            combox_section.Text = "";
            txt_subject_id.Text = "";

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you Sure you Want to Delete This Row ? ", "Warring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                insert.insert_data_B_L("delete from course where cours_id="+Convert.ToInt32(txt_cours_id.Text));
                dataGridView1.DataSource = read.read_data_B_L("select * from course");
            }
        }



        void check_operation()
        {
            if (comboBox_operation.Text == "ADD")
            {
                
                btn_add.Enabled = true;
                btn_Delete.Enabled = false;
                btn_Edite.Enabled = false;
            }
            else if (comboBox_operation.Text == "UPDATE")
            {
               
                btn_add.Enabled = false;
                btn_Delete.Enabled = false;
                btn_Edite.Enabled = true;
            }
            else if (comboBox_operation.Text == "DELETE")
            {
               
                btn_add.Enabled = false;
                btn_Delete.Enabled = true;
                btn_Edite.Enabled = false;
            }

        }


        private void comboBox_operation_SelectedIndexChanged(object sender, EventArgs e)
        {
            check_operation(); 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            try
            {
                int x = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["cours_id"].Value.ToString());
                DataTable id = new DataTable();
                Read_Data_BL acc = new Read_Data_BL();
                id = acc.read_data_B_L("select * from course where cours_id=" + x);
                txt_cours_id.Text = id.Rows[0][0].ToString();
                txt_subject_id.Text = id.Rows[0][1].ToString();
                combox_section.Text = id.Rows[0][2].ToString();
                comboBox_semester.Text = id.Rows[0][3].ToString();
               
            }
            catch
            {

                MessageBox.Show("Empty Feild");
            }
            


        }
    }
}


