using Microsoft.EntityFramework.Core;

namespace Hospital.Persistencia
{
    public class AppContext
    {
        protected override void OnConfiguring(DbContextOptionBuilder optionsBuilder)
        {
            if (!optionsBuilder.Isconfigured)
            {
                optionsBuilder.UseSqlServer("Initial Catalog=HospitalSenaDB; Data Source=LAPTOP-NE420FS2");
            }
        }
    }
}