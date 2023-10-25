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
    public partial class AreaPix : Form
    {
        public int id_conta;
        public string cpf;
        public AreaPix()
        {
            InitializeComponent();
        }

        public AreaPix(int id_conta, string cpf)
        {
            InitializeComponent();
            this.id_conta = id_conta;
            this.cpf = cpf;
        }

        private void btnPix_Click(object sender, EventArgs e)
        {
            Pix pix = new Pix(id_conta);
            pix.Show();
        }

        private void btnChaves_Click(object sender, EventArgs e)
        {
            Chaves chaves = new Chaves(id_conta, cpf);
            chaves.Show();
        }
    }
}
