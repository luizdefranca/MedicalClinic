using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMedica.ServiceReference1;

namespace ClinicaMedica.GUI
{
    public partial class FormLogin : Form
    {
        public LoginInfo LoginData = new LoginInfo();

        Service1Client serv = new Service1Client();
        private FormPrincipal formPrincipal;


        public FormLogin(FormPrincipal formPrincipal)
        {
            InitializeComponent();

            this.formPrincipal = formPrincipal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    Usuario usuario = new Usuario();
                    usuario.Login = textLogin.Text.Trim();
                    usuario.Senha = textSenha.Text;

                    usuario = serv.Logar(usuario);
                    if (usuario == null)
                    {
                        MessageBox.Show("Usuário e/ou Senha inválidos", "NutriCorpo - Clínica Especializada em Nutrição", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        UsuarioSingleton.CodigoUsuario = usuario.CodigoUsuario;
                        UsuarioSingleton.CodigoNutricionista = usuario.Nutricionista.CodigoNutricionista;
                        UsuarioSingleton.CodigoTipoUsuario = usuario.TipoUsuario.CodigoTipoUsuario;
                        UsuarioSingleton.Login = usuario.Login;
                        UsuarioSingleton.Senha = usuario.Senha;
                        this.Close();
                    }
                }
                MessageBox.Show("Você digitou usuário e/ou senha inválidos por 3 vezes, aplicação será encerrada.", "NutriCorpo - Clínica Especializada em Nutrição", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public class LoginInfo
        {
            public string Login
            {
                get;
                set;
            }

            public string Senha
            {
                get;
                set;
            }
        }

    }
}
