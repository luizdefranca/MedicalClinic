using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaNutrical.Model;
using System.Data.SqlClient;

namespace ClinicaNutrical.DAO
{
    public class TipoPrescricaoDAO
    {
        public List<TipoPrescricao> GetAllTipoPrescricaos()
        {
            List<TipoPrescricao> listaTipoPrescricao = new List<TipoPrescricao>();
            SqlDataReader dr = DB.ExecuteReader(DB.connectionStringSqlServer,
                                                System.Data.CommandType.Text,
                                                "Select * from TipoPrescricao");
            while (dr.Read())
            {
                TipoPrescricao tipoPrescricao = new TipoPrescricao(Convert.ToInt32(dr["tip_codigo"]),          //
                                                        Convert.ToString(dr["tip_nome"])
                                                      );

                listaTipoPrescricao.Add(tipoPrescricao);
            }

            return listaTipoPrescricao;
        }

        public void InsertTipoPrescricao(TipoPrescricao tpresc)
        {

            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@tipCodigo", tpresc.CodigoTipo);
            param[1] = new SqlParameter("@tipNome", tpresc.NomeTipo);
            



            StringBuilder strb = new StringBuilder();
            strb.Append("INSERT INTO TipoPrescricao "
                           + "(tip_codigo"
                           + ", tip_nome)");
            strb.Append(" VALUES "
                            + "(@tipCodigo "
                            + ",@tipNome))");

            DB.executeQuery(DB.connectionStringSqlServer, System.Data.CommandType.Text, strb.ToString(), param);
           
        }

        public TipoPrescricao GetTipoPrescricaoById(int id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@tpPresc", id);

            SqlDataReader dr = DB.ExecuteReader(DB.connectionStringSqlServer, System.Data.CommandType.Text,
                                 "SELECT * FROM Consulta WHERE pre_codigo = @tpPresc", param);
            dr.Read();
            
            TipoPrescricao tipoPrescricao = new TipoPrescricao(Convert.ToInt32(dr["tip_codigo"])          //
                                                                ,Convert.ToString(dr["tip_nome"])
                                                                    );

            return tipoPrescricao;

        }

        public void DeleteTipoPrescricao(TipoPrescricao tipoPrescricao)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@codigo", tipoPrescricao.CodigoTipo);

            DB.executeQuery(DB.connectionStringSqlServer, System.Data.CommandType.Text, "DELETE Prescricao WHERE tip_codigo = @codigo", param);
        }
        //TODO: falta metodo UpdateTipoPrescricao
    }

    
}
