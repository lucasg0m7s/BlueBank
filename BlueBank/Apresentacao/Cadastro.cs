using BlueBank.Model;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BlueBank.Apresentacao
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            // Impedindo o user de enviar campos em branco
            string cpf = mskCPF.Text;
            if (txtEmail.Text == "" || txtNome.Text == "" || cpf == "" || txtSenha.Text == "" || mskCel.Text == "" || txtConfirmSenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Impedindo o user de enviar campos incompletos
                if (!mskCPF.MaskCompleted || !mskCel.MaskCompleted)
                {
                    MessageBox.Show("Preencha Completamente os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Impedindo o user de enviar email invalido
                    if (txtEmail.Text.Contains("@") && txtEmail.Text.Contains(".com"))
                    {
                        // Impedindo o user de enviar dados iguais
                        controle.VerificarCadastro(txtEmail.Text, mskCel.Text, cpf);
                        if (controle.mensagem.Equals(""))
                        {
                            if (controle.tem)
                            {
                                MessageBox.Show("Alguns dos dados inseridos ja foram cadastrados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                String mensagem = controle.Cadastrar(txtEmail.Text, txtNome.Text, cpf, txtSenha.Text, mskCel.Text, txtConfirmSenha.Text);
                                if (controle.tem)//mensagem de sucesso
                                {
                                    MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    controle.InicializarConta(cpf);
                                    if (controle.mensagem.Equals(""))
                                    {
                                        MessageBox.Show("Estamos preparando algumas coisas...", "Aguarde", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        mensagem = controle.InicializarChaves(cpf);
                                        if (controle.tem)
                                        {
                                            MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            MessageBox.Show("Pressione OK para fechar a página de cadastro", "Fechar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            Close();
                                            Form1 form = new Form1();
                                            form.Show();
                                        }
                                        else
                                        {
                                            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); // mensagem de erro
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show(controle.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); // mensagem de erro
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(controle.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); // mensagem de erro
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show(controle.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insira um Email válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
            Form1 form = new Form1();
            form.Show();
        }
    }
}

