using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;  // to access data table
using System.Data.SqlClient;
using System.Windows.Forms;// to add message box

namespace Registration_Marks.DAL
{
  public   class Read_Data_DAL   // change to public
    {

        DataTable dt = new DataTable(); // to hole resulte table
        public DataTable read_data_D_A_L(string st)
        {
            connection conn = new connection();
            if (ConnectionState.Closed == conn.con.State)
            {
                conn.con.Open();
            }
            SqlCommand cmd = new SqlCommand(st, conn.con);

            try
            {
                SqlDataReader rd = cmd.ExecuteReader();//  faster than sql data adapter
                dt.Load(rd);
                return dt;

            }
            catch (Exception)
            {


                MessageBox.Show("error when read Data ", "error ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return dt;
        }


    }
}
