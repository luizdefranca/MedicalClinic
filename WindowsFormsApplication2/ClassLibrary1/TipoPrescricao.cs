using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaNutrical.Model
{
    public class TipoPrescricao
    {


        private int codigoTipo;

        public int CodigoTipo
        {
            get { return codigoTipo; }
            set { codigoTipo = value; }
        }
        private string nomeTipo;

        public string NomeTipo
        {
            get { return nomeTipo; }
            set { nomeTipo = value; }
        }

       

        public TipoPrescricao(int codigoTipo, string nomeTipo)
        {
            // TODO: Complete member initialization
            this.codigoTipo = codigoTipo;
            this.nomeTipo = nomeTipo;
        }

        ~TipoPrescricao()
        {
            throw new System.NotImplementedException();
        }
    }
}
