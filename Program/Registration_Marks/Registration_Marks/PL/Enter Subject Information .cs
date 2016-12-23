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
    public partial class Enter_Subject_Information : Form
    {
        DataTable id = new DataTable();
        int index = 0;
        
        Read_Data_BL read_table = new Read_Data_BL();
        Insert_Data_BL insert = new Insert_Data_BL();
        public Enter_Subject_Information()
        {
            InitializeComponent();
        }

        private void Enter_Subject_Information_Load(object sender, EventArgs e)
        {
            date_time.Text = Convert.ToString(DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year);

            txt_name.Text = null;
            txt_note.Text = null;


            btn_Delete.Enabled = false;
            btn_Edite.Enabled = false;
            comboBox_operation.Text = "Add";
            





            dataGridView1.DataSource = read_table.read_data_B_L("select * from subject ");

             id=  read_table.read_data_B_L("select max(subject_id) from subject ");
             index = Convert.ToInt32(id.Rows[0][0]);
             index++;
             txt_id.Text = index.ToString();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {


            if (txt_id.Text == "")
            {
                MessageBox.Show("you must enter values id ", "Error ID  is Empty ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_id.Focus();

            }
            else
            {

                if (DialogResult.Yes == MessageBox.Show("Are you Sure you want to Save to Database ? ", " SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    Insert_Data_BL ob = new Insert_Data_BL();
                    ob.insert_data_B_L(" insert into  subject values (" + Convert.ToInt32(txt_id.Text) + ",'" + txt_name.Text + "','" + txt_note.Text + "')");
                    dataGridView1.DataSource = read_table.read_data_B_L("select * from subject");

                    txt_id.Text = "";
                    txt_id.BackColor = Color.White;

                    txt_name.Text = "";
                    txt_name.BackColor = Color.White;

                  

                    txt_note.Text = "";
                    txt_note.BackColor = Color.White;


                    id = read_table.read_data_B_L("select max(subject_id) from subject ");


                    index = Convert.ToInt32(id.Rows[0][0]);
                    index++;
                    txt_id.Text = index.ToString();

                }
                else
                {

                }
               
            }


        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_id_Validated(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                txt_id.BackColor = Color.LightGray;
                MessageBox.Show(" You Shoud Not Leave This Field Empty", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                txt_id.BackColor = Color.White;
        }

        private void txt_name_Validated(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                txt_name.BackColor = Color.LightGray;
                txt_name.Text = null;
            }
            else
            {
                txt_name.BackColor = Color.White;
            }
        }

       

        private void txt_note_Validated(object sender, EventArgs e)
        {
            if (txt_note.Text == "")
            {
                txt_note.BackColor = Color.LightGray;
                txt_note.Text = null;
            }
            else
            {
                txt_note.BackColor = Color.White;
            }
        }


        void check_buttton()
        {
            if (comboBox_operation.Text == "Add")
            {
                btn_add.Enabled = true;
                btn_Delete.Enabled = false;
                btn_Edite.Enabled = false;
                groupBox1.Enabled = true;

            }
            else if (comboBox_operation.Text == "Edite")
            {
                btn_add.Enabled = false;
                btn_Delete.Enabled = false;
                btn_Edite.Enabled = true;
                groupBox1.Enabled = true;
            }
            else if (comboBox_operation.Text == "Delete")
            {
                btn_add.Enabled = false;
                btn_Delete.Enabled = true;
                btn_Edite.Enabled = false;
                groupBox1.Enabled = false;
            }
        }

        private void comboBox_operation_SelectedIndexChanged(object sender, EventArgs e)
        {

            check_buttton();
        }

        private void btn_Edite_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes==MessageBox.Show("Are You Sure you want to save update  ?"," Save Update ",MessageBoxButtons.YesNo,MessageBoxIcon.Warning))
            {
            insert.insert_data_B_L(" update subject set name='" + txt_name.Text + "', note='" + txt_note.Text + "'  where subject_id="+Convert.ToInt32(txt_id.Text));
            dataGridView1.DataSource = read_table.read_data_B_L("select * from subject");
            txt_id.Text = "";
            txt_name.Text = "";
            txt_note.Text = "";
            }
            else
            {

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["subject_id"].Value.ToString());
                id = read_table.read_data_B_L("select  * from subject where subject_id="+x );
                txt_id.Text = id.Rows[0][0].ToString();
                txt_name.Text = id.Rows[0][1].ToString();
                txt_note.Text = id.Rows[0][2].ToString();


            }
            catch
            {
                MessageBox.Show("Empty Feild");
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are You Sure you want to Delete This coloun ?", "Warring Delete Data ! ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                insert.insert_data_B_L("delete from subject where subject_id=" + Convert.ToInt32(txt_id.Text));
               
                txt_id.Text = "";
                txt_name.Text = "";
                txt_note.Text = "";
                dataGridView1.DataSource = read_table.read_data_B_L("select * from subject");

            }
            else
            {

            }
        }

        



      

    }
}
