using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ClinicaNutrical.DAO
{
    class DataBase
    {
        public SqlConnection cnx = new SqlConnection("Data Source=WINMAC-LUIZ;Initial Catalog=ClinicaNutricional;Persist Security Info=True;User ID=sa;Password=sa");
       
       
        
         
    }
}
