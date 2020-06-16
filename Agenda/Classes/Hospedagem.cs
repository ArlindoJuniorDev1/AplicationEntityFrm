using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Classes
{
    public class Hospedagem
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Quarto { get; set; }
        public string Estadia { get; set; }

        public override string ToString()
        {
            return $"Hospedagem: {this.Id}, {this.Nome}, {this.Quarto}, {this.Estadia} ";
        }
    }





}
