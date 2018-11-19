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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        #region Usuário
        [OperationContract]
        Usuario Logar(Usuario usuario);
        #endregion



        #region Paciente
        [OperationContract]
        List<Paciente> ListarTodosPacientes();

        [OperationContract]
        List<Paciente> ListarTodosPacientesPorNome(string nome);

        [OperationContract]
        Paciente BuscarPaciente(int codigo);
        #endregion



        #region CRUD "Consulta"
        [OperationContract]
        void InserirConsulta(Consulta consulta);

        [OperationContract]
        void EditarConsulta(Consulta consulta);

        [OperationContract]
        void ExcluirConsulta(int codigoConsulta);

        [OperationContract]
        Consulta BuscarConsulta(int codigoConsulta);

        [OperationContract]
        Consulta RetornaConsulta(Consulta consulta);

        [OperationContract]
        List<Consulta> ListarTodasConsultas();

        [OperationContract]
        List<Consulta> ListarTodasConsultasPorPaciente(int codigoPaciente);
        #endregion




        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
