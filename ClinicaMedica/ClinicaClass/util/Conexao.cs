using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaClass.util
{
    //internal sealed class Conexao
    public class Conexao
    {
        private static SqlConnection conexao;

        private static string connectionString = @"Data Source=localhost;Initial Catalog=ClinicaNutricional;UId=sa;Password=sa";

        //Data Source=localhost;Initial Catalog=ClinicaNutricional;Integrated Security=SSPI - Define SSPI para fazer conexao usando autenticacao do windows

        public static SqlConnection GetConexao()
        {
            try
            {
                if (conexao == null || conexao.ConnectionString == "")
                {
                    conexao = new SqlConnection(connectionString);
                }
                return conexao;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro ao conectar!", ex);
            }
        }

        public static SqlConnection AbrirConnection(SqlConnection conexao)
        {
            if (!conexao.State.ToString().Equals("Open"))
            {
                conexao.Open();
            }
            return conexao;
        }

        public static void CloseConnection(SqlConnection conexao)
        {
            if (!conexao.State.ToString().Equals("Close"))
            {
                conexao.Close();
                conexao.Dispose();
            }
        }
    }
}
