using System;
using Microsoft.Win32;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaNutrical.DAO;
using System.Data.SqlClient;
//using ClinicaNutrical.Controller;
using ClinicaNutrical.Model;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            
            
            
            /*DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
           // dt.Load(Dr);

            try
            {
            SqlConnection con = new SqlConnection(DB.connectionStringSqlServer);
            con.Open();

                
                cmd.Connection = con;
                

            }
            catch (Exception err)
            {
                
                throw err;
            }
            
            
            cmd.CommandText = "select * from usuario";
            cmd.CommandType = CommandType.Text;
            IDataReader Dr = cmd.ExecuteReader();
            dt.Load(Dr);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
             */
            DataTable tb = new DataTable();
            tb.Load(DB.ExecuteReader(DB.connectionStringSqlServer, CommandType.Text, "Select * from usuario"));
            dataGridView1.DataSource = tb;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ConsultaControl consultaControl = new ConsultaControl();
           //PacienteContro
            //ClinicaNutrical.Controller.PacienteControl pacienteControl = new PacienteControl();
          //  pacienteControl.ValidaPaciente(new Paciente(null ,"908098"));

           // textBox1.Text ="Version: " + Environment.Version.ToString();
        }

       
    }
}
