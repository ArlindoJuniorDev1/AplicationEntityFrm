namespace Agenda
{
    partial class Frm_MenuPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MenuPrincipal));
            this.Pcb_CadClientes = new System.Windows.Forms.PictureBox();
            this.Pct_Hosped = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Hosped = new System.Windows.Forms.Label();
            this.Grp_Opcoes = new System.Windows.Forms.GroupBox();
            this.Lbl_ListaCadastros = new System.Windows.Forms.Label();
            this.Pcb_ListaCadastros = new System.Windows.Forms.PictureBox();
            this.Lbl_Hospedes = new System.Windows.Forms.Label();
            this.Pct_Hospedes = new System.Windows.Forms.PictureBox();
            this.Pct_Menu = new System.Windows.Forms.PictureBox();
            this.Lbl_HpFeitas = new System.Windows.Forms.Label();
            this.Pct_HospOcorr = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_CadClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_Hosped)).BeginInit();
            this.Grp_Opcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_ListaCadastros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_Hospedes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_HospOcorr)).BeginInit();
            this.SuspendLayout();
            // 
            // Pcb_CadClientes
            // 
            this.Pcb_CadClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pcb_CadClientes.Image = ((System.Drawing.Image)(resources.GetObject("Pcb_CadClientes.Image")));
            this.Pcb_CadClientes.Location = new System.Drawing.Point(6, 19);
            this.Pcb_CadClientes.Name = "Pcb_CadClientes";
            this.Pcb_CadClientes.Size = new System.Drawing.Size(50, 46);
            this.Pcb_CadClientes.TabIndex = 0;
            this.Pcb_CadClientes.TabStop = false;
            this.Pcb_CadClientes.Click += new System.EventHandler(this.Pcb_CadClientes_Click);
            // 
            // Pct_Hosped
            // 
            this.Pct_Hosped.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pct_Hosped.Image = ((System.Drawing.Image)(resources.GetObject("Pct_Hosped.Image")));
            this.Pct_Hosped.Location = new System.Drawing.Point(126, 19);
            this.Pct_Hosped.Name = "Pct_Hosped";
            this.Pct_Hosped.Size = new System.Drawing.Size(53, 46);
            this.Pct_Hosped.TabIndex = 8;
            this.Pct_Hosped.TabStop = false;
            this.Pct_Hosped.Click += new System.EventHandler(this.Pct_Hosped_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastrar Hóspedes";
            // 
            // Lbl_Hosped
            // 
            this.Lbl_Hosped.AutoSize = true;
            this.Lbl_Hosped.Location = new System.Drawing.Point(126, 67);
            this.Lbl_Hosped.Name = "Lbl_Hosped";
            this.Lbl_Hosped.Size = new System.Drawing.Size(53, 13);
            this.Lbl_Hosped.TabIndex = 3;
            this.Lbl_Hosped.Text = "Hospedar";
            // 
            // Grp_Opcoes
            // 
            this.Grp_Opcoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grp_Opcoes.Controls.Add(this.Lbl_HpFeitas);
            this.Grp_Opcoes.Controls.Add(this.Pct_HospOcorr);
            this.Grp_Opcoes.Controls.Add(this.Lbl_ListaCadastros);
            this.Grp_Opcoes.Controls.Add(this.Pcb_ListaCadastros);
            this.Grp_Opcoes.Controls.Add(this.Lbl_Hospedes);
            this.Grp_Opcoes.Controls.Add(this.Pct_Hospedes);
            this.Grp_Opcoes.Controls.Add(this.label1);
            this.Grp_Opcoes.Controls.Add(this.Lbl_Hosped);
            this.Grp_Opcoes.Controls.Add(this.Pcb_CadClientes);
            this.Grp_Opcoes.Controls.Add(this.Pct_Hosped);
            this.Grp_Opcoes.Location = new System.Drawing.Point(12, 21);
            this.Grp_Opcoes.Name = "Grp_Opcoes";
            this.Grp_Opcoes.Size = new System.Drawing.Size(712, 117);
            this.Grp_Opcoes.TabIndex = 4;
            this.Grp_Opcoes.TabStop = false;
            this.Grp_Opcoes.Text = "Opções";
            // 
            // Lbl_ListaCadastros
            // 
            this.Lbl_ListaCadastros.AutoSize = true;
            this.Lbl_ListaCadastros.Location = new System.Drawing.Point(497, 67);
            this.Lbl_ListaCadastros.Name = "Lbl_ListaCadastros";
            this.Lbl_ListaCadastros.Size = new System.Drawing.Size(82, 13);
            this.Lbl_ListaCadastros.TabIndex = 9;
            this.Lbl_ListaCadastros.Text = "Listar Cadastros";
            // 
            // Pcb_ListaCadastros
            // 
            this.Pcb_ListaCadastros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pcb_ListaCadastros.Image = ((System.Drawing.Image)(resources.GetObject("Pcb_ListaCadastros.Image")));
            this.Pcb_ListaCadastros.Location = new System.Drawing.Point(500, 19);
            this.Pcb_ListaCadastros.Name = "Pcb_ListaCadastros";
            this.Pcb_ListaCadastros.Size = new System.Drawing.Size(53, 46);
            this.Pcb_ListaCadastros.TabIndex = 10;
            this.Pcb_ListaCadastros.TabStop = false;
            this.Pcb_ListaCadastros.Click += new System.EventHandler(this.Pcb_ListaCadastros_Click);
            // 
            // Lbl_Hospedes
            // 
            this.Lbl_Hospedes.AutoSize = true;
            this.Lbl_Hospedes.Location = new System.Drawing.Point(369, 67);
            this.Lbl_Hospedes.Name = "Lbl_Hospedes";
            this.Lbl_Hospedes.Size = new System.Drawing.Size(95, 13);
            this.Lbl_Hospedes.TabIndex = 7;
            this.Lbl_Hospedes.Text = "Lista de Hóspedes";
            // 
            // Pct_Hospedes
            // 
            this.Pct_Hospedes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pct_Hospedes.Image = ((System.Drawing.Image)(resources.GetObject("Pct_Hospedes.Image")));
            this.Pct_Hospedes.Location = new System.Drawing.Point(372, 19);
            this.Pct_Hospedes.Name = "Pct_Hospedes";
            this.Pct_Hospedes.Size = new System.Drawing.Size(53, 46);
            this.Pct_Hospedes.TabIndex = 6;
            this.Pct_Hospedes.TabStop = false;
            this.Pct_Hospedes.Click += new System.EventHandler(this.Pct_Hospedes_Click);
            // 
            // Pct_Menu
            // 
            this.Pct_Menu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pct_Menu.Image = ((System.Drawing.Image)(resources.GetObject("Pct_Menu.Image")));
            this.Pct_Menu.Location = new System.Drawing.Point(257, 163);
            this.Pct_Menu.Name = "Pct_Menu";
            this.Pct_Menu.Size = new System.Drawing.Size(263, 259);
            this.Pct_Menu.TabIndex = 5;
            this.Pct_Menu.TabStop = false;
            // 
            // Lbl_HpFeitas
            // 
            this.Lbl_HpFeitas.AutoSize = true;
            this.Lbl_HpFeitas.Location = new System.Drawing.Point(242, 67);
            this.Lbl_HpFeitas.Name = "Lbl_HpFeitas";
            this.Lbl_HpFeitas.Size = new System.Drawing.Size(104, 13);
            this.Lbl_HpFeitas.TabIndex = 12;
            this.Lbl_HpFeitas.Text = "Hospedagens Feitas";
            // 
            // Pct_HospOcorr
            // 
            this.Pct_HospOcorr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pct_HospOcorr.Image = ((System.Drawing.Image)(resources.GetObject("Pct_HospOcorr.Image")));
            this.Pct_HospOcorr.Location = new System.Drawing.Point(245, 19);
            this.Pct_HospOcorr.Name = "Pct_HospOcorr";
            this.Pct_HospOcorr.Size = new System.Drawing.Size(53, 46);
            this.Pct_HospOcorr.TabIndex = 11;
            this.Pct_HospOcorr.TabStop = false;
            this.Pct_HospOcorr.Click += new System.EventHandler(this.Pct_HospOcorr_Click);
            // 
            // Frm_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(752, 484);
            this.Controls.Add(this.Pct_Menu);
            this.Controls.Add(this.Grp_Opcoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_MenuPrincipal";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_CadClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_Hosped)).EndInit();
            this.Grp_Opcoes.ResumeLayout(false);
            this.Grp_Opcoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_ListaCadastros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_Hospedes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_HospOcorr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pcb_CadClientes;
        private System.Windows.Forms.PictureBox Pct_Hosped;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Hosped;
        private System.Windows.Forms.GroupBox Grp_Opcoes;
        private System.Windows.Forms.Label Lbl_Hospedes;
        private System.Windows.Forms.PictureBox Pct_Hospedes;
        private System.Windows.Forms.PictureBox Pct_Menu;
        private System.Windows.Forms.Label Lbl_ListaCadastros;
        private System.Windows.Forms.PictureBox Pcb_ListaCadastros;
        private System.Windows.Forms.Label Lbl_HpFeitas;
        private System.Windows.Forms.PictureBox Pct_HospOcorr;
    }
}

