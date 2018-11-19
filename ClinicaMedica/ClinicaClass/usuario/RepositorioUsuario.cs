using ClinicaClass.nutricionista;
using ClinicaClass.tipoUsuario;
using ClinicaClass.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaClass.usuario
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private const string nomeTable = "Usuario";
        private static SqlConnection conexao;
        private static SqlCommand command;
        private static SqlDataReader dataReader;

        public RepositorioUsuario() { }

        public Usuario Logar(Usuario usuario)
        {
            try
            {
                //fazer aqui a consulta do usuario, retornar null caso nao ache!
                Usuario novoUsuario = null;

                string sql = "SELECT * FROM Usuario WHERE usu_login = '"+ usuario.Login +"' AND usu_senha = '"+usuario.Senha+"'";

                conexao = Conexao.GetConexao();
                conexao = Conexao.AbrirConnection(conexao);

                command = new SqlCommand(sql, conexao);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    novoUsuario = new Usuario();
                    novoUsuario.CodigoUsuario = dataReader.GetInt32(dataReader.GetOrdinal("usu_codigo"));

                    novoUsuario.Nutricionista = new Nutricionista();
                    //if (dataReader.GetString(dataReader.GetOrdinal("nut_codigo")) != null){
                        novoUsuario.Nutricionista.CodigoNutricionista = dataReader.GetInt32(dataReader.GetOrdinal("nut_codigo"));
                    //}

                    novoUsuario.TipoUsuario = new TipoUsuario();
                    novoUsuario.TipoUsuario.CodigoTipoUsuario = dataReader.GetInt32(dataReader.GetOrdinal("tpu_codigo"));

                    novoUsuario.Login = dataReader.GetString(dataReader.GetOrdinal("usu_login"));
                    novoUsuario.Senha = dataReader.GetString(dataReader.GetOrdinal("usu_senha"));
                }

                dataReader.Close();
                dataReader.Dispose();
                command.Dispose();

                return novoUsuario;

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
