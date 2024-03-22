using System;
using System.Collections.Generic;
using CQRS_and_Repository_Pattern.Database.Model.Entities;
using CQRS_and_Repository_Pattern.Database.Model.EntityTypeConfigurations.ModelTypeConfiguration;
using Microsoft.EntityFrameworkCore;

namespace CQRS_and_Repository_Pattern.Database;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<PcuMstGender> PcuMstGenders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;port=3306;database=TEST;user=root;password=123456", ServerVersion.Parse("10.10.2-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("utf8mb4_general_ci").HasCharSet("utf8mb4");
        new PcuMstGenderEntityTypeConfiguration(modelBuilder);
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
