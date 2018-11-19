using ClinicaClass.nutricionista;
using ClinicaClass.paciente;
using ClinicaClass.util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaClass.consulta
{
    public class RepositorioConsulta : IRepositorioConsulta
    {
        private const string nomeTable = "Consulta";
        private static string msg_erro_consulta = "Erro ao realizar consulta";

        private static SqlConnection conexao; 
        private static SqlCommand command; 
        private static DataSet dados;
        private static SqlDataReader dataReader;

        List<Consulta> listConsulta;

        public RepositorioConsulta() {}


        #region Inserir Consulta
        public void Inserir(Consulta consulta)
        {
            try
            {
                conexao = Conexao.GetConexao();
                conexao = Conexao.AbrirConnection(conexao);

                /*
                string sql = "INSERT INTO "+ nomeTable + "(pac_codigo, nut_codigo, con_peso, con_pressao_arterial, con_altura, "+
                             "con_medidas, con_problema_saude, con_restricoes_alimentares, con_uso_medicamento, con_historico_familiar, "+
                             "con_objetivo, con_observacao, con_data) VALUES (@pac_codigo, @nut_codigo, @con_peso, @con_pressao_arterial, @con_altura, " +
                             "@con_medidas, @con_problema_saude, @con_restricoes_alimentares, @con_uso_medicamento, @con_historico_familiar, " +
                             "@con_objetivo, @con_observacao, @con_data);";
                */
                string campos = "", values = "";
                string sql = "INSERT INTO " + nomeTable;

                SqlCommand cmd = conexao.CreateCommand();

                #region Paciente
                if (consulta.Paciente.CodigoPaciente.ToString() != "")
                {
                    campos += "pac_codigo";
                    values += "@pac_codigo";
                    cmd.Parameters.AddWithValue("pac_codigo", consulta.Paciente.CodigoPaciente);
                }
                #endregion
                #region Nutricionista
                if (consulta.Nutricionista.CodigoNutricionista.ToString() != "")
                {
                    campos += ", nut_codigo";
                    values += ", @nut_codigo";
                    cmd.Parameters.AddWithValue("nut_codigo", consulta.Nutricionista.CodigoNutricionista);
                }
                #endregion
                #region Peso
                if (consulta.Peso.ToString() != "")
                {
                    campos += ", con_peso";
                    values += ", @con_peso";
                    cmd.Parameters.AddWithValue("con_peso", consulta.Peso);
                }
                #endregion
                #region Pressao Arterial
                if (consulta.PressaoArterial.ToString() != "")
                {
                    campos += ", con_pressao_arterial";
                    values += ", @con_pressao_arterial";
                    cmd.Parameters.AddWithValue("con_pressao_arterial", consulta.PressaoArterial);
                }
                #endregion
                #region Altura
                if (consulta.Altura.ToString() != "")
                {
                    campos += ", con_altura";
                    values += ", @con_altura";
                    cmd.Parameters.AddWithValue("con_altura", consulta.Altura);
                }
                #endregion
                #region Medidas
                if (consulta.Medidas.ToString() != "")
                {
                    campos += ", con_medidas";
                    values += ", @con_medidas";
                    cmd.Parameters.AddWithValue("con_medidas", consulta.Medidas);
                }
                #endregion
                #region Problema Saude
                if (consulta.ProblemaSaude.ToString() != "")
                {
                    campos += ", con_problema_saude";
                    values += ", @con_problema_saude";
                    cmd.Parameters.AddWithValue("con_problema_saude", consulta.ProblemaSaude);
                }
                #endregion
                #region Restricoes Alimentares
                if (consulta.RestricoesAlimentares.ToString() != "")
                {
                    campos += ", con_restricoes_alimentares";
                    values += ", @con_restricoes_alimentares";
                    cmd.Parameters.AddWithValue("con_restricoes_alimentares", consulta.RestricoesAlimentares);
                }
                #endregion
                #region Uso Medicamento
                if (consulta.UsoMedicamento.ToString() != "")
                {
                    campos += ", con_uso_medicamento";
                    values += ", @con_uso_medicamento";
                    cmd.Parameters.AddWithValue("con_uso_medicamento", consulta.UsoMedicamento);
                }
                #endregion
                #region Historico Familiar
                if (consulta.HistoricoFamiliar.ToString() != "")
                {
                    campos += ", con_historico_familiar";
                    values += ", @con_historico_familiar";
                    cmd.Parameters.AddWithValue("con_historico_familiar", consulta.HistoricoFamiliar);
                }
                #endregion
                #region Objetivo
                if (consulta.Objetivo.ToString() != "")
                {
                    campos += ", con_objetivo";
                    values += ", @con_objetivo";
                    cmd.Parameters.AddWithValue("con_objetivo", consulta.Objetivo);
                }
                #endregion
                #region Observacao
                if (consulta.Observacao.ToString() != "")
                {
                    campos += ", con_observacao";
                    values += ", @con_observacao";
                    cmd.Parameters.AddWithValue("con_observacao", consulta.Observacao);
                }
                #endregion
                #region Data
                campos += ", con_data";
                values += ", @con_data";
                cmd.Parameters.AddWithValue("con_data", consulta.DataConsulta);
                #endregion
                #region Status
                campos += ", con_status";
                values += ", @con_status";
                cmd.Parameters.AddWithValue("con_status", consulta.Status);
                #endregion

                sql += "("+ campos + ") VALUES (" + values + ");";

                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
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
        #endregion

        #region Editar Consulta
        public void Editar(Consulta consulta)
        {
            try
            {
                conexao = Conexao.GetConexao();
                conexao = Conexao.AbrirConnection(conexao);

                /*
                string sql = "UPDATE " + nomeTable + " SET ( "+
                             "pac_codigo = @pac_codigo, nut_codigo = @nut_codigo, con_peso = @con_peso, con_pressao_arterial = @con_pressao_arterial, con_altura = @con_altura, " +
                             "con_medidas = @con_medidas, con_problema_saude = @con_problema_saude, con_restricoes_alimentares = @con_restricoes_alimentares, con_uso_medicamento = @con_uso_medicamento, " +
                             "con_historico_familiar = @con_historico_familiar, con_objetivo = @con_objetivo, con_observacao = @con_observacao) " +
                             "WHERE con_codigo = " + consulta.CodigoConsulta + ";";
                */
                string sql = "UPDATE " + nomeTable;
                string sqlParte = " SET ";

                SqlCommand cmd = conexao.CreateCommand();

                #region Peso
                if (consulta.Peso.ToString() != "")
                {
                    sqlParte += "con_peso = '" + Convert.ToString(consulta.Peso) + "'";
                }
                #endregion
                #region Pressao Arterial
                if (consulta.PressaoArterial.ToString() != "")
                {
                    if (string.Compare(sqlParte, " SET ") != 0)
                        sqlParte += ", ";
                    sqlParte += "con_pressao_arterial = '" + Convert.ToString(consulta.PressaoArterial) + "'";
                }
                #endregion
                #region Altura
                if (consulta.Altura.ToString() != "")
                {
                    if (string.Compare(sqlParte, " SET ") != 0)
                        sqlParte += ", "; 
                    sqlParte += "con_altura = '" + Convert.ToString(consulta.Altura) + "'";
                }
                #endregion
                #region Medidas
                if (consulta.Medidas.ToString() != "")
                {
                    if (string.Compare(sqlParte, " SET ") != 0)
                        sqlParte += ", ";
                    sqlParte += "con_medidas = '" + Convert.ToString(consulta.Medidas) + "'";
                }
                #endregion
                #region Problema Saude
                if (consulta.ProblemaSaude.ToString() != "")
                {
                    if (string.Compare(sqlParte, " SET ") != 0)
                        sqlParte += ", ";
                    sqlParte += "con_problema_saude = '" + Convert.ToString(consulta.ProblemaSaude) + "'";
                }
                #endregion
                #region Restricoes Alimentares
                if (consulta.RestricoesAlimentares.ToString() != "")
                {
                    if (string.Compare(sqlParte, " SET ") != 0)
                        sqlParte += ", ";
                    sqlParte += "con_restricoes_alimentares = '" + Convert.ToString(consulta.RestricoesAlimentares) + "'";
                }
                #endregion
                #region Uso Medicamento
                if (consulta.UsoMedicamento.ToString() != "")
                {
                    if (string.Compare(sqlParte, " SET ") != 0)
                        sqlParte += ", ";
                    sqlParte += "con_uso_medicamento = '" + Convert.ToString(consulta.UsoMedicamento) + "'";
                }
                #endregion
                #region Historico Familiar
                if (consulta.HistoricoFamiliar.ToString() != "")
                {
                    if (string.Compare(sqlParte, " SET ") != 0)
                        sqlParte += ", ";
                    sqlParte += "con_historico_familiar = '" + Convert.ToString(consulta.HistoricoFamiliar) + "'";
                }
                #endregion
                #region Objetivo
                if (consulta.Objetivo.ToString() != "")
                {
                    if (string.Compare(sqlParte, " SET ") != 0)
                        sqlParte += ", ";
                    sqlParte += "con_objetivo = '" + Convert.ToString(consulta.Objetivo) + "'";
                }
                #endregion
                #region Observacao
                if (consulta.Observacao.ToString() != "")
                {
                    if (string.Compare(sqlParte, " SET ") != 0)
                        sqlParte += ", ";
                    sqlParte += "con_observacao = '" + Convert.ToString(consulta.Observacao) + "'";
                }
                #endregion

                //Se o conteudo de sqlParte for diferente da string " SET ", executamos a consulta
                if (string.Compare(sqlParte, " SET ") != 0)
                {
                    sql += sqlParte + " WHERE con_codigo = " + consulta.CodigoConsulta + ";";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                
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
        #endregion

        public void Excluir(int codigoConsulta)
        {
            try
            {
                conexao = Conexao.GetConexao();
                conexao = Conexao.AbrirConnection(conexao);

                string sql = "UPDATE Consulta SET con_status = 'Cancelado' WHERE con_codigo = " + codigoConsulta + ";";

                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
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

        public Consulta Buscar(int codigoConsulta)
        {
            try
            {
                Consulta consulta = null;
                Paciente paciente = null;

                conexao = Conexao.GetConexao();
                conexao = Conexao.AbrirConnection(conexao);

                string sql = "SELECT Con.con_codigo, Con.pac_codigo, Pac.pac_nome, Con.nut_codigo, Con.con_peso, "+
                                    "Con.con_pressao_arterial, Con.con_altura, Con.con_medidas, Con.con_problema_saude, "+
                                    "Con.con_restricoes_alimentares, Con.con_uso_medicamento, Con.con_historico_familiar, "+
                                    "Con.con_objetivo, Con.con_observacao, Con.con_data, Con.con_status "+
                            "FROM Consulta as Con "+
                                    "JOIN Paciente as Pac ON Con.pac_codigo = Pac.pac_codigo "+
                            "WHERE Con.con_codigo = " + codigoConsulta + ";";

                SqlCommand cmd = conexao.CreateCommand();

                cmd.CommandText = sql;
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    consulta = new Consulta();
                    
                    consulta.CodigoConsulta = dataReader.GetInt32(dataReader.GetOrdinal("con_codigo"));
                    consulta.Paciente = new Paciente();
                    consulta.Paciente.CodigoPaciente = dataReader.GetInt32(dataReader.GetOrdinal("pac_codigo"));
                    consulta.Paciente.Nome = dataReader.GetString(dataReader.GetOrdinal("pac_nome"));


                    if (!dataReader.IsDBNull(dataReader.GetOrdinal("con_peso")))
                    {
                        consulta.Peso = dataReader.GetString(dataReader.GetOrdinal("con_peso"));
                    }
                    if (!dataReader.IsDBNull(dataReader.GetOrdinal("con_pressao_arterial")))
                    {
                        consulta.PressaoArterial = dataReader.GetString(dataReader.GetOrdinal("con_pressao_arterial"));
                    }
                    if (!dataReader.IsDBNull(dataReader.GetOrdinal("con_altura")))
                    {
                        consulta.Altura = dataReader.GetString(dataReader.GetOrdinal("con_altura"));
                    }
                    if (!dataReader.IsDBNull(dataReader.GetOrdinal("con_medidas")))
                    {
                        consulta.Medidas = dataReader.GetString(dataReader.GetOrdinal("con_medidas"));
                    }
                    if (!dataReader.IsDBNull(dataReader.GetOrdinal("con_problema_saude")))
                    {
                        consulta.ProblemaSaude = dataReader.GetString(dataReader.GetOrdinal("con_problema_saude"));
                    }
                    if (!dataReader.IsDBNull(dataReader.GetOrdinal("con_restricoes_alimentares")))
                    {
                        consulta.RestricoesAlimentares = dataReader.GetString(dataReader.GetOrdinal("con_restricoes_alimentares"));
                    }
                    if (!dataReader.IsDBNull(dataReader.GetOrdinal("con_uso_medicamento")))
                    {
                        consulta.UsoMedicamento = dataReader.GetString(dataReader.GetOrdinal("con_uso_medicamento"));
                    }
                    if (!dataReader.IsDBNull(dataReader.GetOrdinal("con_historico_familiar")))
                    {
                        consulta.HistoricoFamiliar = dataReader.GetString(dataReader.GetOrdinal("con_historico_familiar"));
                    }
                    if (!dataReader.IsDBNull(dataReader.GetOrdinal("con_objetivo")))
                    {
                        consulta.Objetivo = dataReader.GetString(dataReader.GetOrdinal("con_objetivo"));
                    }
                    if (!dataReader.IsDBNull(dataReader.GetOrdinal("con_observacao")))
                    {
                        consulta.Observacao = dataReader.GetString(dataReader.GetOrdinal("con_observacao"));
                    }
                    if (!dataReader.IsDBNull(dataReader.GetOrdinal("con_status")))
                    {
                        consulta.Status = dataReader.GetString(dataReader.GetOrdinal("con_status"));
                    }
                    
                }

                dataReader.Close();
                dataReader.Dispose();
                cmd.Dispose();

                return consulta;
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

        public Consulta Buscar(Consulta consulta)
        {
            try
            {
                Consulta objConsulta = null;

                conexao = Conexao.GetConexao();
                conexao = Conexao.AbrirConnection(conexao);

                string sql = "SELECT con_codigo FROM Consulta  WHERE ";

                SqlCommand cmd = conexao.CreateCommand();

                #region Paciente
                if (consulta.Paciente.CodigoPaciente.ToString() != "")
                {
                    sql += "pac_codigo = @pac_codigo";
                    cmd.Parameters.AddWithValue("pac_codigo", consulta.Paciente.CodigoPaciente);
                }
                #endregion
                #region Nutricionista
                if (consulta.Nutricionista.CodigoNutricionista.ToString() != "")
                {
                    sql += " AND nut_codigo = @nut_codigo";
                    cmd.Parameters.AddWithValue("nut_codigo", consulta.Nutricionista.CodigoNutricionista);
                }
                #endregion
                #region Peso
                if (consulta.Peso.ToString() != "")
                {
                    sql += " AND con_peso = '" + consulta.Peso + "'";
                }
                #endregion
                #region Pressao Arterial
                if (consulta.PressaoArterial.ToString() != "")
                {
                    sql += " AND con_pressao_arterial = '" + consulta.PressaoArterial + "'";
                }
                #endregion
                #region Altura
                if (consulta.Altura.ToString() != "")
                {
                    sql += " AND con_altura = '"+consulta.Altura+"'";
                }
                #endregion
                #region Medidas
                if (consulta.Medidas.ToString() != "")
                {
                    sql += " AND con_medidas LIKE '"+consulta.Medidas+"'";
                }
                #endregion
                #region Problema Saude
                if (consulta.ProblemaSaude.ToString() != "")
                {
                    sql += " AND con_problema_saude LIKE '"+consulta.ProblemaSaude+"'";
                }
                #endregion
                #region Restricoes Alimentares
                if (consulta.RestricoesAlimentares.ToString() != "")
                {
                    sql += " AND con_restricoes_alimentares LIKE '" + consulta.RestricoesAlimentares + "'";
                }
                #endregion
                #region Uso Medicamento
                if (consulta.UsoMedicamento.ToString() != "")
                {
                    sql += " AND con_uso_medicamento LIKE '" + consulta.UsoMedicamento + "'";
                }
                #endregion
                #region Historico Familiar
                if (consulta.HistoricoFamiliar.ToString() != "")
                {
                    sql += " AND con_historico_familiar LIKE '" + consulta.HistoricoFamiliar + "'";
                }
                #endregion
                #region Objetivo
                if (consulta.Objetivo.ToString() != "")
                {
                    sql += " AND con_objetivo LIKE '" + consulta.Objetivo + "'";
                }
                #endregion
                #region Observacao
                if (consulta.Observacao.ToString() != "")
                {
                    sql += " AND con_observacao LIKE '" + consulta.Observacao + "'";
                }
                #endregion
                #region Status
                    sql += " AND con_status = '"+consulta.Status+"'";
                #endregion

                sql += ";";
                cmd.CommandText = sql;
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    objConsulta = new Consulta();
                    objConsulta.CodigoConsulta = dataReader.GetInt32(dataReader.GetOrdinal("con_codigo"));
                }

                dataReader.Close();
                dataReader.Dispose();
                cmd.Dispose();

                return objConsulta;
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

        public List<Consulta> ListarTodasConsultasPorPaciente(int codigoPaciente)
        {
            try
            {
                listConsulta = new List<Consulta>();

                string sql = "SELECT Con.con_codigo, Con.con_data, Nut.nut_nome, Pac.pac_nome, Con.con_status "+
                             "FROM Consulta as Con JOIN Nutricionista as Nut ON Con.nut_codigo = Nut.nut_codigo "+
                                                  "JOIN Paciente as Pac ON Con.pac_codigo = Pac.pac_codigo " +
                             "WHERE Con.pac_codigo = " + codigoPaciente + " ORDER BY Con.con_data DESC;";

                conexao = Conexao.GetConexao();
                conexao = Conexao.AbrirConnection(conexao);

                command = new SqlCommand(sql, conexao);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Consulta consulta = new Consulta();
                    consulta.CodigoConsulta = dataReader.GetInt32(dataReader.GetOrdinal("con_codigo"));
                    
                    consulta.Nutricionista = new Nutricionista(); ;
                    consulta.Nutricionista.Nome = dataReader.GetString(dataReader.GetOrdinal("nut_nome"));

                    consulta.Paciente = new Paciente();
                    consulta.Paciente.Nome = dataReader.GetString(dataReader.GetOrdinal("pac_nome"));

                    consulta.DataConsulta = dataReader.GetDateTime(dataReader.GetOrdinal("con_data"));

                    consulta.Status = dataReader.GetString(dataReader.GetOrdinal("con_status"));
                    listConsulta.Add(consulta);
                }

                dataReader.Close();
                dataReader.Dispose();
                command.Dispose();

                return listConsulta;

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

        public List<Consulta> ListarTodasConsultas()
        {
            try
            {
                listConsulta = new List<Consulta>();

                string sql = "SELECT Con.con_codigo, Con.con_data, Nut.nut_nome, Pac.pac_nome, Con.con_status " +
                            "FROM Consulta AS Con JOIN Nutricionista AS Nut ON Con.nut_codigo = Nut.nut_codigo " +
                                                 "JOIN Paciente as Pac ON Con.pac_codigo = Pac.pac_codigo " +
                            "ORDER BY Con.con_data DESC";

                conexao = Conexao.GetConexao();
                conexao = Conexao.AbrirConnection(conexao);

                command = new SqlCommand(sql, conexao);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Consulta consulta = new Consulta();
                    
                    consulta.CodigoConsulta = dataReader.GetInt32(dataReader.GetOrdinal("con_codigo"));

                    consulta.Nutricionista = new Nutricionista(); ;
                    consulta.Nutricionista.Nome = dataReader.GetString(dataReader.GetOrdinal("nut_nome"));

                    consulta.Paciente = new Paciente();
                    consulta.Paciente.Nome = dataReader.GetString(dataReader.GetOrdinal("pac_nome"));

                    consulta.DataConsulta = dataReader.GetDateTime(dataReader.GetOrdinal("con_data"));

                    consulta.Status = dataReader.GetString(dataReader.GetOrdinal("con_status"));
                    listConsulta.Add(consulta);
                }

                dataReader.Close();
                dataReader.Dispose();
                command.Dispose();

                return listConsulta;

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
