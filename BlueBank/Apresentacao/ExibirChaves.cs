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
    public partial class ExibirChaves : Form
    {
        private string cpf;
        public ExibirChaves()
        {
            InitializeComponent();
        }

        public ExibirChaves(string cpf)
        { 
            InitializeComponent();
            this.cpf = cpf;
            ExibirKeys(cpf);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void ExibirKeys(string cpf)
        {
            Controle controle = new Controle();
            string Key = "";
            Key = controle.ExibirCPF(cpf);
            if (controle.tem)
            {
                lblCpfKey.Text = Key;
            }
            else
            {
                lblCpfKey.Text = Key;
            }
            Key = controle.ExibirEmail(cpf);
            if (controle.tem)
            {
                lblEmailKey.Text = Key;
            }
            else
            {
                lblEmailKey.Text = Key;
            }
            Key = controle.ExibirCel(cpf);
            if (controle.tem)
            {
                lblCelKey.Text = Key;
            }
            else
            {
                lblCelKey.Text = Key;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e) //Reload
        {
            ExibirKeys(cpf);
        }
    }
}
