using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaNutrical.Model
{
    public class TipoUsuario
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public TipoUsuario(int codigo, string descricao)
        {
            // TODO: Complete member initialization
            this.codigo = codigo;
            this.descricao = descricao;
        }

        public TipoUsuario(string descricao)
        {
            
           
            this.descricao = descricao;
        }

        public TipoUsuario() { }
    }
}
