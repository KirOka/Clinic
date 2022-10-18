using Clinic.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Clinic.DAL.Data
{
    /// <summary>
    /// Контекст
    /// </summary>
    public class ApplicationContext : DbContext
    {
        /// <summary>
        /// Таблица участков
        /// </summary>
        public DbSet<District> Districts { get; set; } = null!;

        /// <summary>
        /// Таблица кабинетов
        /// </summary>
        public DbSet<Office> Offices { get; set; } = null!;

        /// <summary>
        /// Таблица специализаций
        /// </summary>
        public DbSet<Specialization> Specializations { get; set; } = null!;

        /// <summary>
        /// Таблица пациентов
        /// </summary>
        public DbSet<Patient> Patients { get; set; } = null!;

        /// <summary>
        /// Таблица врачей
        /// </summary>
        public DbSet<Doctor> Doctors { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<District>()
                .HasMany(u => u.Patients)
                .WithOne(c => c.District)
                .IsRequired();
            modelBuilder.Entity<District>()
                .HasMany(u => u.Doctors)
                .WithOne(c => c.District)
                .IsRequired();
            modelBuilder.Entity<Office>()
                .HasMany(u => u.Doctors)
                .WithOne(c => c.Office)
                .IsRequired();
            modelBuilder.Entity<Specialization>()
                .HasMany(u => u.Doctors)
                .WithOne(c => c.Specialization)
                .IsRequired();
        }
    }
}
