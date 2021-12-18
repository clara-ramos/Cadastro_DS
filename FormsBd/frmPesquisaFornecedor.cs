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
    public partial class frmPesquisaFornecedor : Form
    {

        private int codigo;
        public int getCodigo()
        {
            return codigo;
        }

        public frmPesquisaFornecedor()
        {
            InitializeComponent();
        }

        private void tbfornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbfornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdDataSet);

        }

        private void frmPesquisaFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdDataSet.tbfornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tbfornecedorTableAdapter.Fill(this.bdDataSet.tbfornecedor);

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tbfornecedorTableAdapter.Fill(this.bdDataSet.tbfornecedor);
            }
            else
            {
                this.tbfornecedorTableAdapter.FillByNome(this.bdDataSet.tbfornecedor, "%" + txtNome + "%");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void tbfornecedorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = Convert.ToInt32(tbfornecedorDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }
    }
}
