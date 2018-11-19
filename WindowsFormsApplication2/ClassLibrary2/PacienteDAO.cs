 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaNutrical.Model;
using System.Data.SqlClient;

namespace ClinicaNutrical.DAO
{
    public class PacienteDAO
    {
        public List<Paciente> GetAllPacientes()
        {
            List<Paciente> listaPaciente = new List<Paciente>();
            SqlDataReader dr = DB.ExecuteReader(DB.connectionStringSqlServer,
                                                System.Data.CommandType.Text,
                                                "Select * from Paciente");
            while (dr.Read())
            {
                Paciente paciente = new Paciente(Convert.ToInt32(dr["pac_codigo"]),          //
                                                      Convert.ToString(dr["pac_nome"]),
                                                      Convert.ToString(dr["pac_cpf"]),
                                                      Convert.ToString(dr["pac_email"]),
                                                      Convert.ToString(dr["pac_sexo"]),
                                                      Convert.ToString(dr["pac_endereco"]),
                                                      Convert.ToDateTime(dr["pac_data_nascimento"]),
                                                      Convert.ToString(dr["pac_atividade"])
                                                      );

                listaPaciente.Add(paciente);
            }

            return listaPaciente;
        }

        public Paciente GetByIdPaciente(int id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@codigo", id);

            SqlDataReader dr = DB.ExecuteReader(DB.connectionStringSqlServer,
                                                System.Data.CommandType.Text,
                                                "Select * from Paciente where pac_codigo = @codigo");
            //if (dr == null)
            //{

            //}
            dr.Read(); 
            Paciente paciente = new Paciente(Convert.ToInt32(dr["pac_codigo"]),          //
                                                    Convert.ToString(dr["pac_nome"]),
                                                    Convert.ToString(dr["pac_cpf"]),
                                                    Convert.ToString(dr["pac_email"]),
                                                    Convert.ToString(dr["pac_sexo"]),
                                                    Convert.ToString(dr["pac_endereco"]),
                                                    Convert.ToDateTime(dr["pac_data_nascimento"]),
                                                    Convert.ToString(dr["pac_atividade"])
                                                    );

            
            return paciente;
        }

        public Paciente GetByNomePaciente(string nome)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@nome", nome);

            SqlDataReader dr = DB.ExecuteReader(DB.connectionStringSqlServer,
                                                System.Data.CommandType.Text,
                                                "Select * from Paciente where pac_nome=@nome");
            dr.Read();
            Paciente paciente = new Paciente(Convert.ToInt32(dr["pac_codigo"]),          //
                                                    Convert.ToString(dr["pac_nome"]),
                                                    Convert.ToString(dr["pac_cpf"]),
                                                    Convert.ToString(dr["pac_email"]),
                                                    Convert.ToString(dr["pac_sexo"]),
                                                    Convert.ToString(dr["pac_endereco"]),
                                                    Convert.ToDateTime(dr["pac_data_nascimento"]),
                                                    Convert.ToString(dr["pac_atividade"])
                                                    );


            return paciente;
        }

        public void DeletePaciente(Paciente paciente)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@codigo", paciente.CodPaciente);

            DB.executeQuery(DB.connectionStringSqlServer, System.Data.CommandType.Text, "DELETE Paciente WHERE pac_codigo = @codigo", param);
        }

        public void InsertPaciente(Paciente paciente)
        {
            SqlParameter[] param = new SqlParameter[7];

            
            param[0] = new SqlParameter("@nome", paciente.Nome);        
            param[1] = new SqlParameter("@cpf", paciente.Cpf);    
            param[2] = new SqlParameter("@email", paciente.Email);
            param[3] = new SqlParameter("@sexo", paciente.Sexo);
            param[4] = new SqlParameter("@endereco", paciente.Endereco);
            param[5] = new SqlParameter("@dataNascimento", paciente.DtNascimento);
            param[6] = new SqlParameter("@atividade", paciente.Atividade);


            StringBuilder strb = new StringBuilder();
            strb.Append("INSERT INTO Paciente "
                           + "( pac_nome "
                           + ", pac_cpf "
                           + ", pac_email "
                           + ", pac_sexo"
                           + ", pac_endereco"
                           + ", pac_data_nascimento"
                           + ", pac_atividade)");

            strb.Append(" VALUES "
                            + "(@nome "
                            + ",@cpf "
                            + ",@email "
                            + ",@sexo "
                            + ",@endereco "
                            + ",@dataNascimento "
                            + ",@atividade)");

            DB.executeQuery(DB.connectionStringSqlServer, System.Data.CommandType.Text, strb.ToString(), param);


        }

        public void UpdatePaciente(Paciente paciente)
        {
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@nome", paciente.Nome);
            param[1] = new SqlParameter("@cpf", paciente.Cpf);
            param[2] = new SqlParameter("@email", paciente.Email);
            param[3] = new SqlParameter("@sexo", paciente.Sexo);
            param[4] = new SqlParameter("@endereco", paciente.Endereco);
            param[5] = new SqlParameter("@dataNascimento", paciente.DtNascimento);
            param[6] = new SqlParameter("@atividade", paciente.Atividade);
            param[7] = new SqlParameter("@codigo", paciente.CodPaciente);


            StringBuilder strb = new StringBuilder();
            strb.Append("UPDATE Paciente "
                        + "SET (pac_nome = @nome "
                           + ", pac_cpf = @cpf "
                           + ", pac_email = @email "
                           + ", pac_sexo = @sexo"
                           + ", pac_endereco = @endereco "
                           + ", pac_data_nascimento = @dataNascimento "
                           + ", pac_atividade = @atividade)");


            strb.Append("WHERE pac_codigo = @codigo");
            DB.executeQuery(DB.connectionStringSqlServer, System.Data.CommandType.Text, strb.ToString(), param);
        }





    }


    
}
