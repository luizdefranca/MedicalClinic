using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaClass.consulta
{
    public class ManterConsulta
    {
        private static RepositorioConsulta respConsulta = new RepositorioConsulta();

        public ManterConsulta() {}

        public void Inserir(Consulta consulta)
        {
            try
            {
                respConsulta.Inserir(consulta);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void Editar(Consulta consulta)
        {
            try
            {
                respConsulta.Editar(consulta);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void Excluir(int codigoConsulta)
        {
            try
            {
                respConsulta.Excluir(codigoConsulta);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public Consulta Buscar(int codigoConsulta)
        {
            try
            {
                return respConsulta.Buscar(codigoConsulta);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public Consulta Buscar(Consulta consulta)
        {
            try
            {
                return respConsulta.Buscar(consulta);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public List<Consulta> ListarTodasConsultas()
        {
            try
            {
                return respConsulta.ListarTodasConsultas();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public List<Consulta> ListarTodasConsultasPorPaciente(int codigoPaciente)
        {
            try
            {
                return respConsulta.ListarTodasConsultasPorPaciente(codigoPaciente);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

    }
}
