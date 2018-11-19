using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using ClinicaNutrical.Model;
using ClinicaNutrical.DAO;
using System.Windows.Forms;

namespace ClinicaNutrical.Controller
{
    public class NutricionistaControl
    {

        public List<Nutricionista> GetAllNutricionistas()
        {
            NutricionistaDAO nutDal = new NutricionistaDAO();
            return nutDal.GetAllNutricionistas();
        }


        public void ValidaNutricionista(Object classe)
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

        public void DeleteNutricionista(Nutricionista nutValue)
        {
            NutricionistaDAO nutDal = new NutricionistaDAO();
            if (!string.IsNullOrEmpty(nutValue.Codigo.ToString()) | !string.IsNullOrWhiteSpace(nutValue.Codigo.ToString()))
            {
                nutDal.DeleteNutricionista(nutValue);
            }
        }

        public void UpdateNutricionista(Nutricionista nutValue)
        {
            NutricionistaDAO nutDal = new NutricionistaDAO();
            if (!string.IsNullOrEmpty(nutValue.Codigo.ToString()) | !string.IsNullOrWhiteSpace(nutValue.Codigo.ToString()))
            {
                nutDal.UpdateNutricionista(nutValue);
            }
        }

        public Nutricionista GetByIdNutricionista(int ID)
        {
            Nutricionista nutricionista = new Nutricionista();
            NutricionistaDAO nutDal = new NutricionistaDAO();
            if (!string.IsNullOrEmpty(ID.ToString()) | !string.IsNullOrWhiteSpace(ID.ToString()))
            {
                nutDal.GetByIdNutricionista(ID);
            }

            return nutricionista;
        }

        public Nutricionista GetByNameNutricionista(string nome)
        {
            Nutricionista nutricionista = new Nutricionista();
            NutricionistaDAO nutDal = new NutricionistaDAO();
            if (!string.IsNullOrEmpty(nome.ToString()) | !string.IsNullOrWhiteSpace(nome.ToString()))
            {
                nutDal.GetByNomeNutricionista(nome);
            }

            return nutricionista;
        }

        public void InsertNutricionista(Nutricionista nut)
        {
            NutricionistaDAO nutDal = new NutricionistaDAO();
            if(!(nut == null))
            {
                nutDal.InsertNutricionista(nut);
            }
        }


    }
}
