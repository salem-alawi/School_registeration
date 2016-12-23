using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Registration_Marks.DAL;
namespace Registration_Marks.BL
{
   public class Insert_Data_BL
    {

       public void insert_data_B_L(string st) //  this function use in PL
       {
           try
           {
               insert_data_DAL ob = new  insert_data_DAL();
               ob.insert_data_D_A_L(st);
           }
           catch
           {
               throw;
           }
       }


    }
}
