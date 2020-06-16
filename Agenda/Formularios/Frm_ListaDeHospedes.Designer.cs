namespace Agenda.Formularios
{
    partial class Frm_ListaDeHospedes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ListaDeHospedes));
            this.Dvg_ListaHospd = new System.Windows.Forms.DataGridView();
            this.Btn_FinalizarH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_ListaHospd)).BeginInit();
            this.SuspendLayout();
            // 
            // Dvg_ListaHospd
            // 
            this.Dvg_ListaHospd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dvg_ListaHospd.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Dvg_ListaHospd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dvg_ListaHospd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dvg_ListaHospd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dvg_ListaHospd.GridColor = System.Drawing.SystemColors.HotTrack;
            this.Dvg_ListaHospd.Location = new System.Drawing.Point(2, 5);
            this.Dvg_ListaHospd.Margin = new System.Windows.Forms.Padding(2);
            this.Dvg_ListaHospd.Name = "Dvg_ListaHospd";
            this.Dvg_ListaHospd.Size = new System.Drawing.Size(657, 449);
            this.Dvg_ListaHospd.TabIndex = 0;
            // 
            // Btn_FinalizarH
            // 
            this.Btn_FinalizarH.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_FinalizarH.Location = new System.Drawing.Point(2, 459);
            this.Btn_FinalizarH.Name = "Btn_FinalizarH";
            this.Btn_FinalizarH.Size = new System.Drawing.Size(132, 29);
            this.Btn_FinalizarH.TabIndex = 1;
            this.Btn_FinalizarH.Text = "Finalizar Hospedagem";
            this.Btn_FinalizarH.UseVisualStyleBackColor = true;
            this.Btn_FinalizarH.Click += new System.EventHandler(this.Btn_FinalizarH_Click);
            // 
            // Frm_ListaDeHospedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(663, 489);
            this.Controls.Add(this.Btn_FinalizarH);
            this.Controls.Add(this.Dvg_ListaHospd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ListaDeHospedes";
            this.Text = "Lista de Hópedes";
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_ListaHospd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dvg_ListaHospd;
        private System.Windows.Forms.Button Btn_FinalizarH;
    }
}