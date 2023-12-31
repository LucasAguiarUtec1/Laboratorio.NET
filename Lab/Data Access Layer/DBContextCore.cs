﻿using Data_Access_Layer.EF_Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DataAccessLayer
{
    public class DBContextCore : IdentityDbContext<Usuarios>
    {
        private string _connectionString = "Server=sqlserver,1433;Database=laboratorio;User Id=sa;Password=Abc*123!;Encrypt=False;";

        public DBContextCore()
        { }

        public DBContextCore(DbContextOptions<DBContextCore> options)
        : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<CategoriaProductos>()
                .HasKey(cp => new { cp.ProductoId, cp.CategoriaId });

            builder.Entity<CategoriaProductos>()
                .HasOne(pc => pc.Productos)
                .WithMany(p => p.Categorias)
                .HasForeignKey(pc => pc.ProductoId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<CategoriaProductos>()
                .HasOne(pc => pc.Categorias)
                .WithMany(c => c.Productos)
                .HasForeignKey(pc => pc.CategoriaId);

        }

        public DbSet<Usuarios> Usuarios { get; set; }

        public DbSet<Productos> Productos { get; set; }

        public DbSet<DtTarjetas> Tarjetas { get; set; }

        public DbSet<DtMetodoDePagos> MetodoDePagos { get; set; }

        public DbSet<DtDirecciones> Direcciones { get; set; }

        public DbSet<DtCriptomendas> Criptomonedas { get; set; }

        public DbSet<Carritos> Carritos { get; set; }

        public DbSet<Categorias> Categorias { get; set; }

        public DbSet<Sucursales> Sucursales { get; set; }

        public DbSet<Empresas> Empresas { get; set; }
    }
}
