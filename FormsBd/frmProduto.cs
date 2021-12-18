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
    public partial class frmProduto : Form
    {

        private void Habilita()
        {
            cd_produtoTextBox.Enabled = true;
            nm_produtoTextBox.Enabled = true;
            nm_categoriaTextBox.Enabled = true;
            qt_estoqueTextBox.Enabled = true;
            vl_custoTextBox.Enabled = true;
            vl_vendaTextBox.Enabled = true;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;
        }

        private void Desabilita()
        {
            cd_produtoTextBox.Enabled = false;
            nm_produtoTextBox.Enabled = false;
            nm_categoriaTextBox.Enabled = false;
            qt_estoqueTextBox.Enabled = false;
            vl_custoTextBox.Enabled = false;
            vl_vendaTextBox.Enabled = false;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnPesquisar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSair.Enabled = true;
        }

        public frmProduto()
        {
            InitializeComponent();
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdDataSet.tbproduto'. Você pode movê-la ou removê-la conforme necessário.
            this.tbprodutoTableAdapter.Fill(this.bdDataSet.tbproduto);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbprodutoBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbprodutoBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbprodutoBindingSource.AddNew();
            Habilita();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tbprodutoBindingSource.RemoveCurrent();
            tbprodutoTableAdapter.Update(bdDataSet.tbproduto);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbprodutoBindingSource.EndEdit();
            tbprodutoTableAdapter.Update(bdDataSet.tbproduto);
            Desabilita();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbprodutoBindingSource.CancelEdit();
            Desabilita();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int cod, reg;
            frmPesquisaProduto fpc = new frmPesquisaProduto();
            fpc.ShowDialog();
            cod = fpc.getCodigo();
            if (cod > 0)
            {
                reg = tbprodutoBindingSource.Find("cd_cliente", cod);
                tbprodutoBindingSource.Position = reg;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;



            strDados = "Ficha do Produto \n\n";
            strDados += "Código:" + cd_produtoTextBox.Text + "\n\n";
            strDados += "Nome:" + nm_produtoTextBox.Text + "\n\n";
            strDados += "Categoria:" + nm_categoriaTextBox.Text + "\n\n";
            strDados += "Estoque:" + qt_estoqueTextBox.Text + "\n\n";
            strDados += "Valor:" + vl_custoTextBox.Text + "\n\n";
            strDados += "Valor Venda:" + vl_vendaTextBox.Text + "\n\n";

            objImpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 50, 50);
        }
    }
}
