using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaNutrical.Controller;
using ClinicaNutrical.Model;

namespace ClinicaNutrical.Controller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultaControl consultaControl = new ConsultaControl();

            PacienteControl pacienteControl = new PacienteControl();
            Paciente paciente = new Paciente(null, "908098");
           // pacienteControl.ValidaPaciente(paciente);


        }
    }
}
