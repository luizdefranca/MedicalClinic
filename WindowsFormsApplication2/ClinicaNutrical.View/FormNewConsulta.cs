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
using ClinicaNutrical.DAO;
using System.Collections;


namespace ClinicaNutrical.View
{
    public partial class FormNewConsulta : Form
    {
        public FormNewConsulta()
        {
            InitializeComponent();
        }


        private void InsertIntoTable(List<Consulta> consultas)
        { 
            foreach(var consulta in consultas)
            {

                ArrayList p = new ArrayList();
                p[0] = consulta.Data;
                p[1] = consulta.Nutricionista.Nome;
                p[2] = consulta.Paciente.Nome;
                p[3] = consulta.Pressao;
                p[4] = consulta.Peso;
                p[5] = consulta.Observacao;

                dtGridViewUltimasConsultas.Rows.Add(new DataGridViewRow().SetValues(p));

            }
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            ConsultaDAO con = new ConsultaDAO();
            
            String nome = Convert.ToString(cmBoxPaciente.Text);
            double peso = Convert.ToUInt32(mskdTBPeso.Text);

            //double medidas = ;
            double     pressao = Convert.ToUInt32(mskdTBAltura.Text);
            string     restricaoAlimentar = Convert.ToString(txtBRetricoes.Text);
            string     objetivo = Convert.ToString(txtBObjetivo.Text);
            string     observacao = Convert.ToString(txtBObservacao.Text);
            string     medicamento = Convert.ToString(txtBMedicamento.Text);
            string     problemaSaude = Convert.ToString(txtProblemaSaude);
            string     historicoFamiliar = Convert.ToString(txtBHistorico);
            DateTime data = DateTime.Today;
            con.InsertConsulta(new Consulta());



        }

        private void btGetAllPaciente_Click(object sender, EventArgs e)
        {
            PacienteControl pacienteCtl = new PacienteControl();
            List<Paciente> pacientes = pacienteCtl.GetAllPacientes();


            cmBoxPaciente.Items.Clear();
            cmBoxPaciente.Sorted = true;


            foreach (var paciente in pacientes)
            {
                cmBoxPaciente.Items.Add(paciente.Nome);
            }

            

        }

        private void btGetAllNutricionista_Click(object sender, EventArgs e)
        {
            NutricionistaControl nutricionistaCtl = new NutricionistaControl();
            List<Nutricionista> nutricionistas = nutricionistaCtl.GetAllNutricionistas();


            cmBNutricionista.Items.Clear();
            cmBNutricionista.Sorted = true;


            foreach (var nutricionista in nutricionistas)
            {
                cmBNutricionista.Items.Add(nutricionista.Nome);
            }

        }

        private void btListAll_Click(object sender, EventArgs e)
        {
            ConsultaControl consultaCtl = new ConsultaControl();
            List<Consulta> consultas = consultaCtl.GetAllConsultas();
            InsertIntoTable(consultas);

        }




    }
}
