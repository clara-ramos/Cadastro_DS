using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsBd
{
    public partial class frmRelProduto : Form
    {
        public frmRelProduto()
        {
            InitializeComponent();
        }

        private void frmRelProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'BdDataSet.tbproduto'. Você pode movê-la ou removê-la conforme necessário.
            this.tbprodutoTableAdapter.Fill(this.BdDataSet.tbproduto);

            this.reportViewer1.RefreshReport();
        }
    }
}
