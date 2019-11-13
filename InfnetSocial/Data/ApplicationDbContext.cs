using System;
using System.Collections.Generic;
using System.Text;
using InfnetSocial.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InfnetSocial.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Amizade>().ToTable("Amizade");
            modelBuilder.Entity<Usuario>().ToTable("Usuario");

            modelBuilder.Entity<Amizade>()
                .HasKey(a => new { a.UsuarioIdA, a.UsuarioIdB });

            modelBuilder.Entity<Amizade>()
                .HasOne(a => a.UsuarioA)
                .WithMany(u => u.AmizadesA)
                .HasForeignKey(a => a.UsuarioIdA)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Amizade>()
                .HasOne(a => a.UsuarioB)
                .WithMany(u => u.AmizadesB)
                .HasForeignKey(a => a.UsuarioIdB)
                .OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
