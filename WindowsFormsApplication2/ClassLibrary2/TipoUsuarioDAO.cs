using ClinicaNutrical.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ClinicaNutrical.DAO
{
    public class TipoUsuarioDAO
    {

        public List<TipoUsuario> GetAllTipoUsuarios()
        {
            List<TipoUsuario> listaTipoUsuario = new List<TipoUsuario>();
            SqlDataReader dr = DB.ExecuteReader(DB.connectionStringSqlServer,
                                                System.Data.CommandType.Text,
                                                "Select * from TipoUsuario");
            while (dr.Read())
            {
                TipoUsuario tipoUsuario = new TipoUsuario(Convert.ToInt32(dr["tpu_codigo"]),          //
                                                          Convert.ToString(dr["tpu_nome"])
                                                          );
                listaTipoUsuario.Add(tipoUsuario);

            }

            return listaTipoUsuario;
        }

        public TipoUsuario getTipoUsuarioById(int id)
        { 
            TipoUsuario tpusuario = new TipoUsuario();
            return tpusuario;
        } 
    }
}
