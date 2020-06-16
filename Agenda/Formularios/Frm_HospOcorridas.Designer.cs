namespace Agenda.Formularios
{
    partial class Frm_HospOcorridas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HospOcorridas));
            this.Dvg_OcorreHp = new System.Windows.Forms.DataGridView();
            this.clientesHospedadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDDataSet2 = new Agenda.BDDataSet2();
            this.Btn_Deletar = new System.Windows.Forms.Button();
            this.clientesHospedadosTableAdapter = new Agenda.BDDataSet2TableAdapters.ClientesHospedadosTableAdapter();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasHospedadosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHospedagemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorHospDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_OcorreHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesHospedadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // Dvg_OcorreHp
            // 
            this.Dvg_OcorreHp.AutoGenerateColumns = false;
            this.Dvg_OcorreHp.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Dvg_OcorreHp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dvg_OcorreHp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.diasHospedadosDataGridViewTextBoxColumn,
            this.dataHospedagemDataGridViewTextBoxColumn,
            this.valorHospDataGridViewTextBoxColumn});
            this.Dvg_OcorreHp.DataSource = this.clientesHospedadosBindingSource;
            this.Dvg_OcorreHp.GridColor = System.Drawing.SystemColors.HotTrack;
            this.Dvg_OcorreHp.Location = new System.Drawing.Point(2, 5);
            this.Dvg_OcorreHp.Name = "Dvg_OcorreHp";
            this.Dvg_OcorreHp.Size = new System.Drawing.Size(626, 414);
            this.Dvg_OcorreHp.TabIndex = 0;
            // 
            // clientesHospedadosBindingSource
            // 
            this.clientesHospedadosBindingSource.DataMember = "ClientesHospedados";
            this.clientesHospedadosBindingSource.DataSource = this.bDDataSet2;
            // 
            // bDDataSet2
            // 
            this.bDDataSet2.DataSetName = "BDDataSet2";
            this.bDDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Btn_Deletar
            // 
            this.Btn_Deletar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Deletar.Location = new System.Drawing.Point(2, 425);
            this.Btn_Deletar.Name = "Btn_Deletar";
            this.Btn_Deletar.Size = new System.Drawing.Size(155, 23);
            this.Btn_Deletar.TabIndex = 1;
            this.Btn_Deletar.Text = "Deletar Registro";
            this.Btn_Deletar.UseVisualStyleBackColor = true;
            this.Btn_Deletar.Click += new System.EventHandler(this.Btn_Deletar_Click);
            // 
            // clientesHospedadosTableAdapter
            // 
            this.clientesHospedadosTableAdapter.ClearBeforeFill = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // diasHospedadosDataGridViewTextBoxColumn
            // 
            this.diasHospedadosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diasHospedadosDataGridViewTextBoxColumn.DataPropertyName = "DiasHospedados";
            this.diasHospedadosDataGridViewTextBoxColumn.HeaderText = "Tempo Hospedado";
            this.diasHospedadosDataGridViewTextBoxColumn.Name = "diasHospedadosDataGridViewTextBoxColumn";
            // 
            // dataHospedagemDataGridViewTextBoxColumn
            // 
            this.dataHospedagemDataGridViewTextBoxColumn.DataPropertyName = "DataHospedagem";
            this.dataHospedagemDataGridViewTextBoxColumn.HeaderText = "Estadia";
            this.dataHospedagemDataGridViewTextBoxColumn.Name = "dataHospedagemDataGridViewTextBoxColumn";
            this.dataHospedagemDataGridViewTextBoxColumn.Width = 80;
            // 
            // valorHospDataGridViewTextBoxColumn
            // 
            this.valorHospDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valorHospDataGridViewTextBoxColumn.DataPropertyName = "ValorHosp";
            this.valorHospDataGridViewTextBoxColumn.HeaderText = "Valor Pago";
            this.valorHospDataGridViewTextBoxColumn.Name = "valorHospDataGridViewTextBoxColumn";
            // 
            // Frm_HospOcorridas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.Btn_Deletar);
            this.Controls.Add(this.Dvg_OcorreHp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_HospOcorridas";
            this.Text = "Hospedagens ocorridas";
            this.Load += new System.EventHandler(this.Frm_HospOcorridas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_OcorreHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesHospedadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dvg_OcorreHp;
        private System.Windows.Forms.Button Btn_Deletar;
        private BDDataSet2 bDDataSet2;
        private System.Windows.Forms.BindingSource clientesHospedadosBindingSource;
        private BDDataSet2TableAdapters.ClientesHospedadosTableAdapter clientesHospedadosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasHospedadosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHospedagemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorHospDataGridViewTextBoxColumn;
    }
}