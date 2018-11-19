using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaClass.paciente
{
    public class ManterPaciente
    {
        private static RepositorioPaciente respPaciente = new RepositorioPaciente();

        public ManterPaciente() { }

        public Paciente Buscar(int codigoPaciente)
        {
            try
            {
                return respPaciente.Buscar(codigoPaciente);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public List<Paciente> ListarTodosPacientesPorNome(string nome)
        {
            try
            {
                return respPaciente.ListarTodosPacientesPorNome(nome);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public List<Paciente> ListarTodosPacientes()
        {
            try
            {
                return respPaciente.ListarTodosPacientes();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
