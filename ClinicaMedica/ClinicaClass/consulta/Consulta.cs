using ClinicaClass.nutricionista;
using ClinicaClass.paciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaClass.consulta
{
    public class Consulta
    {
        private int codigoConsulta;
        private Paciente paciente;
        private Nutricionista nutricionista;
        private string peso;
        private string pressaoArterial;
        private string altura;
        private string medidas;
        private string problemaSaude;
        private string restricoesAlimentares;
        private string usoMedicamento;
        private string historicoFamiliar;
        private string objetivo;
        private string observacao;
        private DateTime dataConsulta;
        private string status;

        public Consulta() {}

        public Consulta(int cCodigoConsulta, Paciente cPaciente, Nutricionista cNutricionista)
        {
            this.codigoConsulta = cCodigoConsulta;
            this.paciente = cPaciente;
            this.nutricionista = cNutricionista;
        }

        public Consulta(int cCodigoConsulta, Paciente cPaciente, Nutricionista cNutricionista, string cPeso, string cPressaoArterial,
            string cAltura, string cMedidas, string cProblemaSaude, string cRestricoesAlimentares, string cUsoMedicamento, 
            string cHistoricoFamiliar, string cObjetivo, string cObservacao, DateTime cDataConsulta, string cStatus)
        {
            this.codigoConsulta = cCodigoConsulta;
            this.paciente = cPaciente;
            this.nutricionista = cNutricionista;
            this.peso = cPeso;
            this.pressaoArterial = cPressaoArterial;
            this.altura = cAltura;
            this.medidas = cMedidas;
            this.problemaSaude = cProblemaSaude;
            this.restricoesAlimentares = cRestricoesAlimentares;
            this.usoMedicamento = cUsoMedicamento;
            this.historicoFamiliar = cHistoricoFamiliar;
            this.objetivo = cObjetivo;
            this.observacao = cObservacao;
            this.dataConsulta = cDataConsulta;
            this.status = cStatus;
        }


        public int CodigoConsulta { get; set; }
        public Paciente Paciente { get; set; }
        public Nutricionista Nutricionista { get; set; }
        public string Peso { get; set; }
        public string PressaoArterial { get; set; }
        public string Altura { get; set; }
        public string Medidas { get; set; }
        public string ProblemaSaude { get; set; }
        public string RestricoesAlimentares { get; set; }
        public string UsoMedicamento { get; set; }
        public string HistoricoFamiliar { get; set; }
        public string Objetivo { get; set; }
        public string Observacao { get; set; }
        public DateTime DataConsulta { get; set; }
        public string Status { get; set; }
    }
}
