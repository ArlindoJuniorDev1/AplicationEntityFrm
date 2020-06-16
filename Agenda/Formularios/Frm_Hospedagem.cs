using Agenda.Classes;
using Agenda.ConexaoBd;
using Microsoft.EntityFrameworkCore.Storage;
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
    public partial class Frm_Hospedagem : Form
    {
        public Frm_Hospedagem()
        {
            InitializeComponent();
            Txt_DataHp.Text = DateTime.Today.ToString();


        }


        public void ListaClientes()
        {

            Context Hosp = new Context();
            var consulta = from table in Hosp.Clientes select new { table.Nome };
            Cmb_Cliente.DataSource = consulta.ToList();
        }



        private void Frm_Hospedagem_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDDataSet1.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter1.Fill(this.bDDataSet1.Clientes);
            // TODO: esta linha de código carrega dados na tabela 'bDDataSet.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.bDDataSet.Clientes);
        }



        private void Btn_Salvar_Click(object sender, EventArgs e)
        {



            Hospedagem Hosped = new Hospedagem();
            ClientesHospedados clientesHospedados = new ClientesHospedados();
            Context bd = new Context();


            string combobox = Cmb_Cliente.SelectedValue.ToString();
            clientesHospedados.Nome = combobox;

            Hosped.Quarto = Txt_Quarto.Text;
            Hosped.Nome = combobox;
            clientesHospedados.ValorHosp = Lbl_Valor.Text;
            clientesHospedados.DataHospedagem = Txt_DataHp.Text;
            clientesHospedados.DiasHospedados = Txt_Dias.Text;

            Clientes clientes = new Clientes();


            using (var Contex = new Context())
            {
                Contex.ClientesHospedados.Add(clientesHospedados);
                Contex.SaveChanges();
            }

            try
            {

                string quart;
                quart = Txt_Quarto.Text;

                int ano = 365;
                int mes = 30;
                int valCliente = Convert.ToInt32(Txt_Dias.Text);
                string Result;

                if (Rdb_Ano.Checked)
                {
                    Result = Convert.ToString(ano * valCliente + " Dias");
                    Hosped.Estadia = Result;

                }
                else
                {
                    if (Rdb_Mes.Checked)
                    {
                        Result = Convert.ToString(mes * valCliente + " Dias");
                        Hosped.Estadia = Result;

                    }
                    else
                    {
                        Hosped.Estadia = Convert.ToString(valCliente + " Dias");

                    }
                }

                using (var contexto = new Context())
                {
                    contexto.hospedagem.Add(Hosped);

                    contexto.SaveChanges();
                }

                var result = MessageBox.Show("Cliente Hospedado!", "Hospedes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Close();
                }

            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException)
            {
                MessageBox.Show($"Ja tem cliente Hospedado no quarto: {Hosped.Quarto}", "Hospedagem!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Txt_Quarto.Text = "";
                Txt_Quarto.Focus();
            }
        }


        public void CalculaEstadia()
        {
            int ValorHosp = 150;
            int ResultVal;


            int ClienteDias;

            ClienteDias = Convert.ToInt32(Txt_Dias.Text);

            ClientesHospedados clientesHospedados = new ClientesHospedados();

            if (Rdb_Ano.Checked)
            {
                ResultVal = ValorHosp * (ClienteDias * 365);
                Lbl_Valor.Text = Convert.ToString(ResultVal);
            }
            else
            {
                if (Rdb_Mes.Checked)
                {
                    ResultVal = ValorHosp * (ClienteDias * 30);
                    Lbl_Valor.Text = Convert.ToString(ResultVal);
                }
                else
                {
                    if (Rdb_Dias.Checked)
                    {
                        ResultVal = ClienteDias * ValorHosp;

                        Lbl_Valor.Text = Convert.ToString(ResultVal);
                    }
                    else
                    {
                        ResultVal = ClienteDias * ValorHosp;

                        Lbl_Valor.Text = Convert.ToString(ResultVal);
                    }
                }
            }
        }
        private void Btn_VerPreco_Click(object sender, EventArgs e)
        {
            CalculaEstadia();
        }
    }
}
