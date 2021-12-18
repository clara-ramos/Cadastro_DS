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
    public partial class frmPesquisaUsuario : Form
    {

        private int codigo;
        public int getCodigo()
        {
            return codigo;
        }

        public frmPesquisaUsuario()
        {
            InitializeComponent();
        }

        private void tbusuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbusuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdDataSet);

        }

        private void frmPesquisaUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdDataSet.tbusuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbusuarioTableAdapter.Fill(this.bdDataSet.tbusuario);

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if(txtNome.Text == "")
            {
                this.tbusuarioTableAdapter.Fill(this.bdDataSet.tbusuario);
            }
            else
            {
                this.tbusuarioTableAdapter.FillByNome(this.bdDataSet.tbusuario, "%" + txtNome + "%");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void tbusuarioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = Convert.ToInt32(tbusuarioDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }
    }
}
