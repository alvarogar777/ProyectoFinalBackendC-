using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ProyectoFinalBackend.Entity;

namespace ProyectoFinalBackend.Model
{
    public class ControlAlmacenDataContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<DetalleCompra> DetalleCompras { get; set; }
        public DbSet<DetalleFactura> DetalleFacturas { get; set; }
        public DbSet<Emailcliente> Emailclientes { get; set; }
        public DbSet<EmailProveedor> EmailProveedores { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Inventario> Inventario { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<TelefonoCliente> TelefonoClientes { get; set; }
        public DbSet<TelefonoProveedor> TelefonoProveedores { get; set; }
        public DbSet<TipoEmpaque> TipoEmpaques { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Categoria>().ToTable("Categoria")
                .HasKey(d => new { d.CodigoCategoria });

            modelBuilder.Entity<Cliente>().ToTable("Cliente")
                .HasKey(d => new { d.Nit });

            modelBuilder.Entity<Compra>().ToTable("Compra")
                .HasKey(d => new { d.IdCompra});

            modelBuilder.Entity<DetalleCompra>().ToTable("DetalleCompra")
                .HasKey(d => new { d.IdDetalle });

            modelBuilder.Entity<DetalleFactura>().ToTable("DetalleFactura")
                .HasKey(d => new { d.CodigoDetalle });

            modelBuilder.Entity<Emailcliente>().ToTable("Emailcliente")
                .HasKey(d => new { d.CodigoEmail });

            modelBuilder.Entity<EmailProveedor>().ToTable("EmailProveedor")
                .HasKey(d => new { d.CodigoEmail });

            modelBuilder.Entity<Factura>().ToTable("Factura")
                .HasKey(d => new { d.Numerofactura});

            modelBuilder.Entity<Inventario>().ToTable("Inventario")
                .HasKey(d => new { d.CodigoInventario });

            modelBuilder.Entity<Producto>().ToTable("Producto")
                .HasKey(d => new { d.CodigoProducto });

            modelBuilder.Entity<Proveedor>().ToTable("Proveedor")
                .HasKey(d => new { d.CodigoProveedor });

            modelBuilder.Entity<Role>().ToTable("Role")
                .HasKey(d => new { d.ID });

            modelBuilder.Entity<TelefonoCliente>().ToTable("TelefonoCliente")
                .HasKey(d => new { d.CodigoTelefono });

            modelBuilder.Entity<TelefonoProveedor>().ToTable("TelefonoProveedor")
                .HasKey(d => new { d.CodigoTelefono});

            modelBuilder.Entity<TipoEmpaque>().ToTable("TipoEmpaque")
                .HasKey(d => new { d.CodigoEmpaque });

            modelBuilder.Entity<User>().ToTable("User")
                .HasKey(d => new { d.ID });

            modelBuilder.Entity<UserRole>().ToTable("UserRole")
                .HasKey(d => new { d.UserID, d.RoleID});
            modelBuilder.Entity<UserRole>()
               .ToTable("UserRole")
               .HasRequired<User>(p => p.User)
               .WithMany(p => p.UserRoles)
               .HasForeignKey<int>(s => s.UserID);
            modelBuilder.Entity<UserRole>()
               .ToTable("UserRole")
               .HasRequired<Role>(p => p.Role)
               .WithMany(p => p.UserRoles)
               .HasForeignKey<int>(s => s.RoleID);
        }
    }
}
