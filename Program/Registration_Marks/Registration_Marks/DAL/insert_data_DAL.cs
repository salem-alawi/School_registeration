using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;  // to access data table
using System.Data.SqlClient;
using System.Windows.Forms;// to add message box

namespace Registration_Marks.DAL
{
   public class insert_data_DAL //change to public
    {
       public void insert_data_D_A_L(string st)
       {
           connection conn = new connection();
           if (ConnectionState.Closed == conn.con.State)
           {
               conn.con.Open();
           }

           SqlCommand cmd = new SqlCommand(st, conn.con);

           try
           {
               cmd.ExecuteNonQuery();
               MessageBox.Show("added successfully !", "add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
           }
           catch
           {
               MessageBox.Show("error when insert Data ", "error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }

    }
}
