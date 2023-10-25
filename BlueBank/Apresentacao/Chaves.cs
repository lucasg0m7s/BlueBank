using BlueBank.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueBank.Apresentacao
{
    public partial class Chaves : Form
    {
        public int id_conta;
        public string cpf;
        public Chaves()
        {
            InitializeComponent();
        }

        public Chaves(int id_conta, string cpf)
        {
            InitializeComponent();
            this.id_conta = id_conta;
            this.cpf = cpf;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Exibir Chaves
        {
            ExibirChaves exibir = new ExibirChaves(cpf);
            exibir.Show();
        }

        private void button2_Click(object sender, EventArgs e) // Cadastrar Chaves
        {
            Controle controle = new Controle();

            DialogResult cpfKey = MessageBox.Show("Deseja utilizar seu cpf como chave pix?", "CPF", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (cpfKey == DialogResult.Yes)
            {
                string mensagem = controle.CpfKey(cpf, id_conta);
                if (controle.tem)
                {
                    MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            DialogResult emailKey = MessageBox.Show("Deseja utilizar seu email como chave pix?", "Email", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (emailKey == DialogResult.Yes)
            {
                string mensagem = controle.EmailKey(cpf, id_conta);
                if (controle.tem)
                {
                    MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            DialogResult celKey = MessageBox.Show("Deseja utilizar seu celular como chave pix?", "Celular", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (celKey == DialogResult.Yes)
            {
                string mensagem = controle.CelKey(cpf, id_conta);
                if (controle.tem)
                {
                    MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();

            DialogResult cpfKey = MessageBox.Show("Deseja desativar a chave CPF?", "CPF", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (cpfKey == DialogResult.Yes)
            {
                string mensagem = controle.DesCpfKey(cpf, id_conta);
                if (controle.tem)
                {
                    MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            DialogResult emailKey = MessageBox.Show("Deseja desativar a chave Email?", "Email", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (emailKey == DialogResult.Yes)
            {
                string mensagem = controle.DesEmailKey(cpf, id_conta);
                if (controle.tem)
                {
                    MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            DialogResult celKey = MessageBox.Show("Deseja desativar a chave Celular?", "Celular", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (celKey == DialogResult.Yes)
            {
                string mensagem = controle.DesCelKey(cpf, id_conta);
                if (controle.tem)
                {
                    MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
