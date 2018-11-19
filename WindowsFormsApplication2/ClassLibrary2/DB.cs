using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Threading;

namespace ClinicaNutrical.DAO
{
    public class DB
    {
        
        //http://www.connectionstrings.com/
       
      //  public SqlConnection sqlConn;

        public Thread thread;
        
        
        //string de conexão obtida para o sql sever
        public static string connectionStringSqlServer = "Data Source=WINMAC-LUIZ;Initial Catalog=ClinicaNutricional;Persist Security Info=True;User ID=sa;Password=sa";
        // 
        // Metodo para passagem de comandos e abre conexao
        //
        public static int executeQuery(string cn,                           // passagem da connectionString
                                        CommandType cmdType,                // informa o tipo de comando (sql ou procedure)
                                        string cmdText,                     //comando sql ou procedure
                                        params SqlParameter[] cmdParameter) // array com os parametros
        {
            SqlCommand cmd = new SqlCommand();
            
            
            //try
            //{

            using (SqlConnection con = new SqlConnection(cn))                // abre a conexao e executa o SqlCommand
            {

                //Thread thread = new Thread(() =>
                //    {
                prepareCommand(cmd, con, cmdType, cmdText, cmdParameter);  // Faz uma chamada para preparar o SqlCommand 
                //    });
                //thread.Start();
                int value = cmd.ExecuteNonQuery();                           //Executa o SqlCommand e recebe o retorno da chamada
                return value;
            }
                //Sql

            
        }

        public static SqlDataReader ExecuteReader(string cn,                                //recebe a string de conexao
                                                   CommandType cmdType,                     // recebe o tipo de comando (SqlText ou Procedure)
                                                   string cmdText,                          // recebe a string com a instrucao em SQL
                                                   params SqlParameter[] cmdParameter)      // recebe um array com parametros
        {
            SqlCommand cmd = new SqlCommand();
            
            SqlConnection con = new SqlConnection(DB.connectionStringSqlServer);            //Nao esquecer de passar a string de conexao
            try
            {
                          
 

                prepareCommand(cmd, con, cmdType, cmdText, cmdParameter);
               

            
                SqlDataReader dataReader = cmd.ExecuteReader();
                
                return dataReader;
            }
            catch (Exception e)
            {
                con.Close();
                
                System.Windows.Forms.MessageBox.Show("Falha: " + e);
                return null;
            }
        }


        public static void prepareCommand(SqlCommand cmd,               // recebe um objeto para receber um comando para o banco de dados
                                          SqlConnection con,            // recebe um objeto de comunicacao com o banco de dados 
                                          CommandType cmdType,          // define o tipo de comando a ser executado (TextSQL ou Procedure)
                                          string cmdText,               // string com a instrucao em SQL
                                          SqlParameter[] cmdParameter)  // parametros q poderao ser repassados
        {
            if (con.State != ConnectionState.Open) // se a conexao nao estiver aberta abrira a conexao
              
                con.Open();
             
            cmd.Connection = con;
            cmd.CommandType = cmdType;
            cmd.CommandText = cmdText;

            if (cmdParameter != null)                                    // Verifica se foi repassado algum parametro
            {
                foreach (SqlParameter param in cmdParameter)             //caso haja parametro insere no vetor do tipo Parameters
                    cmd.Parameters.Add(param);                           // os parametros repassados

            }


        }


        #region
        /*
        public void abrirConexao()
        {
            try
            {
                //iniciando uma conexão com o sql server, utilizando os parâmetros da string de conexão
                this.sqlConn = new SqlConnection(connectionStringSqlServer);
                //abrindo a conexão com a base de dados
                this.sqlConn.Open();
                System.Windows.Forms.MessageBox.Show("Connecao OK");
            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("Falha: " + e); 
            }
        }


        public void fecharConexao()
        {
            //fechando a conexao com a base de dados
            sqlConn.Close();
            //liberando a conexao da memoria
            sqlConn.Dispose();
        }
        
        // public static string ConnectionStringSQLServer;
     
        //string ConnectionString = "Data Source=WINMAC-LUIZ;Initial Catalog=ClinicaNutricional;Persist Security Info=True;User ID=sa;Password=sa";
        */
        #endregion
    } 
}
