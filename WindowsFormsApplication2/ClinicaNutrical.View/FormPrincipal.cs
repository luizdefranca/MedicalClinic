using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaNutrical.View
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            if (doLogin() == true)
            {
                Environment.Exit(0);
            };
        }

        #region Logar
        private bool doLogin()
        {
            DialogResult res;
            FormLogin fl = new FormLogin();
            string login = "";
            string senha = "";
            for (int i = 0; i < 3; i++)
            {
                res = fl.ShowDialog();
                if (res == System.Windows.Forms.DialogResult.OK)
                {
                    login = fl.LoginData.Login;
                    senha = fl.LoginData.Senha;
                }
                else
                {
                    return false;
                }

                /*
                Sessao.usuarioLogado = Fachada.getInstancia().validarLogin(login, senha);

                if (Sessao.usuarioLogado != null)
                {
                    if (Sessao.usuarioLogado.Situacao.Nome.ToUpper() == "Liberado".ToUpper())
                    {
                        toolStripStatusLabel2.Text = "Usuário: " + login.ToUpper();
                        doAplicarPermissões(Sessao.usuarioLogado.CodigoUsuario);
                        return true;
                    }
                    else
                    {
                        Sessao.usuarioLogado = null;
                        MessageBox.Show("Usuário inativo", "SAGA - Sistema de Apoio ao Gabinete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Usuário e/ou Senha inválidos", "SAGA - Sistema de Apoio ao Gabinete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                 * */
            }
            MessageBox.Show("Você digitou usuário e/ou senha inválidos por 3 vezes, aplicação será encerrada.", "SAGA - Sistema de Apoio ao Gabinete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        #endregion

        private void nutricionistaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
