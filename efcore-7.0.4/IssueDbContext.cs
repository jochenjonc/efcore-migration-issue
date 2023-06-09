﻿using Microsoft.EntityFrameworkCore;

namespace efcore_7._0._4;

public class IssueDbContext : DbContext
{
    public IssueDbContext(DbContextOptions<IssueDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var issueBuilder = modelBuilder.Entity<Issue>();

        issueBuilder.ToTable("ISSUE");

        issueBuilder.HasKey(i => i.Id);

        issueBuilder.Property(i => i.Id)
            .HasColumnName("ISSUE_ID");

        issueBuilder.Property(i => i.Name)
            .HasColumnName("NAME");

        issueBuilder.Property(i => i.Weight)
            .HasColumnName("WEIGHT")
            .HasPrecision(8, 5)
            .HasColumnType("NUMBER(8,5)");
    }
}