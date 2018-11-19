using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace ClinicaNutrical.Model

{
    public class Consulta
    {
        private int codConsulta;
        private double peso,
                      altura,
                      medidas,
                      pressao;
        private string restricaoAlimentar,
                       objetivo,
                       observacao,
                       medicamento,
                       problemaSaude,
                       historicoFamiliar;
        private Nutricionista nutricionista;
        private Paciente paciente;
        private DateTime data;
        public double Medidas
        {
            get { return medidas; }
            set { medidas = value; }
        }
        

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public double Pressao
        {
            get { return pressao; }
            set { pressao = value; }
        }

        public int CodConsulta
        {
            get { return codConsulta; }
            set { codConsulta = value; }
        }

        
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }


        public string RestricaoAlimentar
        {
            get { return restricaoAlimentar; }
            set { restricaoAlimentar = value; }
        }

        public string Objetivo
        {
            get { return objetivo; }
            set { objetivo = value; }
        }

        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }

        public string Medicamento
        {
            get { return medicamento; }
            set { medicamento = value; }
        }

        public string ProblemaSaude
        {
            get { return problemaSaude; }
            set { problemaSaude = value; }
        }

        public string HistoricoFamiliar
        {
            get { return historicoFamiliar; }
            set { historicoFamiliar = value; }
        }


        public Nutricionista Nutricionista
        {
            get { return nutricionista; }
            set { nutricionista = value; }
        }


        public Paciente Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        }

   


        public Consulta()
        {
           
        }

        public Consulta(int codConsulta, 
                        DateTime data, 
                        Paciente paciente, 
                        Nutricionista nutricionista, 
                        double peso, 
                        double pressao,
                        double altura,
                        double medidas, 
                        string problemaSaude, 
                        string restricaoAlimentar, 
                        string medicamento, 
                        string historicoFamiliar, 
                        string objetivo, 
                        string observacao)
        {
            this.codConsulta = codConsulta;
            this.data = data;
            this.paciente = paciente;
            this.nutricionista = nutricionista;
            this.peso = peso;
            this.pressao = pressao;
            this.altura = altura;
            this.medidas = medidas;
            this.problemaSaude = problemaSaude;
            this.restricaoAlimentar = restricaoAlimentar;
            this.medicamento = medicamento;
            this.historicoFamiliar = historicoFamiliar;
            this.objetivo = objetivo;
            this.observacao = observacao;
            
        }
        /**
         * Construtor sem o codigo da consulta - codConsulta
         * 
         */

        public Consulta(DateTime data,
                      Paciente paciente,
                      Nutricionista nutricionista,
                      double peso,
                      double pressao,
                      double altura,
                      double medidas,
                      string problemaSaude,
                      string restricaoAlimentar,
                      string medicamento,
                      string historicoFamiliar,
                      string objetivo,
                      string observacao)
        {
            this.data = data;
            this.paciente = paciente;
            this.nutricionista = nutricionista;
            this.peso = peso;
            this.pressao = pressao;
            this.altura = altura;
            this.medidas = medidas;
            this.problemaSaude = problemaSaude;
            this.restricaoAlimentar = restricaoAlimentar;
            this.medicamento = medicamento;
            this.historicoFamiliar = historicoFamiliar;
            this.objetivo = objetivo;
            this.observacao = observacao;

        }

        ~Consulta()
        {
            throw new System.NotImplementedException();
        }
    }
}
