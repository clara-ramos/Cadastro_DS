﻿
namespace FormsBd
{
    partial class frmPesquisaFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisaFornecedor));
            this.bdDataSet = new FormsBd.BdDataSet();
            this.tbfornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbfornecedorTableAdapter = new FormsBd.BdDataSetTableAdapters.tbfornecedorTableAdapter();
            this.tableAdapterManager = new FormsBd.BdDataSetTableAdapters.TableAdapterManager();
            this.tbfornecedorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfornecedorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bdDataSet
            // 
            this.bdDataSet.DataSetName = "BdDataSet";
            this.bdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbfornecedorBindingSource
            // 
            this.tbfornecedorBindingSource.DataMember = "tbfornecedor";
            this.tbfornecedorBindingSource.DataSource = this.bdDataSet;
            // 
            // tbfornecedorTableAdapter
            // 
            this.tbfornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbclienteTableAdapter = null;
            this.tableAdapterManager.tbfornecedorTableAdapter = this.tbfornecedorTableAdapter;
            this.tableAdapterManager.tbprodutoTableAdapter = null;
            this.tableAdapterManager.tbusuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FormsBd.BdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbfornecedorDataGridView
            // 
            this.tbfornecedorDataGridView.AllowUserToAddRows = false;
            this.tbfornecedorDataGridView.AllowUserToDeleteRows = false;
            this.tbfornecedorDataGridView.AutoGenerateColumns = false;
            this.tbfornecedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbfornecedorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tbfornecedorDataGridView.DataSource = this.tbfornecedorBindingSource;
            this.tbfornecedorDataGridView.Location = new System.Drawing.Point(23, 127);
            this.tbfornecedorDataGridView.Name = "tbfornecedorDataGridView";
            this.tbfornecedorDataGridView.ReadOnly = true;
            this.tbfornecedorDataGridView.Size = new System.Drawing.Size(731, 220);
            this.tbfornecedorDataGridView.TabIndex = 1;
            this.tbfornecedorDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbfornecedorDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cd_fornecedor";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código:";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nm_fornecedor";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome:";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 630;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(355, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(92, 48);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(661, 26);
            this.txtNome.TabIndex = 4;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // frmPesquisaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbfornecedorDataGridView);
            this.Name = "frmPesquisaFornecedor";
            this.Text = "Pesquisa de Fornecedor";
            this.Load += new System.EventHandler(this.frmPesquisaFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfornecedorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BdDataSet bdDataSet;
        private System.Windows.Forms.BindingSource tbfornecedorBindingSource;
        private BdDataSetTableAdapters.tbfornecedorTableAdapter tbfornecedorTableAdapter;
        private BdDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tbfornecedorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
    }
}