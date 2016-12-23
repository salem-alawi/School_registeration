using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Registration_Marks.BL; // to access BL
using System.Data.SqlClient;

namespace Registration_Marks.PL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btn_OK.Enabled = false;
            txt_PassWord.Tag = false;
            txt_UserName.Tag = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
       

        
            Read_Data_BL rd = new Read_Data_BL();
            dt=  rd.read_data_B_L("select role from login where user_name='" + txt_UserName.Text + "' and password='" + txt_PassWord.Text + "'");
            if (dt.Rows.Count == 1)
            {
            // check if he is access insert form   
                string s = Convert.ToString(dt.Rows[0][0]);
                if (s == "student")
                {
                    Student_Information ob = new Student_Information();
                   
                    ob.Show();

                    this.Close();
                   
                }
                else if (s == "mark")
                {
                    Marks ob = new Marks();
                   
                    ob.Show();
                    this.Close();

                }
                else if (s == "admin")
                {
                    Home ob = new Home();
                    
                    ob.Show();
                    this.Close();

                }
                else if (s == "course")
                {
                    Cours ob = new Cours();
                    
                    ob.Show();
                    this.Close();
                }


           
            }
            else
            {
                txt_PassWord.Text = "";
                txt_UserName.Text = "";
                MessageBox.Show("Please Check your userName and Password", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void checkok()
        {
            btn_OK.Enabled= ((bool)(txt_UserName.Tag) && (bool)(txt_PassWord.Tag));
        }

        private void txt_UserName_TextChanged(object sender, EventArgs e)   // use to enable   Login button
         {
            if (txt_UserName.Text.Length > 0)
            {
                txt_UserName.Tag = true;
                checkok();

            }
            else if (txt_UserName.Text.Length == 0)
            {
                txt_UserName.Tag = false;
                checkok();
            }
        }

        private void txt_PassWord_TextChanged(object sender, EventArgs e)  // use to enable ok button
        {

            if (txt_PassWord.Text.Length > 0)
            {
                txt_PassWord.Tag = true;
                checkok();
            }
            else if (txt_PassWord.Text.Length == 0)
            {
                txt_PassWord.Tag = false;
                checkok();
            }


        }


         // these two funtion use to chack the access in the main form
        public string get_UserNameText()
        {
            return txt_UserName.Text;
        }
        public string get_PassWordText()
        {
            return txt_PassWord.Text;
        }



    }
}
