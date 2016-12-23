using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Registration_Marks.DAL
{
    public   class connection   // change to  public   
    {
        public SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Registration;Integrated Security=True");
    }
}
