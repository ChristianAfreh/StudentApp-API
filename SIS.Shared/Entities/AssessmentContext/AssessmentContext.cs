using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class AssessmentContext : DbContext
    {
        public AssessmentContext()
        {
        }

        public AssessmentContext(DbContextOptions<AssessmentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Acadyear> Acadyears { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<Assessment> Assessments { get; set; }
        public virtual DbSet<Assessmentavg> Assessmentavgs { get; set; }
        public virtual DbSet<Assessmentavgcat> Assessmentavgcats { get; set; }
        public virtual DbSet<Assessmentcomment> Assessmentcomments { get; set; }
        public virtual DbSet<Assessmentcommentagg> Assessmentcommentaggs { get; set; }
        public virtual DbSet<Assessmentcount> Assessmentcounts { get; set; }
        public virtual DbSet<Assessmentdepartment> Assessmentdepartments { get; set; }
        public virtual DbSet<AssessmentdepartmentCopy> AssessmentdepartmentCopies { get; set; }
        public virtual DbSet<AssessmentdepartmentHr> AssessmentdepartmentHrs { get; set; }
        public virtual DbSet<Assessmentlecturer> Assessmentlecturers { get; set; }
        public virtual DbSet<Assessmentmaster> Assessmentmasters { get; set; }
        public virtual DbSet<AssessmentmasterT> AssessmentmasterTs { get; set; }
        public virtual DbSet<Assessmentmasterdepartment> Assessmentmasterdepartments { get; set; }
        public virtual DbSet<Assessmentperf> Assessmentperves { get; set; }
        public virtual DbSet<Assessmentperfcat> Assessmentperfcats { get; set; }
        public virtual DbSet<Assessmentperfcatsummary> Assessmentperfcatsummaries { get; set; }
        public virtual DbSet<Assessmentperfgrand> Assessmentperfgrands { get; set; }
        public virtual DbSet<AssessmentperfgrandT> AssessmentperfgrandTs { get; set; }
        public virtual DbSet<Assessmentperfsummary> Assessmentperfsummaries { get; set; }
        public virtual DbSet<Assessmentpvt> Assessmentpvts { get; set; }
        public virtual DbSet<AssessmentpvtT> AssessmentpvtTs { get; set; }
        public virtual DbSet<Assessmentreport> Assessmentreports { get; set; }
        public virtual DbSet<AssessmentreportCopy> AssessmentreportCopies { get; set; }
        public virtual DbSet<AssessmentreportCopy1> AssessmentreportCopy1s { get; set; }
        public virtual DbSet<AssessmentreportNopix> AssessmentreportNopixes { get; set; }
        public virtual DbSet<AssessmentreportNopixT> AssessmentreportNopixTs { get; set; }
        public virtual DbSet<AssessmentreportSummarysource> AssessmentreportSummarysources { get; set; }
        public virtual DbSet<Assessmentreportnp> Assessmentreportnps { get; set; }
        public virtual DbSet<Assessmentrespondent> Assessmentrespondents { get; set; }
        public virtual DbSet<AssessmentrespondentsT> AssessmentrespondentsTs { get; set; }
        public virtual DbSet<Assessmentrespondentsexpected> Assessmentrespondentsexpecteds { get; set; }
        public virtual DbSet<Assessmentunit> Assessmentunits { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<College> Colleges { get; set; }
        public virtual DbSet<Collegehr> Collegehrs { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<DepartmentHr> DepartmentHrs { get; set; }
        public virtual DbSet<DepartmentUser> DepartmentUsers { get; set; }
        public virtual DbSet<Departmenthr1> Departmenthrs1 { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Facultyhr> Facultyhrs { get; set; }
        public virtual DbSet<Grading> Gradings { get; set; }
        public virtual DbSet<Lecturer> Lecturers { get; set; }
        public virtual DbSet<Lecturerassessment> Lecturerassessments { get; set; }
        public virtual DbSet<Lecturerassessmentunit> Lecturerassessmentunits { get; set; }
        public virtual DbSet<LecturerassessmentunitCopy> LecturerassessmentunitCopies { get; set; }
        public virtual DbSet<Lecturerassessmentunitnew> Lecturerassessmentunitnews { get; set; }
        public virtual DbSet<LecturerdepartmentHr> LecturerdepartmentHrs { get; set; }
        public virtual DbSet<Mastercourse> Mastercourses { get; set; }
        public virtual DbSet<MastercourseDirect> MastercourseDirects { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }
        public virtual DbSet<Nocollege> Nocolleges { get; set; }
        public virtual DbSet<Nonacademic> Nonacademics { get; set; }
        public virtual DbSet<Nonexistingstaffid> Nonexistingstaffids { get; set; }
        public virtual DbSet<NonexistingstaffidUi> NonexistingstaffidUis { get; set; }
        public virtual DbSet<Number> Numbers { get; set; }
        public virtual DbSet<NumbersCopy> NumbersCopies { get; set; }
        public virtual DbSet<Programmestream> Programmestreams { get; set; }
        public virtual DbSet<Qsetsetting> Qsetsettings { get; set; }
        public virtual DbSet<Qsetsettingcourse> Qsetsettingcourses { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Questionset> Questionsets { get; set; }
        public virtual DbSet<Reg20211> Reg20211s { get; set; }
        public virtual DbSet<Reportingsummary> Reportingsummaries { get; set; }
        public virtual DbSet<Reportingsummaryextended> Reportingsummaryextendeds { get; set; }
        public virtual DbSet<Response> Responses { get; set; }
        public virtual DbSet<Responsevalue> Responsevalues { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<Sishrentityidmap> Sishrentityidmaps { get; set; }
        public virtual DbSet<Sisprogrammecourse> Sisprogrammecourses { get; set; }
        public virtual DbSet<Sisprogrammeoptioncourse> Sisprogrammeoptioncourses { get; set; }
        public virtual DbSet<Sisprogrammeoptioncourselecturer> Sisprogrammeoptioncourselecturers { get; set; }
        public virtual DbSet<Staffname> Staffnames { get; set; }
        public virtual DbSet<StaffnameLocDelete> StaffnameLocDeletes { get; set; }
        public virtual DbSet<Staffphoto> Staffphotos { get; set; }
        public virtual DbSet<Statraw20172020> Statraw20172020s { get; set; }
        public virtual DbSet<Studentlog> Studentlogs { get; set; }
        public virtual DbSet<Sysdiagram> Sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserViewModel> UserViewModels { get; set; }
        public virtual DbSet<Usercollege> Usercolleges { get; set; }
        public virtual DbSet<UsercollegeCopy> UsercollegeCopies { get; set; }
        public virtual DbSet<Userdepartment> Userdepartments { get; set; }
        public virtual DbSet<UserdepartmentCopy> UserdepartmentCopies { get; set; }
        public virtual DbSet<Userfaculty> Userfaculties { get; set; }
        public virtual DbSet<UserfacultyCopy> UserfacultyCopies { get; set; }
        public virtual DbSet<ViewStaffname> ViewStaffnames { get; set; }
        public virtual DbSet<Viewlecturerassignedcourse> Viewlecturerassignedcourses { get; set; }
        public virtual DbSet<Viewlecturercourse> Viewlecturercourses { get; set; }
        public virtual DbSet<staff> staff { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Acadyear>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ACADYEAR");

                entity.Property(e => e.Acadyear1).HasColumnName("ACADYEAR");
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.Name, "RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.UserName, "UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.HasIndex(e => e.RoleId, "IX_RoleId");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<Assessment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENT");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Qid).HasColumnName("QID");

                entity.Property(e => e.Qno).HasColumnName("QNO");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");
            });

            modelBuilder.Entity<Assessmentavg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENTAVG");

                entity.Property(e => e.A).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Qid).HasColumnName("QID");

                entity.Property(e => e.Qno).HasColumnName("QNO");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");

                entity.Property(e => e._1).HasColumnName("1");

                entity.Property(e => e._2).HasColumnName("2");

                entity.Property(e => e._3).HasColumnName("3");

                entity.Property(e => e._4).HasColumnName("4");

                entity.Property(e => e._5).HasColumnName("5");
            });

            modelBuilder.Entity<Assessmentavgcat>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENTAVGCAT");

                entity.Property(e => e.A).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CATEGORY");

                entity.Property(e => e.Categoryid).HasColumnName("CATEGORYID");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Includeingrand).HasColumnName("INCLUDEINGRAND");

                entity.Property(e => e.Qrange)
                    .HasMaxLength(13)
                    .HasColumnName("QRANGE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");

                entity.Property(e => e._1).HasColumnName("1");

                entity.Property(e => e._2).HasColumnName("2");

                entity.Property(e => e._3).HasColumnName("3");

                entity.Property(e => e._4).HasColumnName("4");

                entity.Property(e => e._5).HasColumnName("5");
            });

            modelBuilder.Entity<Assessmentcomment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENTCOMMENT");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Comment).HasColumnName("COMMENT");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Qno).HasColumnName("QNO");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");
            });

            modelBuilder.Entity<Assessmentcommentagg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENTCOMMENTAGG");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Comments).HasColumnName("COMMENTS");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");
            });

            modelBuilder.Entity<Assessmentcount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENTCOUNT");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Qno).HasColumnName("QNO");

                entity.Property(e => e.Response).HasColumnName("RESPONSE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");
            });

            modelBuilder.Entity<Assessmentdepartment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENTDEPARTMENT");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");
            });

            modelBuilder.Entity<AssessmentdepartmentCopy>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENTDEPARTMENT_copy");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");
            });

            modelBuilder.Entity<AssessmentdepartmentHr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENTDEPARTMENT_HR");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");
            });

            modelBuilder.Entity<Assessmentlecturer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENTLECTURER");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");
            });

            modelBuilder.Entity<Assessmentmaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENTMASTER");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");
            });

            modelBuilder.Entity<AssessmentmasterT>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENTMASTER_TS");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");
            });

            modelBuilder.Entity<Assessmentmasterdepartment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENTMASTERDEPARTMENT");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Staffid)
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");
            });

            modelBuilder.Entity<Assessmentperf>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENTPERF");

                entity.Property(e => e.A).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Perf)
                    .HasMaxLength(20)
                    .HasColumnName("PERF");

                entity.Property(e => e.Qno).HasColumnName("QNO");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");

                entity.Property(e => e._1).HasColumnName("1");

                entity.Property(e => e._2).HasColumnName("2");

                entity.Property(e => e._3).HasColumnName("3");

                entity.Property(e => e._4).HasColumnName("4");

                entity.Property(e => e._5).HasColumnName("5");
            });

            modelBuilder.Entity<Assessmentperfcat>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENTPERFCAT");

                entity.Property(e => e.A).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .HasColumnName("CATEGORY");

                entity.Property(e => e.Categoryid).HasColumnName("CATEGORYID");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Includeingrand).HasColumnName("INCLUDEINGRAND");

                entity.Property(e => e.Perf)
                    .HasMaxLength(20)
                    .HasColumnName("PERF");

                entity.Property(e => e.Qrange)
                    .HasMaxLength(13)
                    .HasColumnName("QRANGE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");

                entity.Property(e => e._1).HasColumnName("1");

                entity.Property(e => e._2).HasColumnName("2");

                entity.Property(e => e._3).HasColumnName("3");

                entity.Property(e => e._4).HasColumnName("4");

                entity.Property(e => e._5).HasColumnName("5");
            });

            modelBuilder.Entity<Assessmentperfcatsummary>(entity =>
            {
                entity.ToTable("ASSESSMENTPERFCATSUMMARY");

                entity.HasIndex(e => new { e.Acadyear, e.Sem }, "IX_ASSESSMENTPERFCATSUMMARY_ALL");

                entity.HasIndex(e => new { e.Acadyear, e.Sem, e.Staffid, e.Coursecode, e.Categoryid }, "IX_ASSPERCAT")
                    .IsUnique();

                entity.Property(e => e.Assessmentperfcatsummaryid).HasColumnName("ASSESSMENTPERFCATSUMMARYID");

                entity.Property(e => e.A).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CATEGORY");

                entity.Property(e => e.Categoryid).HasColumnName("CATEGORYID");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Includeingrand).HasColumnName("INCLUDEINGRAND");

                entity.Property(e => e.Perf)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("PERF");

                entity.Property(e => e.Qrange)
                    .IsRequired()
                    .HasMaxLength(13)
                    .HasColumnName("QRANGE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");

                entity.Property(e => e._1).HasColumnName("1");

                entity.Property(e => e._2).HasColumnName("2");

                entity.Property(e => e._3).HasColumnName("3");

                entity.Property(e => e._4).HasColumnName("4");

                entity.Property(e => e._5).HasColumnName("5");
            });

            modelBuilder.Entity<Assessmentperfgrand>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENTPERFGRAND");

                entity.Property(e => e.A).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Perf)
                    .HasMaxLength(20)
                    .HasColumnName("PERF");

                entity.Property(e => e.Respondents).HasColumnName("RESPONDENTS");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");

                entity.Property(e => e.Zt).HasColumnName("ZT");

                entity.Property(e => e.Zta)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("ZTA");
            });

            modelBuilder.Entity<AssessmentperfgrandT>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENTPERFGRAND_TS");

                entity.Property(e => e.A).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Perf)
                    .HasMaxLength(20)
                    .HasColumnName("PERF");

                entity.Property(e => e.Respondents).HasColumnName("RESPONDENTS");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");

                entity.Property(e => e.Zt).HasColumnName("ZT");

                entity.Property(e => e.Zta)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("ZTA");
            });

            modelBuilder.Entity<Assessmentperfsummary>(entity =>
            {
                entity.ToTable("ASSESSMENTPERFSUMMARY");

                entity.HasIndex(e => new { e.Acadyear, e.Sem, e.Staffid, e.Coursecode, e.Qid }, "IX_ASSPERF")
                    .IsUnique();

                entity.Property(e => e.Assessmentperfsummaryid).HasColumnName("ASSESSMENTPERFSUMMARYID");

                entity.Property(e => e.A).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Perf)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("PERF");

                entity.Property(e => e.Qid).HasColumnName("QID");

                entity.Property(e => e.Qno).HasColumnName("QNo");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");

                entity.Property(e => e._1).HasColumnName("1");

                entity.Property(e => e._2).HasColumnName("2");

                entity.Property(e => e._3).HasColumnName("3");

                entity.Property(e => e._4).HasColumnName("4");

                entity.Property(e => e._5).HasColumnName("5");
            });

            modelBuilder.Entity<Assessmentpvt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENTPVT");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Qid).HasColumnName("QID");

                entity.Property(e => e.Qno).HasColumnName("QNO");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");

                entity.Property(e => e._1).HasColumnName("1");

                entity.Property(e => e._2).HasColumnName("2");

                entity.Property(e => e._3).HasColumnName("3");

                entity.Property(e => e._4).HasColumnName("4");

                entity.Property(e => e._5).HasColumnName("5");
            });

            modelBuilder.Entity<AssessmentpvtT>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENTPVT_TS");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Qno).HasColumnName("QNO");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");

                entity.Property(e => e._1).HasColumnName("1");

                entity.Property(e => e._2).HasColumnName("2");

                entity.Property(e => e._3).HasColumnName("3");

                entity.Property(e => e._4).HasColumnName("4");

                entity.Property(e => e._5).HasColumnName("5");
            });

            modelBuilder.Entity<Assessmentreport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENTREPORT");

                entity.Property(e => e.A).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.College)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Comments).HasColumnName("COMMENTS");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Department)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Faculty)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("FACULTY");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(128)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Perf)
                    .HasMaxLength(20)
                    .HasColumnName("PERF");

                entity.Property(e => e.Photo).HasColumnName("PHOTO");

                entity.Property(e => e.Respondents).HasColumnName("RESPONDENTS");

                entity.Property(e => e.Respondentsexpected).HasColumnName("RESPONDENTSEXPECTED");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");

                entity.Property(e => e.Zt).HasColumnName("ZT");

                entity.Property(e => e.Zta)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("ZTA");
            });

            modelBuilder.Entity<AssessmentreportCopy>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENTREPORT_copy");

                entity.Property(e => e.A).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.College)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Comments).HasColumnName("COMMENTS");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Faculty)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FACULTY");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(128)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Perf)
                    .HasMaxLength(20)
                    .HasColumnName("PERF");

                entity.Property(e => e.Photo).HasColumnName("PHOTO");

                entity.Property(e => e.Respondents).HasColumnName("RESPONDENTS");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Staffid)
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");

                entity.Property(e => e.Zt).HasColumnName("ZT");

                entity.Property(e => e.Zta)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("ZTA");
            });

            modelBuilder.Entity<AssessmentreportCopy1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENTREPORT_copy1");

                entity.Property(e => e.A).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.College)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Comments).HasColumnName("COMMENTS");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Department)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Faculty)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("FACULTY");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(128)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Perf)
                    .HasMaxLength(20)
                    .HasColumnName("PERF");

                entity.Property(e => e.Photo).HasColumnName("PHOTO");

                entity.Property(e => e.Respondents).HasColumnName("RESPONDENTS");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");

                entity.Property(e => e.Zt).HasColumnName("ZT");

                entity.Property(e => e.Zta)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("ZTA");
            });

            modelBuilder.Entity<AssessmentreportNopix>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENTREPORT_NOPIX");

                entity.Property(e => e.A).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.College)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Comments).HasColumnName("COMMENTS");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Faculty)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FACULTY");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(128)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Perf)
                    .HasMaxLength(20)
                    .HasColumnName("PERF");

                entity.Property(e => e.Respondents).HasColumnName("RESPONDENTS");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");

                entity.Property(e => e.Zt).HasColumnName("ZT");

                entity.Property(e => e.Zta)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("ZTA");
            });

            modelBuilder.Entity<AssessmentreportNopixT>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENTREPORT_NOPIX_TS");

                entity.Property(e => e.A).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.College)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Faculty)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FACULTY");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(128)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Perf)
                    .HasMaxLength(20)
                    .HasColumnName("PERF");

                entity.Property(e => e.Respondents).HasColumnName("RESPONDENTS");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");

                entity.Property(e => e.Zt).HasColumnName("ZT");

                entity.Property(e => e.Zta)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("ZTA");
            });

            modelBuilder.Entity<AssessmentreportSummarysource>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENTREPORT_SUMMARYSOURCE");

                entity.Property(e => e.A).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Comments).HasColumnName("COMMENTS");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Perf)
                    .HasMaxLength(20)
                    .HasColumnName("PERF");

                entity.Property(e => e.Respondents).HasColumnName("RESPONDENTS");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");

                entity.Property(e => e.Zt).HasColumnName("ZT");

                entity.Property(e => e.Zta)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("ZTA");
            });

            modelBuilder.Entity<Assessmentreportnp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENTREPORTNP");

                entity.Property(e => e.A).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.College)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Faculty)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FACULTY");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(128)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Perf)
                    .HasMaxLength(20)
                    .HasColumnName("PERF");

                entity.Property(e => e.Respondents).HasColumnName("RESPONDENTS");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Staffid)
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");

                entity.Property(e => e.Zt).HasColumnName("ZT");

                entity.Property(e => e.Zta)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("ZTA");
            });

            modelBuilder.Entity<Assessmentrespondent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENTRESPONDENTS");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Respondents).HasColumnName("RESPONDENTS");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");
            });

            modelBuilder.Entity<AssessmentrespondentsT>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENTRESPONDENTS_TS");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Respondents).HasColumnName("RESPONDENTS");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");
            });

            modelBuilder.Entity<Assessmentrespondentsexpected>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENTRESPONDENTSEXPECTED");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STAFFID");
            });

            modelBuilder.Entity<Assessmentunit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSESSMENTUNIT");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Sem).HasColumnName("SEM");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("CATEGORY");

                entity.Property(e => e.Categoryid).HasColumnName("CATEGORYID");

                entity.Property(e => e.Category1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CATEGORY");

                entity.Property(e => e.Categoryorder).HasColumnName("CATEGORYORDER");

                entity.Property(e => e.Includeingrand)
                    .HasColumnName("INCLUDEINGRAND")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Qfrom).HasColumnName("QFROM");

                entity.Property(e => e.Qto).HasColumnName("QTO");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.HasOne(d => d.Set)
                    .WithMany(p => p.Categories)
                    .HasForeignKey(d => d.Setid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CATEGORY__SETID__1F198FD4");
            });

            modelBuilder.Entity<College>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("COLLEGE");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Name)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Collegehr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("COLLEGEHR");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Name)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("COMMENT");

                entity.HasIndex(e => e.Assessmentid, "IX_LECTURERASSESSMENT_COMMENT")
                    .IsUnique();

                entity.Property(e => e.Commentid).HasColumnName("COMMENTID");

                entity.Property(e => e.Assessmentid).HasColumnName("ASSESSMENTID");

                entity.Property(e => e.Comment1)
                    .IsRequired()
                    .HasColumnName("COMMENT");

                entity.Property(e => e.Qid).HasColumnName("QID");

                entity.HasOne(d => d.Assessment)
                    .WithOne(p => p.Comment)
                    .HasForeignKey<Comment>(d => d.Assessmentid)
                    .HasConstraintName("FK_LECTURERASSESSMENT_COMMENT");

                entity.HasOne(d => d.QidNavigation)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.Qid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QUESTION_COMMENT");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DEPARTMENT");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Name)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<DepartmentHr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DEPARTMENT_HR");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");
            });

            modelBuilder.Entity<DepartmentUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DEPARTMENT USERS");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT NAME");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ROLE");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<Departmenthr1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DEPARTMENTHR");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Name)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Faculty>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FACULTY");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Name)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Facultyhr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FACULTYHR");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Name)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Grading>(entity =>
            {
                entity.ToTable("GRADING");

                entity.Property(e => e.Gradingid).HasColumnName("GRADINGID");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Lowerbound)
                    .HasColumnType("decimal(5, 3)")
                    .HasColumnName("LOWERBOUND");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("NAME");

                entity.Property(e => e.Upperbound)
                    .HasColumnType("decimal(5, 3)")
                    .HasColumnName("UPPERBOUND");

                entity.Property(e => e.Value).HasColumnName("VALUE");
            });

            modelBuilder.Entity<Lecturer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LECTURER");

                entity.Property(e => e.Lecturerid).HasColumnName("LECTURERID");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STAFFID");
            });

            modelBuilder.Entity<Lecturerassessment>(entity =>
            {
                entity.HasKey(e => e.Assessmentid)
                    .HasName("PK__LECTURER__3214EC2714F2DD7F");

                entity.ToTable("LECTURERASSESSMENT");

                entity.HasIndex(e => new { e.Acadyear, e.Sem, e.Staffid, e.Setid, e.Coursecode }, "IX_LECTURERASSESSMENT");

                entity.Property(e => e.Assessmentid).HasColumnName("ASSESSMENTID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");

                entity.HasOne(d => d.Set)
                    .WithMany(p => p.Lecturerassessments)
                    .HasForeignKey(d => d.Setid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LECTURERA__SETID__200DB40D");
            });

            modelBuilder.Entity<Lecturerassessmentunit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LECTURERASSESSMENTUNIT");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");
            });

            modelBuilder.Entity<LecturerassessmentunitCopy>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LECTURERASSESSMENTUNIT_copy");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");
            });

            modelBuilder.Entity<Lecturerassessmentunitnew>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LECTURERASSESSMENTUNITNEW");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Staffid)
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");
            });

            modelBuilder.Entity<LecturerdepartmentHr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LECTURERDEPARTMENT_HR");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Staffid).HasColumnName("STAFFID");
            });

            modelBuilder.Entity<Mastercourse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MASTERCOURSE");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Staffid).HasColumnName("STAFFID");
            });

            modelBuilder.Entity<MastercourseDirect>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MASTERCOURSE_DIRECT");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Nocollege>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("_NOCOLLEGE");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");
            });

            modelBuilder.Entity<Nonacademic>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("_NONACADEMIC");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.College)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");
            });

            modelBuilder.Entity<Nonexistingstaffid>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("_NONEXISTINGSTAFFID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<NonexistingstaffidUi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("_NONEXISTINGSTAFFID_UI");

                entity.Property(e => e.Satffidnew)
                    .HasMaxLength(10)
                    .HasColumnName("SATFFIDNEW");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");
            });

            modelBuilder.Entity<Number>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NUMBERS");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.StatCode)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Statistic)
                    .IsRequired()
                    .HasMaxLength(53)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NumbersCopy>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NUMBERS_copy");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.StatCode)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Statistic)
                    .IsRequired()
                    .HasMaxLength(53)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Programmestream>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PROGRAMMESTREAM");

                entity.Property(e => e.Addoptiontocert).HasColumnName("ADDOPTIONTOCERT");

                entity.Property(e => e.Affiliateddepartmenttid).HasColumnName("AFFILIATEDDEPARTMENTTID");

                entity.Property(e => e.Biometricverificationrequired).HasColumnName("BIOMETRICVERIFICATIONREQUIRED");

                entity.Property(e => e.Calendarid).HasColumnName("CALENDARID");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Coresetid).HasColumnName("CORESETID");

                entity.Property(e => e.CrLine1)
                    .HasMaxLength(100)
                    .HasColumnName("CR_LINE1");

                entity.Property(e => e.CrLine2)
                    .HasMaxLength(100)
                    .HasColumnName("CR_LINE2");

                entity.Property(e => e.CrLine3)
                    .HasMaxLength(100)
                    .HasColumnName("CR_LINE3");

                entity.Property(e => e.CrLine4)
                    .HasMaxLength(100)
                    .HasColumnName("CR_LINE4");

                entity.Property(e => e.CtLine1)
                    .HasMaxLength(100)
                    .HasColumnName("CT_LINE1");

                entity.Property(e => e.CtLine2)
                    .HasMaxLength(100)
                    .HasColumnName("CT_LINE2");

                entity.Property(e => e.CtLine3)
                    .HasMaxLength(100)
                    .HasColumnName("CT_LINE3");

                entity.Property(e => e.CtLine4)
                    .HasMaxLength(100)
                    .HasColumnName("CT_LINE4");

                entity.Property(e => e.CtcLine1)
                    .HasMaxLength(100)
                    .HasColumnName("CTC_LINE1");

                entity.Property(e => e.CtcLine2)
                    .HasMaxLength(100)
                    .HasColumnName("CTC_LINE2");

                entity.Property(e => e.CtcLine3)
                    .HasMaxLength(100)
                    .HasColumnName("CTC_LINE3");

                entity.Property(e => e.CtcLine4)
                    .HasMaxLength(100)
                    .HasColumnName("CTC_LINE4");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Durationdescription)
                    .HasMaxLength(100)
                    .HasColumnName("DURATIONDESCRIPTION");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Feeclassificationid).HasColumnName("FEECLASSIFICATIONID");

                entity.Property(e => e.Finalsem).HasColumnName("FINALSEM");

                entity.Property(e => e.Finalyear).HasColumnName("FINALYEAR");

                entity.Property(e => e.Governingboard)
                    .HasMaxLength(50)
                    .HasColumnName("GOVERNINGBOARD");

                entity.Property(e => e.Gradingid).HasColumnName("GRADINGID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.Isadmissionavailable).HasColumnName("ISADMISSIONAVAILABLE");

                entity.Property(e => e.Mincredits).HasColumnName("MINCREDITS");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Parentcollegeid).HasColumnName("PARENTCOLLEGEID");

                entity.Property(e => e.Parentdepartmentid).HasColumnName("PARENTDEPARTMENTID");

                entity.Property(e => e.Parentfacultyid).HasColumnName("PARENTFACULTYID");

                entity.Property(e => e.Programmeid).HasColumnName("PROGRAMMEID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Reporttitle)
                    .HasMaxLength(100)
                    .HasColumnName("REPORTTITLE");

                entity.Property(e => e.Resitcategoryid).HasColumnName("RESITCATEGORYID");

                entity.Property(e => e.Resittemplateid).HasColumnName("RESITTEMPLATEID");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Timestreamid).HasColumnName("TIMESTREAMID");

                entity.Property(e => e.Transcriptourrefprefix)
                    .HasMaxLength(20)
                    .HasColumnName("TRANSCRIPTOURREFPREFIX");

                entity.Property(e => e.Wsitemid).HasColumnName("WSITEMID");
            });

            modelBuilder.Entity<Qsetsetting>(entity =>
            {
                entity.HasKey(e => e.Qsettingid)
                    .HasName("PK__QSETSETT__3214EC272CBD046F");

                entity.ToTable("QSETSETTING");

                entity.Property(e => e.Qsettingid).HasColumnName("QSETTINGID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Coursecode)
                    .HasMaxLength(30)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Psid).HasColumnName("PSID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Yr).HasColumnName("YR");

                entity.HasOne(d => d.Set)
                    .WithMany(p => p.Qsetsettings)
                    .HasForeignKey(d => d.Setid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__QSETSETTI__SETID__2101D846");
            });

            modelBuilder.Entity<Qsetsettingcourse>(entity =>
            {
                entity.HasKey(e => e.Qsetsettingcoursesid)
                    .HasName("PK68");

                entity.ToTable("QSETSETTINGCOURSES");

                entity.Property(e => e.Qsetsettingcoursesid).HasColumnName("QSETSETTINGCOURSESID");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .HasMaxLength(255)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Psid).HasColumnName("PSID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Yr).HasColumnName("YR");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.HasKey(e => e.Qid)
                    .HasName("PK__Question__22A351C88268F683");

                entity.ToTable("QUESTION");

                entity.HasIndex(e => new { e.Setid, e.Qno }, "UQ_QUESTION_SETID_QNO")
                    .IsUnique();

                entity.Property(e => e.Qid).HasColumnName("QID");

                entity.Property(e => e.Categoryid).HasColumnName("CATEGORYID");

                entity.Property(e => e.Iscomment)
                    .HasColumnName("ISCOMMENT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Qno).HasColumnName("QNO");

                entity.Property(e => e.Question1)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("QUESTION");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.Categoryid)
                    .HasConstraintName("CATEGORYQUESTION");

                entity.HasOne(d => d.Set)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.Setid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("QSETQUESTION");
            });

            modelBuilder.Entity<Questionset>(entity =>
            {
                entity.HasKey(e => e.Setid)
                    .HasName("PK__Question__7E08473D5427355B");

                entity.ToTable("QUESTIONSET");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Isdefault)
                    .HasColumnName("ISDEFAULT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(300)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.Setname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SETNAME");
            });

            modelBuilder.Entity<Reg20211>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("_reg2021_1");

                entity.HasIndex(e => new { e.Studentid, e.Programmestreamid, e.Coursecode }, "IX_reg2021");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<Reportingsummary>(entity =>
            {
                entity.ToTable("REPORTINGSUMMARY");

                entity.HasIndex(e => new { e.Staffid, e.Coursecode, e.Acadyear, e.Sem }, "IX_REPORT");

                entity.Property(e => e.Reportingsummaryid).HasColumnName("REPORTINGSUMMARYID");

                entity.Property(e => e.A).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Comments).HasColumnName("COMMENTS");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Perf)
                    .HasMaxLength(20)
                    .HasColumnName("PERF");

                entity.Property(e => e.Respondents).HasColumnName("RESPONDENTS");

                entity.Property(e => e.Respondentsexpected).HasColumnName("RESPONDENTSEXPECTED");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Zt).HasColumnName("ZT");

                entity.Property(e => e.Zta)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("ZTA");
            });

            modelBuilder.Entity<Reportingsummaryextended>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("REPORTINGSUMMARYEXTENDED");

                entity.Property(e => e.A).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Comments).HasColumnName("COMMENTS");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(128)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Perf)
                    .HasMaxLength(20)
                    .HasColumnName("PERF");

                entity.Property(e => e.Reportingsummaryid).HasColumnName("REPORTINGSUMMARYID");

                entity.Property(e => e.Respondents).HasColumnName("RESPONDENTS");

                entity.Property(e => e.Respondentsexpected).HasColumnName("RESPONDENTSEXPECTED");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");

                entity.Property(e => e.Zt).HasColumnName("ZT");

                entity.Property(e => e.Zta)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("ZTA");
            });

            modelBuilder.Entity<Response>(entity =>
            {
                entity.ToTable("RESPONSE");

                entity.HasIndex(e => e.Assessmentid, "IX_RESPONSE_ASSESSMENTID");

                entity.Property(e => e.Responseid).HasColumnName("RESPONSEID");

                entity.Property(e => e.Assessmentid).HasColumnName("ASSESSMENTID");

                entity.Property(e => e.Qid).HasColumnName("QID");

                entity.Property(e => e.Responsevalueid).HasColumnName("RESPONSEVALUEID");

                entity.HasOne(d => d.Assessment)
                    .WithMany(p => p.Responses)
                    .HasForeignKey(d => d.Assessmentid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RESPONSE__ASSESS__17786E0C");

                entity.HasOne(d => d.QidNavigation)
                    .WithMany(p => p.Responses)
                    .HasForeignKey(d => d.Qid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RESPONSE__QID__1960B67E");
            });

            modelBuilder.Entity<Responsevalue>(entity =>
            {
                entity.ToTable("RESPONSEVALUE");

                entity.HasIndex(e => new { e.Setid, e.Value }, "IX_RESPONSEVALUE_SETIDVALUE")
                    .IsUnique();

                entity.Property(e => e.Responsevalueid).HasColumnName("RESPONSEVALUEID");

                entity.Property(e => e.Grading)
                    .HasMaxLength(20)
                    .HasColumnName("GRADING");

                entity.Property(e => e.Gradingid).HasColumnName("GRADINGID");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("LABEL");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Value).HasColumnName("VALUE");

                entity.HasOne(d => d.GradingNavigation)
                    .WithMany(p => p.Responsevalues)
                    .HasForeignKey(d => d.Gradingid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RESPONSEV__GRADI__3138400F");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("ROLE");

                entity.Property(e => e.Roleid).HasColumnName("ROLEID");

                entity.Property(e => e.Role1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ROLE");
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.ToTable("SETTINGS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Ends)
                    .HasColumnType("date")
                    .HasColumnName("ENDS");

                entity.Property(e => e.Isdefault).HasColumnName("ISDEFAULT");

                entity.Property(e => e.Published)
                    .HasColumnName("PUBLISHED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Starts)
                    .HasColumnType("date")
                    .HasColumnName("STARTS");
            });

            modelBuilder.Entity<Sishrentityidmap>(entity =>
            {
                entity.ToTable("SISHRENTITYIDMAP");

                entity.HasIndex(e => new { e.Entity, e.Sisid, e.Hrid }, "UQ_IDS")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Entity)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("ENTITY");

                entity.Property(e => e.Entityname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("ENTITYNAME");

                entity.Property(e => e.Hrid).HasColumnName("HRID");

                entity.Property(e => e.Sisid).HasColumnName("SISID");
            });

            modelBuilder.Entity<Sisprogrammecourse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SISPROGRAMMECOURSE");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursetypeid).HasColumnName("COURSETYPEID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Estimatednumber).HasColumnName("ESTIMATEDNUMBER");

                entity.Property(e => e.Excludefromexamtimetable).HasColumnName("EXCLUDEFROMEXAMTIMETABLE");

                entity.Property(e => e.Excludefromlecturetimetable).HasColumnName("EXCLUDEFROMLECTURETIMETABLE");

                entity.Property(e => e.Lecturerid).HasColumnName("LECTURERID");

                entity.Property(e => e.Practicalcredit).HasColumnName("PRACTICALCREDIT");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Teachingcredit).HasColumnName("TEACHINGCREDIT");

                entity.Property(e => e.Yr).HasColumnName("YR");
            });

            modelBuilder.Entity<Sisprogrammeoptioncourse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SISPROGRAMMEOPTIONCOURSE");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Electivesetid).HasColumnName("ELECTIVESETID");

                entity.Property(e => e.Isexemptresultcheck).HasColumnName("ISEXEMPTRESULTCHECK");

                entity.Property(e => e.Lecturerid).HasColumnName("LECTURERID");

                entity.Property(e => e.Optionid).HasColumnName("OPTIONID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Yr).HasColumnName("YR");
            });

            modelBuilder.Entity<Sisprogrammeoptioncourselecturer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SISPROGRAMMEOPTIONCOURSELECTURER");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Lastaccess).HasColumnName("LASTACCESS");

                entity.Property(e => e.Lecturerid).HasColumnName("LECTURERID");

                entity.Property(e => e.Optionid).HasColumnName("OPTIONID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Yr).HasColumnName("YR");
            });

            modelBuilder.Entity<Staffname>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("STAFFNAME");

                entity.Property(e => e.College)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Faculty)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FACULTY");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(128)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Staffid).HasColumnName("STAFFID");

                entity.Property(e => e.Techmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TECHMAIL");
            });

            modelBuilder.Entity<StaffnameLocDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("STAFFNAME_LOC_delete");

                entity.Property(e => e.College)
                    .HasMaxLength(100)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Faculty)
                    .HasMaxLength(100)
                    .HasColumnName("FACULTY");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(128)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Staffid).HasColumnName("STAFFID");

                entity.Property(e => e.Techmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TECHMAIL");
            });

            modelBuilder.Entity<Staffphoto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("STAFFPHOTO");

                entity.Property(e => e.Photo)
                    .IsRequired()
                    .HasColumnName("PHOTO");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("STAFFID");
            });

            modelBuilder.Entity<Statraw20172020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("_STATRAW20172020");

                entity.HasIndex(e => new { e.Acadyear, e.Staffid, e.Studentid }, "IX_stat20172020");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<Studentlog>(entity =>
            {
                entity.ToTable("STUDENTLOG");

                entity.HasIndex(e => new { e.Acadyear, e.Studentid }, "IX_STUDENTLOG2");

                entity.HasIndex(e => new { e.Acadyear, e.Sem, e.Staffid, e.Setid, e.Coursecode, e.Studentid }, "UQ_STUDENTLOG")
                    .IsUnique();

                entity.Property(e => e.Studentlogid).HasColumnName("STUDENTLOGID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Setid).HasColumnName("SETID");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STAFFID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Whensubmitted)
                    .HasColumnType("datetime")
                    .HasColumnName("WHENSUBMITTED")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Set)
                    .WithMany(p => p.Studentlogs)
                    .HasForeignKey(d => d.Setid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STUDENTLO__SETID__21F5FC7F");
            });

            modelBuilder.Entity<Sysdiagram>(entity =>
            {
                entity.HasKey(e => e.DiagramId)
                    .HasName("PK__sysdiagr__C2B05B61027A6059");

                entity.ToTable("sysdiagrams");

                entity.HasIndex(e => new { e.PrincipalId, e.Name }, "UK_principal_name")
                    .IsUnique();

                entity.Property(e => e.DiagramId).HasColumnName("diagram_id");

                entity.Property(e => e.Definition).HasColumnName("definition");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.Property(e => e.PrincipalId).HasColumnName("principal_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("USER");

                entity.HasIndex(e => new { e.Staffid, e.Username }, "IX_USER")
                    .IsUnique();

                entity.HasIndex(e => e.Username, "UQ_USERNAME")
                    .IsUnique();

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Clientip)
                    .HasMaxLength(20)
                    .HasColumnName("CLIENTIP");

                entity.Property(e => e.Lastlogin)
                    .HasColumnType("datetime")
                    .HasColumnName("LASTLOGIN");

                entity.Property(e => e.Logins)
                    .HasColumnName("LOGINS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME");

                entity.Property(e => e.Role).HasColumnName("ROLE");

                entity.Property(e => e.Staffid)
                    .HasMaxLength(10)
                    .HasColumnName("STAFFID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<UserViewModel>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_dbo.UserViewModels");
            });

            modelBuilder.Entity<Usercollege>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Collegeid });

                entity.ToTable("USERCOLLEGE");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");
            });

            modelBuilder.Entity<UsercollegeCopy>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Collegeid })
                    .HasName("PK__USERCOLL__D30259B34C618FA3");

                entity.ToTable("USERCOLLEGE_copy");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");
            });

            modelBuilder.Entity<Userdepartment>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Departmentid });

                entity.ToTable("USERDEPARTMENT");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");
            });

            modelBuilder.Entity<UserdepartmentCopy>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Departmentid })
                    .HasName("PK__USERDEPA__955DC9C10C07A9EB");

                entity.ToTable("USERDEPARTMENT_copy");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");
            });

            modelBuilder.Entity<Userfaculty>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Facultyid });

                entity.ToTable("USERFACULTY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");
            });

            modelBuilder.Entity<UserfacultyCopy>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Facultyid })
                    .HasName("PK__USERFACU__ECCA8EFA9A01EFFF");

                entity.ToTable("USERFACULTY_copy");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");
            });

            modelBuilder.Entity<ViewStaffname>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_STAFFNAME");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(128)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Staffid).HasColumnName("STAFFID");

                entity.Property(e => e.Techmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TECHMAIL");
            });

            modelBuilder.Entity<Viewlecturerassignedcourse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEWLECTURERASSIGNEDCOURSES");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Lecturer)
                    .IsRequired()
                    .HasMaxLength(101)
                    .IsUnicode(false)
                    .HasColumnName("LECTURER");

                entity.Property(e => e.Optionid).HasColumnName("OPTIONID");

                entity.Property(e => e.Programme)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMME");

                entity.Property(e => e.Programmeoption)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMEOPTION");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STAFFID");

                entity.Property(e => e.Yr).HasColumnName("YR");
            });

            modelBuilder.Entity<Viewlecturercourse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEWLECTURERCOURSE");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Lecturer)
                    .IsRequired()
                    .HasMaxLength(101)
                    .IsUnicode(false)
                    .HasColumnName("LECTURER");

                entity.Property(e => e.Optionid).HasColumnName("OPTIONID");

                entity.Property(e => e.Programme)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMME");

                entity.Property(e => e.Programmeoption)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMEOPTION");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Staffid).HasColumnName("STAFFID");

                entity.Property(e => e.Yr).HasColumnName("YR");
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("STAFF");

                entity.Property(e => e.Dateofbirth)
                    .HasColumnType("date")
                    .HasColumnName("DATEOFBIRTH");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Email)
                    .HasMaxLength(10)
                    .HasColumnName("EMAIL")
                    .IsFixedLength(true);

                entity.Property(e => e.Employmentenddate)
                    .HasColumnType("date")
                    .HasColumnName("EMPLOYMENTENDDATE");

                entity.Property(e => e.Employmenttypeid).HasColumnName("EMPLOYMENTTYPEID");

                entity.Property(e => e.Filenumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FILENUMBER");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Knustvodafoneno)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("KNUSTVODAFONENO");

                entity.Property(e => e.Knustvodaserialno)
                    .HasMaxLength(50)
                    .HasColumnName("KNUSTVODASERIALNO");

                entity.Property(e => e.Maidenname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAIDENNAME");

                entity.Property(e => e.Newstaffid).HasColumnName("NEWSTAFFID");

                entity.Property(e => e.Othername)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Sectionid).HasColumnName("SECTIONID");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STAFFID");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Techmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TECHMAIL");

                entity.Property(e => e.Titleid).HasColumnName("TITLEID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
