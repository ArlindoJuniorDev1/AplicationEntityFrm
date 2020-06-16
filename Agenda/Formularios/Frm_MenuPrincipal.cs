using Agenda.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Frm_MenuPrincipal : Form
    {
        public Frm_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Pcb_CadClientes_Click(object sender, EventArgs e)
        {
            var TelaDeCadastro = new Frm_CadastrarClientes();
            TelaDeCadastro.ShowDialog();
        }

        private void Pct_Hosped_Click(object sender, EventArgs e)
        {
            Frm_Hospedagem Hospedagem = new Frm_Hospedagem();
            Hospedagem.ShowDialog();
        }

        private void Pct_Hospedes_Click(object sender, EventArgs e)
        {
            Frm_ListaDeHospedes hospedes = new Frm_ListaDeHospedes();
            hospedes.Show();
        }

        private void Pcb_ListaCadastros_Click(object sender, EventArgs e)
        {
            Frm_ListaDeCad cadastros = new Frm_ListaDeCad();
            cadastros.Show();
        }

        private void Pct_HospOcorr_Click(object sender, EventArgs e)
        {
            Frm_HospOcorridas ocorridas = new Frm_HospOcorridas();
            ocorridas.Show();
        }
    }
}
