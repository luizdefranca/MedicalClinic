using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaClass.usuario
{
    interface IRepositorioUsuario
    {
        //Usuario buscar(int codigoConsulta);

        Usuario Logar(Usuario usuario);
    }
}
