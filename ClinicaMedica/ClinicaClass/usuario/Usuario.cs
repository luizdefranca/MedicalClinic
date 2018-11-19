using ClinicaClass.nutricionista;
using ClinicaClass.tipoUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaClass.usuario
{
    public class Usuario
    {
        private int codigoUsuario;
        private string login;
        private string senha;
        private Nutricionista nutricionista;
        private TipoUsuario tipoUsuario;


        public int CodigoUsuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public Nutricionista Nutricionista { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
    }
}
