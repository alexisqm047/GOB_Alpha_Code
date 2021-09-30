using Microsoft.EntityFrameworkCore;
using GOB.App.Dominio;

namespace GOB.App.Persistencia
{
    public class AppContext : DbContext
    {
        //public DbSet<Persona> personas{get;set;}
        public DbSet<Aislamiento> aislamiento{get;set;}
        public DbSet<Gobernacion> gobernacion{get;set;}
        public DbSet<GobernadorAsesores> gobernadores{get;set;}
        public DbSet<Ingreso> ingreso{get;set;}
        public DbSet<Oficina> oficina{get;set;}
        public DbSet<PersonalAseo> personal{get;set;}
        public DbSet<Proveedor> proveedor{get;set;}
        public DbSet<SecretariosDespacho> SecretariosDespacho{get;set;}
        public DbSet<Sedes> sedes{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog = Gobernacion");
            }
        }
    }
}