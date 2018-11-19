using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNutrical.DAO
{
    public class Nutricionista
    {
        private String codNutricionista,
               crn,
               nome,
               sexo,
               estadoCivil,
               endereco,
               bairro,
               cidade,
               uf,
               telefone,
               celular,
               observacao;

        private Int32 cep;

        private DateTime dtNascimento;

        public String Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public String Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public String Uf
        {
            get { return uf; }
            set { uf = value; }
        }

        public String Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public String Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public String Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public String EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public String Crn
        {
            get { return crn; }
            set { crn = value; }
        }

        public String CodNutricionista
        {
            get { return codNutricionista; }
            set { codNutricionista = value; }
        }

        public String Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }

        

        public Int32 CEP
        {
            get { return cep; }
            set { cep = value; }
        }

       

        public DateTime DtNascimento
        {
            get { return dtNascimento; }
            set { dtNascimento = value; }
        }


    }

}
