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
    public partial class frmPesquisaProduto : Form {

    private int codigo;
    public int getCodigo()
    {
        return codigo;
    }

   
        public frmPesquisaProduto()
        {
            InitializeComponent();
        }

        private void tbprodutoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbprodutoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdDataSet);

        }

        private void frmPesquisaProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdDataSet.tbproduto'. Você pode movê-la ou removê-la conforme necessário.
            this.tbprodutoTableAdapter.Fill(this.bdDataSet.tbproduto);

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tbprodutoTableAdapter.Fill(this.bdDataSet.tbproduto);
            }
            else
            {
                this.tbprodutoTableAdapter.FillByNome(this.bdDataSet.tbproduto, "%" + txtNome + "%");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void tbprodutoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = Convert.ToInt32(tbprodutoDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }
    }
}
