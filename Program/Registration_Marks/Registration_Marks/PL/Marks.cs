using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Registration_Marks.BL;    // access business layer

namespace Registration_Marks.PL
{
    public partial class Marks : Form
    {


        Read_Data_BL read = new Read_Data_BL();
        Insert_Data_BL insert = new Insert_Data_BL();
        DataTable dt = new DataTable();

        // to Hole index of click
        int Data_grad_view_index;


        string sec;
        public Marks()
        {
            InitializeComponent();
        }

        private void Marks_Load(object sender, EventArgs e)
        {
            date_time.Text = Convert.ToString(DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year);

            //load datagrad view
            dataGridView1.DataSource = read.read_data_B_L("select * from Marks");

            btn_delete.Enabled = false;
            btn_edite.Enabled = false;
            //defuald operation id Add
            comboBox_operation.Text = "ADD";

            groupBox_cours.Enabled = false;
            groupBox_mark.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_id.Text.Length > 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Are You Sure Your Want to Save to DataBase ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {



                    insert.insert_data_B_L("insert into marks values (" + Convert.ToInt32(txt_id.Text) + ",'" + comboBox_subject.Text + "'," + Convert.ToDecimal(txt_Seassion_mark.Text) + "," + Convert.ToDecimal(txt_exam_mark.Text) + "," + Convert.ToInt32(comboBox_term.Text) + ",'" + txt_note.Text + "','" + sec + "' ) ");
                    dataGridView1.DataSource = read.read_data_B_L("select * from marks");


                }
            }
            else
            {
                MessageBox.Show("There is no ID");
            }
        }

     

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {

                dt = read.read_data_B_L("select first_name, Section from student where student_id =" + Convert.ToInt32(txt_id.Text));
                txt_name.Text = Convert.ToString(dt.Rows[0][0]);
                sec = Convert.ToString(dt.Rows[0][1]);
            }
            catch
            {
                MessageBox.Show("ID Number Not Found");
            }
            try
            {
                dataGridView1.DataSource = read.read_data_B_L(" select * from Marks where  student_id=" + Convert.ToInt32(txt_id.Text));
                groupBox_cours.Enabled = true;
                comboBox_subject.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Wronog  ID  Number  ");
            }

            
        }


        void check_button()
        {
            if (comboBox_operation.Text == "ADD")
            {
                groupBox_cours.Enabled = true;
                groupBox_mark.Enabled = true;
                groupBox1.Enabled = true;

                btn_add.Enabled = true;
                btn_delete.Enabled = false;
                btn_edite.Enabled = false;

            }
            else if (comboBox_operation.Text == "DELETE")
            {
                btn_add.Enabled = false;
                btn_delete.Enabled = true;
                btn_edite.Enabled = false;


                groupBox_cours.Enabled = false;
                groupBox_mark.Enabled = false;
                groupBox1.Enabled = false;



            }
            else if (comboBox_operation.Text == "UPDATE")         
            {
                groupBox_cours.Enabled = true;
                groupBox_mark.Enabled = true;
                groupBox1.Enabled = true;

                btn_add.Enabled = false;
                btn_delete.Enabled = false;
                btn_edite.Enabled = true;
            }
        }


        private void comboBox_operation_SelectedIndexChanged(object sender, EventArgs e)
        {
            check_button();
        }

        private void comboBox_term_SelectedIndexChanged(object sender, EventArgs e)
        {
                comboBox_subject.Enabled = true;

                dt = read.read_data_B_L("select distinct name from View_1_subject where student_id="+Convert.ToInt32( txt_id.Text)+" and semester="+Convert.ToInt32(comboBox_term.Text));
                int i;
                comboBox_subject.Items.Clear();
                comboBox_subject.Text = "";
                for (i =0; i<dt.Rows.Count; i++)
                {
                    comboBox_subject.Items.Add(dt.Rows[i][0].ToString());
                }

            
            
        }

        private void comboBox_subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox_mark.Enabled = true;
        }

        private void btn_edite_Click(object sender, EventArgs e)
        {
           

                if (DialogResult.Yes == MessageBox.Show("Are You Sure you wnat to save Update ? ", " Save Change ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    insert.insert_data_B_L("update marks set student_id=" + Convert.ToInt32(txt_id.Text) + ",subject='" + comboBox_subject.Text + "'," + Convert.ToDecimal(txt_Seassion_mark.Text) + ",exam_mark=" + Convert.ToDecimal(txt_exam_mark.Text) + ",term=" + Convert.ToInt32(comboBox_term.Text) + ",note='"+txt_note.Text+"'");

                    dataGridView1.DataSource = read.read_data_B_L("select student_id from marks");

                   
                    


                }
                else
                {

                }
                
            
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataTable name = new DataTable();
                int x = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["x"].Value.ToString());
                DataTable id = new DataTable();
                Data_grad_view_index=Convert.ToInt32( dataGridView1.Rows[e.RowIndex].Cells["x"].Value);

                id = read.read_data_B_L("select student_id , subject , Season_mark , exam_mark  , term , note from marks where x=" + x);
                txt_id.Text = id.Rows[0][0].ToString();
                name = read.read_data_B_L("select  first_name from student where student_id=" + Convert.ToInt32(txt_id.Text));
                txt_name.Text = name.Rows[0][0].ToString();
                if (id.Rows[0][1] == null)
                    comboBox_subject.Text = null;
                else
                    comboBox_subject.Text = id.Rows[0][1].ToString();

             

                if (id.Rows[0][2] == null)
                    txt_Seassion_mark.Text = null;
                else
                    txt_Seassion_mark.Text = id.Rows[0][2].ToString();





                if (id.Rows[0][3] == null)
                    txt_exam_mark.Text = null;
                else
                    txt_exam_mark.Text = id.Rows[0][3].ToString();
               
                if (id.Rows[0][4] == null)
                    comboBox_term.Text = null;
                else
                    comboBox_term.Text = id.Rows[0][4].ToString(); ;

               

                if (id.Rows[0][5] == null)
                  txt_note.Text = null;
                else
                    txt_note.Text = id.Rows[0][5].ToString();
               


            }
            catch
            {

                MessageBox.Show("Empty Feild");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Are you Sure You Want to Delete This Data ?", " Warring Delete ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    insert.insert_data_B_L("delete from marks where student_id= " + Convert.ToInt32(txt_id.Text));
                    dataGridView1.DataSource = read.read_data_B_L("select * from marks");
                    groupBox_cours.Enabled = true;
                    groupBox_mark.Enabled = true;
                    groupBox1.Enabled = true;

                }
                else
                {

                }
            }
            catch
            {
                MessageBox.Show("Emty Field");
            }
        }

        private void txt_Seassion_mark_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }

        }

        private void txt_exam_mark_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }
        }

      
       
       
    }
}
