namespace Agenda.Formularios
{
    partial class Frm_CadastrarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastrarClientes));
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Txt_Logradouro = new System.Windows.Forms.TextBox();
            this.Txt_Bairro = new System.Windows.Forms.TextBox();
            this.Lbl_NomeCliente = new System.Windows.Forms.Label();
            this.Lbl_Logradouro = new System.Windows.Forms.Label();
            this.Lbl_Bairro = new System.Windows.Forms.Label();
            this.Lbl_Cep = new System.Windows.Forms.Label();
            this.Txt_Numero = new System.Windows.Forms.TextBox();
            this.Lbl_Numero = new System.Windows.Forms.Label();
            this.Grp_Endereco = new System.Windows.Forms.GroupBox();
            this.Lbl_CompEnd = new System.Windows.Forms.Label();
            this.Txt_CompEnd = new System.Windows.Forms.TextBox();
            this.Txt_Cep = new System.Windows.Forms.TextBox();
            this.Txt_Cidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cmb_UF = new System.Windows.Forms.ComboBox();
            this.Lbl_CPF = new System.Windows.Forms.Label();
            this.Msk_CPF = new System.Windows.Forms.MaskedTextBox();
            this.Msk_Rg = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CompC = new System.Windows.Forms.TextBox();
            this.Lbl_CompCad = new System.Windows.Forms.Label();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Rdb_Feminino = new System.Windows.Forms.RadioButton();
            this.Grp_Genero = new System.Windows.Forms.GroupBox();
            this.Rdb_Masculino = new System.Windows.Forms.RadioButton();
            this.Grp_Endereco.SuspendLayout();
            this.Grp_Genero.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Location = new System.Drawing.Point(34, 35);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(230, 20);
            this.Txt_Nome.TabIndex = 0;
            // 
            // Txt_Logradouro
            // 
            this.Txt_Logradouro.Location = new System.Drawing.Point(9, 32);
            this.Txt_Logradouro.Name = "Txt_Logradouro";
            this.Txt_Logradouro.Size = new System.Drawing.Size(321, 20);
            this.Txt_Logradouro.TabIndex = 1;
            // 
            // Txt_Bairro
            // 
            this.Txt_Bairro.Location = new System.Drawing.Point(9, 90);
            this.Txt_Bairro.Name = "Txt_Bairro";
            this.Txt_Bairro.Size = new System.Drawing.Size(100, 20);
            this.Txt_Bairro.TabIndex = 2;
            // 
            // Lbl_NomeCliente
            // 
            this.Lbl_NomeCliente.AutoSize = true;
            this.Lbl_NomeCliente.Location = new System.Drawing.Point(31, 19);
            this.Lbl_NomeCliente.Name = "Lbl_NomeCliente";
            this.Lbl_NomeCliente.Size = new System.Drawing.Size(35, 13);
            this.Lbl_NomeCliente.TabIndex = 3;
            this.Lbl_NomeCliente.Text = "Nome";
            // 
            // Lbl_Logradouro
            // 
            this.Lbl_Logradouro.AutoSize = true;
            this.Lbl_Logradouro.Location = new System.Drawing.Point(6, 16);
            this.Lbl_Logradouro.Name = "Lbl_Logradouro";
            this.Lbl_Logradouro.Size = new System.Drawing.Size(61, 13);
            this.Lbl_Logradouro.TabIndex = 4;
            this.Lbl_Logradouro.Text = "Logradouro";
            // 
            // Lbl_Bairro
            // 
            this.Lbl_Bairro.AutoSize = true;
            this.Lbl_Bairro.Location = new System.Drawing.Point(6, 74);
            this.Lbl_Bairro.Name = "Lbl_Bairro";
            this.Lbl_Bairro.Size = new System.Drawing.Size(34, 13);
            this.Lbl_Bairro.TabIndex = 5;
            this.Lbl_Bairro.Text = "Bairro";
            // 
            // Lbl_Cep
            // 
            this.Lbl_Cep.AutoSize = true;
            this.Lbl_Cep.Location = new System.Drawing.Point(257, 74);
            this.Lbl_Cep.Name = "Lbl_Cep";
            this.Lbl_Cep.Size = new System.Drawing.Size(26, 13);
            this.Lbl_Cep.TabIndex = 7;
            this.Lbl_Cep.Text = "Cep";
            // 
            // Txt_Numero
            // 
            this.Txt_Numero.Location = new System.Drawing.Point(137, 90);
            this.Txt_Numero.Name = "Txt_Numero";
            this.Txt_Numero.Size = new System.Drawing.Size(100, 20);
            this.Txt_Numero.TabIndex = 8;
            // 
            // Lbl_Numero
            // 
            this.Lbl_Numero.AutoSize = true;
            this.Lbl_Numero.Location = new System.Drawing.Point(134, 74);
            this.Lbl_Numero.Name = "Lbl_Numero";
            this.Lbl_Numero.Size = new System.Drawing.Size(44, 13);
            this.Lbl_Numero.TabIndex = 9;
            this.Lbl_Numero.Text = "Numero";
            // 
            // Grp_Endereco
            // 
            this.Grp_Endereco.Controls.Add(this.Lbl_CompEnd);
            this.Grp_Endereco.Controls.Add(this.Txt_CompEnd);
            this.Grp_Endereco.Controls.Add(this.Txt_Cep);
            this.Grp_Endereco.Controls.Add(this.Txt_Cidade);
            this.Grp_Endereco.Controls.Add(this.label4);
            this.Grp_Endereco.Controls.Add(this.label3);
            this.Grp_Endereco.Controls.Add(this.Cmb_UF);
            this.Grp_Endereco.Controls.Add(this.Lbl_Logradouro);
            this.Grp_Endereco.Controls.Add(this.Lbl_Numero);
            this.Grp_Endereco.Controls.Add(this.Txt_Logradouro);
            this.Grp_Endereco.Controls.Add(this.Txt_Numero);
            this.Grp_Endereco.Controls.Add(this.Txt_Bairro);
            this.Grp_Endereco.Controls.Add(this.Lbl_Cep);
            this.Grp_Endereco.Controls.Add(this.Lbl_Bairro);
            this.Grp_Endereco.Location = new System.Drawing.Point(25, 148);
            this.Grp_Endereco.Name = "Grp_Endereco";
            this.Grp_Endereco.Size = new System.Drawing.Size(638, 126);
            this.Grp_Endereco.TabIndex = 10;
            this.Grp_Endereco.TabStop = false;
            this.Grp_Endereco.Text = "Endereço";
            // 
            // Lbl_CompEnd
            // 
            this.Lbl_CompEnd.AutoSize = true;
            this.Lbl_CompEnd.Location = new System.Drawing.Point(444, 16);
            this.Lbl_CompEnd.Name = "Lbl_CompEnd";
            this.Lbl_CompEnd.Size = new System.Drawing.Size(71, 13);
            this.Lbl_CompEnd.TabIndex = 22;
            this.Lbl_CompEnd.Text = "Complemento";
            // 
            // Txt_CompEnd
            // 
            this.Txt_CompEnd.Location = new System.Drawing.Point(444, 31);
            this.Txt_CompEnd.Multiline = true;
            this.Txt_CompEnd.Name = "Txt_CompEnd";
            this.Txt_CompEnd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt_CompEnd.Size = new System.Drawing.Size(188, 42);
            this.Txt_CompEnd.TabIndex = 21;
            // 
            // Txt_Cep
            // 
            this.Txt_Cep.Location = new System.Drawing.Point(260, 90);
            this.Txt_Cep.Name = "Txt_Cep";
            this.Txt_Cep.Size = new System.Drawing.Size(70, 20);
            this.Txt_Cep.TabIndex = 20;
            this.Txt_Cep.Leave += new System.EventHandler(this.Txt_Cep_Leave);
            // 
            // Txt_Cidade
            // 
            this.Txt_Cidade.Location = new System.Drawing.Point(353, 90);
            this.Txt_Cidade.Name = "Txt_Cidade";
            this.Txt_Cidade.Size = new System.Drawing.Size(100, 20);
            this.Txt_Cidade.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "UF";
            // 
            // Cmb_UF
            // 
            this.Cmb_UF.FormattingEnabled = true;
            this.Cmb_UF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.Cmb_UF.Location = new System.Drawing.Point(353, 31);
            this.Cmb_UF.Name = "Cmb_UF";
            this.Cmb_UF.Size = new System.Drawing.Size(62, 21);
            this.Cmb_UF.TabIndex = 16;
            // 
            // Lbl_CPF
            // 
            this.Lbl_CPF.AutoSize = true;
            this.Lbl_CPF.Location = new System.Drawing.Point(311, 19);
            this.Lbl_CPF.Name = "Lbl_CPF";
            this.Lbl_CPF.Size = new System.Drawing.Size(27, 13);
            this.Lbl_CPF.TabIndex = 12;
            this.Lbl_CPF.Text = "CPF";
            // 
            // Msk_CPF
            // 
            this.Msk_CPF.Location = new System.Drawing.Point(314, 35);
            this.Msk_CPF.Mask = "000,000,000-00";
            this.Msk_CPF.Name = "Msk_CPF";
            this.Msk_CPF.Size = new System.Drawing.Size(100, 20);
            this.Msk_CPF.TabIndex = 13;
            // 
            // Msk_Rg
            // 
            this.Msk_Rg.Location = new System.Drawing.Point(34, 83);
            this.Msk_Rg.Name = "Msk_Rg";
            this.Msk_Rg.Size = new System.Drawing.Size(100, 20);
            this.Msk_Rg.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Rg";
            // 
            // txt_CompC
            // 
            this.txt_CompC.Location = new System.Drawing.Point(25, 306);
            this.txt_CompC.Multiline = true;
            this.txt_CompC.Name = "txt_CompC";
            this.txt_CompC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_CompC.Size = new System.Drawing.Size(397, 98);
            this.txt_CompC.TabIndex = 16;
            // 
            // Lbl_CompCad
            // 
            this.Lbl_CompCad.AutoSize = true;
            this.Lbl_CompCad.Location = new System.Drawing.Point(23, 290);
            this.Lbl_CompCad.Name = "Lbl_CompCad";
            this.Lbl_CompCad.Size = new System.Drawing.Size(130, 13);
            this.Lbl_CompCad.TabIndex = 17;
            this.Lbl_CompCad.Text = "Complemento ao cadastro";
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Location = new System.Drawing.Point(25, 419);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Salvar.TabIndex = 18;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Rdb_Feminino
            // 
            this.Rdb_Feminino.AutoSize = true;
            this.Rdb_Feminino.Location = new System.Drawing.Point(109, 19);
            this.Rdb_Feminino.Name = "Rdb_Feminino";
            this.Rdb_Feminino.Size = new System.Drawing.Size(67, 17);
            this.Rdb_Feminino.TabIndex = 19;
            this.Rdb_Feminino.TabStop = true;
            this.Rdb_Feminino.Text = "Feminino";
            this.Rdb_Feminino.UseVisualStyleBackColor = true;
            // 
            // Grp_Genero
            // 
            this.Grp_Genero.Controls.Add(this.Rdb_Masculino);
            this.Grp_Genero.Controls.Add(this.Rdb_Feminino);
            this.Grp_Genero.Location = new System.Drawing.Point(314, 67);
            this.Grp_Genero.Name = "Grp_Genero";
            this.Grp_Genero.Size = new System.Drawing.Size(200, 59);
            this.Grp_Genero.TabIndex = 20;
            this.Grp_Genero.TabStop = false;
            this.Grp_Genero.Text = "Genero";
            // 
            // Rdb_Masculino
            // 
            this.Rdb_Masculino.AutoSize = true;
            this.Rdb_Masculino.Location = new System.Drawing.Point(9, 19);
            this.Rdb_Masculino.Name = "Rdb_Masculino";
            this.Rdb_Masculino.Size = new System.Drawing.Size(73, 17);
            this.Rdb_Masculino.TabIndex = 20;
            this.Rdb_Masculino.TabStop = true;
            this.Rdb_Masculino.Text = "Masculino";
            this.Rdb_Masculino.UseVisualStyleBackColor = true;
            // 
            // Frm_CadastrarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 454);
            this.Controls.Add(this.Grp_Genero);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.Lbl_CompCad);
            this.Controls.Add(this.txt_CompC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Msk_Rg);
            this.Controls.Add(this.Msk_CPF);
            this.Controls.Add(this.Lbl_CPF);
            this.Controls.Add(this.Grp_Endereco);
            this.Controls.Add(this.Lbl_NomeCliente);
            this.Controls.Add(this.Txt_Nome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_CadastrarClientes";
            this.Text = "CadastrarClientes";
            this.Grp_Endereco.ResumeLayout(false);
            this.Grp_Endereco.PerformLayout();
            this.Grp_Genero.ResumeLayout(false);
            this.Grp_Genero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.TextBox Txt_Logradouro;
        private System.Windows.Forms.TextBox Txt_Bairro;
        private System.Windows.Forms.Label Lbl_NomeCliente;
        private System.Windows.Forms.Label Lbl_Logradouro;
        private System.Windows.Forms.Label Lbl_Bairro;
        private System.Windows.Forms.Label Lbl_Cep;
        private System.Windows.Forms.TextBox Txt_Numero;
        private System.Windows.Forms.Label Lbl_Numero;
        private System.Windows.Forms.GroupBox Grp_Endereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cmb_UF;
        private System.Windows.Forms.Label Lbl_CPF;
        private System.Windows.Forms.MaskedTextBox Msk_CPF;
        private System.Windows.Forms.MaskedTextBox Msk_Rg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CompC;
        private System.Windows.Forms.Label Lbl_CompCad;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.RadioButton Rdb_Feminino;
        private System.Windows.Forms.GroupBox Grp_Genero;
        private System.Windows.Forms.RadioButton Rdb_Masculino;
        private System.Windows.Forms.TextBox Txt_Cep;
        private System.Windows.Forms.TextBox Txt_Cidade;
        private System.Windows.Forms.Label Lbl_CompEnd;
        private System.Windows.Forms.TextBox Txt_CompEnd;
    }
}