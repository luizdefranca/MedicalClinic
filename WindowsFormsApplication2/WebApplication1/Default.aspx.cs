using ClinicaNutrical.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Load(DB.ExecuteReader(DB.connectionStringSqlServer, CommandType.Text, "Select * from usuario");
            
            dt.AsDataView();    
        }
    }
}