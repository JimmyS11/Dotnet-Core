using Microsoft.EntityFrameworkCore;
using Hospital.Dominio;

namespace Hospital.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get; set;}
        public DbSet<Paciente> Pacientes {get; set;}
        public DbSet<Medico> Medicos {get; set;}
        public DbSet<Enfermera> Enfermeras {get; set;}
        public DbSet<SignoVital> SignosVitales {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Initial Catalog=HospitalSenaDB; Data Source=LAPTOP-NE420FS2; Integrated Security=true");
            }
        }
    }
}