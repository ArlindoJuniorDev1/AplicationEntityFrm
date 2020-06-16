using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Classes
{
    public class ClientesHospedados
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string DiasHospedados { get; set; }
        public string DataHospedagem { get; set; }
        public string ValorHosp { get; set; }

        public override string ToString()
        {
            return $"ClientesHop: {this.Id}, {this.Nome}, {this.DiasHospedados}, {this.DataHospedagem}, {this.ValorHosp} ";
        }

    }
}
