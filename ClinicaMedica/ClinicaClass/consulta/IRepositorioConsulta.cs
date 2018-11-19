using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaClass.consulta
{
    interface IRepositorioConsulta
    {
        void Inserir(Consulta consulta);

        void Editar(Consulta consulta);

        void Excluir(int codigoConsulta);

        Consulta Buscar(int codigoConsulta);

        Consulta Buscar(Consulta consulta);

        List<Consulta> ListarTodasConsultas();

        List<Consulta> ListarTodasConsultasPorPaciente(int codigoPaciente);
    }
}
