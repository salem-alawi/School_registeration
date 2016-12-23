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
    public partial class Add_User : Form
    {

      
        Insert_Data_BL iser = new Insert_Data_BL();
        int index; // for automatic increas id number
        Read_Data_BL rd = new Read_Data_BL();// to access read database
        DataTable dt = new DataTable();
        public Add_User()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_User_Load(object sender, EventArgs e)
        {
            // to increas id automatic
           dt  =rd.read_data_B_L("select max(id) from login");
           index = Convert.ToInt32(dt.Rows[0][0]);
           index++;
           txt_id.Text = index.ToString();

            // setDate  and time 
           date_time.Text = Convert.ToString(DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year);

           // defulte to check enable button 
            txt_user_name.Tag = false;
            txt_password.Tag = false;

            // to inert datato Datagradview in first run
            dataGridView1.DataSource = rd.read_data_B_L("select * from login");
            // defualt value admin
            comboBox1.Text = "admin";
            // defualt value operationgvh add
            comboBox2.Text = "Add";
            btn_add.Enabled = true;
            btn_Delete.Enabled = false;
            btn_Edite.Enabled = false;
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are You Sure You Want to Save THis User And Password to DataBase ? ", " Save ", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Insert_Data_BL ob = new Insert_Data_BL();
                ob.insert_data_B_L("insert into login values ("+Convert.ToInt32(txt_id.Text)+",'" + txt_user_name.Text + "','" + txt_password.Text + "','" + comboBox1.Text + "')");
                dataGridView1.DataSource = rd.read_data_B_L("select * from login ");
                txt_user_name.Text = "";
                txt_password.Text = "";
                comboBox1.Text = "admin";

            }
            else
            {

            }
        }
        void checkadd()
        {
            btn_add.Enabled = ((bool)(txt_user_name.Tag) && (bool)(txt_password.Tag));
        }
        private void txt_user_name_TextChanged(object sender, EventArgs e)
        {
            if (txt_user_name.Text.Length > 0)
            {
                txt_user_name.Tag = true;
                checkadd();
                check_buttton();
            }
            else if (txt_user_name.Text.Length == 0)
            {
                txt_user_name.Tag = false;
                checkadd();
                check_buttton();
            }
            
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            if (txt_password.Text.Length > 0)
            {
                txt_password.Tag = true;
                checkadd();
                check_buttton();

            }
            else if (txt_password.Text.Length == 0)
            {
                txt_password.Tag = false;
                checkadd();
                check_buttton();
            }
           
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            check_buttton();
            if (comboBox2.Text == "Delete")
            {
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true; 
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int x = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
                DataTable id = new DataTable();
                Read_Data_BL acc = new Read_Data_BL();
                id = acc.read_data_B_L("select * from login where id=" + x);
                txt_id.Text = id.Rows[0][0].ToString();
                txt_user_name.Text = id.Rows[0][1].ToString();
                txt_password.Text = id.Rows[0][2].ToString();
                comboBox1.Text = id.Rows[0][3].ToString();
                check_buttton();
            }
            catch
            {
                
                MessageBox.Show("Empty Feild");
            }
        }

        // this function is to check the button enable
        void check_buttton()
        {
            if (comboBox2.Text == "Add")
            {
                btn_add.Enabled = true;
                btn_Delete.Enabled = false;
                btn_Edite.Enabled = false;

            }
            else if (comboBox2.Text == "Edite")
            {
                btn_add.Enabled = false;
                btn_Delete.Enabled = false;
                btn_Edite.Enabled = true;
            }
            else if (comboBox2.Text == "Delete")
            {
                btn_add.Enabled = false;
                btn_Delete.Enabled = true;
                btn_Edite.Enabled = false;
            }
        }

        private void btn_Edite_Click(object sender, EventArgs e)
        {
            iser.insert_data_B_L("update login set user_name='" + txt_user_name.Text + "' ,password='" + txt_password.Text + "', role='" + comboBox1.Text + "'  where id=" + Convert.ToInt32(txt_id.Text) );
            dataGridView1.DataSource = rd.read_data_B_L("select * from login ");
            txt_user_name.Text = "";
            txt_password.Text = "";
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
