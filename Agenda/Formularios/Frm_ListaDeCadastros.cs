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
    public partial class Frm_ListaDeCad : Form
    {
        public Frm_ListaDeCad()
        {
            InitializeComponent();
            GridHospedados();

        }


        void GridHospedados()
        {
            Context Hosp = new Context();
            var consulta = from table in Hosp.Clientes
                           select new
                           { table.Nome, table.CPF, table.Rg, table.numero, table.logradouro, table.bairro, table.localidade, table.uf };

            dataGridView1.DataSource = consulta.ToList();
        }

        private void Frm_ListaDeCadastros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDDataSet5.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter2.Fill(this.bDDataSet5.Clientes);
            // TODO: esta linha de código carrega dados na tabela 'bDDataSet4.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter1.Fill(this.bDDataSet4.Clientes);
            // TODO: esta linha de código carrega dados na tabela 'bDDataSet3.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.bDDataSet3.Clientes);

        }

        [Obsolete]
        private void Btn_DeletarCad_Click(object sender, EventArgs e)
        {
            Context Consult = new Context();


            var result = MessageBox.Show("Sera deletado todos os dados desse cliente\nDeseja Continuar?", "Deletar Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                string Hospede = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                var consulta = from n in Consult.Clientes select new { n.Nome, n.CPF };
                var filt = consulta.Where(x => x.Nome == Hospede);
                var pegaLista = filt.ToList();

                var hospedagem = Consult.Database.ExecuteSqlCommand($"delete from hospedagem where Nome = {pegaLista[0].Nome}");

                var hospedage = Consult.Database.ExecuteSqlCommand($"delete from Clientes where Nome = {pegaLista[0].Nome}");

                var Hospd = Consult.Database.ExecuteSqlCommand($"delete from ClientesHospedados where Nome = {pegaLista[0].Nome}");

                MessageBox.Show("Hospedagem Finalizada!", "Finalizando Hospedagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridHospedados();

            }
        }
    }
}
