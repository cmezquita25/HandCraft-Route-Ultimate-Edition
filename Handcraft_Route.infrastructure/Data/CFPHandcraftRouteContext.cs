using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Handcraft_Route.domain.Entities;

#nullable disable

namespace Handcraft_Route.infrastructure.Data
{
    public partial class CFPHandcraftRouteContext : DbContext
    {
        public CFPHandcraftRouteContext()
        {
        }

        public CFPHandcraftRouteContext(DbContextOptions<CFPHandcraftRouteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Artesano> Artesanos { get; set; }
        public virtual DbSet<ArtesanosCooperativa> ArtesanosCooperativas { get; set; }
        public virtual DbSet<ProductosArtesano> ProductosArtesanos { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=CFPHandcraftRoute.mssql.somee.com;Initial Catalog=CFPHandcraftRoute;Persist Security Info=False;User ID=Mezq22_SQLLogin_2;Password=f49vx6njv3");
            }
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Artesano>(entity =>
            {
                entity.HasKey(e => e.IdArtesanos)
                    .HasName("PK_Artesanos");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GeoUbicacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdArtesanos).ValueGeneratedOnAdd();

                entity.Property(e => e.LogotipoNegocio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MunicipioLocalidad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreArtesano)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RedesSociales)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TallerNegocio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArtesanosCooperativa>(entity =>
            {
                entity.HasKey(e => e.IdCooperativa)
                    .HasName("PK_Artesanos_Cooperativa");

                entity.ToTable("Artesanos_Cooperativa");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                
                entity.Property(e => e.IdCooperativa).ValueGeneratedOnAdd();

                entity.Property(e => e.GeoUbicacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCooperativa)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idCooperativa");

                entity.Property(e => e.NombreComercio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Platillo1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Platillo2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Platillo3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductosArtesano>(entity =>
            {
                entity.HasKey(e => e.IdProductos)
                    .HasName("PK_Productos_Artesanos");

                entity.ToTable("Productos_Artesanos");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                
                entity.Property(e => e.IdProductos).ValueGeneratedOnAdd();

                entity.Property(e => e.Fotografia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdProductos)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idProductos");

                entity.Property(e => e.MaterialElaborado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreProducto)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
