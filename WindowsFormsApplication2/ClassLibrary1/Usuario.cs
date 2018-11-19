using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Validation.Integration.WCF;
using Microsoft.Practices.EnterpriseLibrary.Validation.Integration.WinForms;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace ClinicaNutrical.Model 
{
    public class Usuario
    {
        
        private int codigoUsuario;

        public int CodigoUsuario
        {
            get { return codigoUsuario; }
            set { codigoUsuario = value; }
        }
        
        private Nutricionista nutricionista;

        public Nutricionista Nutricionista
        {
            get { return nutricionista; }
            set { nutricionista = value; }
        }
        private TipoUsuario tipoUsuario;

        public TipoUsuario TipoUsuario
        {
            get { return tipoUsuario; }
            set { tipoUsuario = value; }
        }

        
        private string login;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        private string senha;

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }



        /*
         * 
         */

        public Usuario()
        {
            
        }

        public Usuario(int codigoUsuario, Nutricionista nutricionista, TipoUsuario tipoUsuario, string login, string senha)
        {
            // TODO: Complete member initialization
            this.codigoUsuario = codigoUsuario;
            this.nutricionista = nutricionista;
            this.tipoUsuario = tipoUsuario;
            this.login = login;
            this.senha = senha;
        }

        ~Usuario()
        {
            throw new System.NotImplementedException();
        }
    }
}
