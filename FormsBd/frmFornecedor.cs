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
    public partial class frmFornecedor : Form
    {

        private void Habilita()
        {
            cd_fornecedorTextBox.Enabled = true;
            nm_fornecedorTextBox.Enabled = true;
            nm_contatoTextBox.Enabled = true;
            cd_telefoneTextBox.Enabled = true;
            cd_tipoTextBox.Enabled = true;
            cd_cpfTextBox.Enabled = true;
            cd_rgTextBox.Enabled = true;
            cd_cnpjTextBox.Enabled = true;
            cd_ieTextBox.Enabled = true;
            ds_emailTextBox.Enabled = true;
            ds_enderecoTextBox.Enabled = true;
            nr_enderecoTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            sg_estadoTextBox.Enabled = true;
            cd_cepTextBox.Enabled = true;
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
            cd_fornecedorTextBox.Enabled = false;
            nm_fornecedorTextBox.Enabled = false;
            nm_contatoTextBox.Enabled = false;
            cd_telefoneTextBox.Enabled = false;
            cd_tipoTextBox.Enabled = false;
            cd_cpfTextBox.Enabled = false;
            cd_rgTextBox.Enabled = false;
            cd_cnpjTextBox.Enabled = false;
            cd_ieTextBox.Enabled = false;
            ds_emailTextBox.Enabled = false;
            ds_enderecoTextBox.Enabled = false;
            nr_enderecoTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            sg_estadoTextBox.Enabled = false;
            cd_cepTextBox.Enabled = false;
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

        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdDataSet.tbfornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tbfornecedorTableAdapter.Fill(this.bdDataSet.tbfornecedor);

        }

        private void nr_enderecoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbfornecedorBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbfornecedorBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbfornecedorBindingSource.AddNew();
            Habilita();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tbfornecedorBindingSource.RemoveCurrent();
            tbfornecedorTableAdapter.Update(bdDataSet.tbfornecedor);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbfornecedorBindingSource.EndEdit();
            tbfornecedorTableAdapter.Update(bdDataSet.tbfornecedor);
            Desabilita();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbfornecedorBindingSource.CancelEdit();
            Desabilita();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int cod, reg;
            frmPesquisaFornecedor fpc = new frmPesquisaFornecedor();
            fpc.ShowDialog();
            cod = fpc.getCodigo();
            if (cod > 0)
            {
                reg = tbfornecedorBindingSource.Find("cd_cliente", cod);
                tbfornecedorBindingSource.Position = reg;
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



            strDados = "Ficha do Fornecedor \n\n";
            strDados += "Código:" + cd_fornecedorTextBox.Text + "\n\n";
            strDados += "Nome:" + nm_fornecedorTextBox.Text + "\n\n";
            strDados += "Telefone:" + cd_telefoneTextBox.Text + "\n\n";
            strDados += "Nome do Contato:" + nm_contatoTextBox.Text + "\n\n";
            strDados += "Tipo:" + cd_tipoTextBox.Text + "\n\n";
            strDados += "CPF:" + cd_cpfTextBox.Text + "\n\n";
            strDados += "RG:" + cd_rgTextBox.Text + "\n\n";
            strDados += "Cnpj:" + cd_cnpjTextBox.Text + "\n\n";
            strDados += "Inscrição Estadual:" + cd_ieTextBox.Text + "\n\n";
            strDados += "Email:" + ds_emailTextBox.Text + "\n\n";
            strDados += "Endereço:" + ds_enderecoTextBox.Text + "\n\n";
            strDados += "Número:" + nr_enderecoTextBox.Text + "\n\n";
            strDados += "Bairro:" + nm_bairroTextBox.Text + "\n\n";
            strDados += "Cidade:" + nm_cidadeTextBox.Text + "\n\n";
            strDados += "Estado:" + sg_estadoTextBox.Text + "\n\n";
            strDados += "Cep:" + cd_cepTextBox.Text + "\n\n";


            objImpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 50, 50);
        }
    }
}
