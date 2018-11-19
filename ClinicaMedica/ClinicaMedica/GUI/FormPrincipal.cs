using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMedica.GUI
{
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();

            UsuarioSingleton.CodigoUsuario = 1;
            UsuarioSingleton.CodigoNutricionista = 1;
            UsuarioSingleton.CodigoTipoUsuario = 1;
            UsuarioSingleton.Login = "ADMIN";
            UsuarioSingleton.Senha = "123";

            //doLogin();
        }

        #region Logar
        private void doLogin()
        {
            FormLogin formLogin = new FormLogin(this);
            formLogin.ShowDialog();
        }
        #endregion

        private void prontuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormConsulta fc = new FormConsulta();
            fc.ShowDialog();
        }

        private void realizarPrescriçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrescricao fp = new FormPrescricao();
            fp.ShowDialog();
        }

    }
}
