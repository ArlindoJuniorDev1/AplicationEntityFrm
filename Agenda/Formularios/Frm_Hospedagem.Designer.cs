namespace Agenda.Formularios
{
    partial class Frm_Hospedagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Hospedagem));
            this.Lbl_Clientes = new System.Windows.Forms.Label();
            this.bDDataSet = new Agenda.BDDataSet();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new Agenda.BDDataSetTableAdapters.ClientesTableAdapter();
            this.Txt_Quarto = new System.Windows.Forms.TextBox();
            this.Lbl_Quarto = new System.Windows.Forms.Label();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Cmb_Cliente = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.Txt_Dias = new System.Windows.Forms.TextBox();
            this.Lbl_Estadia = new System.Windows.Forms.Label();
            this.Lbl_Valor2 = new System.Windows.Forms.Label();
            this.Lbl_Valor = new System.Windows.Forms.Label();
            this.Btn_VerPreco = new System.Windows.Forms.Button();
            this.Grp_TpHosp = new System.Windows.Forms.GroupBox();
            this.Rdb_Dias = new System.Windows.Forms.RadioButton();
            this.Rdb_Mes = new System.Windows.Forms.RadioButton();
            this.Rdb_Ano = new System.Windows.Forms.RadioButton();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bDDataSet1 = new Agenda.BDDataSet1();
            this.clientesBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter1 = new Agenda.BDDataSet1TableAdapters.ClientesTableAdapter();
            this.Txt_DataHp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).BeginInit();
            this.Grp_TpHosp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Clientes
            // 
            this.Lbl_Clientes.AutoSize = true;
            this.Lbl_Clientes.Location = new System.Drawing.Point(15, 21);
            this.Lbl_Clientes.Name = "Lbl_Clientes";
            this.Lbl_Clientes.Size = new System.Drawing.Size(39, 13);
            this.Lbl_Clientes.TabIndex = 1;
            this.Lbl_Clientes.Text = "Cliente";
            // 
            // bDDataSet
            // 
            this.bDDataSet.DataSetName = "BDDataSet";
            this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.bDDataSet;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // Txt_Quarto
            // 
            this.Txt_Quarto.Location = new System.Drawing.Point(59, 59);
            this.Txt_Quarto.Name = "Txt_Quarto";
            this.Txt_Quarto.Size = new System.Drawing.Size(85, 20);
            this.Txt_Quarto.TabIndex = 2;
            // 
            // Lbl_Quarto
            // 
            this.Lbl_Quarto.AutoSize = true;
            this.Lbl_Quarto.Location = new System.Drawing.Point(9, 62);
            this.Lbl_Quarto.Name = "Lbl_Quarto";
            this.Lbl_Quarto.Size = new System.Drawing.Size(39, 13);
            this.Lbl_Quarto.TabIndex = 3;
            this.Lbl_Quarto.Text = "Quarto";
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Location = new System.Drawing.Point(28, 255);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(75, 20);
            this.Btn_Salvar.TabIndex = 4;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Cmb_Cliente
            // 
            this.Cmb_Cliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientesBindingSource, "Nome", true));
            this.Cmb_Cliente.DataSource = this.clientesBindingSource;
            this.Cmb_Cliente.DisplayMember = "Nome";
            this.Cmb_Cliente.FormattingEnabled = true;
            this.Cmb_Cliente.Location = new System.Drawing.Point(60, 18);
            this.Cmb_Cliente.Name = "Cmb_Cliente";
            this.Cmb_Cliente.Size = new System.Drawing.Size(389, 21);
            this.Cmb_Cliente.TabIndex = 6;
            this.Cmb_Cliente.ValueMember = "Nome";
            // 
            // clientesBindingSource2
            // 
            this.clientesBindingSource2.DataMember = "Clientes";
            this.clientesBindingSource2.DataSource = this.bDDataSet;
            // 
            // Txt_Dias
            // 
            this.Txt_Dias.Location = new System.Drawing.Point(59, 99);
            this.Txt_Dias.Name = "Txt_Dias";
            this.Txt_Dias.Size = new System.Drawing.Size(85, 20);
            this.Txt_Dias.TabIndex = 7;
            // 
            // Lbl_Estadia
            // 
            this.Lbl_Estadia.AutoSize = true;
            this.Lbl_Estadia.Location = new System.Drawing.Point(9, 102);
            this.Lbl_Estadia.Name = "Lbl_Estadia";
            this.Lbl_Estadia.Size = new System.Drawing.Size(42, 13);
            this.Lbl_Estadia.TabIndex = 8;
            this.Lbl_Estadia.Text = "Estadia";
            // 
            // Lbl_Valor2
            // 
            this.Lbl_Valor2.AutoSize = true;
            this.Lbl_Valor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Valor2.Location = new System.Drawing.Point(75, 43);
            this.Lbl_Valor2.Name = "Lbl_Valor2";
            this.Lbl_Valor2.Size = new System.Drawing.Size(38, 15);
            this.Lbl_Valor2.TabIndex = 9;
            this.Lbl_Valor2.Text = "Valor:";
            // 
            // Lbl_Valor
            // 
            this.Lbl_Valor.AutoSize = true;
            this.Lbl_Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Valor.Location = new System.Drawing.Point(119, 43);
            this.Lbl_Valor.Name = "Lbl_Valor";
            this.Lbl_Valor.Size = new System.Drawing.Size(14, 15);
            this.Lbl_Valor.TabIndex = 10;
            this.Lbl_Valor.Text = "0";
            // 
            // Btn_VerPreco
            // 
            this.Btn_VerPreco.Location = new System.Drawing.Point(78, 20);
            this.Btn_VerPreco.Name = "Btn_VerPreco";
            this.Btn_VerPreco.Size = new System.Drawing.Size(75, 20);
            this.Btn_VerPreco.TabIndex = 11;
            this.Btn_VerPreco.Text = "Ver valor";
            this.Btn_VerPreco.UseVisualStyleBackColor = true;
            this.Btn_VerPreco.Click += new System.EventHandler(this.Btn_VerPreco_Click);
            // 
            // Grp_TpHosp
            // 
            this.Grp_TpHosp.Controls.Add(this.Rdb_Dias);
            this.Grp_TpHosp.Controls.Add(this.Rdb_Mes);
            this.Grp_TpHosp.Controls.Add(this.Rdb_Ano);
            this.Grp_TpHosp.Controls.Add(this.Lbl_Valor);
            this.Grp_TpHosp.Controls.Add(this.Btn_VerPreco);
            this.Grp_TpHosp.Controls.Add(this.Lbl_Valor2);
            this.Grp_TpHosp.Location = new System.Drawing.Point(12, 125);
            this.Grp_TpHosp.Name = "Grp_TpHosp";
            this.Grp_TpHosp.Size = new System.Drawing.Size(248, 100);
            this.Grp_TpHosp.TabIndex = 13;
            this.Grp_TpHosp.TabStop = false;
            this.Grp_TpHosp.Text = "Calcular em:";
            // 
            // Rdb_Dias
            // 
            this.Rdb_Dias.AutoSize = true;
            this.Rdb_Dias.Location = new System.Drawing.Point(6, 64);
            this.Rdb_Dias.Name = "Rdb_Dias";
            this.Rdb_Dias.Size = new System.Drawing.Size(46, 17);
            this.Rdb_Dias.TabIndex = 17;
            this.Rdb_Dias.TabStop = true;
            this.Rdb_Dias.Text = "Dias";
            this.Rdb_Dias.UseVisualStyleBackColor = true;
            // 
            // Rdb_Mes
            // 
            this.Rdb_Mes.AutoSize = true;
            this.Rdb_Mes.Location = new System.Drawing.Point(6, 41);
            this.Rdb_Mes.Name = "Rdb_Mes";
            this.Rdb_Mes.Size = new System.Drawing.Size(45, 17);
            this.Rdb_Mes.TabIndex = 16;
            this.Rdb_Mes.TabStop = true;
            this.Rdb_Mes.Text = "Mês";
            this.Rdb_Mes.UseVisualStyleBackColor = true;
            // 
            // Rdb_Ano
            // 
            this.Rdb_Ano.AutoSize = true;
            this.Rdb_Ano.Location = new System.Drawing.Point(6, 22);
            this.Rdb_Ano.Name = "Rdb_Ano";
            this.Rdb_Ano.Size = new System.Drawing.Size(44, 17);
            this.Rdb_Ano.TabIndex = 15;
            this.Rdb_Ano.TabStop = true;
            this.Rdb_Ano.Text = "Ano";
            this.Rdb_Ano.UseVisualStyleBackColor = true;
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "Clientes";
            this.clientesBindingSource1.DataSource = this.bDDataSet;
            // 
            // clientesBindingSource3
            // 
            this.clientesBindingSource3.DataMember = "Clientes";
            this.clientesBindingSource3.DataSource = this.bDDataSet;
            // 
            // bDDataSet1
            // 
            this.bDDataSet1.DataSetName = "BDDataSet1";
            this.bDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource4
            // 
            this.clientesBindingSource4.DataMember = "Clientes";
            this.clientesBindingSource4.DataSource = this.bDDataSet1;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // Txt_DataHp
            // 
            this.Txt_DataHp.Location = new System.Drawing.Point(382, 45);
            this.Txt_DataHp.Name = "Txt_DataHp";
            this.Txt_DataHp.Size = new System.Drawing.Size(67, 20);
            this.Txt_DataHp.TabIndex = 14;
            // 
            // Frm_Hospedagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 287);
            this.Controls.Add(this.Txt_DataHp);
            this.Controls.Add(this.Grp_TpHosp);
            this.Controls.Add(this.Lbl_Estadia);
            this.Controls.Add(this.Txt_Dias);
            this.Controls.Add(this.Cmb_Cliente);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.Lbl_Quarto);
            this.Controls.Add(this.Txt_Quarto);
            this.Controls.Add(this.Lbl_Clientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Hospedagem";
            this.Text = "Hospedagem";
            this.Load += new System.EventHandler(this.Frm_Hospedagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).EndInit();
            this.Grp_TpHosp.ResumeLayout(false);
            this.Grp_TpHosp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Clientes;
        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private BDDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.TextBox Txt_Quarto;
        private System.Windows.Forms.Label Lbl_Quarto;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.ComboBox Cmb_Cliente;
        private System.Windows.Forms.TextBox Txt_Dias;
        private System.Windows.Forms.Label Lbl_Estadia;
        private System.Windows.Forms.Label Lbl_Valor2;
        private System.Windows.Forms.Label Lbl_Valor;
        private System.Windows.Forms.Button Btn_VerPreco;
        private System.Windows.Forms.GroupBox Grp_TpHosp;
        private System.Windows.Forms.RadioButton Rdb_Dias;
        private System.Windows.Forms.RadioButton Rdb_Mes;
        private System.Windows.Forms.RadioButton Rdb_Ano;
        private System.Windows.Forms.BindingSource clientesBindingSource2;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private System.Windows.Forms.BindingSource clientesBindingSource3;
        private BDDataSet1 bDDataSet1;
        private System.Windows.Forms.BindingSource clientesBindingSource4;
        private BDDataSet1TableAdapters.ClientesTableAdapter clientesTableAdapter1;
        private System.Windows.Forms.TextBox Txt_DataHp;
    }
}