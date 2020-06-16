using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Agenda.Classes
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public string CPF { get; set; }
        public string Rg { get; set; }
        public string ComplementoC { get; set; }
        public string numero { get; set; }

        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }


        public static Clientes DesSerialized(string json)
        {
            return JsonConvert.DeserializeObject<Clientes>(json);
        }




        public override string ToString()
        {
            return $"Clientes: {this.Id},  {this.Nome}, {this.Genero}, {this.CPF}, {this.Rg}, {this.ComplementoC}" +
            $"{this.numero}, {this.cep}, {this.logradouro}, {this.complemento}, {this.bairro}, {this.localidade}, {this.uf}";
        }



    }
}
