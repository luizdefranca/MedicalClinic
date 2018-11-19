using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNutrical.Model
{
    public class Nutricionista: Usuario
    {

        private int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        private string crn;
        public string Crn
        {
            get { return crn; }
            set { crn = value; }
        }
        
        private string cpf;
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        
        private DateTime dtNascimento;
        public DateTime DtNascimento
        {
            get { return dtNascimento; }
            set { dtNascimento = value; }
        }
        
        private string sexo;
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        
        private string estadoCivil;
        public string EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }
        
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        
        private string endereco;
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        
        private string cep;
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        
        private string bairro;
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        
        private string cidade;
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        
        private string uf;
        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }
        
        private string fone;
        public string Fone
        {
            get { return fone; }
            set { fone = value; }
        }
        
        private string celular;
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        
        private string observacao;
        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }

        //Constructions

        public Nutricionista()
        {
            
        }
         
        
        public Nutricionista(int codigo, 
                            string nome, 
                            string crn, 
                            string cpf, 
                            DateTime dtNascimento,  
                            string sexo, 
                            string estadoCivil, 
                            string email, 
                            string endereco,
                            string bairro, 
                            string cep, 
                            string cidade, 
                            string uf, 
                            string fone, 
                            string celular, 
                            string observacao)
        {
            // TODO: Complete member initialization
            this.codigo = codigo;
            this.nome = nome;
            this.crn = crn;
            this.cpf = cpf;
            this.dtNascimento = dtNascimento;
            this.sexo = sexo;
            this.estadoCivil = estadoCivil;
            this.email = email;
            this.endereco = endereco;
            this.bairro = bairro;
            this.cep = cep;
            this.cidade = cidade;
            this.uf = uf;
            this.fone = fone;
            this.celular = celular;
            this.observacao = observacao;
        }

        public Nutricionista( string nome,
                              string crn,
                              string cpf,
                              DateTime dtNascimento,
                              string sexo,
                              string estadoCivil,
                              string email,
                              string endereco,
                              string bairro,
                              string cep,
                              string cidade,
                              string uf,
                              string fone,
                              string celular,
                              string observacao)
        {
            
            
            this.nome = nome;
            this.crn = crn;
            this.cpf = cpf;
            this.dtNascimento = dtNascimento;
            this.sexo = sexo;
            this.estadoCivil = estadoCivil;
            this.email = email;
            this.endereco = endereco;
            this.bairro = bairro;
            this.cep = cep;
            this.cidade = cidade;
            this.uf = uf;
            this.fone = fone;
            this.celular = celular;
            this.observacao = observacao;
        }
        public Nutricionista(int codigo)
        {
            this.codigo = codigo;
        }

        
        ~Nutricionista()
        {
            
        }
       
      

    }

}
 