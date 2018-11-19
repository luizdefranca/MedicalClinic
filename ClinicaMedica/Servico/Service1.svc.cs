using ClinicaClass.consulta;
using ClinicaClass.paciente;
using ClinicaClass.usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Servico
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        #region Usuário
        public Usuario Logar(Usuario usuario)
        {
            return new ManterUsuario().Logar(usuario);
        }
        #endregion

        #region Paciente
        public List<Paciente> ListarTodosPacientes()
        {
            return new ManterPaciente().ListarTodosPacientes();
        }

        public List<Paciente> ListarTodosPacientesPorNome(string nome)
        {
            return new ManterPaciente().ListarTodosPacientesPorNome(nome);
        }

        public Paciente BuscarPaciente(int codigo)
        {
            return new ManterPaciente().Buscar(codigo);
        }
        #endregion

        #region CRUD "Consulta"
        public void InserirConsulta(Consulta consulta)
        {
            new ManterConsulta().Inserir(consulta);
        }

        public void EditarConsulta(Consulta consulta)
        {
            new ManterConsulta().Editar(consulta);
        }
    
        public void ExcluirConsulta(int codigoConsulta)
        {
            new ManterConsulta().Excluir(codigoConsulta);
        }

        public Consulta BuscarConsulta(int codigoConsulta)
        {
            return new ManterConsulta().Buscar(codigoConsulta);
        }

        public Consulta RetornaConsulta(Consulta consulta)
        {
            return new ManterConsulta().Buscar(consulta);
        }

        public List<Consulta> ListarTodasConsultas()
        {
            return new ManterConsulta().ListarTodasConsultas();
        }

        public List<Consulta> ListarTodasConsultasPorPaciente(int codigoPaciente)
        {
            return new ManterConsulta().ListarTodasConsultasPorPaciente(codigoPaciente);
        }
        #endregion



        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
