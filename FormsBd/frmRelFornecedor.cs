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
    public partial class frmRelFornecedor : Form
    {
        public frmRelFornecedor()
        {
            InitializeComponent();
        }

        private void frmRelFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'BdDataSet.tbfornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tbfornecedorTableAdapter.Fill(this.BdDataSet.tbfornecedor);

            this.reportViewer1.RefreshReport();
        }
    }
}
