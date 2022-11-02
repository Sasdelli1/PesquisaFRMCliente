using PesquisaCliente.dao.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesquisaCliente
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtomPesquisa_Click(object sender, EventArgs e)
        {
            Cliente Metodo_Cliente = new Cliente();
            DataSet ResultadodaPesquisa = new DataSet();

            ResultadodaPesquisa = Metodo_Cliente.List_Client(ButtomPesquisa.Text);
            DgCliente.DataSource = ResultadodaPesquisa.Tables[0];

            DgCliente.Refresh();
        }
    }
}
