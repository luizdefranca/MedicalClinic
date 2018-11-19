using ClinicaClass.consulta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaClass.paciente
{
    interface IRepositorioPaciente
    {
        Paciente Buscar(int codigoPaciente);

        List<Paciente> ListarTodosPacientes();

        List<Paciente> ListarTodosPacientesPorNome(string nome);
    }
}
