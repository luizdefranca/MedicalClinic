using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaNutrical.Model;
using System.Data.SqlClient;
using System.Threading;

namespace ClinicaNutrical.DAO
{
    public class ConsultaDAO
    {
        public List<Consulta> GetAllConsultas()
        {
            List<Consulta> listaConsulta = new List<Consulta>();
            
            SqlDataReader dr = DB.ExecuteReader(DB.connectionStringSqlServer,
                                                System.Data.CommandType.Text,
                                                "Select * from Consulta");
            
            
            
            
            while (dr.Read())
            {
                PacienteDAO pacienteDal = new PacienteDAO();
                NutricionistaDAO nutricionistaDal = new NutricionistaDAO();
               // Paciente paciente = pacienteDal.GetByIdPaciente(Convert.ToInt32(dr["pac_codigo"]));
               // Nutricionista nutricionista = nutricionistaDal.GetByIdNutricionista(Convert.ToInt32(dr["nut_codigo"]));
                
                Consulta consulta = new Consulta(  

                    
                                                    Convert.ToInt32(dr["con_codigo"]),          //
                                                    Convert.ToDateTime (dr["con_data"]),                                  
                                                    
                                                    //new Paciente(Convert.ToInt32(dr[2])),
                                                    //new Nutricionista(Convert.ToInt32(dr["nut_codigo"])),
                                                                                                           pacienteDal.GetByIdPaciente(Convert.ToInt32(dr["nut_codigo"])),
                                                                                                           nutricionistaDal.GetByIdNutricionista(Convert.ToInt32(dr["con_codigo"])),
                                                                                                            //Convert.ToInt32(dr["pac_codigo"]),       // inserir objeto paciente
                                                                                                            //Convert.ToInt32(dr["con_codigo"]),       // inserir objeto nutricionista
                                                    Convert.ToDouble(dr["con_peso"]),
                                                    Convert.ToDouble(dr["con_pressao_arterial"]),
                                                    Convert.ToDouble(dr["con_altura"]),
                                                    Convert.ToDouble(dr["con_medidas"]),
                                                    Convert.ToString(dr["con_problema_saude"]),
                                                    Convert.ToString(dr["con_restricoes_alimentares"]),
                                                    Convert.ToString(dr["con_uso_medicamento"]),
                                                    Convert.ToString(dr["con_historico_familiar"]),
                                                    Convert.ToString(dr["con_objetivo"]),
                                                    Convert.ToString(dr["con_observacao"])
                                                      );

                listaConsulta.Add(consulta);

            }
            //foreach (var con in listaConsulta)
            //{
            //    con.Paciente = pacienteDal.GetByIdPaciente(con.Paciente.CodPaciente);
            //}

            //foreach (var con in listaConsulta)
            //{
            //    con.Nutricionista = nutricionistaDal.GetByIdNutricionista(con.Nutricionista.Codigo);
            //}

            return listaConsulta;
        }
        /*
        public void InsertConsulta(Consulta con)
        {

            SqlParameter[] param = new SqlParameter[14];
            param[0] = new SqlParameter("@conCodigo", con.CodConsulta);
            param[1] = new SqlParameter("@data", con.Data);
            param[2] = new SqlParameter("@paciente", con.Paciente);
            param[3] = new SqlParameter("@nutricionista", con.Consulta.Codigo);
            param[4] = new SqlParameter("@sexo", con.Sexo); 
            param[4] = new SqlParameter("@estado_civil", con.EstadoCivil);
            param[6] = new SqlParameter("@email", con.Email);
            param[7] = new SqlParameter("@endereco", con.Endereco);
            param[8] = new SqlParameter("@bairro", con.Bairro);
            param[9] = new SqlParameter("@cep", con.Cep);
            param[10] = new SqlParameter("@cidade", con.Cidade);
            param[11] = new SqlParameter("@uf", con.Uf);
            param[12] = new SqlParameter("@telefone", con.Fone);
            param[13] = new SqlParameter("@celular", con.Celular);
            param[14] = new SqlParameter("@observacao", con.Observacao);



            StringBuilder strb = new StringBuilder();
            strb.Append("INSERT INTO Consulta "
                           + "(con_nome"
                           + ", con_crn"
                           + ", con_cpf "
                           + ", con_data_nascimento"
                           + ", con_sexo"
                           + ", con_estado_civil"
                           + ", con_email"
                           + ", con_endereco"
                           + ", con_bairro"
                           + ", con_cep"
                           + ", con_cidade"
                           + ", con_uf"
                           + ", con_telefone"
                           + ", con_celular"
                           + ", con_observacao)");
            strb.Append(" VALUES "
                            + "(@nome "
                            + ",@crn "
                            + ",@cpf "
                            + ",@data_nascimento "
                            + ",@sexo "
                            + ",@estado_civil "
                            + ",@email "
                            + ",@endereco "
                            + ",@bairro "
                            + ",@cep "
                            + ",@cidade "
                            + ",@uf "
                            + ",@telefone "
                            + ",@celular "
                            + ",@observacao))");

            DB.executeQuery(DB.connectionStringSqlServer, System.Data.CommandType.Text, strb.ToString(), param);
           
        }
         */

        public void InsertConsulta(Consulta consulta)
        {
            SqlParameter[] param = new SqlParameter[13];
            
            param[0] = new SqlParameter("@data",consulta.Data);
            param[1] = new SqlParameter("@paciente",consulta.Paciente.CodPaciente);         //inserir paciente
            param[2] = new SqlParameter("@nutricionista",consulta.Nutricionista.Codigo);    //inserir nutricionista
            param[3] = new SqlParameter("@peso",consulta.Peso);
            param[4] = new SqlParameter("@pressao",consulta.Pressao);
            param[5] = new SqlParameter("@altura",consulta.Altura);
            param[6] = new SqlParameter("@medidas",consulta.Medidas);
            param[7] = new SqlParameter("@saude",consulta.ProblemaSaude);
            param[8] = new SqlParameter("@restricao",consulta.RestricaoAlimentar);
            param[9] = new SqlParameter("@medicamento",consulta.Medicamento);
            param[10] = new SqlParameter("@historico",consulta.HistoricoFamiliar);
            param[11] = new SqlParameter("@objetivo",consulta.Objetivo);
            param[12] = new SqlParameter("@observacao",consulta.Observacao);
          

                        StringBuilder strb = new StringBuilder();
            strb.Append("INSERT INTO Consulta "
                           +"( con_data " 
                           +", pac_codigo " 
                           +", nut_codigo " 
                           +", con_peso " 
                           +", con_pressao " 
                           +", con_altura " 
                           +", con_medidas " 
                           +", con_problema_saude " 
                           +", con_restricoes_alimentares " 
                           +", con_uso_medicamento " 
                           +", con_historico_familiar " 
                           +", con_objetivo " 
                           +", con_observacao)");

            strb.Append(" VALUES "
                            + "(@data "
                            + ",@paciente"
                            + ",@nutricionista"
                            + ",@peso "
                            + ",@pressao "
                            + ",@altura "
                            + ",@medidas "
                            + ",@saude "
                            + ",@restricao "
                            + ",@medicamento "
                            + ",@historico "
                            + ",@objetivo "
                            + ",@observacao)");

            DB.executeQuery(DB.connectionStringSqlServer, System.Data.CommandType.Text, strb.ToString(), param);
           

        }

        public void UpdateConsulta(Consulta consulta)
        {
            SqlParameter[] param = new SqlParameter[14];
            
            param[0] = new SqlParameter("@data", consulta.Data);
            param[1] = new SqlParameter("@paciente", consulta.Paciente.CodPaciente);
            param[2] = new SqlParameter("@nutricionista", consulta.Nutricionista.Codigo);
            param[3] = new SqlParameter("@peso", consulta.Peso);
            param[4] = new SqlParameter("@pressao", consulta.Pressao);
            param[5] = new SqlParameter("@altura", consulta.Altura);
            param[6] = new SqlParameter("@medidas", consulta.Medidas);
            param[7] = new SqlParameter("@saude", consulta.ProblemaSaude);
            param[8] = new SqlParameter("@restricao", consulta.RestricaoAlimentar);
            param[9] = new SqlParameter("@medicamento", consulta.Medicamento);
            param[10] = new SqlParameter("@historico", consulta.HistoricoFamiliar);
            param[11] = new SqlParameter("@objetivo", consulta.Objetivo);
            param[12] = new SqlParameter("@observacao", consulta.Observacao);
            param[13] = new SqlParameter("@codConsulta", consulta.CodConsulta);


            StringBuilder strb = new StringBuilder();
            strb.Append("UPDATE Consulta "
                        + "SET (nut_nome = @nome "
                           + ", nut_crn = @crn "
                           + ", nut_cpf = @cpf "
                           + ", nut_data_nascimento = @dtNascimento"
                           + ", nut_sexo = @sexo "
                           + ", nut_estado_civil = @estadoCivil "
                           + ", nut_email = @email "
                           + ", nut_endereco = @endereco "
                           + ", nut_bairro = @bairro "
                           + ", nut_cep = @cep "
                           + ", nut_cidade = @cidade "
                           + ", nut_uf = @uf "
                           + ", nut_telefone = @fone "
                           + ", nut_celular = @cel "
                           + ", nut_observacao = @obs)");


            strb.Append("WHERE nut_codigo = @codigo");
            DB.executeQuery(DB.connectionStringSqlServer, System.Data.CommandType.Text, strb.ToString(), param);
        }

        public void DeleteConsulta(Consulta consulta)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@codigo", consulta.CodConsulta);

            DB.executeQuery(DB.connectionStringSqlServer, System.Data.CommandType.Text, "DELETE Consulta WHERE con_codigo = @codigo", param);
        }

        public Consulta GetByIdConsulta(int id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@codConsulta", id);

            SqlDataReader dr =  DB.ExecuteReader(DB.connectionStringSqlServer, System.Data.CommandType.Text,
                            "SELECT * FROM Consulta WHERE con_codigo = @codConsulta", param);
            dr.Read();
                PacienteDAO pacienteDal = new PacienteDAO();
                NutricionistaDAO nutricionistaDal = new NutricionistaDAO();
                Consulta consulta = new Consulta(Convert.ToInt32(dr["con_codigo"]),          //
                                                    Convert.ToDateTime(dr["con_data"]),
                                                    pacienteDal.GetByIdPaciente(Convert.ToInt32(dr["pac_codigo"])),
                                                    nutricionistaDal.GetByIdNutricionista(Convert.ToInt32(dr["con_codigo"])),
                    //  Convert.ToInt32(dr["pac_codigo"]),       // inserir objeto paciente
                    //  Convert.ToInt32(dr["con_codigo"]),       // inserir objeto nutricionista
                                                    Convert.ToDouble(dr["con_peso"]),
                                                    Convert.ToDouble(dr["con_pressao_arterial"]),
                                                    Convert.ToDouble(dr["con_altura"]),
                                                    Convert.ToDouble(dr["con_medidas"]),
                                                    Convert.ToString(dr["con_problema_saude"]),
                                                    Convert.ToString(dr["con_restricoes_alimentares"]),
                                                    Convert.ToString(dr["con_uso_medicamento"]),
                                                    Convert.ToString(dr["con_historico_familiar"]),
                                                    Convert.ToString(dr["con_objetivo"]),
                                                    Convert.ToString(dr["con_observacao"])
                                                      );

                return consulta;
          }

        public Consulta GetByData(DateTime data)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@data", data);

            SqlDataReader dr = DB.ExecuteReader(DB.connectionStringSqlServer, System.Data.CommandType.Text,
                            "SELECT * FROM Consulta WHERE con_data = @data", param);
            dr.Read();
            PacienteDAO pacienteDal = new PacienteDAO();
            NutricionistaDAO nutricionistaDal = new NutricionistaDAO();
            Consulta consulta = new Consulta(Convert.ToInt32(dr["con_codigo"]),          //
                                                Convert.ToDateTime(dr["con_data"]),
                                                pacienteDal.GetByIdPaciente(Convert.ToInt32(dr["pac_codigo"])),          // inserir objeto paciente
                                                nutricionistaDal.GetByIdNutricionista(Convert.ToInt32(dr["con_codigo"])), // inserir objeto nutricionista
                                                Convert.ToDouble(dr["con_peso"]),
                                                Convert.ToDouble(dr["con_pressao_arterial"]),
                                                Convert.ToDouble(dr["con_altura"]),
                                                Convert.ToDouble(dr["con_medidas"]),
                                                Convert.ToString(dr["con_problema_saude"]),
                                                Convert.ToString(dr["con_restricoes_alimentares"]),
                                                Convert.ToString(dr["con_uso_medicamento"]),
                                                Convert.ToString(dr["con_historico_familiar"]),
                                                Convert.ToString(dr["con_objetivo"]),
                                                Convert.ToString(dr["con_observacao"])
                                              );

            return consulta;
        }

        public Consulta GetByPaciente(Paciente paciente)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@codPaciente", paciente.CodPaciente);

            SqlDataReader dr = DB.ExecuteReader(DB.connectionStringSqlServer, System.Data.CommandType.Text,
                            "SELECT * FROM Consulta WHERE pac_cod = @codPaciente", param);
            dr.Read();
            PacienteDAO pacienteDal = new PacienteDAO();
            NutricionistaDAO nutricionistaDal = new NutricionistaDAO();
            Consulta consulta = new Consulta(Convert.ToInt32(dr["con_codigo"]),          //
                                                Convert.ToDateTime(dr["con_data"]),
                                                pacienteDal.GetByIdPaciente(Convert.ToInt32(dr["pac_codigo"])),
                                                nutricionistaDal.GetByIdNutricionista(Convert.ToInt32(dr["con_codigo"])),
                //  Convert.ToInt32(dr["pac_codigo"]),       // inserir objeto paciente
                //  Convert.ToInt32(dr["con_codigo"]),       // inserir objeto nutricionista
                                                Convert.ToDouble(dr["con_peso"]),
                                                Convert.ToDouble(dr["con_pressao_arterial"]),
                                                Convert.ToDouble(dr["con_altura"]),
                                                Convert.ToDouble(dr["con_medidas"]),
                                                Convert.ToString(dr["con_problema_saude"]),
                                                Convert.ToString(dr["con_restricoes_alimentares"]),
                                                Convert.ToString(dr["con_uso_medicamento"]),
                                                Convert.ToString(dr["con_historico_familiar"]),
                                                Convert.ToString(dr["con_objetivo"]),
                                                Convert.ToString(dr["con_observacao"])
                                                  );

            return consulta;
        }

    }

         
 

    
}
