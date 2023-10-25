using BlueBank.Apresentacao;
using BlueBank.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BlueBank.Model
{
    public class Controle
    {
        public bool tem;
        public string mensagem = ""; // tudo ok sem erros
        // VERIFICAR LOGIN
        public bool Acessar(String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(login, senha);
            if (!loginDao.mensagem.Equals("")){ // se tiver texto então quer dizer que há um erro vindo do controller
                this.mensagem = loginDao.mensagem; // Então passamos o erro para nossa variável atual
            }
            return tem; 
        }
        //CADASTRAR USUARIO
        public string Cadastrar(String Email, String Nome, String CPF, String Senha, String Celular, String confirmSenha) 
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.Cadastrar(Email,Nome,CPF,Senha,Celular,confirmSenha);
            if (loginDao.tem)// A mensagem que vai vir é uma mensagem de sucesso
            {
                this.tem = true;
            }
            return mensagem;
        }
        // VERIFICAR SE OS DADOS JA EXISTEM
        public bool VerificarCadastro(string email, string cel, string cpf)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.VerificarCadastro(email, cel, cpf);
            if (!loginDao.mensagem.Equals(""))
            { 
                this.mensagem = loginDao.mensagem; 
            }
            return tem;
        }
        // NOME PAGINA INICIAL
        public string NomeBemvindo(string cpf)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.NomeBemVindo(cpf);
            return mensagem;
        }
        // INICIALIZAR ATRIBUTOS DA CONTA
        public bool InicializarConta(string cpf)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.InicializarConta(cpf);
            this.mensagem = "";
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }
        // OBTER ID_CONTA
        public int GetConta(string cpf)
        {
            int id_conta;
            LoginDaoComandos loginDao = new LoginDaoComandos();
            id_conta = loginDao.GetID_Conta(cpf);
            return id_conta;
        }
        // PIX
        public string Pix(string chave, decimal val, int id_conta)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = "";
            this.mensagem = loginDao.Pix(chave, val, id_conta);
            if (loginDao.tem)
            {
                this.tem = loginDao.tem;
            }
            return mensagem;
        }
        //CHAVES PIX
        //INICIALIZANDO CHAVES
        public string InicializarChaves(string cpf)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = "";
            tem = false;
            this.mensagem = loginDao.InicializarChaves(cpf);
            if (loginDao.tem)
            {
                this.tem = loginDao.tem;
            }
            return mensagem;
        }
        //ATIVANDO CHAVES
        public string CpfKey(string cpf, int id_conta)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            mensagem = "";
            tem = false;
            this.mensagem = loginDao.CpfKey(cpf, id_conta);
            if (loginDao.tem)
            {
                this.tem = loginDao.tem;
            }
            return mensagem;
        }
        public string EmailKey(string cpf, int id_conta)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            mensagem = "";
            tem = false;
            this.mensagem = loginDao.EmailKey(cpf, id_conta);
            if (loginDao.tem)
            {
                this.tem = loginDao.tem;
            }
            return mensagem;
        }
        public string CelKey(string cpf, int id_conta)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            mensagem = "";
            tem = false;
            this.mensagem = loginDao.CelKey(cpf, id_conta);
            if (loginDao.tem)
            {
                this.tem = loginDao.tem;
            }
            return mensagem;
        }
        //DESATIVANDO CHAVES
        public string DesCpfKey(string cpf, int id_conta)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            mensagem = "";
            tem = false;
            this.mensagem = loginDao.DesCpfKey(cpf, id_conta);
            if (loginDao.tem)
            {
                this.tem = loginDao.tem;
            }
            return mensagem;
        }
        public string DesEmailKey(string cpf, int id_conta)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            mensagem = "";
            tem = false;
            this.mensagem = loginDao.DesEmailKey(cpf, id_conta);
            if (loginDao.tem)
            {
                this.tem = loginDao.tem;
            }
            return mensagem;
        }
        public string DesCelKey(string cpf, int id_conta)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            mensagem = "";
            tem = false;
            this.mensagem = loginDao.DesCelKey(cpf, id_conta);
            if (loginDao.tem)
            {
                this.tem = loginDao.tem;
            }
            return mensagem;
        }

        //Exibindo Chaves
        public string ExibirCPF(string cpf)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            mensagem = "";
            tem = false;
            mensagem = loginDao.ExibirCPF(cpf);
            tem = loginDao.tem;
            return mensagem;
        }
        public string ExibirEmail(string cpf)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            mensagem = "";
            tem = false;
            mensagem = loginDao.ExibirEmail(cpf);
            tem = loginDao.tem;
            return mensagem;
        }
        public string ExibirCel(string cpf)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            mensagem = "";
            tem = false;
            mensagem = loginDao.ExibirCel(cpf);
            tem = loginDao.tem;
            return mensagem;
        }

        public decimal ExibirSaldo(string cpf)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            decimal lblsaldo = loginDao.ExibirSaldo(cpf);
            return lblsaldo;
        }

        public DataTable ExtratoPix(int id_conta)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            DataTable dataTable;
            dataTable = loginDao.ExtratoPix(id_conta);
            return dataTable;
        }
    }
}
