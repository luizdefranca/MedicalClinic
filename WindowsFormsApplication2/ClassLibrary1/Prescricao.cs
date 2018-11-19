using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaNutrical.Model
{
    public class Prescricao
    {

        private int codigoPrescricao;
        public int CodigoPrescricao
        {
            get { return codigoPrescricao; }
            set { codigoPrescricao = value; }
        }
        
        private TipoPrescricao tipoPrescricao;
        public TipoPrescricao TipoPrescricao
        {
            get { return tipoPrescricao; }
            set { tipoPrescricao = value; }
        }
        
        private Consulta consulta;
        public Consulta Consulta
        {
            get { return Consulta; }
            set { Consulta = value; }
        }
        
        private string descricao;
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
      

        public Prescricao()
        {
            
        }

        public Prescricao( TipoPrescricao tipoPrescricao, Consulta consulta, string descricao)
        {
            
            this.tipoPrescricao = tipoPrescricao;
            this.consulta = consulta;
            this.descricao = descricao;
        }



        public Prescricao(int codigoPrescricao, TipoPrescricao tipoPrescricao, Consulta consult, string descricao)
        {
            // TODO: Complete member initialization
            this.codigoPrescricao = codigoPrescricao;
            this.tipoPrescricao = tipoPrescricao;
            this.consulta = consult;
            this.descricao = descricao;
        }

        ~Prescricao()
        {
            throw new System.NotImplementedException();
        }
    }
}
