using Controllers.Map;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Context
{
    class SistemaContext : DbContext
    {
        public SistemaContext() : base("Server=DESKTOP-Q0M5C87\\SQLEXPRESS; Database=db_odonto; Integrated Security=True;")
        {

        }

        public DbSet<Consulta> Consultas{get; set;}
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Dentista> Dentistas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SistemaContext>(null);
            modelBuilder.Configurations.Add(new DentistaMAP());
            modelBuilder.Configurations.Add(new ConsultaMap());
            modelBuilder.Configurations.Add(new PacienteMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
