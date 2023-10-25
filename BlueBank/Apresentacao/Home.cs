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
    public partial class Home : Form
    {
        public Home(string cpf)
        {
            InitializeComponent();
            Controle controle = new Controle();
            lblname.Text = string.Format("O que deseja fazer, {0}?", controle.NomeBemvindo(cpf));
            lblSaldo.Text = string.Format($"Saldo: {controle.ExibirSaldo(cpf):C}");
        }
    }
}
