using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClinicaNutrical.DAO;
using ClinicaNutrical.Model;
using ClinicaNutrical.Controller;


namespace WebTest
{
    public partial class TestGetAllNutricionista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NutricionistaDAO nutDal = new NutricionistaDAO();
            ConsultaDAO conDal = new ConsultaDAO();
            PacienteDAO pacDal = new PacienteDAO();
            PrescricaoDAO presDal = new PrescricaoDAO();

            GridView1.DataSource = presDal.GetAllPrescricaos();
            GridView1.DataBind();

        }
    }
}