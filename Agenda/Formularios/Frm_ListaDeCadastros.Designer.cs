namespace Agenda.Formularios
{
    partial class Frm_ListaDeCad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ListaDeCad));
            this.bDDataSet3 = new Agenda.BDDataSet3();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new Agenda.BDDataSet3TableAdapters.ClientesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logradouroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ufDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bDDataSet5 = new Agenda.BDDataSet5();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bDDataSet4 = new Agenda.BDDataSet4();
            this.clientesTableAdapter1 = new Agenda.BDDataSet4TableAdapters.ClientesTableAdapter();
            this.clientesTableAdapter2 = new Agenda.BDDataSet5TableAdapters.ClientesTableAdapter();
            this.Btn_DeletarCad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // bDDataSet3
            // 
            this.bDDataSet3.DataSetName = "BDDataSet3";
            this.bDDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.bDDataSet3;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.rgDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.logradouroDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.localidadeDataGridViewTextBoxColumn,
            this.ufDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientesBindingSource2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView1.Location = new System.Drawing.Point(4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(815, 417);
            this.dataGridView1.TabIndex = 0;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rgDataGridViewTextBoxColumn
            // 
            this.rgDataGridViewTextBoxColumn.DataPropertyName = "Rg";
            this.rgDataGridViewTextBoxColumn.HeaderText = "Rg";
            this.rgDataGridViewTextBoxColumn.Name = "rgDataGridViewTextBoxColumn";
            this.rgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logradouroDataGridViewTextBoxColumn
            // 
            this.logradouroDataGridViewTextBoxColumn.DataPropertyName = "logradouro";
            this.logradouroDataGridViewTextBoxColumn.HeaderText = "logradouro";
            this.logradouroDataGridViewTextBoxColumn.Name = "logradouroDataGridViewTextBoxColumn";
            this.logradouroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localidadeDataGridViewTextBoxColumn
            // 
            this.localidadeDataGridViewTextBoxColumn.DataPropertyName = "localidade";
            this.localidadeDataGridViewTextBoxColumn.HeaderText = "localidade";
            this.localidadeDataGridViewTextBoxColumn.Name = "localidadeDataGridViewTextBoxColumn";
            this.localidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ufDataGridViewTextBoxColumn
            // 
            this.ufDataGridViewTextBoxColumn.DataPropertyName = "uf";
            this.ufDataGridViewTextBoxColumn.HeaderText = "uf";
            this.ufDataGridViewTextBoxColumn.Name = "ufDataGridViewTextBoxColumn";
            this.ufDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientesBindingSource2
            // 
            this.clientesBindingSource2.DataMember = "Clientes";
            this.clientesBindingSource2.DataSource = this.bDDataSet5;
            // 
            // bDDataSet5
            // 
            this.bDDataSet5.DataSetName = "BDDataSet5";
            this.bDDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "Clientes";
            this.clientesBindingSource1.DataSource = this.bDDataSet4;
            // 
            // bDDataSet4
            // 
            this.bDDataSet4.DataSetName = "BDDataSet4";
            this.bDDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // clientesTableAdapter2
            // 
            this.clientesTableAdapter2.ClearBeforeFill = true;
            // 
            // Btn_DeletarCad
            // 
            this.Btn_DeletarCad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_DeletarCad.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_DeletarCad.Location = new System.Drawing.Point(4, 426);
            this.Btn_DeletarCad.Name = "Btn_DeletarCad";
            this.Btn_DeletarCad.Size = new System.Drawing.Size(102, 23);
            this.Btn_DeletarCad.TabIndex = 1;
            this.Btn_DeletarCad.Text = "Deletar cadastro";
            this.Btn_DeletarCad.UseVisualStyleBackColor = true;
            this.Btn_DeletarCad.Click += new System.EventHandler(this.Btn_DeletarCad_Click);
            // 
            // Frm_ListaDeCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.Btn_DeletarCad);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ListaDeCad";
            this.Text = "Lista de cadastro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_ListaDeCadastros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BDDataSet3 bDDataSet3;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private BDDataSet3TableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BDDataSet4 bDDataSet4;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private BDDataSet4TableAdapters.ClientesTableAdapter clientesTableAdapter1;
        private BDDataSet5 bDDataSet5;
        private System.Windows.Forms.BindingSource clientesBindingSource2;
        private BDDataSet5TableAdapters.ClientesTableAdapter clientesTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ufDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Btn_DeletarCad;
    }
}