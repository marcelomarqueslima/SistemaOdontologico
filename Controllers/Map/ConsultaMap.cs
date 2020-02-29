using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Map
{
    class ConsultaMap : EntityTypeConfiguration<Consulta>
    {
        public ConsultaMap()
        {
            this.HasKey(p => p.IdConsulta);
            this.Property(p => p.IdConsulta).HasColumnName("Id_Consulta");
            this.Property(p => p.IdDentista).HasColumnName("Id_Dentista");
            this.Property(p => p.IdPaciente).HasColumnName("Id_Paciente");
            this.Property(p => p.Data).HasColumnName("Data_Consulta");
            this.Property(p => p.HoraMarcada).HasColumnName("Hora_Marcada");
            this.Property(p => p.HoraInicio).HasColumnName("Hora_Inicio");
            this.Property(p => p.HoraFim).HasColumnName("Hora_Fim");
        }
    }
}
