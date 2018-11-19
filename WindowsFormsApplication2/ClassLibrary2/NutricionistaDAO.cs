using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaNutrical.Model;
using System.Data.SqlClient;

namespace ClinicaNutrical.DAO
{
    public class NutricionistaDAO
    {
        public List<Nutricionista> GetAllNutricionistas()
        {
            List<Nutricionista> listaNutricionista = new List<Nutricionista> ();
                SqlDataReader dr = DB.ExecuteReader(DB.connectionStringSqlServer, 
                                                    System.Data.CommandType.Text,
                                                    "Select * from Nutricionista");
            while(dr.Read())
            {
                Nutricionista nut = new Nutricionista(Convert.ToInt32(dr["nut_codigo"]),          //
                                                      Convert.ToString(dr["nut_nome"]),
                                                      Convert.ToString(dr["nut_crn"]),
                                                      Convert.ToString(dr["nut_cpf"]),
                                                      Convert.ToDateTime(dr["nut_data_nascimento"]),
                                                      Convert.ToString(dr["nut_sexo"]),
                                                      Convert.ToString(dr["nut_estado_civil"]),
                                                      Convert.ToString(dr["nut_email"]),
                                                      Convert.ToString(dr["nut_endereco"]),
                                                      Convert.ToString(dr["nut_bairro"]),
                                                      Convert.ToString(dr["nut_cep"]),
                                                      Convert.ToString(dr["nut_cidade"]),
                                                      Convert.ToString(dr["nut_uf"]),
                                                      Convert.ToString(dr["nut_telefone"]),
                                                      Convert.ToString(dr["nut_celular"]),
                                                      Convert.ToString(dr["nut_observacao"])
                                                      );

                listaNutricionista.Add(nut);  
            }
            
            return  listaNutricionista;
        }

        public void InsertNutricionista(Nutricionista nut)
        {

            SqlParameter[] param = new SqlParameter[15];
            param[0] = new SqlParameter("@nome", nut.Nome);
            param[1] = new SqlParameter("@crn", nut.Crn);
            param[2] = new SqlParameter("@cpf", nut.Cpf);
            param[3] = new SqlParameter("@data_nascimento", nut.DtNascimento);
            param[4] = new SqlParameter("@sexo", nut.Sexo);
            param[4] = new SqlParameter("@estado_civil", nut.EstadoCivil);
            param[6] = new SqlParameter("@email", nut.Email);
            param[7] = new SqlParameter("@endereco", nut.Endereco);
            param[8] = new SqlParameter("@bairro", nut.Bairro);
            param[9] = new SqlParameter("@cep", nut.Cep);
            param[10] = new SqlParameter("@cidade", nut.Cidade);
            param[11] = new SqlParameter("@uf", nut.Uf);
            param[12] = new SqlParameter("@telefone", nut.Fone);
            param[13] = new SqlParameter("@celular", nut.Celular);
            param[14] = new SqlParameter("@observacao", nut.Observacao);
 


            StringBuilder strb = new StringBuilder();
            strb.Append(    "INSERT INTO Nutricionista "
                           +"(nut_nome" 
                           +", nut_crn" 
                           +", nut_cpf " 
                           +", nut_data_nascimento" 
                           +", nut_sexo" 
                           +", nut_estado_civil" 
                           +", nut_email" 
                           +", nut_endereco" 
                           +", nut_bairro" 
                           +", nut_cep" 
                           +", nut_cidade" 
                           +", nut_uf" 
                           +", nut_telefone" 
                           +", nut_celular" 
                           +", nut_observacao)");
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
                            + ",@observacao)");

            DB.executeQuery(DB.connectionStringSqlServer, System.Data.CommandType.Text, strb.ToString(), param);
           
        }

        public void UpdateNutricionista(Nutricionista nut)
        {
            SqlParameter[] param = new SqlParameter[16];
            param[0] = new SqlParameter("@nome", nut.Nome);
            param[1] = new SqlParameter("@crn", nut.Crn);
            param[2] = new SqlParameter("@cpf", nut.Cpf);
            param[3] = new SqlParameter("@data_nascimento", nut.DtNascimento);
            param[4] = new SqlParameter("@sexo", nut.Sexo);
            param[4] = new SqlParameter("@estado_civil", nut.EstadoCivil);
            param[6] = new SqlParameter("@email", nut.Email);
            param[7] = new SqlParameter("@endereco", nut.Endereco);
            param[8] = new SqlParameter("@bairro", nut.Bairro);
            param[9] = new SqlParameter("@cep", nut.Cep);
            param[10] = new SqlParameter("@cidade", nut.Cidade);
            param[11] = new SqlParameter("@uf", nut.Uf);
            param[12] = new SqlParameter("@telefone", nut.Fone);
            param[13] = new SqlParameter("@celular", nut.Celular);
            param[14] = new SqlParameter("@observacao", nut.Observacao);
            param[16] = new SqlParameter("@codigo", nut.Codigo);

            
            StringBuilder strb = new StringBuilder();
            strb.Append("UPDATE Nutricionista "
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

        public void DeleteNutricionista(Nutricionista nut)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@codigo", nut.Codigo) ;

            DB.executeQuery(DB.connectionStringSqlServer, System.Data.CommandType.Text, "DELETE Nutricionista WHERE nut_codigo = @codigo", param);
        }

        public Nutricionista GetByIdNutricionista(int id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@codigo", id);
            SqlDataReader dr = DB.ExecuteReader(DB.connectionStringSqlServer,
                                                System.Data.CommandType.Text,
                                                "Select * from Nutricionista where nut_codigo=@codigo", param);
            dr.Read();
            Nutricionista nutricionista = new Nutricionista(Convert.ToInt32(dr["nut_codigo"]),          //
                                                    Convert.ToString(dr["nut_nome"]),
                                                    Convert.ToString(dr["nut_crn"]),
                                                    Convert.ToString(dr["nut_cpf"]),
                                                    Convert.ToDateTime(dr["nut_data_nascimento"]),
                                                    Convert.ToString(dr["nut_sexo"]),
                                                    Convert.ToString(dr["nut_estado_civil"]),
                                                    Convert.ToString(dr["nut_email"]),
                                                    Convert.ToString(dr["nut_endereco"]),
                                                    Convert.ToString(dr["nut_bairro"]),
                                                    Convert.ToString(dr["nut_cep"]),
                                                    Convert.ToString(dr["nut_cidade"]),
                                                    Convert.ToString(dr["nut_uf"]),
                                                    Convert.ToString(dr["nut_telefone"]),
                                                    Convert.ToString(dr["nut_celular"]),
                                                    Convert.ToString(dr["nut_observacao"])
                                                    );

            

            return nutricionista;
        }

        public Nutricionista GetByNomeNutricionista(string nome)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@nome", nome);
            SqlDataReader dr = DB.ExecuteReader(DB.connectionStringSqlServer,
                                                System.Data.CommandType.Text,
                                                "Select * from Nutricionista where nut_nome=@nome", param);
            dr.Read();
            Nutricionista nutricionista = new Nutricionista(Convert.ToInt32(dr["nut_codigo"]),          //
                                                    Convert.ToString(dr["nut_nome"]),
                                                    Convert.ToString(dr["nut_crn"]),
                                                    Convert.ToString(dr["nut_cpf"]),
                                                    Convert.ToDateTime(dr["nut_data_nascimento"]),
                                                    Convert.ToString(dr["nut_sexo"]),
                                                    Convert.ToString(dr["nut_estado_civil"]),
                                                    Convert.ToString(dr["nut_email"]),
                                                    Convert.ToString(dr["nut_endereco"]),
                                                    Convert.ToString(dr["nut_bairro"]),
                                                    Convert.ToString(dr["nut_cep"]),
                                                    Convert.ToString(dr["nut_cidade"]),
                                                    Convert.ToString(dr["nut_uf"]),
                                                    Convert.ToString(dr["nut_telefone"]),
                                                    Convert.ToString(dr["nut_celular"]),
                                                    Convert.ToString(dr["nut_observacao"])
                                                    );



            return nutricionista;
        }

    }
}
