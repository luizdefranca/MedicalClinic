using ClinicaNutrical.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ClinicaNutrical.DAO
{
    public class UsuarioDAO
    {
        public List<Usuario> GetAllUsuarios()
        {
            List<Usuario> listaUsuario = new List<Usuario>();
            SqlDataReader dr = DB.ExecuteReader(DB.connectionStringSqlServer,
                                                System.Data.CommandType.Text,
                                                "Select * from Usuario");

            NutricionistaDAO nutricionista = new NutricionistaDAO();
            TipoUsuarioDAO tpUsuario = new TipoUsuarioDAO();
            while (dr.Read())
            {
                Usuario usuario = new Usuario(  Convert.ToInt32(dr["usu_codigo"]),          //
                                                nutricionista.GetByIdNutricionista(Convert.ToInt32(dr["nut_codigo"])), //1-N: inseri objeto Nutricionista
                                                tpUsuario.getTipoUsuarioById(Convert.ToInt32(dr["tpu_codigo"])), //1-N: inseri objeto TipoUsuario
                                                Convert.ToString(dr["usu_login"]),
                                                Convert.ToString(dr["usu_senha"])
                                              );
                listaUsuario.Add(usuario);

            }

            return listaUsuario;
        }

        

    }
}
