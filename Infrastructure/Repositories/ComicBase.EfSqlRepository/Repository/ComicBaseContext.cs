using ComicBase.Core.Domain.Entities;
using ComicBase.EfSqlRepository.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ComicBase.EfSqlRepository.Repository
{
    public class ComicBaseContext : DbContext
    {
        public ComicBaseContext() { }

        public ComicBaseContext(DbContextOptions<ComicBaseContext> options) : base(options) { }

        public ComicBaseContext(string connectionString)
            : base(GetOptions(connectionString)) { }

            
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Publisher> Publishers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new IssueMap());
            modelBuilder.ApplyConfiguration(new PublisherMap());
        }

        private static DbContextOptions GetOptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions
                .UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        }
    }
}
