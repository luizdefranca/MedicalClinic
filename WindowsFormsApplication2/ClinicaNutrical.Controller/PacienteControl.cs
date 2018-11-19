using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using ClinicaNutrical.Model;
using System.Windows.Forms;
using ClinicaNutrical.DAO;

namespace ClinicaNutrical.Controller
{
    public class PacienteControl
    {
        public void ValidaPaciente(Object classe, StringBuilder strb)
        {
            Validator<Object> valida = ValidationFactory.CreateValidator<Object>();
            ValidationResults resultados = valida.Validate(classe);

            if (!resultados.IsValid)
            {
                //StringBuilder strb = new StringBuilder();
                foreach (ValidationResult resultado in resultados)
                {
                    strb.Append(resultado.Key);
                }
                
                MessageBox.Show(strb.ToString(), " Erro de validacao");
            }

         }

        public List<Paciente> GetAllPacientes()
        {
            PacienteDAO pacienteDal = new PacienteDAO();
            return pacienteDal.GetAllPacientes();
        }

        public Paciente GetByIdPaciente(int id)
        {
            Paciente paciente = null;
            PacienteDAO pacienteDal = new PacienteDAO();

            if (!(string.IsNullOrEmpty(id.ToString()) | string.IsNullOrWhiteSpace(id.ToString())))
            {
                paciente = pacienteDal.GetByIdPaciente(id);
                return paciente;
            }
            return paciente;
        
        }
    }


}
