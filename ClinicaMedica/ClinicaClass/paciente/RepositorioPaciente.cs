using ClinicaClass.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaClass.paciente
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        private const string nomeTable = "Paciente";
        
        private static SqlConnection conexao; 
        private static SqlCommand command; 
        private static DataSet dados;
        private static SqlDataReader dataReader;

        List<Paciente> listPaciente;

        public RepositorioPaciente() { }

        public Paciente Buscar(int codigoConsulta)
        {
            try
            {
                string sql = "SELECT * FROM " + nomeTable + " WHERE pac_codigo = " + codigoConsulta + ";";
                conexao = Conexao.GetConexao();
                conexao = Conexao.AbrirConnection(conexao);

                SqlCommand cmd = conexao.CreateCommand();

                cmd.CommandText = sql;
                dataReader = cmd.ExecuteReader();
                Paciente paciente = new Paciente();
                while (dataReader.Read())
                {
                    
                    paciente.CodigoPaciente = dataReader.GetInt32(0);
                    paciente.Nome = dataReader.GetString(1);
                }

                dataReader.Close();
                dataReader.Dispose();
                command.Dispose();


                return paciente;
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
                listPaciente = new List<Paciente>();

                conexao = Conexao.GetConexao();
                conexao = Conexao.AbrirConnection(conexao);

                string sql = "SELECT * FROM " + nomeTable; //+" WHERE pac_nome = '%" + nome + "%'";

                command = conexao.CreateCommand();
                if (nome.Equals("") == false)
                {
                    sql += " WHERE pac_nome LIKE '%"+nome+"%'";
                }

                command.CommandText = sql;
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Paciente paciente = new Paciente();
                    paciente.CodigoPaciente = dataReader.GetInt32(0);
                    paciente.Nome = dataReader.GetString(1);
                    listPaciente.Add(paciente);
                }

                dataReader.Close();
                dataReader.Dispose();
                command.Dispose();

                return listPaciente;

            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                if (conexao != null)
                    Conexao.CloseConnection(conexao);
            }
        }

        public List<Paciente> ListarTodosPacientes()
        {
            try
            {
                listPaciente = new List<Paciente>();

                string sql = "SELECT * FROM " + nomeTable;

                conexao = Conexao.GetConexao();
                conexao = Conexao.AbrirConnection(conexao);

                command = new SqlCommand(sql, conexao);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Paciente paciente = new Paciente();
                    paciente.CodigoPaciente = dataReader.GetInt32(dataReader.GetOrdinal("pac_codigo"));
                    paciente.Nome = dataReader.GetString(dataReader.GetOrdinal("pac_nome"));
                    listPaciente.Add(paciente);
                }

                dataReader.Close();
                dataReader.Dispose();
                command.Dispose();

                return listPaciente;                               
                
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                if (conexao != null)
                    Conexao.CloseConnection(conexao);
            }
        }
    }
}
