using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaClass.usuario
{
    public class ManterUsuario
    {
        private static RepositorioUsuario respUsuario = new RepositorioUsuario();

        public ManterUsuario() {}

        public Usuario Logar(Usuario usuario)
        {
            return respUsuario.Logar(usuario);
        }
    }
}
