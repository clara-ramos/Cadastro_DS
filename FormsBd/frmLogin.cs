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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbusuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbusuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdDataSet);

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdDataSet.tbusuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbusuarioTableAdapter.Fill(this.bdDataSet.tbusuario);

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            tbusuarioTableAdapter.FillLogin(bdDataSet.tbusuario, txtLogin.Text, txtSenha.Text);
            if (txtLogin.Text=="adm" && txtSenha.Text=="123" || tbusuarioBindingSource.Count > 0)
            {
                frmPrincipal fp = new frmPrincipal();
                fp.Show();
            }
            else
            {
                MessageBox.Show("Login ou senha inválida !!!");
            }
        }
    }
}
