using ComicBase.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComicBase.EfSqlRepository.Mappings
{
    /// <summary>
    /// Entity Framework Mapping for a Publisher entity.
    /// </summary>
    internal class PublisherMap : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.SiteUrl).IsRequired();

            builder.Property(p => p.Created).IsRequired();
            builder.Property(p => p.Updated).IsRequired();
            builder.Property(p => p.Active).IsRequired();
        }
    }
}