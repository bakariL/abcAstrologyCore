using ckl.Models;
using ckl.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<HoroscropeReading> HoroscropeReadings { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<PartnerType> PartnerTypes { get; set; }
        public DbSet<ReportType> ReportTypes { get; set; }
        public DbSet<ReadingReportTypeAssociation> ReportTypeAssocitaions { get; set; }
        public DbSet<PartnerTypeAssociation> PartnerTypeAssociations { get; set; }
        public DbSet<SaturnReport> SaturnReports { get; set; }
        public DbSet<Request> Request { get; set; }     
        public DbSet<UploadFile> UploadedFiles { get; set; }
        public DbSet<Message> Emails { get; set; }
        public DbSet<TextMsg> TextMsg { get; set; }
        public DbSet<Message> messages { get; set; }
        public DbSet<Connection> Connections { get; set; }

    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);       
            modelBuilder.Entity<ReadingReportTypeAssociation>().HasKey(r => new { r.ReportID, r.ReportTypeID });
            modelBuilder.Entity<PartnerTypeAssociation>().HasKey(r => new { r.PartnerTypeId, r.PartnerId });
            modelBuilder.Entity<ApplicationUser>().ToTable("tblUsers", "dbo");
            modelBuilder.Entity<IdentityRole>().ToTable("tblRoles", "dbo");
            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("tblUserRoles", "dbo");
            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("tblUserClaims", "dbo");
            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("tblUserLogins", "dbo");
            modelBuilder.Entity<IdentityUserToken<string>>().ToTable("tblUserTokens", "dbo");
            modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("tblRoleClaims", "dbo");
        }
    }
}
