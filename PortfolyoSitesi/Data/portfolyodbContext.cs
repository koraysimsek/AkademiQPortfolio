using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PortfolyoSitesi.Data
{
    public partial class PortfolyoDbContext : DbContext
    {
        public PortfolyoDbContext()
        {
        }

        public PortfolyoDbContext(DbContextOptions<PortfolyoDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<About> Abouts { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Contact> Contacts { get; set; } = null!;
        public virtual DbSet<Experience> Experiences { get; set; } = null!;
        public virtual DbSet<Message> Messages { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<Service> Services { get; set; } = null!;
        public virtual DbSet<Skill> Skills { get; set; } = null!;
        public virtual DbSet<Slider> Sliders { get; set; } = null!;
        public virtual DbSet<Testimonial> Testimonials { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=KORAY;Database=portfolyodb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<About>(entity =>
            {
                entity.ToTable("About");

                entity.Property(e => e.AboutId).HasColumnName("AboutID");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.EndYear).HasMaxLength(50);

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(500)
                    .HasColumnName("ImageURL");

                entity.Property(e => e.NameSurname).HasMaxLength(50);

                entity.Property(e => e.Section).HasMaxLength(50);

                entity.Property(e => e.StartYear).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.University).HasMaxLength(50);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(100);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("Contact");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Email).HasMaxLength(500);

                entity.Property(e => e.Phone).HasMaxLength(500);
            });

            modelBuilder.Entity<Experience>(entity =>
            {
                entity.ToTable("Experience");

                entity.Property(e => e.ExperienceId).HasColumnName("ExperienceID");

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.Description)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.EndDate).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.ToTable("Message");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.MessageContent).HasMaxLength(1000);

                entity.Property(e => e.NameSurname).HasMaxLength(50);

                entity.Property(e => e.Subject).HasMaxLength(250);
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("Project");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(500)
                    .HasColumnName("ImageURL");

                entity.Property(e => e.ProjectLink).HasMaxLength(500);

                entity.Property(e => e.ProjectName).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Projects_Category");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("Service");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.IconUrl)
                    .HasMaxLength(500)
                    .HasColumnName("IconURL");

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.ToTable("Skill");

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.Property(e => e.SkillName).HasMaxLength(50);
            });

            modelBuilder.Entity<Slider>(entity =>
            {
                entity.ToTable("Slider");

                entity.Property(e => e.SliderId).HasColumnName("SliderID");

                entity.Property(e => e.NameSurname).HasMaxLength(50);

                entity.Property(e => e.ProfileImageUrl)
                    .HasMaxLength(500)
                    .HasColumnName("ProfileImageURL");

                entity.Property(e => e.Title).HasMaxLength(500);
            });

            modelBuilder.Entity<Testimonial>(entity =>
            {
                entity.ToTable("Testimonial");

                entity.Property(e => e.TestimonialId).HasColumnName("TestimonialID");

                entity.Property(e => e.Company).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .HasColumnName("ImageURL");

                entity.Property(e => e.TestimonialName).HasMaxLength(200);

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
