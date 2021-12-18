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
    public partial class frmCliente : Form
    {

        private void Habilita()
        {
            cd_clienteTextBox.Enabled = true;
            nm_clienteTextBox.Enabled = true;
            cd_telefoneTextBox.Enabled = true;
            cd_cpfTextBox.Enabled = true;
            cd_rgTextBox.Enabled = true;
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
            cd_clienteTextBox.Enabled = false;
            nm_clienteTextBox.Enabled = false;
            cd_telefoneTextBox.Enabled = false;
            cd_cpfTextBox.Enabled = false;
            cd_rgTextBox.Enabled = false;
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

        public frmCliente()
        {
            InitializeComponent();
        }


        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdDataSet.tbcliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbclienteTableAdapter.Fill(this.bdDataSet.tbcliente);

        }

        private void nr_enderecoLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbclienteBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbclienteBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbclienteBindingSource.AddNew();
            Habilita();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tbclienteBindingSource.RemoveCurrent();
            tbclienteTableAdapter.Update(bdDataSet.tbcliente);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbclienteBindingSource.EndEdit();
            tbclienteTableAdapter.Update(bdDataSet.tbcliente);
            Desabilita();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbclienteBindingSource.CancelEdit();
            Desabilita();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int cod, reg;
            frmPesquisaCliente fpc = new frmPesquisaCliente();
            fpc.ShowDialog();
            cod = fpc.getCodigo();
            if (cod > 0)
            {
                reg = tbclienteBindingSource.Find("cd_cliente", cod);
                tbclienteBindingSource.Position = reg;
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



            strDados = "Ficha do Cliente \n\n";
            strDados += "Código:" + cd_clienteTextBox.Text + "\n\n";
            strDados += "Nome:" + nm_clienteTextBox.Text + "\n\n";
            strDados += "Endereço:" + ds_enderecoTextBox.Text + "\n\n";
            strDados += "Cidade:" + nm_cidadeTextBox.Text + "\n\n";
            strDados += "E-mail:" + ds_emailTextBox.Text + "\n\n";
            strDados += "Telefone:" + cd_telefoneTextBox.Text + "\n\n";
            strDados += "CPF:" + cd_cpfTextBox.Text + "\n\n";
            strDados += "RG:" + cd_rgTextBox.Text + "\n\n";



            objImpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 50, 50);
        }
    }
}
