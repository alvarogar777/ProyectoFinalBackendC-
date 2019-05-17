using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProyectoFinalBackend.Model
{
    public class ControlAlmacenDataContext : DbContext
    {
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<TipoEmpaque> TipoEmpaque { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Categoria>().ToTable("Categoria")
                .HasKey(d => new { d.CodigoCategoria });
            modelBuilder.Entity<Cliente>().ToTable("Cliente")
                .HasKey(d => new { d.Nit });
            modelBuilder.Entity<Proveedor>().ToTable("Proveedor")
                .HasKey(d => new { d.CodigoProveedor });
            modelBuilder.Entity<Role>().ToTable("Role")
                .HasKey(d => new { d.ID });
            modelBuilder.Entity<TipoEmpaque>().ToTable("TipoEmpaque")
                .HasKey(d => new { d.CodigoEmpaque });
            modelBuilder.Entity<User>().ToTable("User")
                .HasKey(d => new { d.ID });
        }
    }
}
