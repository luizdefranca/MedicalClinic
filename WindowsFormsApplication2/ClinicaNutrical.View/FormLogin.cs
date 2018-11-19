using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ClinicaNutrical.View
{
    public partial class FormLogin : Form
    {
        public LoginInfo LoginData = new LoginInfo();

        public FormLogin()
        {
            InitializeComponent();

            /*
            try
            {
                Conexao con = new Conexao();
                con.Conectar();
                MessageBox.Show("Conexão Efetuada com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
 
            if (conectarBanco() == false)
            {
                Environment.Exit(0);
            };
             
        }

        private bool conectarBanco()
        {
           /* bool conectado = false;
            try
            {
                Conexao conecxao = new Conexao();
                if (conecxao.Conectar() == true)
                    conectado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NutriCorpo - Clínica Especializada em Nutrição", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            * */
            return true; //conectado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                #region UserData
                LoginData.Login = textLogin.Text.Trim();
                LoginData.Senha = textSenha.Text;
                #endregion

                //configuracoes.Configurar(Constantes.caminhoBanco, textLogin.Text, textSenha.Text, checkLembrarLogin.Checked, checkLembrarSenha.Checked, CheckLoginAutomatico.Checked);
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
