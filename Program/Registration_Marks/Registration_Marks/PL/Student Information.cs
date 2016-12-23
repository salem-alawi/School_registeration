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
    public partial class Student_Information : Form
    {

        DataTable id = new DataTable(); // to  hold the max id number 
        Read_Data_BL read = new Read_Data_BL();
        Insert_Data_BL ob = new Insert_Data_BL();
        int index = 0; // to automatic incerase id number


        public Student_Information()
        {
            InitializeComponent();
        }

        private void Student_Information_Load(object sender, EventArgs e)
        {
            date_time.Text = Convert.ToString(DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year);

            id = read.read_data_B_L("select short_DP_Name from Section");
            int i;
            for (i = 0; i < id.Rows.Count; i++)
            {

                comboBox_section.Items.Add(id.Rows[i][0].ToString());
            }



            btn_add.Enabled = true;
            btn_delete.Enabled = false;
            btn_edite.Enabled = false;
            comboBox_operation.Text = "ADD";



          
            txt_address.Text = null;
        
            txt_email.Text = null;
       
            txt_Fname.Text = null;
        
            txt_Lname.Text = null;
          
            txt_note.Text = null;
         
            txt_person_conactct.Text = null;
          
            txt_Telephone.Text = null;
         
            txt_address.Text = null;
         
            txt_email.Text = null;
        
            txt_Fname.Text = null;
      
            txt_Lname.Text = null;
       
            txt_note.Text = null;
          
            txt_person_conactct.Text = null;
         
            txt_Telephone.Text = null;
         




           

            dataGridView1.DataSource = read.read_data_B_L("select * from student");


            id = read.read_data_B_L("select max(student_id) from student");
            try
            {

                index = Convert.ToInt32(id.Rows[0][0]);
                index++;
               
            }
            catch
            {
                index = 1;
            }
            txt_studentId.Text = index.ToString();

        }
        //  to force to enter only number
        private void txt_studentId_KeyPress(object sender, KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_Telephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_studentId_Validated(object sender, EventArgs e)
        {
            if (txt_studentId.Text == "")
            {
                txt_studentId.BackColor = Color.LightGray;
                txt_studentId.Focus();
            }
            else
                txt_studentId.BackColor = Color.White;
        }

        private void txt_Lname_Validated(object sender, EventArgs e)
        {
            if (txt_Lname.Text == "")
            {
                txt_Lname.BackColor = Color.LightGray;
                txt_Lname.Text = null;
            }
            else
                txt_Lname.BackColor = Color.White;

        }

        private void txt_person_conactct_Validated(object sender, EventArgs e)
        {
            if (txt_person_conactct.Text == "")
            {
                txt_person_conactct.BackColor = Color.LightGray;
                txt_person_conactct.Text = null;
            }
            else
                txt_person_conactct.BackColor = Color.White;
        }

        private void txt_email_Validated(object sender, EventArgs e)
        {
            if (txt_email.Text == "")
            {
                txt_email.BackColor = Color.LightGray;
                txt_email.Text = null;
            }
            else
                txt_email.BackColor = Color.White;
        }

        private void txt_address_Validated(object sender, EventArgs e)
        {
            if (txt_address.Text == "")
            {
                txt_address.Text = null;
                txt_address.BackColor = Color.LightGray;
            }
            else
                txt_address.BackColor = Color.White;
        }

        private void txt_Fname_Validated(object sender, EventArgs e)
        {
            if (txt_Fname.Text == "")
            {
                txt_Fname.BackColor = Color.LightGray;
                MessageBox.Show(" Warring You Leave Name Empty", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txt_Fname.BackColor = Color.White;
            }
        }




         void   check_operation()
        {
            if   ( comboBox_operation.Text =="ADD")
            {
                btn_add.Enabled=true;
                btn_delete.Enabled=false;
                btn_edite.Enabled=false;
            }else if( comboBox_operation.Text   =="UPDATE")
            {
                btn_add.Enabled=false;
                btn_delete.Enabled=false;
                btn_edite.Enabled=true;
            }else if( comboBox_operation.Text =="DELETE")
            {
                btn_add.Enabled = false;
                btn_delete.Enabled = true;
                btn_edite.Enabled = false;
            }
            

            
             
        }

         private void comboBox_operation_SelectedIndexChanged(object sender, EventArgs e)
         {
             check_operation(); 
         }

         private void Operation(object sender, EventArgs e)
         {

         }

         private void groupBox1_Enter(object sender, EventArgs e)
         {

         }
          //  UPDATE BUTTON
         private void btn_edite_Click(object sender, EventArgs e)
         {
             if (txt_studentId.Text == "")
             {
                 MessageBox.Show("you must enter values id ", "Error ID  is Empty ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 txt_studentId.Focus();
             }


             if (DialogResult.Yes == MessageBox.Show("Are you Sure you want to Save Update to Database ? ", " SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
             {
                 string gend;
                 if (radioButton1.Checked == true)
                 {
                     gend = "Male";
                 }
                 else
                 {
                     gend = "Female";
                 }


                 ob.insert_data_B_L("update student set student_id=" + Convert.ToInt32(txt_studentId.Text) + ",first_name='" + txt_Fname.Text + "',last_name='" + txt_Lname.Text + "',date_of_Birth='" + date_of_birth.MinDate + "', admission_date='" + date_of_admission.MinDate + "',   conatct_person='" + txt_person_conactct.Text + "',address='" + txt_address.Text + "',telephone='" + txt_Telephone.Text + "',gender='" + gend + "',email='" + txt_email.Text + "',Section='" + comboBox_section.Text + "',note='" + txt_note.Text + "' where student_id=" + Convert.ToInt32(txt_studentId.Text));



                 dataGridView1.DataSource = read.read_data_B_L("select * from student");
                 txt_studentId.Text = "";
                 txt_address.Text = "";
                 txt_address.BackColor = Color.White;
                 txt_email.Text = "";
                 txt_email.BackColor = Color.White;
                 txt_Fname.Text = "";
                 txt_Fname.BackColor = Color.White;
                 txt_Lname.Text = "";
                 txt_Lname.BackColor = Color.White;
                 txt_note.Text = "";
                 txt_note.BackColor = Color.White;
                 txt_person_conactct.Text = "";
                 txt_person_conactct.BackColor = Color.White;
                 txt_Telephone.Text = "";
                 txt_Telephone.BackColor = Color.White;


              
                 id = read.read_data_B_L("select max(student_id) from student");


                 index = Convert.ToInt32(id.Rows[0][0]);
                 index++;
                 txt_studentId.Text = index.ToString();
             }
             else
             {


             }


         }

         private void btn_add_Click(object sender, EventArgs e)
         {
             if (txt_studentId.Text == "")
             {
                 MessageBox.Show("you must enter values id ", "Error ID  is Empty ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 txt_studentId.Focus();
             }
             else
             {
                 string gend;
                 if (radioButton1.Checked == true)
                 {
                     gend = "Male";
                 }
                 else
                 {
                     gend = "Female";
                 }


                 if (DialogResult.Yes == MessageBox.Show("Are you Sure you want to Save to Database ? ", " SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                 {
                   
                     ob.insert_data_B_L("insert into student values (" + Convert.ToInt32(txt_studentId.Text) + ",'" + txt_Fname.Text + "','" + txt_Lname.Text + "','" + date_of_birth.MinDate + "','" + date_of_admission.MinDate + "','" + txt_person_conactct.Text + "','" + txt_address.Text + "','" + txt_Telephone.Text + "','" + gend + "','" + txt_email.Text + "','" + comboBox_section.Text + "','" + txt_note.Text + "')");
                     // للتعرف على الراديو بتن

                     dataGridView1.DataSource = read.read_data_B_L("select * from student");
                     txt_studentId.Text = "";
                     txt_address.Text = "";
                     txt_address.BackColor = Color.White;
                     txt_email.Text = "";
                     txt_email.BackColor = Color.White;
                     txt_Fname.Text = "";
                     txt_Fname.BackColor = Color.White;
                     txt_Lname.Text = "";
                     txt_Lname.BackColor = Color.White;
                     txt_note.Text = "";
                     txt_note.BackColor = Color.White;
                     txt_person_conactct.Text = "";
                     txt_person_conactct.BackColor = Color.White;
                     txt_Telephone.Text = "";
                     txt_Telephone.BackColor = Color.White;


                     id = read.read_data_B_L("select max(student_id) from student");


                     index = Convert.ToInt32(id.Rows[0][0]);
                     index++;
                     txt_studentId.Text = index.ToString();

                 }
                 else
                 {

                 }
             }

         }

         private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
         {
              try
             {
                 int x = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["student_id"].Value.ToString());
                 DataTable id = new DataTable();

                 id = read.read_data_B_L("select student_id , first_name , last_name , conatct_person ,address , telephone , gender,email , Section , note from student where student_id=" + x);
                 txt_studentId.Text = id.Rows[0][0].ToString();
                 if (id.Rows[0][1] == null)
                     txt_Fname.Text = null;
                  else
                txt_Fname.Text = id.Rows[0][1].ToString();
                 if (id.Rows[0][2] == null)
                     txt_Lname.Text = null;
                  else
                 txt_Lname.Text = id.Rows[0][2].ToString();

                 


          
                          if (id.Rows[0][3] == null)
                              txt_person_conactct.Text = null;
                  else
                         txt_person_conactct.Text     = id.Rows[0][3].ToString();
                  if(id.Rows[0][4]==null)
                       txt_address.Text=null;
                  else
                      txt_address.Text = id.Rows[0][4].ToString();
                  if (id.Rows[0][5] == null)
                      txt_Telephone.Text = null;
                  else
                      txt_Telephone.Text = id.Rows[0][5].ToString(); ;

                 string g = id.Rows[0][6].ToString();
                  if (g == "Male      ")
                  {
                      radioButton1.Checked = true;
                      radioButton2.Checked = false;
                  }
                  else
                  {
                      radioButton2.Checked = true;
                      radioButton1.Checked = false;
                  }
                    
                
                       
                   
                    if (id.Rows[0][7] == null)
                        txt_email.Text = null;
                  else
                      txt_email.Text  = id.Rows[0][7].ToString();
                           comboBox_section.Text  = id.Rows[0][8].ToString();
                           if (id.Rows[0][9] == null)
                               txt_note.Text = null;
                  else
                           txt_note.Text = id.Rows[0][9].ToString();
                          
            
             }
             catch
             {

                 MessageBox.Show("Empty Feild");
             }

         }

         private void btn_delete_Click(object sender, EventArgs e)
         {
             if (DialogResult.Yes == MessageBox.Show("Are you Sure you Want to Delete This Row ? ", "Warring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
             {
                 ob.insert_data_B_L("delete from student where student_id="+Convert.ToInt32(txt_studentId.Text));

                  dataGridView1.DataSource = read.read_data_B_L("select * from student");
             }
             else
             {
              
             }
         }

         private void label1_Click(object sender, EventArgs e)
         {

         }

         private void panel1_Paint(object sender, PaintEventArgs e)
         {

         }

         private void radioButton2_CheckedChanged(object sender, EventArgs e)
         {

         }

         private void radioButton1_CheckedChanged(object sender, EventArgs e)
         {

         }

         private void comboBox_section_SelectedIndexChanged(object sender, EventArgs e)
         {

         }

         private void label13_Click(object sender, EventArgs e)
         {

         }

         private void label12_Click(object sender, EventArgs e)
         {

         }

         private void date_of_admission_ValueChanged(object sender, EventArgs e)
         {

         }

         private void date_of_birth_ValueChanged(object sender, EventArgs e)
         {

         }

         private void txt_note_TextChanged(object sender, EventArgs e)
         {

         }

         private void txt_Telephone_TextChanged(object sender, EventArgs e)
         {

         }

         private void txt_address_TextChanged(object sender, EventArgs e)
         {

         }

         private void txt_email_TextChanged(object sender, EventArgs e)
         {

         }

         private void txt_person_conactct_TextChanged(object sender, EventArgs e)
         {

         }

         private void txt_Lname_TextChanged(object sender, EventArgs e)
         {

         }

         private void txt_Fname_TextChanged(object sender, EventArgs e)
         {

         }

         private void txt_studentId_TextChanged(object sender, EventArgs e)
         {

         }

         private void label10_Click(object sender, EventArgs e)
         {

         }

         private void label9_Click(object sender, EventArgs e)
         {

         }

         private void label8_Click(object sender, EventArgs e)
         {

         }

         private void label7_Click(object sender, EventArgs e)
         {

         }

         private void label6_Click(object sender, EventArgs e)
         {

         }

         private void label5_Click(object sender, EventArgs e)
         {

         }

         private void label4_Click(object sender, EventArgs e)
         {

         }

         private void label3_Click(object sender, EventArgs e)
         {

         }

         private void label2_Click(object sender, EventArgs e)
         {

         }

         private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {

         }

         private void label11_Click(object sender, EventArgs e)
         {

         }

        


            

         

        
    }
}
