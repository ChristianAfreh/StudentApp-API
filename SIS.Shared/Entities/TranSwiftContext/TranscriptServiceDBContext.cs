using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SIS.Shared.Entities.TranSwiftContext
{
    public partial class TranscriptServiceDBContext : DbContext
    {
        public TranscriptServiceDBContext()
        {
        }

        public TranscriptServiceDBContext(DbContextOptions<TranscriptServiceDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Applicant> Applicants { get; set; }
        public virtual DbSet<ApplicantPicture> ApplicantPictures { get; set; }
        public virtual DbSet<ApplicantProgrammeStream> ApplicantProgrammeStreams { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<StudentUser> StudentUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Applicant>(entity =>
            {
                entity.HasKey(e => e.ApplicantId)
                    .IsClustered(false);

                entity.ToTable("Applicant");

                entity.HasIndex(e => e.CountryId, "FKCity_Applicant");

                entity.HasIndex(e => e.NationalIdtypeId, "FKNationalIDType_Applicant");

                entity.HasIndex(e => e.ApplicantId, "IDX_Applicant_StudentAspNet_User")
                    .IsUnique()
                    .HasFilter("([UserId] IS NULL AND [StudentUserId] IS NULL)");

                entity.HasIndex(e => e.ApplicantId, "IDX_Applicant_StudentUser_IsStudent")
                    .IsUnique()
                    .HasFilter("([IsStudent]=(1) AND [StudentUserId] IS NULL)");

                entity.HasIndex(e => e.UserId, "UK_Applicant_User")
                    .IsUnique()
                    .HasFilter("([UserId] IS NOT NULL)");

                entity.Property(e => e.ApplicantId).HasColumnName("ApplicantID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Created).HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NationalIdnumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NationalIDNumber");

                entity.Property(e => e.NationalIdtypeId).HasColumnName("NationalIDTypeID");

                entity.Property(e => e.OtherNames)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.PostalAddress).HasMaxLength(300);

                entity.Property(e => e.ResidentialAddress)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.StudentUser)
                    .WithMany(p => p.Applicants)
                    .HasForeignKey(d => d.StudentUserId)
                    .HasConstraintName("FK_Applicant_Student");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Applicant)
                    .HasForeignKey<Applicant>(d => d.UserId)
                    .HasConstraintName("FK_Applicant_AspNetUsers");
            });

            modelBuilder.Entity<ApplicantPicture>(entity =>
            {
                entity.HasKey(e => e.ApplicantPictureId)
                    .IsClustered(false);

                entity.ToTable("ApplicantPicture");

                entity.HasIndex(e => e.ApplicantId, "FKApplicant_ApplicantPicture");

                entity.Property(e => e.ApplicantPictureId).HasColumnName("ApplicantPictureID");

                entity.Property(e => e.ApplicantId).HasColumnName("ApplicantID");

                entity.Property(e => e.ApplicantPicture1)
                    .IsRequired()
                    .HasColumnName("ApplicantPicture");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.Applicant)
                    .WithMany(p => p.ApplicantPictures)
                    .HasForeignKey(d => d.ApplicantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicantPicture_Applicant");
            });

            modelBuilder.Entity<ApplicantProgrammeStream>(entity =>
            {
                entity.HasKey(e => e.ApplicantProgrammeStreamId)
                    .HasName("PK_ApplicantProgramme")
                    .IsClustered(false);

                entity.ToTable("ApplicantProgrammeStream");

                entity.HasIndex(e => e.ApplicantId, "FKApplicant_ApplicantProgramme");

                entity.HasIndex(e => e.GraduateTypeId, "FKGraduateType_ApplicantProgramme");

                entity.HasIndex(e => e.ProgrammeStreamId, "FKProgramme_ApplicantProgramme");

                entity.HasIndex(e => new { e.StudentNumber, e.ApplicantId }, "UK_ApplicantProgrammeStream_Applicant_StudentNo")
                    .IsUnique()
                    .HasFilter("([StudentNumber] IS NOT NULL)");

                entity.Property(e => e.ApplicantProgrammeStreamId).HasColumnName("ApplicantProgrammeStreamID");

                entity.Property(e => e.ApplicantId).HasColumnName("ApplicantID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.GraduateTypeId).HasColumnName("GraduateTypeID");

                entity.Property(e => e.IndexNo).HasMaxLength(20);

                entity.Property(e => e.ProgrammeStreamId).HasColumnName("ProgrammeStreamID");

                entity.Property(e => e.SchoolRecognizedName).HasMaxLength(200);

                entity.Property(e => e.SisprovidedStudentNumber)
                    .HasMaxLength(20)
                    .HasColumnName("SISProvidedStudentNumber");

                entity.Property(e => e.StudentNumber).HasMaxLength(20);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(150);

                entity.HasOne(d => d.Applicant)
                    .WithMany(p => p.ApplicantProgrammeStreams)
                    .HasForeignKey(d => d.ApplicantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicantProgrammeStream_Applicant");
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.EmailConfirmed)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.InsertedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.InsertedBy).HasMaxLength(150);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<StudentUser>(entity =>
            {
                entity.ToTable("StudentUser");

                entity.Property(e => e.Created).HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.StudentId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StudentName).HasMaxLength(200);

                entity.Property(e => e.StudentPersonalEmail).HasMaxLength(150);

                entity.Property(e => e.StudentUsername)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
