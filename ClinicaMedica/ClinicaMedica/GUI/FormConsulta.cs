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
    public partial class FormConsulta : Form
    {

        #region Atributos
        private Consulta objConsulta;
        private Service1Client servico = new Service1Client();
        private List<Consulta> listaConsulta;
        private int id;
        #endregion

        public FormConsulta()
        {
            InitializeComponent();
            ListarTodasConsultas();

            //btnOK.Enabled = false;
            btnCancelar.Enabled = false;
            objConsulta = null;
        }

        private void ExibeListaConsulta(List<Consulta> listaConsulta)
        {
            if (listaConsulta.Count > 0)
            {
                foreach (var item in listaConsulta)
                {
                    ListViewItem lista = lvConsulta.Items.Add(item.CodigoConsulta.ToString());
                    lista.SubItems.Add(item.Nutricionista.Nome);
                    lista.SubItems.Add(item.Paciente.Nome);
                    lista.SubItems.Add(item.DataConsulta.ToShortDateString());
                    lista.SubItems.Add(item.DataConsulta.ToShortTimeString());
                    lista.SubItems.Add(item.Status);
                }
            }
        }

        private void ListarTodasConsultas()
        {
            lvConsulta.Items.Clear();
            listaConsulta = servico.ListarTodasConsultas().ToList();
            ExibeListaConsulta(listaConsulta);
        }

        private void ListarTodasConsultasPorPaciente(int id)
        {
            lvConsulta.Items.Clear();
            listaConsulta = servico.ListarTodasConsultasPorPaciente(id).ToList();
            ExibeListaConsulta(listaConsulta);
        }

        //Botão Confirmar
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                Consulta consulta = new Consulta();

                if (txtCodigoPaciente.Text != "")
                {
                    #region Paciente
                    consulta.Paciente = new Paciente();
                    consulta.Paciente.CodigoPaciente = Convert.ToInt32(txtCodigoPaciente.Text.Trim());
                    #endregion
                    #region Nutricionista
                    consulta.Nutricionista = new Nutricionista();
                    consulta.Nutricionista.CodigoNutricionista = UsuarioSingleton.CodigoNutricionista;
                    #endregion
                    #region Peso
                    if (txtPeso.Text.Trim() != "")
                    {
                        consulta.Peso = txtPeso.Text.Trim();
                    }
                    else
                    {
                        consulta.Peso = "";
                    }
                    #endregion
                    #region PressaoArterial
                    if (txtPressaoArterial.Text.Trim() != "")
                    {
                        consulta.PressaoArterial = txtPressaoArterial.Text.Trim();
                    }
                    else
                    {
                        consulta.PressaoArterial = "";
                    }
                    #endregion
                    #region Altura
                    if (txtAltura.Text.Trim() != "")
                    {
                        consulta.Altura = txtAltura.Text.Trim();
                    }
                    else
                    {
                        consulta.Altura = "";
                    }
                    #endregion
                    #region Medidas
                    if (txtMedidas.Text.Trim() != "")
                    {
                        consulta.Medidas = txtMedidas.Text.Trim();
                    }
                    else
                    {
                        consulta.Medidas = "";
                    }
                    #endregion
                    #region ProblemaSaude
                    if (txtProblemasSaude.Text.Trim() != "")
                    {
                        consulta.ProblemaSaude = txtProblemasSaude.Text.Trim();
                    }
                    else
                    {
                        consulta.ProblemaSaude = "";
                    }
                    #endregion
                    #region RestricoesAlimentares
                    if (txtRestricoesAlimentares.Text.Trim() != "")
                    {
                        consulta.RestricoesAlimentares = txtRestricoesAlimentares.Text.Trim();
                    }
                    else
                    {
                        consulta.RestricoesAlimentares = "";
                    }
                    #endregion
                    #region UsoMedicamento
                    if (txtUsoMedicamento.Text.Trim() != "")
                    {
                        consulta.UsoMedicamento = txtUsoMedicamento.Text.Trim();
                    }
                    else
                    {
                        consulta.UsoMedicamento = "";
                    }
                    #endregion
                    #region HistoricoFamiliar
                    if (txtHistoricoFamiliar.Text.Trim() != "")
                    {
                        consulta.HistoricoFamiliar = txtHistoricoFamiliar.Text.Trim();
                    }
                    else
                    {
                        consulta.HistoricoFamiliar = "";
                    }
                    #endregion
                    #region Objetivo
                    if (txtObjetivo.Text.Trim() != "")
                    {
                        consulta.Objetivo = txtObjetivo.Text.Trim();
                    }
                    else
                    {
                        consulta.Objetivo = "";
                    }
                    #endregion
                    #region Observacao
                    if (txtObservacao.Text.Trim() != "")
                    {
                        consulta.Observacao = txtObservacao.Text.Trim();
                    }
                    else
                    {
                        consulta.Observacao = "";
                    }
                    #endregion
                    #region Data
                    consulta.DataConsulta = DateTime.Now;
                    #endregion
                    #region Status
                    consulta.Status = "Ativo";
                    #endregion

                    //Inserir Consulta
                    if (objConsulta == null)
                    #region Inserir Consulta
                    {
                        objConsulta = consulta;
                        servico.InserirConsulta(objConsulta);
                        objConsulta = servico.RetornaConsulta(objConsulta);
                        MessageBox.Show("'Consulta' inserida com sucesso", "NutriCorpo - Clínica Especializada em Nutrição", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    #endregion
                    else //Editar Consulta
                    #region Editar Consulta
                    {
                        if (objConsulta.CodigoConsulta != null){
                            consulta.CodigoConsulta = objConsulta.CodigoConsulta;
                            servico.EditarConsulta(consulta);
                            MessageBox.Show("Consulta alterada com sucesso", "NutriCorpo - Clínica Especializada em Nutrição", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Não é possível alterar esta consulta!", "NutriCorpo - Clínica Especializada em Nutrição", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    #endregion
                    //this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um paciente para continuar!", "NutriCorpo - Clínica Especializada em Nutrição", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        private void btnLocalizarPaciente_Click(object sender, EventArgs e)
        {
            FormPesquisarPaciente fpc = new FormPesquisarPaciente(this);
            fpc.ShowDialog();
        }

        private void lvConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            objConsulta = null;
            btnOK.Enabled = false;
            btnCancelar.Enabled = true;
            if (lvConsulta.SelectedItems.Count > 0)
            {
                string idSelecionado = lvConsulta.SelectedItems[0].Text;
                id = Convert.ToInt32(idSelecionado);
                this.CarregarConsulta(id);
                //MessageBox.Show("o id selecionado eh " + idSelecionado);
            }
        }

        public void CarregarPaciente(int id)
        {
            Paciente paciente = servico.BuscarPaciente(id);

            objConsulta = null;
            btnOK.Enabled = true;
            btnCancelar.Enabled = false;
            ClearForm(this);
            HabilitarControles();

            txtCodigoPaciente.Text = id.ToString();
            txtNomePaciente.Text = paciente.Nome;
            ListarTodasConsultasPorPaciente(paciente.CodigoPaciente);
        }

        private void CarregarConsulta(int id)
        {
            objConsulta = null;
            Consulta consulta = servico.BuscarConsulta(id);

            if (consulta != null){
                txtCodigoPaciente.Text = consulta.Paciente.CodigoPaciente.ToString();
                txtNomePaciente.Text = consulta.Paciente.Nome;

                DesabilitarControles();

                txtPeso.Text = consulta.Peso;
                txtPressaoArterial.Text = consulta.PressaoArterial;
                txtAltura.Text = consulta.Altura;
                txtMedidas.Text = consulta.Medidas;
                txtProblemasSaude.Text = consulta.ProblemaSaude;
                txtRestricoesAlimentares.Text = consulta.RestricoesAlimentares;
                txtUsoMedicamento.Text = consulta.UsoMedicamento;
                txtHistoricoFamiliar.Text = consulta.HistoricoFamiliar;
                txtObjetivo.Text = consulta.Objetivo;
                txtObservacao.Text = consulta.Observacao;
            }
            else
            {
                MessageBox.Show("Consulta não encontrada!", "NutriCorpo - Clínica Especializada em Nutrição", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }          
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (lvConsulta.SelectedItems.Count > 0)
            {
                string idSelecionado = lvConsulta.SelectedItems[0].Text;
                //MessageBox.Show("o id selecionado eh " + idSelecionado);

                id = Convert.ToInt32(idSelecionado);               
                string status = lvConsulta.SelectedItems[0].SubItems[5].Text;

                if (status == "Ativo"){
                    servico.ExcluirConsulta(id);
                    MessageBox.Show("Consulta cancelada com sucesso!", "NutriCorpo - Clínica Especializada em Nutrição", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (txtCodigoPaciente.Text != "")
                    {
                        int idPaciente = Convert.ToInt32(txtCodigoPaciente.Text);
                        ListarTodasConsultasPorPaciente(idPaciente);
                    }
                    else
                    {
                        ListarTodasConsultas();
                    }
                }
                else
                {
                    MessageBox.Show("Esta consulta já está cancelada! Por favor, selecione uma consulta ativa.", "NutriCorpo - Clínica Especializada em Nutrição", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListarTodasConsultas_Click(object sender, EventArgs e)
        {
            objConsulta = null;
            ClearForm(this);
            HabilitarControles();
            ListarTodasConsultas();
        }

        #region Desabilitar Controles
        private void DesabilitarControles()
        {
            txtPeso.ReadOnly = true;
            txtPressaoArterial.ReadOnly = true;
            txtAltura.ReadOnly = true;
            txtMedidas.ReadOnly = true;
            txtProblemasSaude.ReadOnly = true;
            txtRestricoesAlimentares.ReadOnly = true;
            txtUsoMedicamento.ReadOnly = true;
            txtHistoricoFamiliar.ReadOnly = true;
            txtObjetivo.ReadOnly = true;
            txtObservacao.ReadOnly = true;
        }
        #endregion
        #region Habilitar Controles
        private void HabilitarControles()
        {
            txtPeso.ReadOnly = false;
            txtPressaoArterial.ReadOnly = false;
            txtAltura.ReadOnly = false;
            txtMedidas.ReadOnly = false;
            txtProblemasSaude.ReadOnly = false;
            txtRestricoesAlimentares.ReadOnly = false;
            txtUsoMedicamento.ReadOnly = false;
            txtHistoricoFamiliar.ReadOnly = false;
            txtObjetivo.ReadOnly = false;
            txtObservacao.ReadOnly = false;
        }
        #endregion
        #region Limpar campos do formulário
        public static void ClearForm(System.Windows.Forms.Control parent)
        {
            foreach (System.Windows.Forms.Control ctrControl in parent.Controls)
            {
                //Loop through all controls
                if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.TextBox)))
                {
                    //Check to see if it's a textbox
                    ((System.Windows.Forms.TextBox)ctrControl).Text = string.Empty;
                    //If it is then set the text to String.Empty (empty textbox)
                }
                /*
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RichTextBox)))
                {
                    //If its a RichTextBox clear the text
                    ((System.Windows.Forms.RichTextBox)ctrControl).Text = string.Empty;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.ComboBox)))
                {
                    //Next check if it's a dropdown list
                    ((System.Windows.Forms.ComboBox)ctrControl).SelectedIndex = -1;
                    //If it is then set its SelectedIndex to 0
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.CheckBox)))
                {
                    //Next uncheck all checkboxes
                    ((System.Windows.Forms.CheckBox)ctrControl).Checked = false;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RadioButton)))
                {
                    //Unselect all RadioButtons
                    ((System.Windows.Forms.RadioButton)ctrControl).Checked = false;
                }
                */
                if (ctrControl.Controls.Count > 0)
                {
                    //Call itself to get all other controls in other containers
                    ClearForm(ctrControl);
                }
            }
        }
        #endregion

    }
}
