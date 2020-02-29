using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Map
{
    class DentistaMAP : EntityTypeConfiguration<Dentista>
    {
        public DentistaMAP()
        {
            this.ToTable("Dentista");
            this.HasKey(d => d.Id);
            this.Property(d => d.Id).HasColumnName("ID_Dentista");
            this.Property(d => d.Nome).HasColumnName("Nome_Dentista");
            this.Property(d => d.Email).HasColumnName("Email_Dentista");
            this.Property(d => d.Telefone).HasColumnName("Telefone_Dentista");
            this.Property(d => d.Celular).HasColumnName("Celular_Dentista");
            this.Property(d => d.CRO).HasColumnName("CRO");
        }
    }
}
