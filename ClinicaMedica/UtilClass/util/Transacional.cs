using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilClass.util
{
    public class Transacional : AcessoDados
    {
        
        private SqlConnection _conexao;
        private SqlTransaction _transacao;
        private string _proprietario;

        public Transacional()
        {
            if (_conexao == null)
            {
                _conexao = Conexao.GetConexao();
            }
        }

        public virtual SqlTransaction transacao
        {
            get { return _transacao; }
            set { _transacao = value; }
        }

        public virtual SqlConnection conexao
        {
            get { return _conexao; }
            set { _conexao = value; }
        }

        public void iniciarTransacao(string proprietario)
        {
            try
            {
                if (transacao == null)
                {
                    _conexao.Open();
                    _proprietario = proprietario;
                    transacao = _conexao.BeginTransaction();
                }
            }
            catch { }
        }
        
        public void commit(string proprietario)
        {
            try
            {
                if (_proprietario == proprietario)
                    transacao.Commit();
                _conexao.Close();
            }
            catch
            { }
        }

        public void rollBack(string proprietario)
        {
            try
            {
                if (_proprietario == proprietario)
                    transacao.Rollback();
                _conexao.Close();
            }
            catch
            { }
        }
    }//fim da classe Transacional()
}//fim do namespace
