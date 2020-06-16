using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agenda.Classes;
using Agenda.ConexaoBd;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Formularios
{
    public partial class Frm_HospOcorridas : Form
    {
        public Frm_HospOcorridas()
        {
            InitializeComponent();
            GridHospedes();

        }


        void GridHospedes()
        {
            Context Hosp = new Context();
            var consulta = from table in Hosp.ClientesHospedados
                           select new
                           { table.Nome, table.DiasHospedados, table.DataHospedagem, table.ValorHosp };

            Dvg_OcorreHp.DataSource = consulta.ToList();
        }

        private void Frm_HospOcorridas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDDataSet2.ClientesHospedados'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesHospedadosTableAdapter.Fill(this.bDDataSet2.ClientesHospedados);

        }

        [Obsolete]
        private void Btn_Deletar_Click(object sender, EventArgs e)
        {
            Context Consult = new Context();


            var result = MessageBox.Show("Finalizar Hospedagem?", "Hospedagem", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                string Hospede = Dvg_OcorreHp.CurrentRow.Cells[0].Value.ToString();

                var consulta = from n in Consult.ClientesHospedados select new { n.Nome, n.Id, n.ValorHosp, n.DiasHospedados, n.DataHospedagem };
                var filt = consulta.Where(x => x.Nome == Hospede);
                var pegaLista = filt.ToList();

                var hospedagem = Consult.Database.ExecuteSqlCommand($"delete from hospedagem where Nome = {pegaLista[0].Nome}");
                var hospedage = Consult.Database.ExecuteSqlCommand($"delete from ClientesHospedados where Nome = {pegaLista[0].Nome}");

                MessageBox.Show("Registro Deletado!", "Deletando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridHospedes();


            }


        }
    }
}
