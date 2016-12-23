using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Registration_Marks.DAL;  //  use to access    class in this class
namespace Registration_Marks.BL
{
  public  class Read_Data_BL  //  change to public 
    {

      public DataTable read_data_B_L(string st)
      {

          try
          {
              Read_Data_DAL objdal = new Read_Data_DAL();
              return objdal.read_data_D_A_L(st);
          }
          catch (Exception)
          {

              throw;
          }
      }



    }
}
