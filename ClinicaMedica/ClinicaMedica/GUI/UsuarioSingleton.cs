using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.GUI
{
    public class UsuarioSingleton
    {
        private static UsuarioSingleton instancia;
        private static int codigoUsuario;
        private static int codigoNutricionista;
        private static int codigoTipoUsuario;
        private static string login;
        private static string senha;

        public UsuarioSingleton()
        {
        }

        // Verifica se já existe uma instancia de UsuarioSingleton
        public static UsuarioSingleton getInstancia()
        {
            if (instancia == null)
            {
                instancia = new UsuarioSingleton();
            }
            return instancia;
        }

        public static int CodigoUsuario
        {
            get;
            set;
        }

        public static int CodigoNutricionista
        {
            get;
            set;
        }

        public static int CodigoTipoUsuario
        {
            get;
            set;
        }

        public static string Login
        {
            get;
            set;
        }

        public static string Senha
        {
            get;
            set;
        }


    }
}
