using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EduCenter.Models;

public partial class EduCenterDbContext : DbContext
{
    public EduCenterDbContext()
    {
    }

    public EduCenterDbContext(DbContextOptions<EduCenterDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<GroupMember> GroupMembers { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Server=10.10.0.79;Port=5432;Database=EduCenterDB;User Id=postgres;Password=q1w2e3r4Z");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Group>(entity =>
        {
            entity.Property(e => e.GroupId).ValueGeneratedNever();
        });

        modelBuilder.Entity<GroupMember>(entity =>
        {
            entity.HasIndex(e => e.GroupId, "IX_GroupMembers_GroupId");

            entity.HasIndex(e => e.StudentId, "IX_GroupMembers_StudentId");

            entity.Property(e => e.GroupMemberId).ValueGeneratedNever();

            entity.HasOne(d => d.Group).WithMany(p => p.GroupMembers).HasForeignKey(d => d.GroupId);

            entity.HasOne(d => d.Student).WithMany(p => p.GroupMembers).HasForeignKey(d => d.StudentId);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.Property(e => e.StudentId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.Property(e => e.SubjectId).ValueGeneratedNever();
            entity.Property(e => e.SubjectName).HasMaxLength(100);
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.Property(e => e.TeacherId).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
