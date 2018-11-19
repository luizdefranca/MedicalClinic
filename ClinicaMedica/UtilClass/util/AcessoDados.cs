using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilClass.util
{
    public class AcessoDados
    {
        private static SqlConnection conexao; 
        private static SqlCommand command; 
        private static DataSet dados;

        public AcessoDados() { }

        public bool Conectar()
        {
            try
            {
                conexao = Conexao.GetConexao();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Executa um SELECT e retorna um bloco de registros
        
        
        //Executa um SELECT e retorna um registro apenas


        //Executa Comandos do tipo: UPDATE, INSERT E DELETE
        #region void - executarComando - sql, transacao
        public void executarComando(string sql, Transacional transacao)
        {
            try
            {
                conexao = Conexao.GetConexao();
                conexao = Conexao.AbrirConnection(conexao);

                //command = new SqlCommand(sql, conexao);
                
                command = new SqlCommand();
                command.Connection = transacao.transacao.Connection;
                command.CommandText = sql;
                command.Transaction = transacao.transacao;
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        #endregion

        #region DataSet - ConsultarDataSet - sql
        public DataSet ConsultaDataSet(string sql)
        {
            DataSet dsConsulta = new DataSet();
            try
            {
                conexao = Conexao.GetConexao();
                conexao = Conexao.AbrirConnection(conexao);


                //DataAdapter daConsulta = new DataAdapter(sql, conexao);
                //daConsulta.Fill(dsConsulta);

                return dsConsulta;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conexao != null)
                    Conexao.CloseConnection(conexao);
            }
        }
        #endregion

        #region SqlDataReader - ConsultarSqlDataReader - sql
        public SqlDataReader ConsultaSqlDataReader(string sql)
        {
            try
            {
                conexao = Conexao.GetConexao();
                conexao = Conexao.AbrirConnection(conexao);

                SqlCommand cmd = new SqlCommand(sql, conexao);
                SqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conexao != null)
                    Conexao.CloseConnection(conexao);
            }
        }
        #endregion
    }
}
