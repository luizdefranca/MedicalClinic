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
    public class ConsultaControl
    {
        //public void ValidaConsulta(Object classe, StringBuilder strb)
        //{
        //    Validator<Object> valida = ValidationFactory.CreateValidator<Object>();
        //    ValidationResults resultados = valida.Validate(classe);

        //    if (!resultados.IsValid)
        //    {
        //        //StringBuilder strb = new StringBuilder();
        //        foreach (ValidationResult resultado in resultados)
        //        {
        //            strb.Append(resultado.Key);
        //        }

        //        MessageBox.Show(strb.ToString(), " Erro de validacao");
        //    }

        //}

        public List<Consulta> GetAllConsultas()
        {
            ConsultaDAO consultaDal = new ConsultaDAO();
            return consultaDal.GetAllConsultas();

        }

        public Consulta GetByIdConsulta(int id)
        {
            Consulta consulta = null;
            ConsultaDAO consultaDal = new ConsultaDAO();
            if (!(string.IsNullOrEmpty(id.ToString()) | string.IsNullOrWhiteSpace(id.ToString())))
            {

                return consultaDal.GetByIdConsulta(id);
            }
            return consulta;

        }

        public Consulta GetByPaciente(Paciente paciente)
        {
            Consulta consulta = null;
            ConsultaDAO consultaDal = new ConsultaDAO();
            if (!(string.IsNullOrEmpty(paciente.CodPaciente.ToString()) | string.IsNullOrWhiteSpace(paciente.CodPaciente.ToString())))
            {

                return consultaDal.GetByPaciente(paciente);
            }
            return consulta; 
        }

        public void UpdateConsulta(Consulta consultaValue)
        {

            ConsultaDAO consultaDal = new ConsultaDAO();
            if (!(string.IsNullOrEmpty(consultaValue.CodConsulta.ToString()) | string.IsNullOrWhiteSpace(consultaValue.CodConsulta.ToString())))
            {
                consultaDal.UpdateConsulta(consultaValue);
            }
        }

        public void DeleteConsulta(Consulta consultaValue)
        {
            ConsultaDAO consultaDal = new ConsultaDAO();
            if (!(string.IsNullOrWhiteSpace(consultaValue.CodConsulta.ToString()) | string.IsNullOrEmpty(consultaValue.CodConsulta.ToString())))
            {
                consultaDal.DeleteConsulta(consultaValue);
            }
        }

        //public Consulta GetByNutricionistaAndPaciente(Nutricionista nutricionista, Paciente paciente)
        //{
        //    Consulta consulta = null;

        //    if (!((string.IsNullOrEmpty(nutricionista.Codigo.ToString())
        //        |
        //            string.IsNullOrWhiteSpace(nutricionista.Codigo.ToString()))
        //        &
        //          (string.IsNullOrWhiteSpace(paciente.CodPaciente.ToString()))
        //        |
        //            string.IsNullOrEmpty(paciente.CodPaciente.ToString())))
        //    {
        //        //falta implementar GetByNutricionistaAndPaciente

        //        return consulta;
        //    }

        //    return consulta;

        //}


    }
}
