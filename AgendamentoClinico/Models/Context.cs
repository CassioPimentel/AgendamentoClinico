using System.Data.Entity;

namespace AgendamentoClinico.Models
{
    public class Context : DbContext
    {
        public Context() : base("Context") { }

        public DbSet<Agendamento> Agendamento { get; set; }
        public DbSet<Clinica> Clinica { get; set; }
        public DbSet<ConvenioPaciente> ConvenioPaciente { get; set; }
        public DbSet<Convenio> Convenio { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Situacao> Situacao { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("uBv6sPbqyv");
        }
    }
}