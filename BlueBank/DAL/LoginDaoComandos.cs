using BlueBank.Apresentacao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueBank.DAL
{
    internal class LoginDaoComandos
    {
        public bool tem = false;
        public string mensagem = "";
        public int id_user = 0;
        public int id_conta = 0;
        SqlCommand cmd = new SqlCommand();
        Conexao conn = new Conexao();
        SqlDataReader dr;
        public bool verificarLogin(String login, String senha)
        {
            //Comandos SQL para verificar se tem no banco de dados
            cmd.CommandText = "select * from Usuarios where CPF = @login and Senha = @senha";
            cmd.Parameters.Add(new SqlParameter("@login", login));
            cmd.Parameters.Add(new SqlParameter("@senha", senha));

            try
            {
                cmd.Connection = conn.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) // se foi encontrado
                {
                    tem = true;
                }
                conn.Desconectar();
                dr.Close();
            }
            catch (Exception ex)
            {
                mensagem = ex.Message;
            }
            return tem;
        }

        public string Cadastrar(String Email, String Nome, String CPF, String Senha, String Celular, String confirmSenha)
        {
            tem = false;
            // Comandos para inserir no banco de dados
            if(Senha.Equals(confirmSenha))
            {
                cmd.CommandText = "Insert into Usuarios (Nome, CPF, Celular, Email, Senha) values (@nome, @cpf, @cel, @email, @senha);";
                cmd.Parameters.Add(new SqlParameter("@nome",Nome));
                cmd.Parameters.Add(new SqlParameter("@cpf", CPF));
                cmd.Parameters.Add(new SqlParameter("@cel", Celular));
                cmd.Parameters.Add(new SqlParameter("@email", Email));
                cmd.Parameters.Add(new SqlParameter("@senha", Senha));
                try
                {
                    cmd.Connection = conn.Conectar();
                    cmd.ExecuteNonQuery();
                    conn.Desconectar();
                    mensagem = "Cadastrado com sucesso!";
                    tem = true;
                }
                catch (Exception ex)
                {
                    mensagem = ex.Message;
                }
            }
            else
            {
                mensagem = "Senhas não correspondem!";
            }

            return mensagem;

        }
        public bool VerificarCadastro(string email, string cel, string cpf)
        {
            //Comandos SQL para verificar se tem no banco de dados
            cmd.CommandText = "select * from Usuarios where CPF = @cpf or Celular = @cel or Email = @email";
            cmd.Parameters.Add(new SqlParameter("@cpf", cpf));
            cmd.Parameters.Add(new SqlParameter("@cel", cel));
            cmd.Parameters.Add(new SqlParameter("@email", email));

            try
            {
                cmd.Connection = conn.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) // se foi encontrado
                {
                    tem = true;
                }
                conn.Desconectar();
                dr.Close();
            }
            catch (Exception ex)
            {
                mensagem = ex.Message;
            }
            return tem;
        }
        public string NomeBemVindo(string cpf)
        {
            string lblname = "";
            cmd.CommandText = "select nome from Usuarios where cpf = @cpf";
            cmd.Parameters.Add(new SqlParameter("@cpf", cpf));
            cmd.Connection= conn.Conectar();
            lblname = (string)cmd.ExecuteScalar();
            conn.Desconectar();
            return lblname;
        }
        public decimal ExibirSaldo(string cpf)
        {
            decimal lblsaldo;
            id_conta = GetID_Conta(cpf);
            cmd.CommandText = "select saldo from Contas where id_conta = @id_conta";
            cmd.Parameters.Add(new SqlParameter("@id_conta", id_conta));
            cmd.Connection = conn.Conectar();
            lblsaldo = (decimal)cmd.ExecuteScalar();
            conn.Desconectar();
            return lblsaldo;
        }

        public bool InicializarConta(string cpf)
        {            
            DateTime dataAtual = DateTime.Today;                        
            Random random = new Random();
            int num_conta = random.Next(100000, 999999);   
            
            do
            {
                tem = false;
                cmd.CommandText = "Select * from Contas where numero_conta = @num_conta";
                cmd.Parameters.Add(new SqlParameter("@num_conta", num_conta));
                cmd.Connection = conn.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                conn.Desconectar();
                dr.Close();
                if (tem)
                {
                    num_conta = random.Next(100000, 999999);
                }                
            } while (tem == true);

            id_user = GetId_user(cpf);

            cmd.CommandText = "Insert into Contas (numero_conta, saldo, data_abertura, id_usuario) Values (@numconta,@saldo,@data_abertura,@id_user)";
            cmd.Parameters.Add(new SqlParameter("@numconta", num_conta));
            cmd.Parameters.Add(new SqlParameter("@saldo", 5000.00m));
            cmd.Parameters.Add(new SqlParameter("@data_abertura", dataAtual));
            cmd.Parameters.Add(new SqlParameter("@id_user", id_user));
            try
            {
                cmd.Connection = conn.Conectar();
                cmd.ExecuteNonQuery();
                conn.Desconectar();
                tem = true;
            }
            catch (Exception ex)
            {
                mensagem = ex.Message;
            }
            conn.Desconectar();
            return tem;
        }

        public int GetId_user(string cpf)
        {
            cmd.CommandText = "Select Id_usuario from Usuarios where cpf = @cpf";
            cmd.Parameters.Add(new SqlParameter("@cpf", cpf));
            cmd.Connection = conn.Conectar();
            id_user = (int)cmd.ExecuteScalar();
            conn.Desconectar();
            return id_user;
        }

        public int GetID_Conta(string cpf)
        {
            id_user = GetId_user(cpf);
            cmd.CommandText = "Select Id_conta from Contas where id_usuario = @id_user";
            cmd.Parameters.Add(new SqlParameter("@id_user", id_user));
            cmd.Connection = conn.Conectar();
            int id_conta = (int)cmd.ExecuteScalar();
            conn.Desconectar();
            return id_conta;
        }

        public string Pix(string chave, decimal val_pix, int id_conta)
        {
            DateTime dataAtual = DateTime.Now;
            //Verificando se a chave pix existe
            cmd.Connection = conn.Conectar();
            cmd.CommandText = "Select Id_conta from Chaves_pix where cpf_chave = @chave or email_chave = @chave or cel_chave = @chave";
            cmd.Parameters.Add(new SqlParameter("@chave", chave));           
            var id_conta_destino = cmd.ExecuteScalar();
            int id_conta_origem = id_conta;
            tem = false;

            //Validando e Obtendo valor do saldo de origem 
            if (id_conta_destino != null)
            {
                int id_conta_destino2 = (int)cmd.ExecuteScalar();
                if (id_conta_origem == id_conta_destino2)
                {
                    mensagem = "Não é possível realizar um pix para si mesmo!";
                }
                else
                {
                    cmd.CommandText = "Select saldo from Contas where Id_conta = @id_conta_origem";
                    cmd.Parameters.Add(new SqlParameter("@id_conta_origem", id_conta_origem));
                    decimal saldo_origem = (decimal)cmd.ExecuteScalar();
                    if (saldo_origem >= val_pix)
                    {
                        SqlTransaction transaction = cmd.Connection.BeginTransaction();
                        try
                        {
                            //Debitar o valor da conta de origem
                            cmd.CommandText = "Update Contas SET saldo = saldo - @val_pix where id_conta = @id_conta_origem";
                            using (SqlCommand debitar = new SqlCommand(cmd.CommandText, cmd.Connection, transaction))
                            {
                                debitar.Parameters.Add(new SqlParameter("@val_pix", val_pix));
                                debitar.Parameters.Add(new SqlParameter("@id_conta_origem", id_conta_origem));
                                debitar.ExecuteNonQuery();
                            }


                            //Adicionar o valor a conta de destino
                            cmd.CommandText = "Update Contas Set saldo = saldo + @val_pix where id_conta = @id_conta_destino";
                            using (SqlCommand adicionar = new SqlCommand(cmd.CommandText, cmd.Connection, transaction))
                            {
                                adicionar.Parameters.Add(new SqlParameter("@val_pix", val_pix));
                                adicionar.Parameters.Add(new SqlParameter("@id_conta_destino", id_conta_destino));
                                adicionar.ExecuteNonQuery();
                            }

                            cmd.CommandText = "Insert Into Pix (data_pix, valor, id_conta_origem, id_conta_destino)Values(@data,@val_pix,@id_conta_origem, @id_conta_destino)";
                            using (SqlCommand registrar = new SqlCommand(cmd.CommandText, cmd.Connection, transaction))
                            {
                                registrar.Parameters.Add(new SqlParameter("@data", dataAtual));
                                registrar.Parameters.Add(new SqlParameter("@val_pix", val_pix));
                                registrar.Parameters.Add(new SqlParameter("@id_conta_origem", id_conta_origem));
                                registrar.Parameters.Add(new SqlParameter("@id_conta_destino", id_conta_destino));
                                registrar.ExecuteNonQuery();
                            }

                            transaction.Commit();                         
                            tem = true;
                            mensagem = "Pix realizado com sucesso!";
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            mensagem = ex.Message;
                        }
                    }
                    else
                    {
                        mensagem = "Pix não realizado, saldo insuficiente!";
                    }
                }                
            }
            else
            {
                mensagem = "Essa chave não pertence a nenhuma conta";
            }
            conn.Desconectar();
            return mensagem;
        }

        public string InicializarChaves(string cpf)
        {
            tem = false;
            id_conta = GetID_Conta(cpf);
            cmd.CommandText = "Insert into Chaves_pix (id_conta) values (@id_conta)";
            cmd.Parameters.Add(new SqlParameter("@id_conta", id_conta));
            try
            {
                cmd.Connection = conn.Conectar();
                cmd.ExecuteNonQuery();
                conn.Desconectar();
                tem = true;
                mensagem = "Tudo Pronto!";
            }
            catch (Exception ex)
            {
                mensagem = ex.Message;
            }
            return mensagem;
        }

        public string CpfKey(string cpf, int id_conta)
        {
            tem = false;
            cmd.Connection = conn.Conectar();
            cmd.CommandText = "Select * from Chaves_pix where cpf_chave = @cpf_chave";
            cmd.Parameters.Add(new SqlParameter("@cpf_chave", cpf));
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                mensagem = "A chave CPF já está ativa!";
            }           
            else
            {
                try
                {
                    dr.Close();
                    conn.Desconectar();
                    cmd.Connection = conn.Conectar();
                    cmd.CommandText = "Update Chaves_pix SET cpf_chave = @cpf where id_conta = @id_conta";
                    cmd.Parameters.Add(new SqlParameter("@cpf", cpf));
                    cmd.Parameters.Add(new SqlParameter("@id_conta", id_conta));
                    cmd.ExecuteNonQuery();
                    mensagem = "Chave CPF ativada com sucesso!";
                    tem = true;
                }
                catch (Exception ex)
                {
                    mensagem = ex.Message;
                }              
            }
            conn.Desconectar();
            return mensagem;
        }
        public string EmailKey(string cpf, int id_conta)
        {
            tem = false;
            cmd.Connection = conn.Conectar();
            cmd.CommandText = "Select email from Usuarios where cpf = @cpf";
            cmd.Parameters.Add(new SqlParameter("@cpf", cpf));
            string email = (string)cmd.ExecuteScalar();
            cmd.CommandText = "Select * from Chaves_pix where email_chave = @email_chave";
            cmd.Parameters.Add(new SqlParameter("@email_chave", email));
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                mensagem = "A chave Email já está ativa!";
            }
            else
            {
                try
                {
                    dr.Close();
                    conn.Desconectar();
                    cmd.Connection = conn.Conectar();
                    cmd.CommandText = "Update Chaves_pix SET email_chave = @email where id_conta = @id_conta";
                    cmd.Parameters.Add(new SqlParameter("@email", email));
                    cmd.Parameters.Add(new SqlParameter("@id_conta", id_conta));
                    cmd.ExecuteNonQuery();
                    mensagem = "Chave Email ativada com sucesso!";
                    tem = true;
                }
                catch (Exception ex)
                {
                    mensagem = ex.Message;
                }
            }
            conn.Desconectar();
            return mensagem;
        }
        public string CelKey(string cpf, int id_conta)
        {
            tem = false;
            cmd.Connection = conn.Conectar();
            cmd.CommandText = "Select celular from Usuarios where cpf = @cpf";
            cmd.Parameters.Add(new SqlParameter("@cpf", cpf));
            string cel = (string)cmd.ExecuteScalar();
            cmd.CommandText = "Select * from Chaves_pix where cel_chave = @cel";
            cmd.Parameters.Add(new SqlParameter("@cel", cel));
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                mensagem = "A chave Celular já está ativa!";
            }
            else
            {
                try
                {
                    dr.Close();
                    conn.Desconectar();
                    cmd.Connection = conn.Conectar();
                    cmd.CommandText = "Update Chaves_pix SET cel_chave = @cel_chave where id_conta = @id_conta";
                    cmd.Parameters.Add(new SqlParameter("@cel_chave", cel));
                    cmd.Parameters.Add(new SqlParameter("@id_conta", id_conta));
                    cmd.ExecuteNonQuery();
                    mensagem = "Chave Celular ativada com sucesso!";
                    tem = true;
                }
                catch (Exception ex)
                {
                    mensagem = ex.Message;
                }
            }
            conn.Desconectar();
            return mensagem;
        }
        public string DesCpfKey(string cpf, int id_conta)
        {
            tem = false;  
            cmd.Connection = conn.Conectar();
            cmd.CommandText = "Select * from Chaves_pix where cpf_chave = @cpf_chave";
            cmd.Parameters.Add(new SqlParameter("@cpf_chave", cpf));
            dr = cmd.ExecuteReader();
            if (!dr.HasRows)
            {
                mensagem = "A chave CPF já está desativada!";
            }
            else
            {
                try
                {
                    dr.Close();
                    cmd.CommandText = "Update Chaves_pix Set cpf_chave = null where id_conta = @id_conta";
                    cmd.Parameters.Add(new SqlParameter("@id_conta", id_conta));
                    cmd.ExecuteNonQuery();
                    mensagem = "Chave CPF Desativada com Sucesso!";
                    tem = true;
                }
                catch (Exception ex)
                {
                    mensagem = ex.Message;
                }
            }
            conn.Desconectar();
            return mensagem;
        }
        public string DesEmailKey(string cpf, int id_conta)
        {
            tem = false;
            cmd.Connection = conn.Conectar();
            cmd.CommandText = "Select email from Usuarios where cpf = @cpf";
            cmd.Parameters.Add(new SqlParameter("@cpf", cpf));
            string email = (string)cmd.ExecuteScalar();
            cmd.CommandText = "Select * from Chaves_pix where email_chave = @email_chave";
            cmd.Parameters.Add(new SqlParameter("@email_chave", email));
            dr = cmd.ExecuteReader();
            if (!dr.HasRows)
            {
                mensagem = "A chave Email já está desativada!";
            }
            else
            {
                try
                {
                    dr.Close();
                    cmd.CommandText = "Update Chaves_pix SET email_chave = null where id_conta = @id_conta";
                    cmd.Parameters.Add(new SqlParameter("@id_conta", id_conta));
                    cmd.ExecuteNonQuery();
                    mensagem = "Chave Email desativada com sucesso!";
                    tem = true;
                }
                catch (Exception ex)
                {
                    mensagem = ex.Message;
                }
            }
            conn.Desconectar();
            return mensagem;
        }
        public string DesCelKey(string cpf, int id_conta)
        {
            tem = false;
            cmd.Connection = conn.Conectar();
            cmd.CommandText = "Select celular from Usuarios where cpf = @cpf";
            cmd.Parameters.Add(new SqlParameter("@cpf", cpf));
            string cel = (string)cmd.ExecuteScalar();
            cmd.CommandText = "Select * from Chaves_pix where cel_chave = @cel";
            cmd.Parameters.Add(new SqlParameter("@cel", cel));
            dr = cmd.ExecuteReader();
            if (!dr.HasRows)
            {
                mensagem = "A chave Celular já está desativada!";
            }
            else
            {
                try
                {
                    dr.Close();
                    cmd.CommandText = "Update Chaves_pix SET cel_chave = null where id_conta = @id_conta";
                    cmd.Parameters.Add(new SqlParameter("@id_conta", id_conta));
                    cmd.ExecuteNonQuery();
                    mensagem = "Chave Celular desativada com sucesso!";
                    tem = true;
                }
                catch (Exception ex)
                {
                    mensagem = ex.Message;
                }
            }
            conn.Desconectar();
            return mensagem;
        }

        public string ExibirCPF(string cpf)
        {
            tem = false;
            string key = "";
            cmd.Connection = conn.Conectar();
            cmd.CommandText = "select * from Chaves_pix where cpf_chave = @cpf";
            cmd.Parameters.Add(new SqlParameter("@cpf", cpf));
            dr = cmd.ExecuteReader();
            if(!dr.HasRows)
            {
                key = "Chave Não ativada";
            }
            else
            {
                key = cpf;
                tem = true;
            }
            dr.Close();
            conn.Desconectar();
            return key;
        }
        public string ExibirEmail(string cpf)
        {
            tem = false;
            string key = "";
            cmd.Connection = conn.Conectar();
            cmd.CommandText = "Select email from Usuarios where cpf = @cpf";
            cmd.Parameters.Add(new SqlParameter("@cpf", cpf));
            string email = (string)cmd.ExecuteScalar();
            cmd.CommandText = "select * from Chaves_pix where email_chave = @email";
            cmd.Parameters.Add(new SqlParameter("@email", email));
            dr = cmd.ExecuteReader();
            if (!dr.HasRows)
            {
                key = "Chave Não ativada";
            }
            else
            {
                key = email;
                tem = true;
            }
            dr.Close();
            conn.Desconectar();
            return key;
        }
        public string ExibirCel(string cpf)
        {
            tem = false;
            string key = "";
            cmd.Connection = conn.Conectar();
            cmd.CommandText = "Select celular from Usuarios where cpf = @cpf";
            cmd.Parameters.Add(new SqlParameter("@cpf", cpf));
            string cel = (string)cmd.ExecuteScalar();
            cmd.CommandText = "select * from Chaves_pix where cel_chave = @cel";
            cmd.Parameters.Add(new SqlParameter("@cel", cel));
            dr = cmd.ExecuteReader();
            if (!dr.HasRows)
            {
                key = "Chave Não ativada";
            }
            else
            {
                key = cel;
                tem = true;
            }
            dr.Close();
            conn.Desconectar();
            return key;
        }
        public DataTable ExtratoPix(int id_conta)
        {
            cmd.Connection = conn.Conectar();
            cmd.CommandText = "SELECT * FROM Pix WHERE id_conta_origem = @idConta";
            cmd.Parameters.AddWithValue("@idConta", id_conta);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            conn.Desconectar();
            return dataTable;   
        }
    }
}
