using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaNutrical.Model;
using System.Data.SqlClient;

namespace ClinicaNutrical.DAO
{
    public class PrescricaoDAO
    {
        public List<Prescricao> GetAllPrescricaos()
        {
            List<Prescricao> listaPrescricao = new List<Prescricao>();
            SqlDataReader dr = DB.ExecuteReader(DB.connectionStringSqlServer,
                                                System.Data.CommandType.Text,
                                                "Select * from Prescricao");

            TipoPrescricaoDAO tpPrescricao = new TipoPrescricaoDAO();
            ConsultaDAO consulta = new ConsultaDAO();
            
            while (dr.Read())
            {
                Prescricao presc = new Prescricao(Convert.ToInt32(dr["pre_codigo"]),          
                                                    tpPrescricao.GetTipoPrescricaoById(Convert.ToInt32(dr["tip_codigo"])),       // inserir objeto tipo
													consulta.GetByIdConsulta(Convert.ToInt32(dr["pre_codigo"])),                 // inserir objeto prescricao
                                                    Convert.ToString(dr["pre_descricao"])
                                                      );

                listaPrescricao.Add(presc);

            }

            return listaPrescricao;
        }

        public void InsertPrescricao(Prescricao presc)
        {


            SqlParameter[] param = new SqlParameter[3];
            
            param[0] = new SqlParameter("@codTipo", presc.TipoPrescricao.CodigoTipo);
			param[1] = new SqlParameter("@codPrescricao", presc.Consulta.CodConsulta);
            param[2] = new SqlParameter("@descricao", presc.Descricao);
            



            StringBuilder strb = new StringBuilder();
            strb.Append("INSERT INTO Prescricao "
                           + ", tip_codigo"
                           + ", pre_codigo "
                           + ", pre_descricao)");
            strb.Append(" VALUES "
                            + ",@codTipo "
                            + ",@codPrescricao "
                            + ",@descricao))");

            DB.executeQuery(DB.connectionStringSqlServer, System.Data.CommandType.Text, strb.ToString(), param);
           
        }

        public Prescricao GetByIdPrescricao(int id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@codPrescricao", id);

            SqlDataReader dr = DB.ExecuteReader(DB.connectionStringSqlServer, System.Data.CommandType.Text,
                            "SELECT * FROM Prescricao WHERE pre_codigo = @codPrescricao", param);
            dr.Read();
            TipoPrescricaoDAO tpPrescricaoDal = new TipoPrescricaoDAO();
            ConsultaDAO consultaDal = new ConsultaDAO();
            Prescricao prescricao = new Prescricao(Convert.ToInt32(dr["pre_codigo"]),          //
                                                tpPrescricaoDal.GetTipoPrescricaoById(Convert.ToInt32(dr["tip_codigo"])),
                                                consultaDal.GetByIdConsulta(Convert.ToInt32(dr["con_codigo"])),
                                                Convert.ToString(dr["pre_descricao"])
                                                  );

            return prescricao;
        }

        public void DeletePrescricao(Prescricao prescricao)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@codigo", prescricao.CodigoPrescricao);

            DB.executeQuery(DB.connectionStringSqlServer, System.Data.CommandType.Text, "DELETE Prescricao WHERE pres_codigo = @codigo", param);
        }

        //TODO: falta metodo UpdatePrescricao



    }
}
