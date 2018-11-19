using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ClinicaNutrical.Model
{
    public class Paciente
    {
        
        // Declaracao de variaveis

        private int codPaciente;

        public int CodPaciente
        {
            get { return codPaciente; }
            set { codPaciente = value; }
        }

       
       
        private string nome;

        
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        private string endereco;

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        private DateTime dtNascimento;

        public DateTime DtNascimento
        {
            get { return dtNascimento; }
            set { dtNascimento = value; }
        }
        private string atividade;

        public string Atividade
        {
            get { return atividade; }
            set { atividade = value; }
        }






        public Paciente(int codPaciente, string nome, string cpf, string email, string sexo, string endereco, DateTime dtNascimento, string atividade)
        {
            // TODO: Complete member initialization
            this.codPaciente = codPaciente;
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
            this.sexo = sexo;
            this.endereco = endereco;
            this.dtNascimento = dtNascimento;
            this.atividade = atividade;
        }


        public Paciente(string nome, string cpf, string email, string sexo, string endereco, DateTime dtNascimento, string atividade)
        {


            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
            this.sexo = sexo;
            this.endereco = endereco;
            this.dtNascimento = dtNascimento;
            this.atividade = atividade;
        }

        public Paciente(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }

        public Paciente(int codPaciente)
        {
            this.codPaciente = codPaciente;
         }
        public Paciente() { }

        ~Paciente()
        {
            throw new System.NotImplementedException();
        }


        
       
    }
}
