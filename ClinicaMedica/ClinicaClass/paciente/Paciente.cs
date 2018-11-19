using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaClass.paciente
{
    public class Paciente
    {
        private int codigoPaciente;
        private string nome;
        private string cpf;
        private string email;
        private char sexo;
        private string endereco;
        private DateTime dataNascimento;
        private string atividade;

        public int CodigoPaciente { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public char Sexo { get; set; }
        public string Endereco { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Atividade { get; set; }
    }
}
