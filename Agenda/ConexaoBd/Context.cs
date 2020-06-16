using Agenda.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Agenda.ConexaoBd
{
    public class Context : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Hospedagem> hospedagem { get; set; }
        public DbSet<ClientesHospedados> ClientesHospedados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = BD; Trusted_Connection = true;");
        }

    }
}
