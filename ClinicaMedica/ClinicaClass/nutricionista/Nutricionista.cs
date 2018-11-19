using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaClass.nutricionista
{
    public class Nutricionista
    {
        private int codigoNutricionista;
        private string nome;
        private string crn;
        private string cpf;
        private DateTime dataNascimento;
        private char sexo;
        private string estadoCivil;
        private string email;
        private string endereco;
        private string bairro;
        private string cep;
        private string cidade;
        private string uf;
        private string telefone;
        private string celular;
        private string observacao;

        public int CodigoNutricionista
        {
            get { return codigoNutricionista; }
            set { codigoNutricionista = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Crn
        {
            get { return crn; }
            set { crn = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }
        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public string EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }
    }
}
