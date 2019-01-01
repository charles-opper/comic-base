using ComicBase.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComicBase.EfSqlRepository.Mappings
{
    /// <summary>
    /// Entity Framework Mapping for an Issue entity.
    /// </summary>
    internal class IssueMap : IEntityTypeConfiguration<Issue>
    {
        public void Configure(EntityTypeBuilder<Issue> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            builder.Property(p => p.Title).IsRequired();
            builder.Property(p => p.Year).IsRequired();
            builder.Property(p => p.Volume).IsRequired();
            builder.Property(p => p.IssueNumber).IsRequired();
            builder.Property(p => p.PublisherId).IsRequired();

            builder.Property(p => p.Created).IsRequired();
            builder.Property(p => p.Updated).IsRequired();
            builder.Property(p => p.Active).IsRequired();
        }
    }
}
