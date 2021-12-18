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
    public partial class frmPesquisaCliente : Form
    {

        private int codigo;
        public int getCodigo()
        {
            return codigo;
        }

        public frmPesquisaCliente()
        {
            InitializeComponent();
        }

        private void tbclienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbclienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdDataSet);

        }

        private void frmPesquisaCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdDataSet.tbcliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbclienteTableAdapter.Fill(this.bdDataSet.tbcliente);

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tbclienteTableAdapter.Fill(this.bdDataSet.tbcliente);
            }
            else
            {
                this.tbclienteTableAdapter.FillByNome(this.bdDataSet.tbcliente, "%" + txtNome + "%");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void tbclienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = Convert.ToInt32(tbclienteDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }
    }
}
