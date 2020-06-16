using Agenda.ConexaoBd;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda.Formularios
{
    public partial class Frm_ListaDeHospedes : Form
    {
        public Frm_ListaDeHospedes()
        {
            InitializeComponent();
            GridHospedados();
        }





        void GridHospedados()
        {
            Context Hosp = new Context();
            var consulta = from table in Hosp.hospedagem select new 
            { table.Nome, table.Quarto, table.Estadia };

            Dvg_ListaHospd.DataSource = consulta.ToList();
        }

        private void Btn_VerH_Click(object sender, EventArgs e)
        {
            GridHospedados();
        }


        [Obsolete]
        private void Btn_FinalizarH_Click(object sender, EventArgs e)
        {
            Context Consult = new Context();


           var result =  MessageBox.Show("Finalizar Hospedagem?", "Hospedagem", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if(result == DialogResult.Yes)
            {
                string Hospede = Dvg_ListaHospd.CurrentRow.Cells[1].Value.ToString();

                var consulta = from n in Consult.hospedagem select new { n.Nome, n.Quarto,n.Estadia  };
                var filt = consulta.Where(x => x.Quarto ==  Hospede);
                var pegaLista = filt.ToList();

                var hospedagem = Consult.Database.ExecuteSqlCommand($"delete from hospedagem where Quarto = {pegaLista[0].Quarto}");

                MessageBox.Show("Hospedagem Finalizada!", "Finalizando Hospedagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridHospedados();

            }


        }
    }
}
