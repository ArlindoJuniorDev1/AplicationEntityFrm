using Agenda.Classes;
using Agenda.ConexaoBd;
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
    public partial class Frm_CadastrarClientes : Form
    {
        public Frm_CadastrarClientes()
        {
            InitializeComponent();
        }

        private void Txt_Cep_Leave(object sender, EventArgs e)
        {
            string CepDigitado = Txt_Cep.Text;

            var json = Metodos.JSONCEP(CepDigitado);
            Clientes CEP = new Clientes();
            CEP = Clientes.DesSerialized(json);

            Txt_Logradouro.Text = CEP.logradouro;
            Txt_Bairro.Text = CEP.bairro;
            Cmb_UF.Text = CEP.uf;
            Txt_Cidade.Text = CEP.localidade;
            Txt_CompEnd.Text = CEP.complemento;
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            var clientes = new Clientes();

            clientes.bairro = Txt_Bairro.Text;
            clientes.cep = Txt_Cep.Text;
            clientes.complemento = Txt_CompEnd.Text;
            clientes.ComplementoC = txt_CompC.Text;
            clientes.CPF = Msk_CPF.Text;
            
            if (Rdb_Feminino.Checked)
            {
                clientes.Genero = "Feminino";
            }
            else
            {
                if(Rdb_Masculino.Checked)
                {
                    clientes.Genero = "Masculino";
                }
                else
                {
                    clientes.Genero = null;
                }
            }
            clientes.localidade = Txt_Cidade.Text;
            clientes.logradouro = Txt_Logradouro.Text;
            clientes.Nome = Txt_Nome.Text;
            clientes.numero = Txt_Numero.Text;
            clientes.Rg = Msk_Rg.Text;
            clientes.uf = Cmb_UF.SelectedItem.ToString();

            

            if (clientes.Nome == "")
            {
                MessageBox.Show("O cadastro tem que conter nome/n Verifique!",
                    "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                using (var contexto = new Context())
                {
                    contexto.Clientes.Add(clientes);
                    contexto.SaveChanges();
                }
                var result = MessageBox.Show("Cliente Cadastrado com sucesso!", "Cadastrar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Close();
                }
            }
        }
    }
}
