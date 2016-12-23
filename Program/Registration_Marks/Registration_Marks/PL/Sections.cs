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
    public partial class Sections : Form
    {

        Read_Data_BL read = new Read_Data_BL();
        Insert_Data_BL insert = new Insert_Data_BL();
        DataTable dt = new DataTable();

        int index;
       


        public Sections()
        {
            InitializeComponent();
        }

        private void Sections_Load(object sender, EventArgs e)
        {
           

            // setDate  and time 
            date_time.Text = Convert.ToString(DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year);



            btn_delete.Enabled = false;
            btn_edite.Enabled = false;
            //   btn_add.Enabled = true;

            dataGridView1.DataSource = read.read_data_B_L("select * from Section");

            comboBox_operation.Text = "Add";


        }
            




        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_big_name.Text.Length > 0 && txt_short_name.Text.Length > 0)
            {



                if (DialogResult.Yes == MessageBox.Show("Are You Sure You Want to Save to DataBase ? ", " Save ", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {

                    insert.insert_data_B_L("insert into Section values ('" + txt_big_name.Text + "','" + txt_short_name.Text + "')");
                    dataGridView1.DataSource = read.read_data_B_L("select * from Section");
                    txt_big_name.Text = "";
                    txt_short_name.Text = "";
             

                }
                else
                {

                }


            }
            else
            {
                MessageBox.Show("Check the Empty field field !");
            }
               

        }

        private void btn_Edite_Click(object sender, EventArgs e)
        {

            if (txt_big_name.Text.Length > 0 && txt_short_name.Text.Length > 0)
            {

                if (DialogResult.Yes == MessageBox.Show("Are You Sure You Want to Save Edite to DataBase ? ", " Save ", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    insert.insert_data_B_L("update Section set Department_name='" + txt_big_name.Text + "',short_DP_Name='" + txt_short_name.Text + "' where ind="+index);
                    dataGridView1.DataSource = read.read_data_B_L("select * from Section");
                }
                else
                {
                }
            }
            else
            {
                MessageBox.Show("Check the Empty field field !");
            }
        }

        private void txt_section_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }
        }



        void check_button()
        {
            if (comboBox_operation.Text == "ADD")
            {

                btn_add.Enabled = true;
                btn_delete.Enabled = false;
                btn_edite.Enabled = false;


                txt_short_name.Enabled = true;
                txt_big_name.Enabled = true;

            }
            else if (comboBox_operation.Text == "DELETE")
            {
                btn_add.Enabled = false;
                btn_delete.Enabled = true;
                btn_edite.Enabled = false;

                txt_big_name.Enabled = false;
                txt_short_name.Enabled = false;



            }
            else if (comboBox_operation.Text == "EDITE")
            {
                

                btn_add.Enabled = false;
                btn_delete.Enabled = false;
                btn_edite.Enabled = true;
                txt_short_name.Enabled = true;
                txt_big_name.Enabled= true;
            }
        }

        private void comboBox_operation_SelectedIndexChanged(object sender, EventArgs e)
        {

            check_button();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                index = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ind"].Value);
                txt_big_name.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Department_name"].Value);
                txt_short_name.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["short_DP_Name"].Value);
        



            }
            catch
            {

                MessageBox.Show("Empty Feild");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

      

       
        }
    }

