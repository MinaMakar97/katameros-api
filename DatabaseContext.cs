﻿using Katameros.Models;
using Microsoft.EntityFrameworkCore;

namespace Katameros
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BooksTranslation>()
                .HasKey(t => new { t.BookId, t.LanguageId });
            modelBuilder.Entity<SectionsMetadatasTranslation>()
                .HasKey(t => new { t.SectionsId, t.SectionsMetadatasId, t.LanguageId });
            modelBuilder.Entity<SubSectionsMetadatasTranslation>()
                .HasKey(t => new { t.SubSectionsId, t.SubSectionsMetadatasId, t.LanguageId });
            modelBuilder.Entity<ReadingsMetadatasTranslation>()
                .HasKey(t => new { t.ReadingId, t.ReadingsMetadatasId, t.LanguageId });
        }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Bible> Bibles { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BooksTranslation> BooksTranslations { get; set; }
        public DbSet<Verse> Verses { get; set; }
        public DbSet<AnnualReading> AnnualReadings { get; set; }
        public DbSet<SundayReading> SundayReadings { get; set; }
        public DbSet<GreatLentReading> GreatLentReadings { get; set; }
        public DbSet<PentecostReading> PentecostReadings { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<SectionsMetadata> SectionsMetadatas { get; set; }
        public DbSet<SectionsMetadatasTranslation> SectionsMetadatasTranslations { get; set; }
        public DbSet<SubSection> SubSections { get; set; }
        public DbSet<SubSectionsMetadata> SubSectionsMetadatas { get; set; }
        public DbSet<SubSectionsMetadatasTranslation> SubSectionsMetadatasTranslations { get; set; }
        public DbSet<Reading> Readings { get; set; }
        public DbSet<ReadingsMetadata> ReadingsMetadatas { get; set; }
        public DbSet<ReadingsMetadatasTranslation> ReadingsMetadatasTranslations { get; set; }
    }
}