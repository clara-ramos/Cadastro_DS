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
    public partial class frmRelCliente : Form
    {
        public frmRelCliente()
        {
            InitializeComponent();
        }

        private void frmRelCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'BdDataSet.tbcliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbclienteTableAdapter.Fill(this.BdDataSet.tbcliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
