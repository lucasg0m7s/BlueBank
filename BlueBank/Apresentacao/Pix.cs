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
    public partial class Pix : Form
    {
        public int id_conta;
        public Pix()
        {
            InitializeComponent();
        }
        public Pix(int id_conta)
        {
            InitializeComponent();
            this.id_conta = id_conta;
            txtVal.Text = "0,00";
        }

        private void btnRealizarPix_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();            
            if(txtChave.Text == "" || txtVal.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(txtVal.Text == "0,00")
            {
                MessageBox.Show("Não é possivel fazer um pix de R$0,00. Insira um valor!", "Pix inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string valor = txtVal.Text;
                decimal val_pix = Convert.ToDecimal(valor);
                string mensagem = controle.Pix(txtChave.Text, val_pix, id_conta);
                if (controle.tem)
                {
                    MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtVal.Text = "";
                    txtChave.Text = "";
                }
                else
                {
                    MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
            

        private void txtVal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.DecNumber(sender, e);
        }

        private void txtVal_Leave(object sender, EventArgs e)
        {  
            if(txtVal.Text != "")
            {
                var num = Convert.ToDecimal(txtVal.Text);
                txtVal.Text = num.ToString("N2");
            }
            else
            {
                txtVal.Text = "0,00";
            }                       
        }
    }
}
