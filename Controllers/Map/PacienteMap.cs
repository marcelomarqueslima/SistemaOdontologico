using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Map
{
    class PacienteMap : EntityTypeConfiguration<Paciente>
    {
        public PacienteMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasColumnName("Id_Paciente");
            this.Property(p => p.Nome).HasColumnName("Nome_Paciente");
            this.Property(p => p.Email).HasColumnName("Email_Paciente");
            this.Property(p => p.Telefone).HasColumnName("Telefone_Paciente");
            this.Property(p => p.Celular).HasColumnName("Celular_Paciente");
            this.Property(p => p.Cep).HasColumnName("Cep_Paciente");
            this.Property(p => p.Endereco).HasColumnName("Endereco_Paciente");
            this.Property(p => p.Complemento).HasColumnName("Complemento_Paciente");
            this.Property(p => p.Nascimento).HasColumnName("Nascimento_Paciente");
            this.Property(p => p.Sexo).HasColumnName("Sexo_Paciente");
        }
    }
}
