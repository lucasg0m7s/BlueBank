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

namespace BlueBank.Apresentacao
{
    public partial class ExtratoPix : Form
    {
        public ExtratoPix()
        {
            InitializeComponent();
        }
        public ExtratoPix(int id_conta)
        {
            InitializeComponent();
            Controle controle = new Controle();
            DataTable dataTable;
            dataTable = controle.ExtratoPix(id_conta);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["Id_pix"].Width = 90;
            dataGridView1.Columns["data_pix"].Width = 150;
            dataGridView1.Columns["valor"].Width = 100;
            dataGridView1.Columns["Id_conta_origem"].Width = 150;
            dataGridView1.Columns["Id_conta_destino"].Width = 150;
            dataGridView1.Columns["valor"].HeaderText = "Valor";
        }

    }
}
