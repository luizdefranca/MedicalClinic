using ClinicaMedica.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMedica.GUI
{
    public partial class FormPesquisarPaciente : Form
    {
        Service1Client serv = new Service1Client();
        List<Paciente> listaPaciente = new List<Paciente>();
        Paciente paciente = new Paciente();

        private FormConsulta formConsulta;

        private void Inicializar()
        {
            lvPacientes.Items.Clear();
            listaPaciente = serv.ListarTodosPacientes().ToList();

            if (listaPaciente.Count > 0)
            {
                foreach (var item in listaPaciente)
                {
                    ListViewItem lista = lvPacientes.Items.Add(item.CodigoPaciente.ToString());
                    lista.SubItems.Add(item.Nome);
                }
            }
        }
        public FormPesquisarPaciente(FormConsulta formConsulta)
        {
            InitializeComponent();

            Inicializar();
            this.formConsulta = formConsulta;
        }


        private void btnPesquisarPaciente_Click(object sender, EventArgs e)
        {
            paciente.Nome = txtNomePaciente.Text;
            lvPacientes.Items.Clear();
            listaPaciente = serv.ListarTodosPacientesPorNome(paciente.Nome).ToList();

            if (listaPaciente.Count > 0)
            {
                foreach (var item in listaPaciente)
                {
                    ListViewItem lista = lvPacientes.Items.Add(item.CodigoPaciente.ToString());
                    lista.SubItems.Add(item.Nome);
                }
            }
            else
            {
                MessageBox.Show("Paciente não encontrado! Por favor, verifique se digitou corretamente e tente novamente.", "NutriCorpo - Clínica Especializada em Nutrição", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lvPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lvPacientes.SelectedItems.Count >0)
            {
                int id = Convert.ToInt32(lvPacientes.SelectedItems[0].Text);

                formConsulta.CarregarPaciente(id);
                this.Close();
            }
           

        }
    }
}
