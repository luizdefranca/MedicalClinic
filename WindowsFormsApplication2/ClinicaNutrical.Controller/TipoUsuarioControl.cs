using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using ClinicaNutrical.Model;
using System.Windows.Forms;

namespace ClinicaNutrical.Controller
{
    public class TipoUsuarioControl
    {

        public void ValidaTipoUsuario(Object classe)
        {
            Validator<Object> valida = ValidationFactory.CreateValidator<Object>();
            ValidationResults resultados = valida.Validate(classe);

            if (!resultados.IsValid)
            {
                StringBuilder strb = new StringBuilder();
                foreach (ValidationResult resultado in resultados)
                {
                    strb.Append(resultado.Key);
                }

                MessageBox.Show(strb.ToString(), " Erro de validacao");
            }
        }
    }
}
